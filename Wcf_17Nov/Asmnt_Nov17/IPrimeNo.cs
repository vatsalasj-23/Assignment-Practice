using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AssignmentCalcs
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPrimeNo" in both code and config file together.
	[ServiceContract]
	public interface IPrimeNo
	{
		[OperationContract]
		string Prime(int a, int b, int j);
	}
}

[DataContract]

public class Prime
{
	[DataMember]
	public int a;

	[DataMember]
	public int b;

	[DataMember]
	public int j;





}
