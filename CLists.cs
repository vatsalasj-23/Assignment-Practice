using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShrpLists
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("C# Lists");//create an object for lists

			//syntax
			//<datatype variable name=new list<datatype>();

			var user = new List<string>();
			user.Add("c#");
			user.Add("Programming");
			user.Add("Vatsala sj");
			user.Add("Darshan SJ");
			Console.WriteLine("THE lists has been created");

			foreach (var list in user)
			{
				Console.WriteLine("the elements of a lists are: " + list);
				Console.ReadLine();

				
			}
			Console.WriteLine("the removed elements are: " + user.Remove("c#"));
			var vehicle = new List<string>() { "activa3G", "activa4G", "activa5G", "activa6G" };

			foreach (var docker in vehicle)
			{
				Console.WriteLine("another way of creating a list: " + docker);

			}
			//accessing the list by another way
			Console.WriteLine("the first index of a elements is: " + vehicle[0]);
			Console.WriteLine("the second index of a elements is: " + vehicle[1]);
			Console.WriteLine("the third index of a elements is: " + vehicle[2]);
			Console.WriteLine("the fourth index of a elements is: " + vehicle[3]);
//Console.WriteLine("the fifth index of a elements is: " + vehicle[4]);//SYSTEM OUT OF RANGE EXCEPTION WILL GIVE IN THIS 45 TH LINE  
	
			Console.ReadLine();

//INSERT() will take 2 values one is : position(index),and the second on is value of that particualr index
			vehicle.Insert(5, "HeroHonda");//index must be  within the bounds of a lists======an exception will come if we dont put any index in 51st line of vehicle()
			Console.WriteLine("the fifth index of a element is: " + vehicle[5]);
			Console.ReadLine();

		}
	}
}
