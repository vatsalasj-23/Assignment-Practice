using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANonymousDel
{
	public delegate int AddnumsDelegate(int a, int b, int c);

	class Program
	{
		//public static int Addnums(int a, int b, int c)
		//{

		//	Console.WriteLine(a+b+c);

		//}
		static void Main(string[] args)
		{
			//AddnumsDelegate add = new AddnumsDelegate(Addnums);
			
			AddnumsDelegate add = delegate (int a, int b, int c)
			{
				Console.WriteLine(a + b + c);
			};
			int v=add.Invoke(100, 50, 150);
			Console.WriteLine(v);
			Console.ReadLine();



		}
	}
}
