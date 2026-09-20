using System;
using System.Collections.Generic;
using System.Text;

namespace Tazhgah.Core.GlobalUsings.Data
{
    public class MediaModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
