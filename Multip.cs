using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplication
{
	class Multip
	{
		static void Main(string[] args)
		{
			int i, n;
			Console.WriteLine("Enter the no to be calculated as a table: ");
			n = Convert.ToInt32(Console.ReadLine());
			for(i=1; i<=10;i++)
			{
				Console.Write("{0}*{1}={2}\n",n,i, n * i);
			}
			Console.ReadLine();
		}
	}
}
