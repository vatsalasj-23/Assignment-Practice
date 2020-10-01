using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromNo
{
	class PalindromeNo
	{
		static void Main(string[] args)
		{
			int n, r, sum = 0, temp;
			Console.WriteLine("enter the number: ");
			n = int.Parse(Console.ReadLine());
			temp = n;
			while (n > 0)
			{
				r = n % 10;
				sum = (sum * 10) + r;
				n = n / 10;
			}
			if (temp == sum)
				Console.WriteLine("it is a Palindrome Number");
			else
				Console.WriteLine("it is not a palindrome Number");
			Console.ReadLine();
			
		}
	}
}
