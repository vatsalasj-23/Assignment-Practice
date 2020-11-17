using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AssignmentCalcs
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IReverse" in both code and config file together.
	[ServiceContract]
	public interface IReverse
	{
		[OperationContract]
		int Reverse(int num, int rem, int rev = 0);
	}
}

[DataContract]
public class ReverseNo
{
	[DataMember]
	public int num;

	[DataMember]
	public int rem;

	[DataMember]
	public int rev;
}
