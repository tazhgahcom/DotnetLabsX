using System;
using System.Collections.Generic;
using System.Text;
using Tazhgah.Core.Interfaces.Interfaces;

namespace Tazhgah.Core.Interfaces.Services
{
    public class ConsolePrint : IPrintable<object>
    {
        public void Print(object value)
        {
            value.Dump();
        }
    }
}
