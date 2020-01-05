using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vividly.Models
{
    public class CustomersViewModel
    {
        public List<Customer> Customers { get; set; }

        public bool ShowCustomerNotFound => this.Customers == null || this.Customers.Count.Equals(0);
    }
}