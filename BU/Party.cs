using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayerExample.BU
{
    internal class Party
    {
        public string Name { get; private set; }
        public string StartingTime { get; set; }
        public string EndingTime { get; set; }
        public int Budget { get; set; }
        public List<Guest> Guests { get; set; } 

        public Party(string name, string startingTime, string endingTime, int budget)
        {
            Name = name;
            StartingTime = startingTime;
            EndingTime = endingTime;
            Budget = budget;
            Guests = new List<Guest>();
        }

        public void AddGuest(Guest guest)
        {
            Guests.Add(guest);
            guest.Party = this;
        }
    }
}
