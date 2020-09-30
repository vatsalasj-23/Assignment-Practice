using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
	class Palindrome
	{
		static void Main(string[] args)
		{
			string name, rev;
			name = "MAAM";
			char[] c = name.ToArray();
			Array.Reverse(c);
			rev = new string(c);
			bool b = (rev == name);
			if (b == true)
			{
				Console.WriteLine(name  +"  Name  is a palindrome");
			}
			else
			{
				Console.WriteLine(name  +"  Name is not a palindrome");
			}

			Console.ReadLine();
		}
	}
}
