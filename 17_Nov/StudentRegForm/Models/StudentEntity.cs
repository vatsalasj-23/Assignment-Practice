using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace StudentRegForm.Models
{
	public class StudentEntity : DbContext
	{
		public StudentEntity() : base("ProductionConnection")
		{

		}
		public DbSet<Student>  StudentRegTable {get;set;}
	}
}