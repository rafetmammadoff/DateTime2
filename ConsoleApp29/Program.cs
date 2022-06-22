using System;
using System.Collections.Generic;

namespace ConsoleApp29
{
    class Program
    {
        static void Main(string[] args)
        {
            Hospital hospital = new Hospital();
            string option;
            do
            {
                Selection();
                option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        AddAppointment(hospital);
                        break;
                    case "2":
                        EndAppointment(hospital);
                        break;
                    case "3":
                        ShowAllAppointment(hospital);
                        break;
                    case "4":
                        ShowWeeklyAppointment(hospital);
                        break;
                    case "5":
                        ShowTodayAppointment(hospital);
                        break;
                    case "6":
                        ShowContiuningAppointment(hospital);
                        break;

                }
            } while (option != "7");
        }
        static void Selection()
        {
            Console.WriteLine("1.Appointment yarat");
            Console.WriteLine("2.Appointment - i bitir");
            Console.WriteLine("3.Bütün appointment - lərə bax");
            Console.WriteLine("4.Bu həftəki appointment-lərə bax");
            Console.WriteLine("5.Bugünki appointment - lərə bax");
            Console.WriteLine("6.Bitməmiş appointmentlərə bax");
            Console.WriteLine("7.Menudan çıx");
        }
        static void AddAppointment(Hospital hospital)
        {
            Console.WriteLine("Patient adini daxil edin");
            string namePatient = Console.ReadLine();
            Console.WriteLine("Doctor adini daxil edin");
            string nameDoctor = Console.ReadLine();
            string startDateStr;
            DateTime startDate;
            do
            {
                Console.WriteLine("Baslama vaxti daxil edin");
                startDateStr = Console.ReadLine();
            } while (!DateTime.TryParse(startDateStr, out startDate));
            Appointment appointment = new Appointment() { Doctor = nameDoctor, Patient = namePatient, StartDate = startDate };
            hospital.AddAppointment(appointment);
        }
        static void EndAppointment(Hospital hospital)
        {
            string noStr;
            do
            {
                Console.WriteLine("Bitirmek istediyiniz appointment nomresini daxil edin");
                noStr = Console.ReadLine();
            } while (hospital.appointments.Find(x => x.No == int.Parse(noStr)) == null);
            int no = int.Parse(noStr);
            hospital.EndAppointment(no);
        }
        static void ShowAllAppointment(Hospital hospital)
        {
            List<Appointment> appointments = hospital.GetAllAppointments();
            Console.WriteLine("\nAll appointments");
            foreach (var item in appointments)
            {
                Console.WriteLine($"Xeste:{item.Patient} Hekim: {item.Doctor} Baslama vaxti: {item.StartDate} Bitme vaxti: {item.EndDate}");
            }
        }
        static void ShowWeeklyAppointment(Hospital hospital)
        {
            List<Appointment> appointments = hospital.GetWeeklyAppointments();
            Console.WriteLine("\nHeftelik appointments");
            foreach (var item in appointments)
            {
                Console.WriteLine($"Xeste:{item.Patient} Hekim: {item.Doctor} Baslama vaxti: {item.StartDate} Bitme vaxti: {item.EndDate}");
            }
        }
        static void ShowTodayAppointment(Hospital hospital)
        {
            List<Appointment> appointments = hospital.GetTodaysAppointments();
            Console.WriteLine("\nTodays appointments");
            foreach (var item in appointments)
            {
                Console.WriteLine($"Xeste:{item.Patient} Hekim: {item.Doctor} Baslama vaxti: {item.StartDate} Bitme vaxti: {item.EndDate}");
            }
        }
        static void ShowContiuningAppointment(Hospital hospital)
        {
            List<Appointment> appointments = hospital.GetAllContinuingAppointments();
            Console.WriteLine("\nContinuing appointments");
            foreach (var item in appointments)
            {
                Console.WriteLine($"Xeste:{item.Patient} Hekim: {item.Doctor} Baslama vaxti: {item.StartDate} Bitme vaxti: {item.EndDate}");
            }
        }

    }
}
