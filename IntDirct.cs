using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectryInt
{
	class IntDirct
	{
		static void Main(string[] args)
		{
			Console.WriteLine("C Sharp Dictionary");
			Dictionary<int, string> Assignment = new Dictionary<int, string>();
			Assignment.Add(1, "bangalore");
			Assignment.Add(2, "mumbai");
			Assignment.Add(3, "pune");
			Assignment.Add(4, "hyderabad");
			Assignment.Add(5, "chennai");

			Assignment[6] = "Delhi";
			Assignment[7] = "kolkatta";
			Assignment[8] = "Ahmedabad";
			Assignment[9] = "Noida";

			Console.WriteLine("The count of a elements are: " + Assignment.Count());
			Console.WriteLine("\n");
			foreach (KeyValuePair<int, string> V in Assignment)
			{
				Console.WriteLine("The Updated Elements are: " + V.Key + "\t" + V.Value);
				Console.ReadLine();
			}
			Console.WriteLine("After Removing the states by six times, we will be getting these below states");
			Assignment.Remove(1);
			Assignment.Remove(2);
			Assignment.Remove(3);
			Assignment.Remove(4);
			Assignment.Remove(5);
			Assignment.Remove(6);
			//Assignment.Remove("1");
			foreach (KeyValuePair<int, string> V in Assignment)
			{
				Console.WriteLine("The Updated Elements are: " + V.Key + "\t" + V.Value);
				Console.ReadLine();
			}

			Console.WriteLine("The count of a elements are: " + Assignment.Count());//3
			Console.ReadLine();

			Console.WriteLine("To remove 5 elements we need other two element to add so pushing 3 elements");

			Assignment.Add(1, "bangalore");
			Assignment.Add(2, "mumbai");
			Assignment.Add(3, "pune");
			foreach (KeyValuePair<int, string> V in Assignment)
			{
				Console.WriteLine("The Updated Elements are: " + V.Key + "\t" + V.Value);
				Console.ReadLine();
			}

			Console.WriteLine("The count of a elements are: " + Assignment.Count());//3
			Console.ReadLine();

			Console.WriteLine("Removing the states by 5 times");
			Assignment.Remove(7);
			Assignment.Remove(8);
			Assignment.Remove(9);
			Assignment.Remove(1);
			Assignment.Remove(2);


			foreach (KeyValuePair<int, string> V in Assignment)
			{
				Console.WriteLine("The Updated Elements are: " + V.Key + "\t" + V.Value);
				Console.ReadLine();
			}

			Console.WriteLine("The count of a elements are: " + Assignment.Count());//1
			Console.ReadLine();

			Console.WriteLine("adding elements");
			Assignment.Add(1, "bangalore");
			Assignment.Add(2, "mumbai");
			Assignment.Add(4, "hyderabad");
			Assignment.Add(5, "chennai");
			foreach (KeyValuePair<int, string> V in Assignment)
			{
				Console.WriteLine("The Updated Elements are: " + V.Key + "\t" + V.Value);
				Console.ReadLine();
			}

			Console.WriteLine("The count of a elements are: " + Assignment.Count());//3
			Console.ReadLine();

			Console.WriteLine("\n");
			Console.WriteLine("Removing the states by 4 times");
			Assignment.Remove(1);
			Assignment.Remove(2);
			Assignment.Remove(3);
			Assignment.Remove(4);
			foreach (KeyValuePair<int, string> V in Assignment)
			{
				Console.WriteLine("The Updated Elements are: " + V.Key + "\t" + V.Value);
				Console.ReadLine();
			}

			Console.WriteLine("The count of a elements are: " + Assignment.Count());//1
			Console.ReadLine();

			Console.WriteLine("\n");
			Console.WriteLine("To remove 3 elements we need other two element to add so pushing 6 elements");
			Assignment.Add(1, "bangalore");
			Assignment.Add(2, "mumbai");
			Assignment.Add(3, "pune");
			Assignment.Add(4, "hyderabad");
			Assignment[6] = "Delhi";
			Assignment[7] = "kolkatta";
			foreach (KeyValuePair<int, string> V in Assignment)
			{
				Console.WriteLine("The Updated Elements are: " + V.Key + "\t" + V.Value);
				Console.ReadLine();
			}

			Console.WriteLine("The count of a elements are: " + Assignment.Count());//3
			Console.ReadLine();

			Console.WriteLine("\n");
			Console.WriteLine("Removing the states by 4 times");
			Assignment.Remove(1);
			Assignment.Remove(2);
			Assignment.Remove(3);

			foreach (KeyValuePair<int, string> V in Assignment)
			{
				Console.WriteLine("The Updated Elements are: " + V.Key + "\t" + V.Value);
				Console.ReadLine();
			}

			Console.WriteLine("The count of a elements are: " + Assignment.Count());//3
			Console.ReadLine();

			Console.WriteLine("\n");
			Console.WriteLine("Removing the states by 2 times");
			Assignment.Remove(4);
			Assignment.Remove(6);

			foreach (KeyValuePair<int, string> V in Assignment)
			{
				Console.WriteLine("The Updated Elements are: " + V.Key + "\t" + V.Value);
				Console.ReadLine();
			}

			Console.WriteLine("The count of a elements are: " + Assignment.Count());//3
			Console.ReadLine();


		}
	}
}
	


