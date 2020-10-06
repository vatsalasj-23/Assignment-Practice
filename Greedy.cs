using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexExp9
{
	class Greedy
	{
		static void Main()
		{
			string test = "/bird/cat/";
			// Version 1: use lazy (or non-greedy) metacharacter.
			var result1 = Regex.Match(test, "^/.*?/");
			if (result1.Success)
			{
				Console.WriteLine("NON-GREEDY: {0}", result1.Value);
				Console.ReadLine();

			}
			// Version 2: default Regex.
			var result2 = Regex.Match(test, "^/.*/");
			if (result2.Success)
			{
				Console.WriteLine("GREEDY:     {0}", result2.Value);
				Console.ReadKey();
			}
		}
	}
}
