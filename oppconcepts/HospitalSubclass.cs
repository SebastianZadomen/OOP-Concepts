using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oppconcepts
{
    public class Hospital : HealthCenters
    {
        public bool isFree { get; set; }

        public Hospital(string name, string location, int numBeds, int numRooms, int numDoctors, bool isFree)
            : base(name, location, numBeds, numRooms, numDoctors)
        {
            this.isFree = isFree;
        }

        public override void PerformSurgery()
        {
            if (NumBeds > 0 && NumDoctors > 0)
            {
                NumBeds--;
                NumRooms--;
                NumDoctors--;
                Console.WriteLine($"Performing surgery at {Name} (Public Hospital).");
            }
            if (!isFree && NumBeds > 0 && NumDoctors > 0)
            {
                NumBeds--;
                NumRooms--;
                NumDoctors--;
                Console.WriteLine($"Performing surgery at {Name} (Private Hospital).");
            }
            else
            {
                Console.WriteLine("Surgery is not possible: insufficient hospital resources.");
            }
        }
    }
}

