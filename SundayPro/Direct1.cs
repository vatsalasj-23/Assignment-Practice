using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDirectory
{
	class AsntDirec
	{
		static void Main(string[] args)
		{
			Console.WriteLine("C Sharp Dictionary");
			Dictionary<string, string> Sunday = new Dictionary<string, string>();
			Sunday.Add("1", "bangalore");
			Sunday.Add("2", "mumbai");
			Sunday.Add("3", "pune");
			Sunday.Add("4", "hyderabad");
			Sunday.Add("5", "chennai");

			Sunday["6"] = "Delhi";
			Sunday["7"] = "kolkatta";
			Sunday["8"] = "Ahmedabad";
			Sunday["9"] = "Noida";

			Console.WriteLine("The count of a elements are: " + Sunday.Count());
			Console.WriteLine("\n");
			foreach (KeyValuePair<string, string> V in Sunday)
			{
				Console.WriteLine("The Updated Elements are: " + V.Key + "\t" + V.Value);
				Console.ReadLine();
			}
			Console.WriteLine("After Removing the states by six times, we will be getting these below states");
			Sunday.Remove("1");
			Sunday.Remove("2");
			Sunday.Remove("3");
			Sunday.Remove("4");
			Sunday.Remove("5");
			Sunday.Remove("6");
			//Assignment.Remove("1");
			foreach (KeyValuePair<string, string> V in Sunday)
			{
				Console.WriteLine("The Updated Elements are: " + V.Key + "\t" + V.Value);
				Console.ReadLine();
			}

			Console.WriteLine("The count of a elements are: " + Sunday.Count());//3
			Console.ReadLine();

			Console.WriteLine("To remove 5 elements we need other two element to add so pushing 3 elements");

			Sunday.Add("1", "bangalore");
			Sunday.Add("2", "mumbai");
			Sunday.Add("3", "pune");
			foreach (KeyValuePair<string, string> V in Sunday)
			{
				Console.WriteLine("The Updated Elements are: " + V.Key + "\t" + V.Value);
				Console.ReadLine();
			}

			Console.WriteLine("The count of a elements are: " + Sunday.Count());//3
			Console.ReadLine();

			Console.WriteLine("Removing the states by 5 times");
			Sunday.Remove("7");
			Sunday.Remove("8");
			Sunday.Remove("9");
			Sunday.Remove("1");
			Sunday.Remove("2");


			foreach (KeyValuePair<string, string> V in Sunday)
			{
				Console.WriteLine("The Updated Elements are: " + V.Key + "\t" + V.Value);
				Console.ReadLine();
			}

			Console.WriteLine("The count of a elements are: " + Sunday.Count());//1
			Console.ReadLine();

			Console.WriteLine("adding elements");
			Sunday.Add("1", "bangalore");
			Sunday.Add("2", "mumbai");
			Sunday.Add("4", "hyderabad");
			Sunday.Add("5", "chennai");
			foreach (KeyValuePair<string, string> V in Sunday)
			{
				Console.WriteLine("The Updated Elements are: " + V.Key + "\t" + V.Value);
				Console.ReadLine();
			}

			Console.WriteLine("The count of a elements are: " + Sunday.Count());//3
			Console.ReadLine();

			Console.WriteLine("\n");
			Console.WriteLine("Removing the states by 4 times");
			Sunday.Remove("1");
			Sunday.Remove("2");
			Sunday.Remove("3");
			Sunday.Remove("4");
			foreach (KeyValuePair<string, string> V in Sunday)
			{
				Console.WriteLine("The Updated Elements are: " + V.Key + "\t" + V.Value);
				Console.ReadLine();
			}

			Console.WriteLine("The count of a elements are: " + Sunday.Count());//1
			Console.ReadLine();

			Console.WriteLine("\n");
			Console.WriteLine("To remove 3 elements we need other two element to add so pushing 6 elements");
			Sunday.Add("1", "bangalore");
			Sunday.Add("2", "mumbai");
			Sunday.Add("3", "pune");
			Sunday.Add("4", "hyderabad");
			Sunday["6"] = "Delhi";
			Sunday["7"] = "kolkatta";
			foreach (KeyValuePair<string, string> V in Sunday)
			{
				Console.WriteLine("The Updated Elements are: " + V.Key + "\t" + V.Value);
				Console.ReadLine();
			}

			Console.WriteLine("The count of a elements are: " + Sunday.Count());//3
			Console.ReadLine();

			Console.WriteLine("\n");
			Console.WriteLine("Removing the states by 4 times");
			Sunday.Remove("1");
			Sunday.Remove("2");
			Sunday.Remove("3");

			foreach (KeyValuePair<string, string> V in Sunday)
			{
				Console.WriteLine("The Updated Elements are: " + V.Key + "\t" + V.Value);
				Console.ReadLine();
			}

			Console.WriteLine("The count of a elements are: " + Sunday.Count());//3
			Console.ReadLine();

			Console.WriteLine("\n");
			Console.WriteLine("Removing the states by 2 times");
			Sunday.Remove("4");
			Sunday.Remove("6" +
				"");

			foreach (KeyValuePair<string, string> V in Sunday)
			{
				Console.WriteLine("The Updated Elements are: " + V.Key + "\t" + V.Value);
				Console.ReadLine();
			}

			Console.WriteLine("The count of a elements are: " + Sunday.Count());//3
			Console.ReadLine();


		}
	}
}

