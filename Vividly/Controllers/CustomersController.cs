using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vividly.Models;

namespace Vividly.Controllers
{
    public class CustomersController : Controller
    {
        [Route("")]
        [Route("Customers/GetAllCustomers")]
        public ViewResult GetAllCustomers()
        {
            var viewModel = new CustomersViewModel
            {
                Customers = this.GetCustomers()
            };

            return View(viewModel);
        }

        [Route("Customers/GetCustomerById/{id}")]
        public ActionResult GerCustomerById(int? id)
        {
            if (id == null)
            {
                return Content("Please enter an id!!!");
            }
            var customer = this.GetCustomers().Where(x => x.Id == id).FirstOrDefault();

            if (customer == null)
            {
                return Content(string.Format("Customer with Id {0} not found!!!", id));
            }
            else
            {
                return View(customer);
            }
        }
        private List<Customer> GetCustomers()
        {
            return new List<Customer>
            {
            new Customer
            {
            Id = 1,
            Name = "Aman"
            },

            new Customer
            { 
            Id = 2,
            Name = "Adarsh"
            }
            };
        }
    }
}