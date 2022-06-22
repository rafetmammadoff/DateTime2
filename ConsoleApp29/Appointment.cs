using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp29
{
    class Appointment
    {
        public Appointment()
        {
            _no = _total;
            _total++;
        }
        private int _no;
        private static int _total = 1000;
        public int No
        {
            get => _no;
        }
        public string Patient;
        public string Doctor;
        public DateTime StartDate;
        public DateTime EndDate;
    }
}
