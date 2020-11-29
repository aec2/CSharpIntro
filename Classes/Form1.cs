using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Student ogrenci1 = new Student();
            ogrenci1.FirstName = "Enes";
            ogrenci1.Age = 25;
            ogrenci1.Mail = "aenesc1@gmail.com";
            
            Student ogrenci2 = new Student();
            ogrenci2.FirstName = "Salim";
            ogrenci2.Age = 24;
            ogrenci2.Mail = "salim@gmail.com";            
            
            Student ogrenci3 = new Student();
            ogrenci3.FirstName = "Furkan";
            ogrenci3.Age = 26;
            ogrenci3.Mail = "furkan@gmail.com";

            List<Student> students = new List<Student>() { ogrenci1, ogrenci2, ogrenci3 };

            foreach (var student in students)
            {
                //MessageBox.Show(student.FirstName + " " + student.Age + " " + student.Mail);
                lbxStudents.Items.Add(student.FirstName);
            }

            dgrwStudents.DataSource = students;
        }
    }
}
