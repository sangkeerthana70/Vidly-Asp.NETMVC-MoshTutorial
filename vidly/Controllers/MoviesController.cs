
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidly.Models;//refers to namespace in models folder which has the class Movie

namespace vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            //create an instance of movie model in Models/Movie.cs
            var movie = new Movie()
            {
                Name = "shrek",
                Id = 12345
            };
            return View(movie);
        }
        //example of a parameter embedded in the URL
        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }
        //optional parameters can be given in an action
        public ActionResult Index()
        {
            var movie = new Movie()
            {
                Name = "shrek",
                
            };
            return Content("IndexPage");
            
        }
    }
}