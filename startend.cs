using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexExp4
{
	class startend
	{
		static void Main()
		{
			string test = "45aabbxxyy55";

			// Match the start of a string.
			if (Regex.IsMatch(test, "^45aabbx"))
			{
				Console.WriteLine("START MATCHES");
			}

			// Match the end of a string.
			if (Regex.IsMatch(test, "yy55$"))
			{
				Console.WriteLine("END MATCHES");
				Console.ReadLine();

			}
		}
	}
}
