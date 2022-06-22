using System;
using System.Collections.Generic;

namespace ConsoleApp29
{
    class Program
    {
        static void Main(string[] args)
        {
            Hospital hospital = new Hospital();
            Appointment appo1 = new Appointment
            {
                Patient = "ehmed ehmedov",
                Doctor = "Kamran",
                StartDate = new DateTime(2022, 06, 15)
            };
            Appointment appo2 = new Appointment
            {
                Patient = "kartoska ehmedov",
                Doctor = "Kamran",
                StartDate = new DateTime(2022, 06, 22)
            };
            Appointment appo3 = new Appointment
            {
                Patient = "canavar ehmedov",
                Doctor = "Kamran",
                StartDate = new DateTime(2022, 06, 11)
            };
            Appointment appo4 = new Appointment
            {
                Patient = "kitab ehmedov",
                Doctor = "Kamran",
                StartDate = new DateTime(2022, 06, 19)
            };
            hospital.AddAppointment(appo1);
            hospital.AddAppointment(appo2);
            hospital.AddAppointment(appo3);
            hospital.AddAppointment(appo4);
            hospital.EndAppointment(1000);
            List<Appointment> new1 = hospital.GetAllContinuingAppointments();
            

            foreach (var item in new1)
            {
                Console.WriteLine(item.Patient + " " + item.EndDate);
            }

        }
    }
}
