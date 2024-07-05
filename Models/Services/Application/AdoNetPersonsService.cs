using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using People.Models.Infrastructure;
using People.Models.ViewModels;
using System.Data;





namespace People.Models.Services.Application
{
    public class AdoNetPersonsService : IPersonService
    {
        private readonly IDatabaseAccessor db;
        public AdoNetPersonsService(IDatabaseAccessor db)
        {
            this.db =  db;
        }

        public List<PersonViewModel> GetPeople()
        {
            string query = "SELECT id, name, surname , age FROM persona";
            DataSet dataSet = db.Query(query);
            var dataTable = dataSet.Tables[0];
            var personsList = new List<PersonViewModel>();


            foreach (DataRow personRow in dataTable.Rows)
            {
                var person = PersonViewModel.FromDataRow(personRow);
                personsList.Add(person);

            }
            return personsList;
        }
        public PersonDetailViewModel GetPerson(int id)
        {
            string query = "SELECT id, name, surname , age FROM persona WHERE id = " + id + "; SELECT Id, IDperson, Marca , Modello , Colore  FROM auto WHERE IDperson =" + id;

            DataSet dataSet = db.Query(query);
            var personDataTable = dataSet.Tables[0];
            if (personDataTable.Rows.Count != 1)
            {
                throw new InvalidOperationException($"Persona con id = {id} non trovata");
            }
            var personRow = personDataTable.Rows[0];
            var personDetailViewModel = PersonDetailViewModel.FromDataRow(personRow);


            var autoDataTable = dataSet.Tables[1];
            foreach (DataRow autoRow in autoDataTable.Rows)
            {
                var auto = AutoViewModel.FromDataRow(autoRow);
                personDetailViewModel.Garage.Add(auto);
            }

            return personDetailViewModel;
        }

    }
}

