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
    public partial class Teachers : Form
    {
        AbbDbContext db = new AbbDbContext();
        teacher teach = new teacher();
        public Teachers()
        {
            InitializeComponent();

           
            foreach (teacher tch in db.Teachers)
            {
                comteacherscourses.Items.Add($"{tch.teacherFirstName} {tch.teacherLastName}".ToString());
            }

            foreach (teacher tch in db.Teachers)
            {
                comteachersstudents.Items.Add($"{tch.teacherFirstName} {tch.teacherLastName}".ToString());
            }


            foreach (teacher tch in db.Teachers)
            {
                comdeleteteacher.Items.Add($"{tch.teacherFirstName} {tch.teacherLastName}".ToString());
            }

            comeditteacher.Items.Add("First Name");
            comeditteacher.Items.Add("Last Name");
            comeditteacher.Items.Add("Age");
            comeditteacher.Items.Add("Gender");

            foreach (teacher tch in db.Teachers)
            {
                comediteteacher2.Items.Add($"{tch.teacherFirstName} {tch.teacherLastName}".ToString());
            }


        }

        private void CBallteacher_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CBallteacher.Checked)
            {
                dgvteacher.DataSource = db.Teachers.ToList();
            }

            if (CBteacherscourses.Checked)
            {
                int tea = db.Teachers.Where(x => (x.teacherFirstName + " " + x.teacherLastName) == comteacherscourses.SelectedItem.ToString()).Select(y => y.teacherID).FirstOrDefault();

                var relat = db.Relations.Where(x => (x.teacherIDFK == tea)).Select(y => y.subjectIDFK).ToList();
                List<int> teacherRcourse = new List<int>();
                foreach (int rel in relat)
                {
                    if (!teacherRcourse.Contains(rel)) teacherRcourse.Add(rel);
                }
                List<subject> subjects = new List<subject>();
                var sub = db.Subjects.ToList();
                for (int i = 0; i < teacherRcourse.Count; i++)
                {
                    foreach (subject s in sub)
                    {
                        if (s.subjectID == teacherRcourse[i]) subjects.Add(s);
                    }
                }
                
                dgvteacher.DataSource = subjects.Select(x => new { x.GraphicDesign, x.WebbDevelopment, x.Programming, x.DataBase }).ToList();
            }

            if (CBteacher.Checked)
            {
                int tea = db.Teachers.Where(x => (x.teacherFirstName + " " + x.teacherLastName) == comteachersstudents.SelectedItem.ToString()).Select(y => y.teacherID).FirstOrDefault();

                var relat = db.Relations.Where(x => (x.teacherIDFK == tea)).Select(y => y.studentIDFK).ToList();
                List<int> teacherRstudent = new List<int>();
                foreach (int rel in relat)
                {
                    if (!teacherRstudent.Contains(rel)) teacherRstudent.Add(rel);
                }

                List<student> students = new List<student>();
                var stud = db.Students.ToList();
                for (int i = 0; i < teacherRstudent.Count; i++)
                {
                    foreach (student st in stud)
                    {
                        if (st.studentID == teacherRstudent[i]) students.Add(st);
                    }
                }

                dgvteacher.DataSource = students.Select(x => new { x.studentID, x.studentFirstName, x.studentLastName }).ToList();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            newTeacher newT = new newTeacher();
            newT.Show();
            
        }


        private void comdeletteacher_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comeditteacher_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            mainBage mainB = new mainBage();
            mainB.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            teacher teach = db.Teachers.FirstOrDefault(x => (x.teacherFirstName + " " + x.teacherLastName) == comdeleteteacher.SelectedItem.ToString());
            if (teach != null) db.Teachers.Remove(teach);
            db.SaveChanges();
            MessageBox.Show($"The Teacher {teach.teacherFirstName} {teach.teacherLastName} is deleted.");          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            teacher teach = db.Teachers.FirstOrDefault(x => (x.teacherFirstName+ " "+ x.teacherLastName) == comediteteacher2.SelectedItem.ToString());
            if (teach != null)
            {
                gender g = gender.unknown;
                int n = 0;
                switch (comeditteacher.SelectedItem.ToString())
                {
                    case ("First Name"):
                        teach.teacherFirstName = txteditteacher.Text;
                        MessageBox.Show("You Succeeded To Update Teacher's First Name");
                        break;

                    case ("Last Name"):
                        teach.teacherLastName = txteditteacher.Text;
                        MessageBox.Show("You Succeeded To Update Teacher's Last Name");
                        break;

                    case ("Age"):
                        if (int.TryParse(txteditteacher.Text, out n))
                        {
                            if (n > 17 && n < 100)
                            {
                                teach.teacherAge = n;
                                MessageBox.Show("You Succeeded To Update Teacher's Age");
                            }
                            else MessageBox.Show("invalid value");
                        }
                        else MessageBox.Show("invalid value");
                        break;

                    case ("Gender"):
                        if (gender.TryParse(txteditteacher.Text, out g))
                        {

                            teach.Gender = g;
                            MessageBox.Show("You Succeeded To Update Teacher's gender");
                        }
                        else MessageBox.Show("invalid value");
                        break;
                }
                db.Teachers.Update(teach);
                    db.SaveChanges();
            }
            else MessageBox.Show("Not Exist");

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
            mainBage newB = new mainBage();
            newB.Show();
        }
    }
}
