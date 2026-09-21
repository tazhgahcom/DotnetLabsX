using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Tazhgah.Core.RequiredProperties
{
    public class PersonModel
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }

        [SetsRequiredMembers]
        public PersonModel()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
        }

        [SetsRequiredMembers]
        public PersonModel(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
