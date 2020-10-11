using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JaggedArray
{
	class JaggedArray
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Jagged Array Programming in C# Programming");
			//Declare the elements of a array
			int[][] JaggedArray = new int[5][];
			JaggedArray[0] = new int[2] { 1, 2 };
			JaggedArray[1] = new int[5] { 1, 2, 3, 4, 5 };
			JaggedArray[2] = new int[4] { 1, 2, 5, 8 };
			JaggedArray[3] = new int[6] { 1, 2, 3, 5, 6, 8 };
			JaggedArray[4] = new int[3] { 1, 2, 5 };

			for (int i = 0; i < JaggedArray.Length; i++)
			{
				Console.WriteLine("Elements of an array({0}): ", i);
				for (int j = 0; j < JaggedArray[i].Length; j++)
				{
					Console.WriteLine(JaggedArray[i][j] + "\t");
					Console.ReadLine();

				}
			}
		}
	}
}
