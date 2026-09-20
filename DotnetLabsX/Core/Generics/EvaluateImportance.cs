using System;
using System.Collections.Generic;
using System.Text;

namespace Tazhgah.Core.Generics
{
    public class EvaluateImportance : IImportance<int>, IImportance<string>
    {
        public int MostImportant(int value1, int value2)
        {
            return value1 > value2 ? value1 : value2;
        }

        public string MostImportant(string value1, string value2)
        {
            return value1.Length > value2.Length ? value1 : value2;
        }
    }
}
