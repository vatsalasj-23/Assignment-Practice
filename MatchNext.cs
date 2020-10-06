using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace RegexExp5
{
	class MatchNext
	{
		static void Main()
		{
			string value = "4 AND 5";

			// Step 1: get first match.
			Match match = Regex.Match(value, @"\d+");
			if (match.Success)
			{
				Console.WriteLine(match.Value);
			}

			// Step 2: get second match.
			match = match.NextMatch();
			if (match.Success)
			{
				Console.WriteLine(match.Value);
				Console.ReadLine();

			}
		}
	}
}
