using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignStack
{
	class StackPg
	{
		static void Main(string[] args)
		{
			Console.WriteLine("C# Stack Programming");

			//int[] arr = new int[10] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };

			Stack<int> Assignment = new Stack<int>();//  stack: Last In First Out(LIFO) Operation
			Assignment.Push(2);
			Assignment.Push(4);
			Assignment.Push(6);
			Assignment.Push(8);
			Assignment.Push(10);
			Assignment.Push(12);
			Assignment.Push(14);
			Assignment.Push(16);
			Assignment.Push(18);
			Assignment.Push(20);



			foreach (int V in Assignment)
			{
				Console.WriteLine("Entered elements in a Stack using push methods are: " + V);
				Console.ReadLine();
			}

			Console.WriteLine("Popping elements");

			Console.WriteLine(Assignment.Pop());//20
			Console.WriteLine(Assignment.Pop());//18
			Console.WriteLine(Assignment.Pop());//16
			Console.WriteLine(Assignment.Pop());//14
			Console.WriteLine(Assignment.Pop());//12
			Console.WriteLine(Assignment.Pop());//10
			Console.WriteLine("6 elements are removed");
			Console.WriteLine(Assignment.Count());
			Console.ReadLine();

			Assignment.Push(10);//Adding 10

			foreach (int V in Assignment)
			{
				Console.WriteLine("Entered elements in a Stack using push methods are: " + V);
				Console.ReadLine();
			}

			Console.WriteLine("5 elements are removed");
			Console.WriteLine(Assignment.Pop());//deleting 10
			Console.WriteLine(Assignment.Pop());//deleting 8
			Console.WriteLine(Assignment.Pop());//deleting6
			Console.WriteLine(Assignment.Pop());//deleting  4
			Console.WriteLine(Assignment.Pop());//deleting 2

			Console.WriteLine(Assignment.Count());// 0
			Console.ReadLine();

			Console.WriteLine("5 elements are added");
			Assignment.Push(2);//adding 2
			Assignment.Push(4);//adding 4
			Assignment.Push(6);//adding 6
			Assignment.Push(8);//adding 8
			Assignment.Push(10);//adding 10

			foreach (int V in Assignment)
			{
				Console.WriteLine("Entered elements in a Stack using push methods are: " + V);
				Console.ReadLine();
			}
			Console.WriteLine(Assignment.Count());//6
			Console.WriteLine("\n");

			Console.WriteLine("4 elements are removed");
			Console.WriteLine(Assignment.Pop());//deleting 10
			Console.WriteLine(Assignment.Pop());//deleting 8
			Console.WriteLine(Assignment.Pop());//deleting 6
			Console.WriteLine(Assignment.Pop());//deleting 4
			Console.WriteLine(Assignment.Count());//2
			Console.ReadLine();


			Console.WriteLine("4 elements are added");
			Assignment.Push(12);//adding 12
			Assignment.Push(14);//adding 14
			Assignment.Push(16);//adding 16
			Assignment.Push(18);// adding 18////18,16,14,12
			Console.WriteLine(Assignment.Count());//6

			foreach (int V in Assignment)
			{
				Console.WriteLine("Entered elements in a Stack using push methods are: " + V);
				//Console.WriteLine("the total no of elements are :" + V);
				Console.ReadLine();
			}
			Console.WriteLine(Assignment.Count());

			Console.WriteLine("3 elements are removed");
			Console.WriteLine(Assignment.Pop()); //deleting 18
			Console.WriteLine(Assignment.Pop());//deleting 16
			Console.WriteLine(Assignment.Pop());//deleting 14
			Console.WriteLine(Assignment.Count());//3
			Console.ReadLine();

			Console.WriteLine("2 elements are added");
			Assignment.Push(4);//adding 4
			Assignment.Push(6);//adding 6

			foreach (int V in Assignment)

			{
				Console.WriteLine("Entered elements in a Stack using push methods are: " + V);
				Console.ReadLine();
			}
			Console.WriteLine(Assignment.Count());//4

			Console.WriteLine("2 elements are removed");
			Console.WriteLine(Assignment.Pop());//deleting 8
			Console.WriteLine(Assignment.Pop());//deleting 6
			Console.WriteLine(Assignment.Count());//2
			Console.ReadLine();

			foreach (int V in Assignment)

			{
				Console.WriteLine("Entered elements in a Stack using push methods are: " + V);

				Console.ReadLine();
			}
			Console.WriteLine(Assignment.Count());


		}
	}
}
	}
}
