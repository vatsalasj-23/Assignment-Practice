using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDelegate
{
	public delegate string GreetingsDelegate(string str);//declaring the delegate


	class GreetDel
	{
		public static string Greetings(string name)
		{
			return "hello " + name + " A very good morning";

		}
		static void Main(string[] args)
		{
			GreetingsDelegate obj= new GreetingsDelegate(Greetings);//object ceation of delegate or INSTNTIATING A Delegate
			//Method is passing returning a value
			string str = obj.Invoke("girls");
			Console.WriteLine(str);
			Console.ReadLine();

		}
	}
}
