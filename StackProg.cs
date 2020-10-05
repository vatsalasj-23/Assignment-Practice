using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Stack
{
	class StackProg
	{
		static void Main(string[] args)
		{
			Console.WriteLine("CSharp Stack Programming");
			Console.WriteLine("\n");

			Stack<string> MyProg = new Stack<string>();
			MyProg.Push("vatsala");
			MyProg.Push("Associate Eninnering");
			MyProg.Push("loaction is in Hyderabad");

			foreach(string A in MyProg)
			{
				Console.WriteLine("The Elements of MyStack: " +A);
				Console.ReadLine();

			}
			Console.WriteLine(MyProg.Contains("vatsala"));
			Console.WriteLine(MyProg.Contains("VATSALA"));
			Console.ReadLine();

			
		}
	}
}
