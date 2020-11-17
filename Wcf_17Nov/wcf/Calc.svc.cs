using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Calc" in code, svc and config file together.
	// NOTE: In order to launch WCF Test Client for testing this service, please select Calc.svc or Calc.svc.cs at the Solution Explorer and start debugging.
	public class Calc : ICalc
	{
		public int sum(int num1, int num2)
		{
			return num1 + num2;
		}

		public int substract(int num1, int num2)
		{
			if (num1 > num2)
			{
				return num1 - num2;
		
			}
			else
			{
                return 0;
			}
			
		}

		public int multiply(int num1, int num2)
		{
			return num1 * num2;
		}

		public int divide(int num1, int num2)
		{
			if (num1 > num2)
			{
				return num1 / num2;
			}
			else
			{
				return 0;
			}
		}




		
	}
}
