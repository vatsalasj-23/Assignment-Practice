using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace StudentRegForm.Models
{
	public class Student
	{
		[Key]
		public int ID { get; set; }
		public string Name { get; set; }
		public string Age  { get; set; }
		public double ContactNo { get; set; }
		public string City { get; set; }
	}
}