using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcMVC
{
    class Logger
    {
        private static readonly string _fileName = DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss")+".txt";

        private static readonly StreamWriter _sw = new StreamWriter(File.Create("./"+_fileName));

        public static void Log(string operation, Time first, Time second, Time result)
        {
            _sw.WriteLine("{0} {1} {2} = {3}", first, operation, second, result);
            _sw.Flush();
        }

        public static void Log(string operation, Time first, Time second, string result)
        {
            _sw.WriteLine("{0} {1} {2} = {3}", first, operation, second, result);
            _sw.Flush();
        }

        public static void Log(string operation, Time time, int result)
        {
            _sw.WriteLine("{0}({1}) = {2}", operation, time, result);
            _sw.Flush();
        }
    }
}
