using System;
using System.Collections.Generic;
using System.Text;

namespace Tazhgah.Core.GlobalUsings.Data
{
    public class PostModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Content { get; set; } = null!;
    }
}
