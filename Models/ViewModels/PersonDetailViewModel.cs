using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
namespace People.Models.ViewModels
{
    public class PersonDetailViewModel : PersonViewModel
    {
      public List <AutoViewModel> Garage {get;set;}
       

       public static new  PersonDetailViewModel FromDataRow (DataRow dataRow){
         var personViewModel = new PersonDetailViewModel {
                Id = Convert.ToInt32(dataRow ["id"]),
                Name = Convert.ToString(dataRow["name"]),
                Surname = Convert.ToString(dataRow["surname"]),
                 Age = Convert.ToInt32(dataRow["age"]),
                 Garage = new List<AutoViewModel>()

             
            };
            return personViewModel;
      }
    


    }
}