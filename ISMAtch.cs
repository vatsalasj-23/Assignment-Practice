using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace RegexExp15
{
	class ISMAtch
	{
		static bool IsValid(string value)
		{
			return Regex.IsMatch(value, @"^[a-zA-Z0-9]*$");
		}

		static void Main()
		{
			// Test the strings with the IsValid method.
			Console.WriteLine(IsValid("dxctechnolofy123456"));
			Console.WriteLine(IsValid("DxcTechnology21345"));
			Console.WriteLine(IsValid(":-)"));
			Console.ReadLine();

			
			// Console.WriteLine(IsValid(null)); // Throws an exception
		}
	}
}
