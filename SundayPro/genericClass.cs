using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Context;

namespace CSharpGeneric
{
	class sample<T>
	{
		T data;
		//method for sample
		public sample(T check)     //check assigned to type parameter
		{
			this.data = check;

		}
		public void read()
		{
			Console.WriteLine("The passed to the initializer: "+this.data);
		}

	}
		
	//driver method or main method
	class genericClass
	{
		static void Main(string[] args)
		{
			sample<int> s = new sample<int>(100);
			sample<string> s1 = new sample<string>("vatsala");
			sample<bool> s2 = new sample<bool>(true);

			Console.WriteLine();
			s.read();
			s1.read();
			s2.read();

			Console.ReadLine();



		}
	}
}
