using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexExp18
{
	class text
	{
		static void Main()
		{
			const string value = "VATSALA";
			// ... This ignores the case of the "TE" characters.
			if (Regex.IsMatch(value, "vat..", RegexOptions.IgnoreCase))
			{
				Console.WriteLine(true);
				Console.ReadLine();

			}
		}
	}
}
