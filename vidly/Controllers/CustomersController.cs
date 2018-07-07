using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidly.Models;
using vidly.ViewModels;

namespace vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            //list of customers
            var customers = new List<Customer>
            {
                //object initialization syntax
                new Customer { Name = "Anamika"},
                new Customer { Name = "Athmika"},
                new Customer { Name = "Daisy"},
                new Customer { Name = "Violet"},
                new Customer { Name = "Lily" },
                new Customer { Name = "Petunia"}
            };
            //create a view Model Object
            var viewModel = new RandomMovieViewModel
            {
                
                Customers = customers

            };
            return View(viewModel);
        }
    }
}