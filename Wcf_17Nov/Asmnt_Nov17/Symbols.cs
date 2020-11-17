using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AssignmentCalcs
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICalcAsmnt" in both code and config file together.
	[ServiceContract]
	public interface Symbols
	{

		[OperationContract]
		int Greater(int num1, int num2);

		[OperationContract]
		int Lesser(int num1, int num2);

		[OperationContract]
		int EqualTo(int num1, int num2);

	}
	[DataContract]
	public class Composite
	{
		bool val = true;
		String strval = "DXC Technology";

		[DataMember]
		public bool value
		{
			get { return value; }
			set { val = value; }
		}

		[DataMember]
		public string stringValue
		{
			get { return strval;}
			set { strval = value; }
		}
	}
}
