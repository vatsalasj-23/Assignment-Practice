using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexExp10
{
	class DXC
	{
		static void Main()
		{
			string input = "DXC .Net Training";
			Match match = Regex.Match(input, @"\d+");
			if (match.Success)
			{
				int.TryParse(match.Value, out int number);
				// Show that we have the numbers.
				Console.WriteLine("NUMBERS: {0}, {1}", number, number + 1);
				Console.ReadLine();

			}
		}
	}
}
