using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace SgThreadAssign
{
	class Threads
	{
		public int Thread1(int x, int y)
		{
			return x + y;

		}
		public int Thread2(int a)

		{
			Console.WriteLine("Thread is sleeping");
			Thread.Sleep(10000);

			return a * a * a;

		}
		public string Thread3(string s1,string s2)
		{
			return s1 + s2;
		}
		static void Main(string[] args)
		{
			Threads obj = new Threads();
			Console.WriteLine("The sum is:" + obj.Thread1(2, 3));
			Console.WriteLine("cube is:" + obj.Thread2(20));
			Console.WriteLine("String is:" + obj.Thread3("Vatsala ", " Jagadeesha"));
			Console.ReadKey();

		}
	}
}


