using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oppconcepts
{
    public class EmergencyCenter : HealthCenters
    {
        public int TimeAverageWaitAverage { get; set; }

        public EmergencyCenter(string name, string location, int numBeds, int numRooms, int numDoctors, int timeAverageWaitAverage)
            : base(name, location, numBeds, numRooms, numDoctors)
        {
            TimeAverageWaitAverage = timeAverageWaitAverage;
        }
        public override void PerformSurgery()
        {
            if (NumBeds > 0 && NumDoctors > 0)
            {
                NumBeds--;
                NumDoctors--;
                NumDoctors--;
                Console.WriteLine($"Performing surgery at the Emergency Center {Name}.");
            }
            else
            {
                Console.WriteLine("Surgery is not possible: insufficient resources.");
            }
        }
        public void AttendEmergency()
        {
            Console.WriteLine($"Emergency attended in {Name}. Average waiting time: {TimeAverageWaitAverage} minutes.");
        }

    }
}
