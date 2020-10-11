using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queque
{
	class StackQueque
	{
		static void Main(string[] args)
		{
			Console.WriteLine("C# Queque Programming");
			Queue<string> VSJ = new Queue<string>();  //Queque Object created
			Stack<string> DSJ = new Stack<string>();


			VSJ.Enqueue("vatsala sj");
			VSJ.Enqueue("darshan sj");
			VSJ.Enqueue("brother");
			VSJ.Enqueue("Family");

			DSJ.Push("vatsala sj");
			DSJ.Push("darshan sj");
			DSJ.Push("brother");
			DSJ.Push("family");


			foreach (string A in VSJ)
			{
				Console.WriteLine("the elements quequed are: " + A);
				Console.ReadLine();
			}

			Console.WriteLine("Elements left after applying Dequeque method: " + VSJ.Dequeue());
			Console.WriteLine("elements of the queque are: " + VSJ.Peek());
			Console.WriteLine("The cuurent elements prersent are: " + VSJ.Count());

			Console.WriteLine("Elements left after applying Dequeque method: " + VSJ.Dequeue());
			Console.WriteLine("elements of the queque are: " + VSJ.Peek());
			Console.WriteLine("The cuurent elements prersent are: " + VSJ.Count());




			foreach (string B in DSJ)
			{
				Console.WriteLine("the elemnts stacked are: " + B);
				Console.ReadLine();

			}
		}
	}
}
