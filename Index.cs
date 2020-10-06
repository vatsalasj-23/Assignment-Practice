using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace RegexExp12
{
	class Index
	{
		static void Main()
		{
			Match m = Regex.Match("123 Axxxxy", @"A.*y");
			if (m.Success)
			{
				Console.WriteLine("Value  = " + m.Value);
				Console.WriteLine("Length = " + m.Length);
				Console.WriteLine("Index  = " + m.Index);
				Console.ReadLine();

			}
		}
	}
}
