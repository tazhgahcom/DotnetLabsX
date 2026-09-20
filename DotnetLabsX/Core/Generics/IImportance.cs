using System;
using System.Collections.Generic;
using System.Text;

namespace Tazhgah.Core.Generics
{
    public interface IImportance<T>
    {
        T MostImportant(T value1, T value2);
    }
}
