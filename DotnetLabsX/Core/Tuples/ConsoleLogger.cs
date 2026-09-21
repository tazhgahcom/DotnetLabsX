using DesignPatterns.Core.Tuples;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tazhgah.Core.Tuples
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string data)
        {
            Console.WriteLine(data);
        }

        public void Log(int data)
        {
            Console.WriteLine(data.ToString());
        }

        public void Log(float data)
        {
            Console.WriteLine(data);
        }

        public void Log(double data)
        {
            Console.WriteLine(data);
        }

        public void Log(object data)
        {
            Console.WriteLine(data.ToString());
        }
    }
}
