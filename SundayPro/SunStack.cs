using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStack
{
	class SunStack
	{
		static void Main(string[] args)
		{
			Console.WriteLine("C# Stack Programming");

			//int[] arr = new int[10] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };

			Stack<int> Sun = new Stack<int>();//  stack: Last In First Out(LIFO) Operation
			Sun.Push(2);
			Sun.Push(4);
			Sun.Push(6);
			Sun.Push(8);
			Sun.Push(10);
			Sun.Push(12);
			Sun.Push(14);
			Sun.Push(16);
			Sun.Push(18);
			Sun.Push(20);



			foreach (int V in Sun)
			{
				Console.WriteLine("Entered elements in a Stack using push methods are: " + V);
				Console.ReadLine();
			}

			Console.WriteLine("Popping elements");

			Console.WriteLine(Sun.Pop());//20
			Console.WriteLine(Sun.Pop());//18
			Console.WriteLine(Sun.Pop());//16
			Console.WriteLine(Sun.Pop());//14
			Console.WriteLine(Sun.Pop());//12
			Console.WriteLine(Sun.Pop());//10
			Console.WriteLine("6 elements are removed");
			Console.WriteLine(Sun.Count());
			Console.ReadLine();

			Sun.Push(10);//Adding 10

			foreach (int V in Sun)
			{
				Console.WriteLine("Entered elements in a Stack using push methods are: " + V);
				Console.ReadLine();
			}

			Console.WriteLine("5 elements are removed");
			Console.WriteLine(Sun.Pop());//deleting 10
			Console.WriteLine(Sun.Pop());//deleting 8
			Console.WriteLine(Sun.Pop());//deleting6
			Console.WriteLine(Sun.Pop());//deleting  4
			Console.WriteLine(Sun.Pop());//deleting 2

			Console.WriteLine(Sun.Count());// 0
			Console.ReadLine();

			Console.WriteLine("5 elements are added");
			Sun.Push(2);//adding 2
			Sun.Push(4);//adding 4
			Sun.Push(6);//adding 6
			Sun.Push(8);//adding 8
			Sun.Push(10);//adding 10

			foreach (int V in Sun)
			{
				Console.WriteLine("Entered elements in a Stack using push methods are: " + V);
				Console.ReadLine();
			}
			Console.WriteLine(Sun.Count());//6
			Console.WriteLine("\n");

			Console.WriteLine("4 elements are removed");
			Console.WriteLine(Sun.Pop());//deleting 10
			Console.WriteLine(Sun.Pop());//deleting 8
			Console.WriteLine(Sun.Pop());//deleting 6
			Console.WriteLine(Sun.Pop());//deleting 4
			Console.WriteLine(Sun.Count());//2
			Console.ReadLine();


			Console.WriteLine("4 elements are added");
			Sun.Push(12);//adding 12
			Sun.Push(14);//adding 14
			Sun.Push(16);//adding 16
			Sun.Push(18);// adding 18////18,16,14,12
			Console.WriteLine(Sun.Count());//6

			foreach (int V in Sun)
			{
				Console.WriteLine("Entered elements in a Stack using push methods are: " + V);
				//Console.WriteLine("the total no of elements are :" + V);
				Console.ReadLine();
			}
			Console.WriteLine(Sun.Count());

			Console.WriteLine("3 elements are removed");
			Console.WriteLine(Sun.Pop()); //deleting 18
			Console.WriteLine(Sun.Pop());//deleting 16
			Console.WriteLine(Sun.Pop());//deleting 14
			Console.WriteLine(Sun.Count());//3
			Console.ReadLine();

			Console.WriteLine("2 elements are added");
			Sun.Push(4);//adding 4
			Sun.Push(6);//adding 6

			foreach (int V in Sun)

			{
				Console.WriteLine("Entered elements in a Stack using push methods are: " + V);
				Console.ReadLine();
			}
			Console.WriteLine(Sun.Count());//4

			Console.WriteLine("2 elements are removed");
			Console.WriteLine(Sun.Pop());//deleting 8
			Console.WriteLine(Sun.Pop());//deleting 6
			Console.WriteLine(Sun.Count());//2
			Console.ReadLine();

			foreach (int V in Sun)

			{
				Console.WriteLine("Entered elements in a Stack using push methods are: " + V);

				Console.ReadLine();
			}
			Console.WriteLine(Sun.Count());


		}
	}
}
