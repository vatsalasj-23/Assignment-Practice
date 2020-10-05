using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictAssignt
{
	class DictAssign
	{
		static void Main(string[] args)
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();//Dictionary object created
			dictionary.Add("category", "men collections");
			dictionary.Add("jewellary", "Women collections");
			dictionary.Add("flipkart", "house collections");

			Console.WriteLine("\n");

			foreach (KeyValuePair<string, string> V in dictionary)
			{
				Console.WriteLine("The Elements are: " + V.Key + "\t" + V.Value);
				//Console.WriteLine("the count of a current elemnts are: " + CDictionary.Count());
				Console.ReadLine();
			}
			Console.WriteLine("the count of a current elemnts are: " + dictionary.Count());

			dictionary["4"] = "four";
			dictionary["5"] = "five";
			dictionary["6"] = "six";
			dictionary["7"] = "seven";
			dictionary["8"] = "eight";
			dictionary["9"] = "nine";
			dictionary["10"] = "ten";

			Console.WriteLine("The Updated Elements in a collection lists are : " + dictionary.Count());
			Console.WriteLine("\n");
			foreach (KeyValuePair<string, string> V in dictionary)//keyvaluepair is the only things suits for a lists like values
			{
				Console.WriteLine("The UPDATED AND TOTAL Elements are: " + V.Key + "\t" + V.Value);//Accessed the dictionary items
				Console.ReadLine();
			}
			Console.WriteLine("the count of a current elemnts are: " + dictionary.Count());
			Console.ReadLine();


			

		}
	}
}

