using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Partial_View.Models;

namespace Partial_View.Controllers
{
    public class HomeController : Controller
    {
		// GET: Home
		public ActionResult Index()
		{
			List<Employee> emp = new List<Employee>()
			{
				new Employee()
				{
					ID = 1,
					Email = "1dxc.dxc@dxc.com",
					Name = "1DXCtechnology",
					Description = "1hyderabadh"

				},
				new Employee()
				{
					ID = 2,
					Email = "2dxc.dxc@dxc.com",
					Name = "2DXCtechnology",
					Description = "2hyderabadh"

				},
				new Employee()
				{
					ID = 3,
					Email = "3dxc.dxc@dxc.com",
					Name = "3DXCtechnology",
					Description = "3hyderabadh"

				},
				new Employee()
				{
					ID = 4,
					Email = "4dxc.dxc@dxc.com",
					Name = "4DXCtechnology",
					Description = "4hyderabadh"

				},
				new Employee()
				{
					ID = 5,
					Email = "5dxc.dxc@dxc.com",
					Name = "5DXCtechnology",
					Description = "5hyderabadh"

				},
			};

			return View(emp);
		}
        
    }
}