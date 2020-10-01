using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNo
{
	class Program
	{
		static void Main(string[] args)
		{
			int num, i, v;
			int choice = 0;
			Console.WriteLine("Enter the number: ");
			num = int.Parse(Console.ReadLine());
			v = num / 2;
			for (i = 2; i <= v; i++)
			{
				if (num % i == 0)
				{
					Console.WriteLine("Number is not PrimeNo ");
					choice = 1;
					break;
				}
			}
			if (choice == 0)
			{
				Console.WriteLine("Number is Prime Number: ");

				Console.ReadLine();

			}
		}
	}
}

