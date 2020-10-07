using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsrpLinq
{
	class Clinq
	{
		static void Main(string[] args)
		{
			int[] arr = { 1, 46, 78, 90, 32, 56, 43, 12, 13, 78 };

			var brr = from i in arr where i > 40 orderby i descending select i;
			var crr = from i in arr where i > 30 orderby i ascending select i;

			foreach (int x in brr)
			{
				Console.Write(x + " ");
				Console.ReadLine();
			}

			Console.WriteLine("**********************************************");

			foreach (int x in crr)
			{
				Console.Write(x + " ");
				Console.ReadLine();
			}
		}
	}
}


