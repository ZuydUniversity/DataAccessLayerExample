using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayerExample.BU
{
    internal class Guest
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public Party Party { get; set; }

        public Guest(string name, DateTime birthDate)
        {
            Name = name; 
            BirthDate = birthDate; 
        }
    }
}
