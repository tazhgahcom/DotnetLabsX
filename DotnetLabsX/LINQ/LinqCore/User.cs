using System;
using System.Collections.Generic;
using System.Text;

namespace Tazhgah.LinqCore
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Family { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public bool IsDeleted { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
