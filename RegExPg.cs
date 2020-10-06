using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace RegExp1
{
	class RegExPg
	{
		static void Main(string[] args)
		{
			Regex regex = new Regex(@"\d+");
			Match mt = regex.Match("a3355a");
			if (mt.Success)
			{
				Console.WriteLine("Match value: " + mt.Value);//OP IS 3355
				Console.ReadLine();

			}
		}
	}
}
