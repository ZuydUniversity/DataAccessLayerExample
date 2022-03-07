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
        public string BirthDate { get; set; }
        public Party Party { get; set; }

        public Guest(string name, string birthDate)
        {
            Name = name; 
            BirthDate = birthDate; 
        }
    }
}
