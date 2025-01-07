using System;
namespace oppconcepts
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Hospital publicHospital = new Hospital("Hospital Público Central", "Granollers", 100, 50, 20, true);
            Hospital privateHospital = new Hospital("Hospital Privado Elite", "Badalona", 80, 40, 15, false);
            Clinic clinica = new Clinic("Clínica Especializada", "Sant andreu", 50, 20, 10, "Cardiología");
            Cap cap = new Cap("CAP Roquetes", "Roquetes", 10, 5, 8, true, true);
            EmergencyCenter urgencias = new EmergencyCenter("Urgencias 24H", "Les Franqueses", 30, 15, 12, 20);

            privateHospital.AdmitPatient();

            string statusHospitalPrivate = HealthCenters.GenerateCenterStatus(
            privateHospital.Name,
            privateHospital.NumBeds,
            privateHospital.NumRooms,
            privateHospital.NumDoctors
            );

            Console.WriteLine(statusHospitalPrivate);

        }
    }
}