using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFCreateStudent
{
    public class NamePerson
    {
		protected string name;

		public  string Name
		{
			get { return name; }
			set { name = value; }
		}
		protected string plastname;

		public string Plastname
		{
			get { return plastname; }
			set { plastname = value; }
		}
		protected string mlastname;

		public string Mlastname
		{
			get { return mlastname; }
			set { mlastname = value; }
		}
		
		public NamePerson()
		{
            name = string.Empty;
            mlastname = string.Empty;
            plastname = string.Empty;
        }
		public NamePerson(string name, string plasname, string mlastname)
		{
			this.name = name;
			this.plastname=plasname;
			this.mlastname=mlastname;
		}
		public override string ToString()
		{
			return name.ToUpper() + " " + plastname.ToUpper() + " " + mlastname.ToUpper();
        }

	}
}
