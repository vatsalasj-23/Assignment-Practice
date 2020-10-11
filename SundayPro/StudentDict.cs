using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDict2
{
	class DictAssign
	{
		static void Main(string[] args)
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();//Dictionary object created
			dictionary.Add("School", "St.John's Convent");
			dictionary.Add("College", "Sir MV PUC");
			dictionary.Add("Engg", "UBDTCE");

			Console.WriteLine("\n");

			foreach (KeyValuePair<string, string> V in dictionary)
			{
				Console.WriteLine("The Elements are: " + V.Key + "\t" + V.Value);
				//Console.WriteLine("the count of a current elemnts are: " + CDictionary.Count());
				Console.ReadLine();
			}
			Console.WriteLine("the count of a current elemnts are: " + dictionary.Count());

			dictionary["Student"] = "Vatsala SJ";
			dictionary["Student ID"] = "4UB15EE052";
			dictionary["Student Department"] = "EEE";
			dictionary["CR"] = "Vatsala SJ";
			dictionary["Company"] = "DXC Technology";
			dictionary["age"] = "24";


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


