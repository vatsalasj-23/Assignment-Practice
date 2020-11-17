using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AssignmentCalcs
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Sentence" in code, svc and config file together.
	// NOTE: In order to launch WCF Test Client for testing this service, please select Sentence.svc or Sentence.svc.cs at the Solution Explorer and start debugging.
	public class Sentence : ISentence
	{
		public Sentence(string s1, string s2, string s3)
		{
			return (s1 + s2 + s3);
		}
	}
}
