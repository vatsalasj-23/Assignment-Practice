using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ActionLink.Models;

namespace ActionLink.Controllers
{
    public class FirstController : Controller

    {
        // GET: First
        public ActionResult Index()
        {
			Employee emp = new Employee()//Instance for the model class- employee
			{
				Name = "Vatsala sj",
				Salary = "davanagere",
				DepartmentName ="Engineer"
			};

            return View();
        }
		[HttpPost]
		public ActionResult Index(Employee emp)
		{
			return View();
		}
    }
}