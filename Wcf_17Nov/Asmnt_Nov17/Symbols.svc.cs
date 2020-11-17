using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AssignmentCalcs
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CalcAsmnt" in code, svc and config file together.
	// NOTE: In order to launch WCF Test Client for testing this service, please select CalcAsmnt.svc or CalcAsmnt.svc.cs at the Solution Explorer and start debugging.
	public class CalcAsmnt : Symbols
	{
		public int Greater(int num1, int num2)
		{
			if (num1 > num2)
			{
				return num1;
			}
			else
			{
				return 0;
			}
		}

		public int Lesser(int num1, int num2)
		{
			if (num1 < num2)
			{
				return num1;
			}
			else
			{
				return 0;
			}
		}

		public int EqualTo(int num1, int num2)
		{
			if (num1 == num2)
			{
				return num1+num2 ;
			}
			else
			{
				return 0;
			}
		}
	}
}
