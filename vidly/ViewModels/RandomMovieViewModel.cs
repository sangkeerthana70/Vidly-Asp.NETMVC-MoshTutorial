﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using vidly.Models;

namespace vidly.ViewModels
{
    public class RandomMovieViewModel
    {
        //properties
        public List<Movie> Movie { get; set; }
        public List<Customer> Customers { get; set; }

    }
}