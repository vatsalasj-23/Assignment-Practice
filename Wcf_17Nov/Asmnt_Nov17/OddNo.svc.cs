using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AssignmentCalcs
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "OddNo" in code, svc and config file together.
	// NOTE: In order to launch WCF Test Client for testing this service, please select OddNo.svc or OddNo.svc.cs at the Solution Explorer and start debugging.
	public class OddNo : IOddNo
	{
		public int num(int num1)
		{

			
			if (num1 % 2 != 0)
			{
				return num1;
			}

			else
			{
				return 0;
			}
		}
	}
}
