using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AssignmentCalcs
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Reverse" in code, svc and config file together.
	// NOTE: In order to launch WCF Test Client for testing this service, please select Reverse.svc or Reverse.svc.cs at the Solution Explorer and start debugging.
	public class Reverse : IReverse
	{
		public int ReverseNos(int num, int rem, int rev = 0)
		{
			while (num != 0)
			{
				rem = num % 10;
				rev = rev * 10 + rem;
				num /= 10;
			}


			if (num != rev)
			{
				return rev;
			}

			else
			{
				return 0;
			}
			
		}
	}
}
