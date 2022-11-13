using MVC_Sample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Sample.ViewModel
{
    public class CustomerBookViewModel
    {
        public IEnumerable<Book> Books { get; set; }
        public IEnumerable<Customer> Customers { get; set; }
    }
}