using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFCreateStudent
{
    internal class Student: Person  
    {
		private string matricula;

		public string Matricula
		{
			get { return matricula; }
			set { matricula = value; }
		}
		private string carrera;

		public string Carrera
		{
			get { return carrera; }
			set { carrera = value; }
		}
		private double promedio;

		public double Promedio
		{
			get { return promedio; }
			set { promedio = value; }
		}
		public Student() : base()
		{
			matricula=string.Empty;
			carrera=string.Empty;
			promedio=0;
		}
        public Student(string fullname, DateTime? datetime, string matricula, string carrera, double promedio) : base(fullname, datetime)
        {
            this.matricula = matricula;
            this.carrera = carrera;
			this.promedio = promedio;
        }
        public override string ToString()
        {
            return base.ToString() + " / " + matricula.ToUpper() + " / " + carrera.ToUpper() + " / " + promedio;
        }
    }
}
