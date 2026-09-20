using System;
using System.Collections.Generic;
using System.Text;

namespace Tazhgah.Core.PatternMatching.Data
{
    public class PersonModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public AddressModel Address { get; set; } = new();
    }
}
