using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexExp8
{
	class Program
	{
		static void Main()
		{
			// Replace 2 or more digit pattern with a string.
			Regex regex = new Regex(@"\d+");
			string result = regex.Replace("cat 123 456", "animal");
			string right = regex.Replace("pigeon 123 456", "bird");
			Console.WriteLine("RESULT: {0}", result);
			Console.WriteLine("RESULT: {0}", right);
			Console.ReadLine();

		}
		
	}
}
