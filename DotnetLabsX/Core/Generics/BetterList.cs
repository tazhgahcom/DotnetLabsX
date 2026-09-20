using Dumpify;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tazhgah.Core.Generics
{
    public class BetterList<T>
    {
        protected readonly List<T> data = new();


        public void AddToList(T value)
        {
            data.Add(value);
            Console.WriteLine($"{value} has been added to the list");
        }

        public void PrintData()
        {
            data.Dump();
        }
    }
}
