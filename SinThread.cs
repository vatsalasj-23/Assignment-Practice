using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace SThread
{
	//driver class
	class SinThread
	{
		static string Thread1()
		{
			return "THREAD 1 is called";
		}
		static string Thread2()
		{
			return "THREAD 2 is called";
		}
		static string Thread3()
		{
			return "THREAD 3 is called";
		}
		//main program
		static void Main(string[] args)
		{
			//Program pg = new Program();
			//Thread T = Thread.CurrentThread();
			//Console.WriteLine(T);


			
			string res1 = Thread1();
			Console.WriteLine(res1);

			string res2 = Thread2();
			Console.WriteLine(res2);

			string res3 = Thread3();
			Console.WriteLine(res3);

			Console.ReadLine();
			



		}
	}
}
