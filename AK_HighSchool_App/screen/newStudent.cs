using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AK_HighSchool_App._AppDbContext;
using AK_HighSchool_App.Models;

namespace AK_HighSchool_App.screen
{
    public partial class newStudent : Form
    {
        AbbDbContext db = new AbbDbContext();
        student st = new student();
        public newStudent()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            st.studentFirstName = txtfirstname.Text;
            st.studentLastName = txtlastname.Text;
            st.userName = txtusername.Text;
            st.password = txtpassword.Text;
            st.email = txtemail.Text;
            if (int.TryParse(txtage.Text, out a))
            {
                if (a > 17 && a < 100) st.studentAge = a;
            }
            if (rbmale.Checked)
            {
                st.Gender = gender.male;
            }
            else st.Gender = gender.female;

            db.Students.Add(st);
            db.SaveChanges();
            A stud = new A();
            stud.Show();
            this.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
