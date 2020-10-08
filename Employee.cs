using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAnonymous
{
	public delegate string GreetingDelegate(string str);
	class Employee
	{
		//public static string Greetings(string value)
		//{
		//	return "the " + value + " Manager is very strict";

		//}
		static void Main(string[] args)
		{
			//GreetingDelegate obje = new GreetingDelegate(Greetings);
			GreetingDelegate obje = delegate (string value)
			{
				return "the " + value + " Manager is very strict";

			};
			string str = obje.Invoke("BANK");
			Console.WriteLine(str);
			Console.ReadLine();
		}
	}
}
