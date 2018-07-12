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
        //Db context to access the database
        private  ApplicationDbContext context;
        //initialize dbcontext in the constructor
        public CustomersController()
        {
            context = new ApplicationDbContext();
        }
        //override the dispose method of the base controller class
        protected override void Dispose(bool disposing)
        {
           context.Dispose();
        }
        // GET: Customers
        public ViewResult Index()
        {

            //modified the code to assign Customers(ViewModel) data to get data from  context.Customers in the database

            //create a view Model Object
            var viewModel = new IndexViewModel
            {

                //Customers = generateCustomers()
                Customers = context.Customers.ToList()

            };
            return View(viewModel);
        }

        public ActionResult Display(int id)
        {
            /*Old code solution for SECTION-2
            var customers = generateCustomers();
            Customer customer = null;//declare a variable customer of type Customer
            foreach (var c in customers)
            {
                if (c.Id == id)
                {
                    customer = c;
                    break;
                }
            }
            if (customer == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(customer);
            }*/
            var customer = context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

        /*public List<Customer> generateCustomers()
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

        }*/
    }
}