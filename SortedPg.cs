using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedLists
{
	class Program
	{
		static void Main(string[] args)
		{
			SortedList<int, String> num = new SortedList<int, string>();
			num.Add(10, "ten");
			num.Add(4, "four");
			num.Add(3, "three");
			num.Add(2, "NULL");

			foreach (var V in num)
			{
				//Console.WriteLine("the sorted elements are : " + V.Key+"\t"+V.Value);
				Console.WriteLine("the sorted elements are : " + "key:{0},value:{1}", V.Key, V.Value);//Another way of writing the console.writeline
				Console.ReadLine();

			}
			
		}
	}
}
