using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayJagged
{
	class Jagged1
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Jagged Arrays in C# Programming");
			Console.WriteLine("Declaring the elements of an array");

			int[][] Arr = new int[4][];
			Arr[0] = new int[5] { 5, 10, 15, 20, 25 };
			Arr[2] = new int[3] { 6,7,8 };      //intentionally changed the index value
			Arr[1] = new int[4] { 2, 4, 6, 8 };
			Arr[3] = new int[1] { 10 };

			//All the elements are declared
			for (int i = 0; i < Arr.Length; i++)
			{
				Console.WriteLine(Arr[i] + "\t");
				for(int j=0;j<Arr[i].Length;j++)
				{
					Console.WriteLine(Arr[i][j] + "\t");
				}
				
			}
			Console.ReadLine();



		}
	}
}
