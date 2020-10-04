using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestNo
{
	class LargestArray
	{
		static void Main(string[] args)
		{
			int[] array = new int[10];
			Console.WriteLine("enter the array elements to b sorted");
			for (int i = 0; i < 10; i++)
			{
				array[i] = Convert.ToInt32(Console.ReadLine());
			}
			
			int largest = array[9];
			for (int i = 0; i < 10; i++)
			{

				if (array[i] > largest)
				{
					largest = array[i];

				}
			}			
			Console.WriteLine("the largest no is {0}", largest);
			Console.ReadLine();
		}
	}
}

