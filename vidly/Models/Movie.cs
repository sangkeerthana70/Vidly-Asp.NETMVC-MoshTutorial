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

        //public static implicit operator Movie(List<Movie> v)
        //{
        //    throw new NotImplementedException();
        //}
    }
}