using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace RegexExp3
{
	class start
	{
		static void Main()
		{
			string test = "xxyy";

			// Match the start of a string.
			if (Regex.IsMatch(test, "^xx"))
			{
				Console.WriteLine("START MATCHES");
			}

			// Match the end of a string.
			if (Regex.IsMatch(test, "yy$"))
			{
				Console.WriteLine("END MATCHES");
				Console.ReadLine();

			}
		}
	}
}
