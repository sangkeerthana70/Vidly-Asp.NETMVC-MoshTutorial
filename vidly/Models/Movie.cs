using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ReleaseDate { get; set; }
        public int ReleaseYear { get; set; }
        public string Category { get; set; }

        
    }
}