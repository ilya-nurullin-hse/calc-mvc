using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcMVC
{
    class TimeCalc
    {
        public static Time Sum(Time first, Time second)           // сумма двух (1 + 2)
        {
            int time = ToSeconds(first) + ToSeconds(second);
            
            return ToTime(time);
        }

        public static Time Sub(Time first, Time second)          //  разность (1-2), если отрицательная, то часы -1
        {
            int time = ToSeconds(first) - ToSeconds(second);
            if (time < 0) return new Time(-1, 0, 0);
            return ToTime(time);
        }

        public static Time GetInterval(Time from, Time to)       // интервал (2 -1), если отрицательная, то часы -1
        {
            int time= ToSeconds(to) - ToSeconds(from);
            if (time < 0) return new Time(-1, 0, 0);
            return ToTime(time);
        }

        public static int ToSeconds(Time time)                   // перевод в секунды
        {
            return time.Hours * 3600 + time.Minutes * 60 + time.Seconds;
        }

        public static int ToMinutes(Time time)                  // перевод в минуты - округление в меньшую сторону
        {
            return time.Hours * 60 + time.Minutes + time.Seconds / 60;
        }

        public static int ToHours(Time time)                   // перевод в часы - округление в меньшую сторону
        {
            return time.Hours + time.Minutes / 60 + time.Seconds / 3600;
        }
        private static Time ToTime(int seconds)               // перевод из секунд в формат Time - вспомогательная функция
        {
            int h = seconds / 3600;
            int m = (seconds - h * 3600) / 60;
            int s = seconds - h * 3600 - m * 60;
            return new Time(h, m, s);
        }
    }
}