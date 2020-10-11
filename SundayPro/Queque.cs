using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuequeAssign
{
	class Queque
	{
		static void Main(string[] args)
		{
			Queue<int> Sunday = new Queue<int>();
			Sunday.Enqueue(2);
			Sunday.Enqueue(4);
			Sunday.Enqueue(6);
			Sunday.Enqueue(8);
			Sunday.Enqueue(10);
			Sunday.Enqueue(12);
			Sunday.Enqueue(14);
			Sunday.Enqueue(16);
			Sunday.Enqueue(18);
			Sunday.Enqueue(20);
			foreach (int V in Sunday)
			{
				Console.WriteLine("Adding elements by Enqueque method: " + V);
				Console.ReadLine();

			}
			Console.WriteLine("\n");
			Console.WriteLine("Removing elements by Dequeque method");
			Sunday.Dequeue();//2
			Sunday.Dequeue();//4
			Sunday.Dequeue();//6
			Sunday.Dequeue();//8
			Sunday.Dequeue();//10
			Sunday.Dequeue();//12

			foreach (int V in Sunday)
			{
				Console.WriteLine("Updated elements by Enqueque method: " + V);
				Console.ReadLine();

			}

			Sunday.Enqueue(2);
			Sunday.Enqueue(4);
			Sunday.Enqueue(6);
			foreach (int V in Sunday)
			{
				Console.WriteLine("Adding elements by Enqueque method: " + V);
				Console.ReadLine();

			}
			Console.WriteLine("\n");
			Console.WriteLine("Removing elements by Dequeque method");
			Sunday.Dequeue();//
			Sunday.Dequeue();//
			Sunday.Dequeue();//
			Sunday.Dequeue();
			Sunday.Dequeue();
			foreach (int V in Sunday)
			{
				Console.WriteLine("Updated elements by Enqueque method: " + V);
				Console.ReadLine();

			}

			Sunday.Enqueue(8);
			Sunday.Enqueue(10);
			Sunday.Enqueue(12);
			foreach (int V in Sunday)
			{
				Console.WriteLine("Adding elements by Enqueque method: " + V);
				Console.ReadLine();

			}
			Console.WriteLine("\n");
			Console.WriteLine("Removing elements by Dequeque method");
			Sunday.Dequeue();//
			Sunday.Dequeue();//
			Sunday.Dequeue();//
			foreach (int V in Sunday)
			{
				Console.WriteLine("Updated elements by Enqueque method: " + V);
				Console.ReadLine();

			}
			Sunday.Enqueue(14);
			Sunday.Enqueue(16);
			foreach (int V in Sunday)
			{
				Console.WriteLine("Adding elements by Enqueque method: " + V);
				Console.ReadLine();

			}
			Console.WriteLine("\n");
			Console.WriteLine("Removing elements by Dequeque method");
			Sunday.Dequeue();//
			Sunday.Dequeue();//
			Sunday.Dequeue();//
			foreach (int V in Sunday)
			{
				Console.WriteLine("Updated elements by Enqueque method: " + V);
				Console.ReadLine();

			}
			Sunday.Enqueue(18);
			Sunday.Enqueue(20);
			Sunday.Enqueue(2);
			foreach (int V in Sunday)
			{
				Console.WriteLine("Adding elements by Enqueque method: " + V);
				Console.ReadLine();

			}
			Console.WriteLine("\n");
			Console.WriteLine("Removing elements by Dequeque method");
			Sunday.Dequeue();//
			Sunday.Dequeue();//
			Sunday.Dequeue();//
			foreach (int V in Sunday)
			{
				Console.WriteLine("Updated elements by Enqueque method: " + V);
				Console.ReadLine();

			}
		}
	}
}
