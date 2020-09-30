using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evenno
{
	class Even
	{
		static void Main(string[] args)
		{
			int n = 20;
			Console.WriteLine("printing even nos : ");
			for (int i = 0; i < n; i++)
			{
				if (i % 2 == 0)
				{
					Console.WriteLine("{0}", i);
				}				
				Console.ReadLine();
			}

		}
	}
}
