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
        public ViewResult Index()
        {

            //create a view Model Object
            var viewModel = new RandomMovieViewModel
            {

                Customers = generateCustomers()

            };
            return View(viewModel);
        }

        public ViewResult Display(int id)
        {
            var customers = generateCustomers();
            Customer customer = null;
            foreach (var c in customers)
            {
                if (c.Id == id)
                {
                    customer = c;
                    break;
                }
            }
            return View(customer);
        }

        public List<Customer> generateCustomers()
        {
            var customers = new List<Customer>
            {
                //object initialization syntax for list of customers
                new Customer { Id = 1, Name = "Anamika", Age = 20, Sex = "Female" },
                new Customer { Id = 2, Name = "Athmika", Age = 22, Sex = "Female" },
                new Customer { Id = 3, Name = "Daisy", Age = 24, Sex = "Female" },
                new Customer { Id = 4, Name = "Violet", Age = 26, Sex = "Female" },
                new Customer { Id = 5, Name = "Lily", Age = 28, Sex = "Female" },
                new Customer { Id = 6, Name = "Petunia", Age = 30, Sex = "Female" }
            };
            return customers;

        }
    }
}