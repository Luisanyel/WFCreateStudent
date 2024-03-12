using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFCreateStudent
{
    public class Person:NamePerson
    {
		protected string fullname;

		public string Fullname
		{
			get { return fullname; }
			set { fullname = value; }
		}
		protected DateTime? datetime;

		public DateTime? Datetime
		{
			get { return datetime; }
			set { datetime = value; }
		}
		public Person()
		{
			fullname = string.Empty;
			datetime = null;
		}
		public Person(string fullname, DateTime? datetime)
		{
			this.fullname = fullname;
			this.datetime = datetime;
		}
		public override string ToString() 
		{ 
			return base.ToString() +  " / " + datetime.Value.ToShortDateString();
		}

	}
}
