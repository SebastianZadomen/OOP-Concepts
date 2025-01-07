using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oppconcepts
{
    public abstract class HealthCenters
    {
        private string name;
        private string location;
        private int numBeds;
        private int numRooms;
        private int numDoctors;

        public string Name { get => name; set => name = value; }
        public string Location { get => location; set => location = value; }
        public int NumBeds { get => numBeds; set => numBeds = value; }
        public int NumRooms { get => numRooms; set => numRooms = value; }
        public int NumDoctors { get => numDoctors; set => numDoctors = value; }

        public virtual void AdmitPatient()
        {
            if (numRooms > 0)
            {
                numRooms--;
                numDoctors--;
                Console.WriteLine($"Admitting patient in {name}.");
            }
            else
            {
                Console.WriteLine("There are no rooms available to admit patients.");
            }
        }

        public void Discharge()
        {
            numRooms++;
            Console.WriteLine($"Patient discharged in {name}.");
        }

        public static double CalculateOccupancyPercentage(int totalBeds, int bedsAvailable)
        {
            int occupiedBeds = totalBeds - bedsAvailable;
            if (totalBeds == 0) return 0;
            return (double)occupiedBeds / totalBeds * 100;
        }
        public static string GenerateCenterStatus(string name, int bedsAvailable, int doctorsAvailable, int numRooms)
        {
            return $"Condition of the center {name}: {bedsAvailable} beds available , available rooms {numRooms} and {doctorsAvailable} available doctors.";
        }

        public abstract void PerformSurgery();

        public HealthCenters(string name, string location, int numBeds, int numRooms, int numDoctors)
        {
            this.name = name;
            this.location = location;
            this.numBeds = numBeds;
            this.numRooms = numRooms;
            this.numDoctors = numDoctors;
        }
    }
}