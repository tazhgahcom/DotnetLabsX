using DesignPatterns.Core.Tuples;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tazhgah.Core.Tuples.Models
{
    public class PersonModel
    {
        private readonly ILogger _logger;

        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string? LastName { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public PersonModel(ILogger logger)
        {
            _logger = logger;
        }

    }
}
