using System;
using System.Collections.Generic;
using System.Text;

namespace Tazhgah.Core.Debugging
{
    public class Person
    {
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public string FunkyNameBuilder()
        {
            string output = string.Empty;
            for (int i = 0; i < FirstName.Length; i++) { 
                if (i % 2 == 0)
                {
                    output += FirstName.Substring(i, 1).ToLower();
                }
                else
                {
                    output += FirstName.Substring(i, 1).ToUpper();
                }
            }
            return output;
        }
    }
}
