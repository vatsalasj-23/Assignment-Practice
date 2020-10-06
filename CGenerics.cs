using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharpGenerics
{
	class student<T>
	{
		T data;             //type parameter,method for a class
		public student(T value)
		{
			this.data = value;

		}
		public void Write()
		{
			Console.WriteLine("The passed initializer is " + this.data);
			Console.ReadLine();

		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			student<string> Name = new student<string>("DARSHAN");
			student<int> age = new student<int>(15);
			student<bool> Present = new student<bool>(true);

			Name.Write();
			age.Write();
			Present.Write();


		}
	}
}
