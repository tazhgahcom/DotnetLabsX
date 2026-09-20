using System;
using System.Collections.Generic;
using System.Text;

namespace Tazhgah.LinqCore
{
    public class Game
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Genre { get; set; } = null!;
        public int ReleaseYear { get; set; } = 1970;
        public float Rating { get; set; }
        public float Price { get; set; }
    }
}
