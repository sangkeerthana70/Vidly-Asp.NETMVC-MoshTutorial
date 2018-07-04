
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidly.Models;//refers to namespace in models folder which has the class Movie
using vidly.ViewModels;

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
            //list of customers
            var customers = new List<Customer>
            {
                //object initialization syntax
                new Customer { Name = "Anamika"},
                new Customer { Name = "Athmika"}
            };
            //create a view Model Object
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers

            };
            return View(viewModel);
            //return new ViewResult();
            //return Content("Hello World!");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        }
        //example of a parameter embedded in the URL
        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        //create action for the custom route in RouteConfig.cs
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
        //apply route attribute by giving URL template in it.
       // [Route("movies/released/{year}/{month:regex(\\d{4}):range(1, 12)}")]


        //optional parameters can be given in an action
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex = {0}&sortby={1}", pageIndex, sortBy));
            
        }
    }
}
//note: movies?pageIndex=1&sortBy=ReleaseDate can be given as a parameter in the URL to change the pageIndex and sortby Values for the last 
//Index ActionResult method here. But cannot be embedded inside the URL as it requires a custom route that will include two parameters.