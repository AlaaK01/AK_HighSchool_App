using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AK_HighSchool_App._AppDbContext;
using AK_HighSchool_App.Models;

namespace AK_HighSchool_App.screen
{
    public partial class newTeacher : Form
    {
        AbbDbContext db = new AbbDbContext();
        public newTeacher()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            teacher teach = new teacher();
            teach.teacherFirstName = txtfirstname.Text;
            teach.teacherLastName = txtlastname.Text;
           
            if (rbmale.Checked)
            {
               teach.Gender = gender.male;
            }
            else teach.Gender = gender.female;
            if (int.TryParse(txtage.Text, out a))
            {
                if (a > 17 && a < 100) teach.teacherAge = a;
            }
            db.Teachers.Add(teach);
            db.SaveChanges();
            MessageBox.Show("You Succeeded To Crate A New Teacher.");
            Teachers teacherS = new Teachers();
            teacherS.Show();
            this.Close();
        }

        private void txtlastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
