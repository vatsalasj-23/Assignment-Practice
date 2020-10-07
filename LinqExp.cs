using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLinq1
{
	class LinqExp
	{
		static void Main(string[] args)
		{
			string[] employee = { "vatsala", "darshan", "priya", "hari", "jagadeesha", "lalitha", "ganga" };

			var emp = from V in employee where V.Length > 6 orderby V descending select V;

			foreach (string x in emp)
			{
				Console.WriteLine(x+" ");
				Console.ReadLine();
			}
			Console.WriteLine("*******************************************************************");
			var sgh = from X in employee where X.Length < 5 orderby X ascending select X;
			foreach (string y in sgh)
			{
				Console.WriteLine(y+" ");
				Console.ReadLine();
			}



		}
	}

}
