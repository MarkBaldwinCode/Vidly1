using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Customers;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        //GET: /Customers/

        public ActionResult Index()
        {
            return View();
        }

    
        // GET: /Customers/currentCustomer/

        public string currentCustomer()
        {
            //var customer = new Customer() { Name = "John Smith" };
            return "This is John Smith";
        }
    }
}