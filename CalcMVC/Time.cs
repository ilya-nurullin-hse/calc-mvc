using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcMVC
{
    class Time
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public Time(int hours = 0, int minutes = 0, int seconds = 0)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public override string ToString()
        {
            return string.Format("{0:D}:{1:D2}:{2:D2}", Hours, Minutes, Seconds); // для C# < 6.0
            /* return $"{Hours:D}:{Minutes:D2}:{Seconds:D2}";*/     // для C# >= 6.0
        }
    }
}
