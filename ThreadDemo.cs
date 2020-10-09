using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CThreading1
{
	class ThreadDemo
	{
		//by deafult every application is singlr threaded modules
		static void Main(string[] args)
		{
			//this is also a thread called as a main method thread

			Thread t = Thread.CurrentThread;
			t.Name = "thread created manually by vatsala ";
			Console.WriteLine(Thread.CurrentThread.Name);
			Console.WriteLine("\n");
			Thread V = Thread.CurrentThread;
			//V.Equals(t) = = true;
			Console.WriteLine(Thread.CurrentThread.Name);
			Console.WriteLine("hello to the  world from threading concepts ");
			Console.ReadLine();

		}
	}
}
