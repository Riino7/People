using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace People.Models.InputModel
{
    public class PersonCreateInputModel
    {
          public string name { get; set; }
          public string surname { get; set; }
          public int age { get; set; }
    }
}