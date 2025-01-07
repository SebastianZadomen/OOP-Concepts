using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oppconcepts
{
    public class Clinic : HealthCenters
    {
        public string Specialty { get; set; }

        public Clinic(string name, string location, int numBeds, int numRooms, int numDoctors, string specialty)
            : base(name, location, numBeds, numRooms, numDoctors)
        {
            this.Specialty = specialty;
        }
        public override void PerformSurgery()
        {
            if (NumBeds > 0 && NumDoctors > 0)
            {
                NumBeds--;
                NumRooms--;
                NumDoctors--;
                Console.WriteLine($"Performing surgery at the clinic {Name}. \n Specialty : {Specialty}.");
            }
            else
            {
                Console.WriteLine("Surgery is not possible: insufficient resources in the clinic.");
            }
        }
    }
}