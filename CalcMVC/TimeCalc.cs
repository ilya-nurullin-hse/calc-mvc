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
            return time.Hours * 360 + time.Minuties * 60 + time.Seconds;
        }

        public static int ToMinutes(Time time)                  // перевод в минуты - округление в меньшую сторону
        {
            return time.Hours * 60 + time.Minuties + time.Seconds / 60;
        }

        public static int ToHours(Time time)                   // перевод в часы - округление в меньшую сторону
        {
            return time.Hours + time.Minuties / 60 + time.Seconds / 360;
        }
        private static Time ToTime(int seconds)               // перевод из секунд в формат Time - вспомогательная функция
        {
            int h = time / 360;                            
            int m = (time - h * 360) / 60;
            int s = time - h * 360 - m * 60;
            return new Time(h, m, s);
        }
    }
}