using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentRegForm.Models;

namespace StudentRegForm.Controllers
{
    public class StudentController : Controller
    {
		// GET: Student

		StudentEntity db = new StudentEntity();
		//public ActionResult Index()
		//{
		//	return View(db.StudentRegTable.ToList());
		//}
		public ViewResult Index()
		{
			return View(db.StudentRegTable.ToList());
		}
  
   
    }
}
//AttachDbFilename=[DataDirectory|\StudentReg.mdf
//<add name="DefaultConnection" connectionString="Data Source=CQTT4323;Initial database=JBSMonitor;Integrated Security=True" providerName="System.Data.SqlClient"/>