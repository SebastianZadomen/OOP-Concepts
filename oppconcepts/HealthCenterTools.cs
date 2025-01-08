using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oppconcepts
{
    public static class HealthCenterUtils
    {
        public static double CalculateOccupancyPercentage(int totalBeds, int occupiedBeds)
        {
            if (totalBeds == 0) return 0;
            return (double)occupiedBeds / totalBeds * 100;
        }

        public static string GenerateCenterStatus(string name, int bedsAvailable, int doctorsAvailable)
        {
            return $"Condition of the center '{name}': {bedsAvailable} beds available and {doctorsAvailable} available doctors.";
        }
        public static double CalculateAverageTimePerPatient(int totalDoctors, int totalPatients, double averageDoctorTime)
        {
            if (totalDoctors == 0 || totalPatients == 0) return 0; 
            return (totalPatients * averageDoctorTime) / totalDoctors;
        }
    }
}