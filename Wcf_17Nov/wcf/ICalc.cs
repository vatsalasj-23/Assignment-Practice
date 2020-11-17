using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICalc" in both code and config file together.
	[ServiceContract]
	public interface ICalc
	{
		[OperationContract]
		int sum(int num1, int num2);//Addition
		//void DoWork();

		[OperationContract]
		int substract(int num1, int num2);//substarction

		[OperationContract]
		int multiply(int num1, int num2);//Multiplication

		[OperationContract]
		int divide(int num1, int num2);//Division
	}
}
//use a data contract to composite types to service operations.
[DataContract]
public class CompositeType
{
	bool bvalue = true;        //BOOLEAN VARIABLE ASSIGNED TRUE
	String stringValue = "Hello World";     //String variable returning "hello world"

	[DataMember]
	public bool value
	{
		get { return value; }
		set { bvalue = value; }
	}

	[DataMember]
	public string stringvalue
	{
		get { return stringValue; }
		set { stringValue = value; }
	}
}