using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp29
{
    class Hospital
    {
        public List<Appointment> appointments = new List<Appointment>();
        public void AddAppointment(Appointment appointment)
        {
            appointments.Add(appointment);
        }

        public void EndAppointment(int no)
        {
            Appointment appo = appointments.Find(x => x.No == no);
            if (appo != null)
            {
                appo.EndDate = DateTime.Now;
            }
        }
        public Appointment GetAppointment(int no)
        {
            Appointment appo = appointments.Find(x => x.No == no);
            if (appo != null)
            {
                return appo;
            }
            else
            {
                return null;
            }
        }

        public List<Appointment> GetAllAppointments()
        {
            return appointments;
        }

        public List<Appointment> GetWeeklyAppointments()
        {
            return appointments.FindAll(x => x.StartDate < DateTime.Now && x.StartDate > DateTime.Now.Date.AddDays(-7));
        }
        public List<Appointment> GetTodaysAppointments()
        {
            return appointments.FindAll(x => x.StartDate.ToShortDateString()==DateTime.Now.ToShortDateString());
        }
        public List<Appointment> GetAllContinuingAppointments()
        {
            return appointments.FindAll(x => x.EndDate.Year==0001);
        }




    }
}
