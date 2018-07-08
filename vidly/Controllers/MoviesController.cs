
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
        public ViewResult Index()
        {
            //var movie = this.generateMovies();
            //create a view Model Object
            var viewModel = new IndexViewModel
            {

                Movie = generateMovies()

            };
            return View(viewModel);
        }


            //return new ViewResult();
            //return Content("Hello World!");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        

        public ActionResult Display(int movieId)
        {
            var movies = generateMovies();
            Movie movie = null;//declare a variable of type Movie
            foreach (var m in movies)
            {
                if (m.Id == movieId)
                {
                    movie = m;
                    break;

                }
            }
            if (movie == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(movie);
            }
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
        public List<Movie> generateMovies()
        {
            var movies = new List<Movie>
            {
                new Movie { Id = 1, Name = "Shrek", ReleaseDate = "Apr 22", ReleaseYear = 2001, Category = "Fantasy/Adventure" },
                new Movie { Id = 2, Name = "Wall-e", ReleaseDate = "June 27", ReleaseYear = 2008, Category = "Science/Fiction" },
                new Movie { Id = 3, Name = "Frozen", ReleaseDate = "Nov 27", ReleaseYear = 2013, Category = "Fantasy/Musical Comedy" },
                new Movie { Id = 4, Name = "Emoji", ReleaseDate = "July 28", ReleaseYear = 2008, Category = "Science/Fiction" },

            };
            return movies;


        }

    }
}
//note: movies?pageIndex=1&sortBy=ReleaseDate can be given as a parameter in the URL to change the pageIndex and sortby Values for the last 
//Index ActionResult method here. But cannot be embedded inside the URL as it requires a custom route that will include two parameters.