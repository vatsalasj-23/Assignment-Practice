using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLinqEmp
{
	class EmpAssign
	{

		public class Employee
		{
			public string EmployeeName{get;set;}
			public int EmployeeID { get; set; }
			public int EmployeeSalary { get; set; }
			public string EmployeeDesignation { get; set; }
		}

		static void Main(string[] args)
		{
			IList<Employee> EmployeeList = new List<Employee>()
			{
				new Employee() { EmployeeName = "VatsalaSJ", EmployeeID = 101, EmployeeSalary = 30000, EmployeeDesignation = "software" },
				new Employee() { EmployeeName = "Darshan", EmployeeID = 102, EmployeeSalary = 60000, EmployeeDesignation = "HR" },
				new Employee() { EmployeeName = "Pammi", EmployeeID = 103, EmployeeSalary = 40000, EmployeeDesignation = "IT" },
				new Employee() { EmployeeName = "chinnu", EmployeeID = 104, EmployeeSalary = 50000, EmployeeDesignation = "sales" },
			};

			var Employees = EmployeeList.Where(S => S.EmployeeSalary > 40000).Select(S => S).Where(S => S.EmployeeID < 103).Select(S => S.EmployeeName);
			foreach (var V in Employees)
			{
				Console.WriteLine(V);
				Console.ReadLine();
			}
			Console.WriteLine("**********************************************************************************");

			var EMP = EmployeeList.Where(T => T.EmployeeName.Length > 7).Select(T => T).Where(T => T.EmployeeSalary < 40000).Select(T => T.EmployeeDesignation);
			foreach (var x in EMP)
			{
				Console.WriteLine(x);
				Console.ReadLine();

			}
			Console.WriteLine("**********************************************************************************");

			var E = EmployeeList.Where(U => U.EmployeeSalary > 30000).Select(U => U).Where(U => U.EmployeeID > 101).Select(U => U.EmployeeName);
			foreach (var Y in E)
			{
				Console.WriteLine(Y);
				Console.ReadLine();
			}

		}
	}
}
