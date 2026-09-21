using System;
using System.Collections.Generic;
using System.Text;

namespace Tazhgah.Core.Tuples
{
    public static class ConsoleMessage
    {
       
        public static void WriteSuccessMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Green;
            WriteLine(message);
            Console.ResetColor();
        }
            
        public static void WriteErrorMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
            WriteLine(message);
            Console.ResetColor();
        }

    }
}
