using System;
using System.Collections.Generic;
using System.Text;

namespace Tazhgah.Core.GlobalUsings.Data
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
