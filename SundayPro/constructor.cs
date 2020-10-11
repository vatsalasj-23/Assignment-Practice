using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace CConstructor
{
	class constructor
	{
		static void test(object max)
		{
			int num = Convert.ToInt32(max);
			for (int i = 1; i < num; i++)
			{
				Console.WriteLine(i);

			}
		}
		static void Main(string[] args)
		{
			ParameterizedThreadStart obj = new ParameterizedThreadStart(test);
			Thread t = new Thread(obj);
			t.Start(15);
			Console.WriteLine("main thread  exciting");
			Console.ReadLine();

		}
	}
}
