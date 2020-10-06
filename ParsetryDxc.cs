using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace RegexExp11
{
	class ParsetryDxc
	{
		static void Main()
		{
			string input = "The no 1 Company is DXC Technology";
			Match match = Regex.Match(input, @"\d+");
			if (match.Success)
			{
				int.TryParse(match.Value, out int number);
				// Show that we have the numbers.
				Console.WriteLine("NUMBERS: {0}, {1}", number, number + 1);//1,2
				Console.WriteLine("NUMBERS: {0}", number);
				Console.ReadLine();

			}
		}
	}
}
