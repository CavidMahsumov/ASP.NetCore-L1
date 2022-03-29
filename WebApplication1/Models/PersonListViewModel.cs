using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entities;

namespace WebApplication1.Models
{
    public class PersonListViewModel
    {
        public List<Person> Persons { get; set; }
        public List<string> Cities { get; set; }
    }
}
