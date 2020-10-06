using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexExp16
{
	class test
	{
		static void Main()
		{
			const string value = "TEST";
			// ... This ignores the case of the "TE" characters.
			if (Regex.IsMatch(value, "te..", RegexOptions.IgnoreCase))
			{
				Console.WriteLine(true);
				Console.ReadLine();

			}
		}
	}
}
