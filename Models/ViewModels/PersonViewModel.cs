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
         var personViewModel = new PersonViewModel {
                Id = Convert.ToInt32(dataRow ["id"]),
                Name = Convert.ToString(dataRow["name"]),
                Surname = Convert.ToString(dataRow["surname"]),
                 Age = Convert.ToInt32(dataRow["age"]),
             
            };
            return personViewModel;
      }

    }
}