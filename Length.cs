using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace RegexExp13
{
	class Length
	{
		static void Main()
		{
			Match V = Regex.Match("123 Axxxxy", @"A.*y");
			if (V.Success)
			{
				Console.WriteLine("Value  = " + V.Value);
				Console.WriteLine("Length = " + V.Length);
				Console.WriteLine("Index  = " + V.Index);
				Console.ReadLine();

			}
		}
	}
}
