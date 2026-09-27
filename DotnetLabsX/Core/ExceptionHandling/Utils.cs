using System;
using System.Collections.Generic;
using System.Text;

namespace Tazhgah.Core.ExceptionHandling
{
    public static class Utils
    {

        public static int GetAge(string ageString)
        {
            int output = int.Parse(ageString);
            return output;
        }

    }
}
