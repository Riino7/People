 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Threading.Tasks;
 using System.Data;

 namespace People.Models.ViewModels
 {
     public class AutoViewModel 
     {
         public int Id { get; set; }

          public int IDperson { get; set; }
        

         public string Marca { get; set; }

         public string Modello { get; set; }

         public string Colore { get; set; }

        //  public AutoViewModel(int Id, int IDperson, string Marca, string Modello, string Colore)
        //  {
        //      this.Id = Id;
        //      this.IDperson = IDperson;
        //      this.Marca = Marca;
        //      this.Modello = Modello;
        //      this.Colore = Colore;
        //  }
        
           public static new AutoViewModel FromDataRow (DataRow dataRow){
          var autoViewModel = new AutoViewModel {
                 Id = Convert.ToInt32(dataRow ["Id"]),
                 IDperson = Convert.ToInt32(dataRow ["IDperson"]),
                 Marca = Convert.ToString(dataRow["Marca"]),
                 Modello = Convert.ToString(dataRow["Modello"]),
                 Colore = Convert.ToString(dataRow["Colore"]),
             
             };
             return autoViewModel;
             }
       
     }
 }

