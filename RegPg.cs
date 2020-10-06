using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace RegexExp
{
	class RegPg
	{
		static void Main(string[] args)
		{
			Regex value = new Regex(@"\d+");
			Match V = value.Match("dfg34256lk");
			if (V.Success)
			{
				Console.WriteLine("matvh value: "+V);
				Console.ReadLine();

			}
			
			
		}
	}
}
