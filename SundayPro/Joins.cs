using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace CJoins
{
	class Joins
	{
		public void Method1()
		{
			for (int i = 0; i < 5; i++)
			{
				Console.WriteLine("Happy Sunday");
			}
		}
		public void Method2()
		{
			for (int i = 0; i < 5; i++)
			{
				Console.WriteLine("Tommorrow is a working day");
			}
		}
		static void Main(string[] args)
		{
			Console.WriteLine("Main thread started");
			Joins p = new Joins();
			Thread t1 = new Thread(p.Method1);
			Thread t2 = new Thread(p.Method2);
			p.Method2();p.Method1();p.Method2();
			t1.Start();t2.Start();
			t1.Join();t2.Join();
			Console.WriteLine("Main thread exiting");
			Console.ReadKey();
		}
	}
}


