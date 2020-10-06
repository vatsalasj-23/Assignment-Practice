using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace RegexExp1
{
	class RexPg3
	{
		static void Main()
		{
			
			string ip = "/content/ALTERnate-1.aspx";//input string

			// Part 2: call Regex.Match.
			Match value = Regex.Match(ip, @"content/([A-Za-z0-9\-]+)\.aspx$",
			RegexOptions.IgnoreCase);

			// Part 3: check the Match for Success.
			if (value.Success)
			{
				// Part 4: get the Group value and display it.
				string key = value.Groups[1].Value;
				Console.WriteLine("The value is : "+ value.Value);
				Console.ReadLine();

			}
		}
	}
}
