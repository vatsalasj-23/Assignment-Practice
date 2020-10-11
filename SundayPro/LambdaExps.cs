using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExp
{
	class LambdaExps
	{
		//WITHOUT USING ANY DELEGATES

		static void Main(string[] args)
		{
			//LIST TO STORE NUMBERS
			List<int> Num = new List<int>() { 12, 24, 36, 48, 60, 72, 84, 96, 108, 120 };
			Console.WriteLine(Num);
			foreach (int i in Num)
			{
				Console.WriteLine(i);
				Console.ReadLine();

			}

			Console.WriteLine("*********************************************************************");

			//using lambda expressions to calculate square of each num in the lists(x=>x*x)
			var Square = Num.Select(x => x * x);
			foreach (int J in Square)
			{
				Console.WriteLine(J);
				Console.ReadLine();
			}
		}

	}

}
