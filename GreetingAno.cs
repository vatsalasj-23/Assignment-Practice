using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cdelegate1
{
	class GreetingAno
	{
		//DECLARING A DELEGATE
		public delegate string GreetingDelegate1(string str);

		public static string Greetings(string value)
		{
			return value + "  bank app is very safety when compared to other banks";
		}
		static void Main(string[] args)
		{
			GreetingDelegate1 obj1 = new GreetingDelegate1(Greetings);//Instantiating a delegate

			string str = obj1.Invoke("HDFC");//invoking a method 
			Console.WriteLine(str);
			Console.ReadLine();

		}
	}
}

//NORMAL DELEGATE METHOD
{
//public delegate string GreetingHDFC(string str);//decalre a method

//public static string 
static void Main(string[] args)
{
	greetingDelegate object=delegate()

}
