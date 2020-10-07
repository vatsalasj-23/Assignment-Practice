using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLinqSharp
{
	class LinqPg
	{
		static void Main(string[] args)
		{
			int[] array = { 11, 21, 34, 4, 54, 55, 67, 80, 90, 99, 123, 32, 34, 35 };

			var Num = from i in array where i > 30 orderby i descending select i;
			foreach (int x in Num)
			{
				Console.WriteLine(x);
				Console.ReadLine();

			}
			Console.WriteLine("\n");

			var number = from g in array where g < 30 orderby g ascending select g;
			foreach (int y in number)
			{
				Console.WriteLine(y);
				Console.ReadLine();

			}
			Console.WriteLine();
			Console.WriteLine("\n");
			Console.WriteLine("*******************************************************************************");

			string[] student = { "jagadeesha", "lalitha", "darshan", "vatsala", "ganga", "pavi" };

			var studentList = from S in student where S.Length > 6 orderby S descending select S;

			foreach (string n in studentList)
			{
				Console.WriteLine(n);
				Console.ReadLine();

			}

			Console.WriteLine("\n");

			var Studentss = from v in student where v.Length < 6 orderby v ascending select v;
			foreach (string j in Studentss)
			{
				Console.WriteLine(j);
				Console.ReadLine();
			}



		}
	}
}
