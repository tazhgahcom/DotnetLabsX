using System;
using System.Collections.Generic;
using System.Text;

namespace Tazhgah.Core.GlobalUsings.Data
{
    public class PersonModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public AddressModel Address { get; set; } = new AddressModel();
    }
}
