using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAnonymous1
{
	public delegate string DayDelegate(string stri);
	public delegate string MonthDelegate(string strg);

	class DayMonthAnony
	{
		//public static string Week(string value)
		//{
		//	return "This " + value + " is going to be awesome";
		//}
		static void Main(string[] args)
		{
			//DayDelegate day = new DayDelegate(Week);     ///normal delgate object  reation
			DayDelegate day = delegate (string value)        ///anonymous creation
			  {
				  return "This " + value + " is going to be awesome";
			  };

			MonthDelegate month = delegate (string value1)
			  {
				  return "This " + value1 + " month rent has been paid";
			  };

			string stri = day.Invoke("Function");
			Console.WriteLine(stri);
			Console.ReadKey();
			Console.WriteLine("===============================================================================");
			string strg = month.Invoke("October");
			Console.WriteLine(strg);
			Console.ReadLine();


		}
	}
}
