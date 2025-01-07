using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oppconcepts
{
    public class Cap : HealthCenters
    {
        public bool OffersVaccination { get; set; }
        public bool OffersGeneralMedicalConsultation { get; set; }

        public Cap(string name, string location, int numBeds, int numRooms, int numDoctors,
                                        bool offersVaccination, bool offersGeneralMedicalConsultation)
            : base(name, location, numBeds, numRooms, numDoctors)
        {
            this.OffersVaccination = offersVaccination;
            this.OffersGeneralMedicalConsultation = offersGeneralMedicalConsultation;
        }

        public void RealizarVacunacion()
        {
            if (OffersVaccination)
            {
                Console.WriteLine($"Performing vaccinations at the CAP {Name}.");
            }
            else
            {
                Console.WriteLine($"The CAP {Name} does not offer vaccination services.");
            }
        }


        public override void PerformSurgery()
        {
            Console.WriteLine($"The CAP {Name} is not equipped to perform surgery. Please go to a hospital.");
        }

        public void MedicalConsultation()
        {
            if (OffersGeneralMedicalConsultation)
            {
                Console.WriteLine($"The CAP {Name} is offering general medical consultations.");
            }
            else
            {
                Console.WriteLine($"The CAP {Name} does not offer general medical consultations.");
            }
        }
    }
}