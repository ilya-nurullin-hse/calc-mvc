using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcMVC
{
    /// <summary>
    /// Исключение выбрасываемое при получении неверной даты
    /// </summary>
    class WrongTimePeriodException : ApplicationException
    {
        public WrongTimePeriodException() : base() { }
        public WrongTimePeriodException(string str) : base(str) { }
        
        public override string ToString()
        {
            return Message;
            
        }
    }
}
