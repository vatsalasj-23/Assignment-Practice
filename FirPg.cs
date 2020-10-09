using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProgram
{
	class FirPg
	{
		static void Main(string[] args)
		{
			Method1();
			Method2();
			Method3();
			Console.ReadLine();
		}
		static void Method1()
		{
			for (int i = 1; i < 51; i++)
			{
				Console.WriteLine("the Method 1 values are: " + i);
			}
		}

		static void Method2()
		{
			for (int i = 1; i < 51; i++)
			{
				Console.WriteLine("the Method 2 values are: " + i);
			}
		}

		static void Method3()
		{
			for (int i = 1; i < 51; i++)
			{
				Console.WriteLine("the Method 3 values are: " + i);
			}
		}
	}
}
