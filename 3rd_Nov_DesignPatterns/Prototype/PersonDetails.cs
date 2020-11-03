using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
	public class PersonDetails
	{
		public int Age;
		public DateTime BirthDate;
		public string Name;
		public IdInfo IdInfo;

		public PersonDetails ShallowCopy()
		{
			return (PersonDetails)this.MemberwiseClone();
		}

		public PersonDetails DeepCopy()
		{
			PersonDetails clone = (PersonDetails)this.MemberwiseClone();
			clone.IdInfo = new IdInfo(IdInfo.IdNumber);
			clone.Name = String.Copy(Name);
			return clone;
		}
	}

	public class IdInfo
	{
		public int IdNumber;

		public IdInfo(int idNumber)
		{
			this.IdNumber = idNumber;
		}
	}

}

