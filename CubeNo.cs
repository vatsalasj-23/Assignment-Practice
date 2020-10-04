using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeNum
{
	class CubeNo
	{
		static void Main(string[] args)
		{
			int i, Num;

			Console.Write("Input number of terms : ");
			Num = Convert.ToInt32(Console.ReadLine());
			for (i = 1; i <= Num; i++)
			{
				Console.Write("Number is : {0} and cube of the {1} is :{2} \n", i, i, (i * i * i));
				Console.ReadLine();
			}
		}
	}
}

