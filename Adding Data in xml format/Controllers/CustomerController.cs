using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Adding_Data_in_xml_format.Models;

namespace Adding_Data_in_xml_format.Controllers
{
    public class CustomerController : Controller
    {
        CustomerRepo repos = new CustomerRepo();
        CustomerRepo2 repos2=new CustomerRepo2();

        // GET: Customer
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Customer c)
        {
            repos.CustomerDetails(c);
            return View();
        }

        public ActionResult Result()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Result(CustomerData cd)
        {
            repos2.CustomerDetails(cd);
            return View();
        }
      
    }
}