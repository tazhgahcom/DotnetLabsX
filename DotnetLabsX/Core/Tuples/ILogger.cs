using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Core.Tuples
{
    public interface ILogger
    {
        void Log(string data);
        void Log(int data);
        void Log(float data);
        void Log(double data);
        void Log(object data);
    }
}
