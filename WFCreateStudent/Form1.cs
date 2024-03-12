namespace WFCreateStudent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Student student =new Student();
        private void btnCreate_Click(object sender, EventArgs e)
        {
            student.Name=txtName.Text ;
            student.Plastname=txtPname.Text;
            student.Mlastname=txtMname.Text;
            student.Datetime = DateTime.Parse(dtpDatetime.Text);
            student.Matricula= txtId.Text;
            student.Carrera=txtCareer.Text;
            student.Promedio= double.Parse(nudAverage.Text);
            LblStudent.Text += student.ToString() + "\n";
        }
    }
}
