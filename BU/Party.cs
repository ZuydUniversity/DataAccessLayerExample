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
        public DateTime StartingTime { get; set; }
        public DateTime EndingTime { get; set; }
        public int Budget { get; set; }
        public List<Guest> Guests { get; set; } 

        public Party(string name, DateTime startingTime, DateTime endingTime, int budget)
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
