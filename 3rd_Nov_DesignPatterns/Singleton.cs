using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	class DesignPatterns
	{
		public sealed class Calculate
		{
			private Calculate()
			{

			}
		
		private static Calculate instance = null;//instance method for the class Calculate:Singleton Design Patterns

		public static Calculate Instance
		{
			get
			{
				if (instance == null)
					{
						instance = new Calculate();
					}
				return instance;

			}
		}
		public double ValueOne { get; set; }
		public double ValueTwo { get; set; }
		public double Addition()
		{
			return ValueOne + ValueTwo;

		}
			public double Subtraction()
			{
				return ValueTwo - ValueOne;
			}
			public double Multiplication()
			{
				return ValueOne * ValueTwo;
			}
			public double Division()
			{
				return ValueOne / ValueTwo;
			}
	}
		public static void Main(string[] args)
		{
			Calculate.Instance.ValueOne = 10.0;
			Calculate.Instance.ValueTwo = 15.6;
			
			Console.WriteLine("Addition: " + Calculate.Instance.Addition());
			Console.WriteLine("Subtraction: " + Calculate.Instance.Subtraction());
			Console.WriteLine("Multiplication: " + Calculate.Instance.Multiplication());
			Console.WriteLine("Division: " + Calculate.Instance.Division());
			Console.ReadLine();
		}
	}
}
