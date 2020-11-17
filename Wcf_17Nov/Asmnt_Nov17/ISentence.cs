using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AssignmentCalcs
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISentence" in both code and config file together.
	[ServiceContract]
	public interface ISentence
	{
		[OperationContract]
		string Sentencess(string s1,string s2,string s3);
	}
}

[DataContract]
public class Sentence
{
	[DataMember]
	public string s1;

	[DataMember]
	public string s2;

	[DataMember]
	public string s3;

	//bool val = true;
	//String strval = "DXC Technology";

	//[DataMember]
	//public bool value
	//{
	//	get { return value; }
	//	set { val = value; }
	//}

	//[DataMember]
	//public string stringValue
	//{
	//	get { return strval; }
	//	set { strval = value; }
	//}

}
