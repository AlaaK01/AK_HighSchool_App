using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AK_HighSchool_App.Models;
using AK_HighSchool_App._AppDbContext;

namespace AK_HighSchool_App.screen
{
    public partial class Courses : Form
    {
        AbbDbContext db = new AbbDbContext();
        subject sub = new subject();
        public Courses()
        {
            InitializeComponent();

            foreach (subject sub in db.Subjects)
            {
                combystudentsattending.Items.Add($"{sub.subjectID}- {sub.GraphicDesign}{sub.WebbDevelopment}{sub.Programming}{sub.DataBase}");
            }

            foreach (student st in db.Students)
            {
                comastudentscourses.Items.Add($"{st.studentID}- {st.studentFirstName} {st.studentLastName}");
            }

            foreach (student st in db.Students)
            {
                comselectname.Items.Add($"{st.studentID}- {st.studentFirstName} {st.studentLastName}");
            }

            //foreach (subject sub in db.Subjects)
            //{
            //    comselectcourse.Items.Add($"{sub.subjectID}- {sub.GraphicDesign} {sub.WebbDevelopment} {sub.Programming} {sub.DataBase}");
            //}

            foreach (teacher teach in db.Teachers)
            {
                comchooseteacher.Items.Add($"{teach.teacherID}- {teach.teacherFirstName} {teach.teacherLastName}");
            }



            comselectcourse.Items.Add("1- adobeIllustrator");
            comselectcourse.Items.Add("2- adobePhotoshp");
            comselectcourse.Items.Add("3- corelDrow");
            comselectcourse.Items.Add("4- Html");
            comselectcourse.Items.Add("5- Css");
            comselectcourse.Items.Add("6- javaScript");
            comselectcourse.Items.Add("7- Csharp");
            comselectcourse.Items.Add("8- Java");
            comselectcourse.Items.Add("9- python");
            comselectcourse.Items.Add("10- sqlServer");
            comselectcourse.Items.Add("11- oracle");
            comselectcourse.Items.Add("12- mySql");


        }

        private void CBallcourses_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (CBallcourses.Checked)
            {
                dgvsubject.DataSource = db.Subjects.Select(x => new { x.GraphicDesign, x.WebbDevelopment, x.Programming, x.DataBase }).ToList();
            }

            if (CBbystudentsattending.Checked)
            {
                List<subject> courses = db.Subjects.ToList();
                List<int> courseR1 = new List<int>();
                string input1 = combystudentsattending.SelectedItem.ToString();               
                foreach (var sub in courses)
                {                                         
                    if ($"{sub.subjectID}- {sub.GraphicDesign}{sub.WebbDevelopment}{sub.Programming}{sub.DataBase}" == input1) courseR1.Add(sub.subjectID);

                }
                List<Relation> courseRelation = db.Relations.ToList();
                List<int> courseR2 = new List<int>();
                for (int i = 0; i < courseR1.Count; i++)
                {
                    foreach (Relation relat in courseRelation)
                    {
                        if (relat.subjectIDFK == courseR1[i]) courseR2.Add(relat.studentIDFK);                      
                    }
                }
                List<student> students = new List<student>();
                var stud = db.Students.ToList();
                for (int i = 0; i < courseR2.Count; i++)
                {
                    foreach (student st in stud)
                    {
                        if (st.studentID == courseR2[i]) students.Add(st);
                    }
                }
                dgvsubject.DataSource = students.Select(x => new { x.studentID, x.studentFirstName, x.studentLastName, x.email, x.Gender, x.studentAge }).ToList();
            }

            if (CBastudentscourses.Checked)
            {
                List<student> stud = db.Students.ToList();
                List<int> studentR1 = new List<int>();
                string input2 = comastudentscourses.SelectedItem.ToString();
                foreach (var st in stud)
                {                                            
                    if ($"{st.studentID}- {st.studentFirstName} {st.studentLastName}" == input2) studentR1.Add(st.studentID);

                }
                List<Relation> studentRcourse = db.Relations.ToList();
                List<int> studentR2 = new List<int>();
                for (int i = 0; i < studentR1.Count; i++)
                {
                    foreach (Relation relat in studentRcourse)
                    {
                        if (relat.studentIDFK == studentR1[i]) studentR2.Add(relat.subjectIDFK);
                    }
                }
                List<subject> subjects = new List<subject>();
                var sub = db.Subjects.ToList();
                for (int i = 0; i < studentR2.Count; i++)
                {
                    foreach (subject s in sub)
                    {
                        if (s.subjectID == studentR2[i]) subjects.Add(s);
                    }
                }
                dgvsubject.DataSource = subjects.Select(x => new { x.GraphicDesign, x.WebbDevelopment, x.Programming, x.DataBase }).ToList();
            }

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            mainBage mainB = new mainBage();
            mainB.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Relation relat = new Relation();
            student st = db.Students.FirstOrDefault(x => (x.studentID + "- " + x.studentFirstName + " " + x.studentLastName) == comselectname.SelectedItem.ToString());
            teacher teach = db.Teachers.FirstOrDefault(x => (x.teacherID + "- " + x.teacherFirstName + " " + x.teacherLastName) == comchooseteacher.SelectedItem.ToString());
            //subject sub = db.Subjects.FirstOrDefault(x => (x.subjectID + "- " + x.GraphicDesign + " " + x.WebbDevelopment + " " + x.Programming + " " + x.DataBase) == comselectcourse.SelectedItem.ToString());

            

            if (st != null && teach != null)
            {
                relat.studentIDFK = st.studentID;
                relat.teacherIDFK = teach.teacherID;
                switch (comselectcourse.SelectedItem.ToString())
                {
                    case ("1- adobeIllustrator"):
                        relat.subjectIDFK = 1;
                        break;
                    case ("2- adobePhotoshp"):
                        relat.subjectIDFK = 2;
                        break;
                    case ("3- corelDrow"):
                        relat.subjectIDFK = 3;
                        break;
                    case ("4- Html"):
                        relat.subjectIDFK = 4;
                        break;
                    case ("5- Css"):
                        relat.subjectIDFK = 5;
                        break;
                    case ("6- javaScript"):
                        relat.subjectIDFK = 6;
                        break;
                    case ("7- Csharp"):
                        relat.subjectIDFK = 7;
                        break;
                    case ("8- Java"):
                        relat.subjectIDFK = 8;
                        break;
                    case ("9- python"):
                        relat.subjectIDFK = 9;
                        break;
                    case ("10- sqlServer"):
                        relat.subjectIDFK = 10;
                        break;
                    case ("11- oracle"):
                        relat.subjectIDFK = 11;
                        break;
                    case ("12- mySql"):
                        relat.subjectIDFK = 12;
                        break;
                }
                db.Relations.Add(relat);
                db.SaveChanges();
                MessageBox.Show($"The Student {st.studentFirstName} {st.studentLastName} enroller to the course ");

            }
        }      
    }
}
