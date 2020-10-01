using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintndSum
{
	class Program
	{
		static void Main(string[] args)
		{
			int sum, num = 0;			
			Console.Write("Enter a number: ");
			sum = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("enter the value of a sum: ");

			while (sum != 0)
			{
				num = num + sum % 10;
				sum = sum / 10;
			}

			

			Console.WriteLine("num = " + num);
			Console.ReadLine();

		}
	}
}
// C# program to compute 
// sum of digits in number. 
//using System; 

//class GFG
//{
//	/* Function to get sum of digits */
//	static int getSum(int n)
//	{
//		int sum = 0;

//		while (n != 0)
//		{
//			sum = sum + n % 10;
//			n = n / 10;
//		}

//		return sum;
//	}

//	// Driver program 
//	public static void Main()
//	{
//		int n = 687;
//		Console.Write(getSum(n));
//	}
//}

// This code is contributed by Sam007 
