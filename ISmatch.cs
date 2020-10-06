using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace RegexExp14
{
	class ISmatch
	{
		static bool IsValid(string value)
		{
			return Regex.IsMatch(value, @"^[a-zA-Z0-9]*$");
		}

		static void Main()
		{
			// Test the strings with the IsValid method.
			Console.WriteLine(IsValid("dotnetperls0123"));
			Console.WriteLine(IsValid("DotNetPerls"));
			Console.WriteLine(IsValid(":-)"));
			// Console.WriteLine(IsValid(null)); // Throws an exception
			Console.ReadLine();

		}
	}
}
