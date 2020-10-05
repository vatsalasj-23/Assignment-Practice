using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDictionary
{
	class CSrpDict
	{
		static void Main(string[] args)
		{
			Console.WriteLine("\n");

			Dictionary<int, string> CDictionary = new Dictionary<int, string>();//divtionary object created with another name
			CDictionary.Add(1, "one");
			CDictionary.Add(2, "two");
			CDictionary.Add(3, "three");
			CDictionary.Add(4, "four");

			foreach (KeyValuePair<int, string> V in CDictionary)
			{
				Console.WriteLine("the elemnts are: " + V.Key + "\t" + V.Value);
				Console.ReadLine();
			}


			CDictionary[5] = "five";
			CDictionary[6] = "six";
			CDictionary[7] = "seven";
			CDictionary[8] = "eight";
			CDictionary[9] = "nine";
			CDictionary[10] = "ten";

			Console.WriteLine("the updated elemnts in a collevction lists are : " + CDictionary.Count());
			Console.WriteLine("\n");
			foreach (KeyValuePair<int, string> V in CDictionary)
			{
				Console.WriteLine("The UPDATED AND TOTAL Elements are: " + V.Key + "\t" + V.Value);
				Console.ReadLine();
			}

			Console.ReadLine();

		}
	}
}
