using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Data;

namespace People.Models.ViewModels
{
    public class PersonViewModel
    {
        public int Id{get;set;} 
        public string Name{get;set;}
        public string Surname{get;set;}
        public int Age{get;set;}
        // public List<Auto> Garage{get;set;}
   
     
      public static PersonViewModel FromDataRow (DataRow dataRow){
           var personViewModel = new PersonViewModel
    {
        Id = dataRow["id"] != DBNull.Value ? Convert.ToInt32(dataRow["id"]) : 0,
        Name = dataRow["name"] != DBNull.Value ? Convert.ToString(dataRow["name"]) : string.Empty,
        Surname = dataRow["surname"] != DBNull.Value ? Convert.ToString(dataRow["surname"]) : string.Empty,
        Age = dataRow["age"] != DBNull.Value ? Convert.ToInt32(dataRow["age"]) : 0,
    };
            return personViewModel;
      }

    }
}