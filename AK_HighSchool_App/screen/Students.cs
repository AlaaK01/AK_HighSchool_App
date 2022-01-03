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
    public partial class A : Form
    {
        string input1 = "";
        string input2 = "";
        AbbDbContext db = new AbbDbContext();
       
        public A()
        {
            InitializeComponent();
            for (int i = 20; i < 65; i++ )
            {
                comage.Items.Add(i.ToString());
            }

            comstudycategory.Items.Add(category.graphicDesign.ToString());
            comstudycategory.Items.Add(category.webDevelopment.ToString());
            comstudycategory.Items.Add(category.programming.ToString());
            comstudycategory.Items.Add(category.dataBase.ToString());

            comstudytype.Items.Add(studyType.distance);
            comstudytype.Items.Add(studyType.onSite);
            comstudytype.Items.Add(studyType.both);

            comgpa.Items.Add(gpa.A);
            comgpa.Items.Add(gpa.B);
            comgpa.Items.Add(gpa.C);
            comgpa.Items.Add(gpa.D);
            comgpa.Items.Add(gpa.E);
            comgpa.Items.Add(gpa.F);

            foreach (student st in db.Students)
            {
                comselectstudent.Items.Add($"{st.studentID}- {st.studentFirstName} {st.studentLastName}".ToString());
            }

            commodification.Items.Add("First Name");
            commodification.Items.Add("Last Name");
            commodification.Items.Add("User Name");
            commodification.Items.Add("Password");
            commodification.Items.Add("Email");
            commodification.Items.Add("Age");
            commodification.Items.Add("Gender");

            foreach (student st in db.Students)
            {
                comdeletestudent.Items.Add($"{st.studentID}- {st.studentFirstName} {st.studentLastName}".ToString());
            }


        }

        private void Students_Load(object sender, EventArgs e)
        {

        }

        private void dgvstudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CBallstudents.Checked)
            {
                dgvstudent.DataSource = db.Students.Select(x => new { x.studentID, x.studentFirstName, x.studentLastName, x.email, x.Gender, x.studentAge }).ToList();
                
            }
            if (CBfirstname.Checked)
            {
                dgvstudent.DataSource = db.Students.Where(x => x.studentFirstName == input1).Select(x => new { x.studentID, x.studentFirstName, x.studentLastName, x.email, x.Gender, x.studentAge }).ToList();
            }
            if (CBlastname.Checked)
            {
                dgvstudent.DataSource = db.Students.Where(x => x.studentLastName == input2).Select(x => new { x.studentID, x.studentFirstName, x.studentLastName, x.email, x.Gender, x.studentAge }).ToList();
            }
            if (CBage.Checked)
            {
                dgvstudent.DataSource = db.Students.Where(x => x.studentAge == Convert.ToInt16(comage.SelectedItem.ToString())).Select(x => new { x.studentID, x.studentFirstName, x.studentLastName, x.email, x.Gender, x.studentAge }).ToList();
            }

            if (CBstudycategory.Checked)
            {
                List<subject> subb = db.Subjects.ToList();
                List<int> courseRstudent = new List<int>();
               
                foreach (var sub in subb)
                {
                    if (sub.Category.ToString() == comstudycategory.SelectedItem.ToString()) courseRstudent.Add(sub.subjectID);

                }
                List<Relation> CategoryRelation = db.Relations.ToList();
                List<int> courseRstudent2 = new List<int>();
                for (int i = 0; i < courseRstudent.Count; i++)
                {
                    foreach (Relation relat in CategoryRelation)
                    {
                        if (relat.subjectIDFK == courseRstudent[i])
                            if (!courseRstudent2.Contains(relat.studentIDFK)) courseRstudent2.Add(relat.studentIDFK);

                    }
                }

                List<student> students = new List<student>();
                var stud = db.Students.ToList();
                for (int i = 0; i < courseRstudent2.Count; i++)
                {
                    foreach (student st in stud)
                    {
                        if (st.studentID == courseRstudent2[i]) students.Add(st);
                    }
                }

                dgvstudent.DataSource = students.Select(x => new { x.studentID, x.studentFirstName, x.studentLastName }).ToList();


            }

            if (CBstudytype.Checked)
            {
                
                List<int> Stype = new List<int>();
                string input4 = comstudytype.SelectedItem.ToString();                
                List<Relation> studyTypeRelation = db.Relations.ToList();
               
                foreach (Relation relat in studyTypeRelation)
                {
                    if (relat.StudyType.ToString() == input4)
                        if (!Stype.Contains(relat.studentIDFK)) Stype.Add(relat.studentIDFK);
                }

                List<student> students = new List<student>();
                var stud = db.Students.ToList();
                for (int i = 0; i < Stype.Count; i++)
                {
                    foreach (student st in stud)
                    {
                        if (st.studentID == Stype[i]) students.Add(st);
                    }
                }
                dgvstudent.DataSource = students.Select(x => new { x.studentID, x.studentFirstName, x.studentLastName }).ToList();


            }

            if (CBgpa.Checked)
            {

                List<int> gpaList = new List<int>();
                string input5 = comgpa.SelectedItem.ToString();
                List<Relation> gpaRelation = db.Relations.ToList();
                foreach (Relation relat in gpaRelation)
                {
                    if (relat.GPA.ToString() == input5) 
                        if (!gpaList.Contains(relat.studentIDFK)) gpaList.Add(relat.studentIDFK);
                }

                List<student> students = new List<student>();
                var stud = db.Students.ToList();
                for (int i = 0; i < gpaList.Count; i++)
                {
                    foreach (student st in stud)
                    {
                        if (st.studentID == gpaList[i]) students.Add(st);
                    }
                }
                dgvstudent.DataSource = students.Select(x => new { x.studentID, x.studentFirstName, x.studentLastName }).ToList();
            }

            


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtfirstname_TextChanged(object sender, EventArgs e)
        {
            //input1 = txtallstudents.Text;
            
        }

        private void cbfirstname_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CBallstudents_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CBfirstname_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void txtfirstname_TextChanged_1(object sender, EventArgs e)
        {
            input1 = txtfirstname.Text;
        }

        private void CBlastname_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtlastname_TextChanged(object sender, EventArgs e)
        {
            input2 = txtlastname.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CBage_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            newStudent newS = new newStudent();
            newS.Show();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged_3(object sender, EventArgs e)
        {

        }

        private void deletestudent_Click(object sender, EventArgs e)
        {
            student st = db.Students.FirstOrDefault(x => (x.studentID+"- "+x.studentFirstName + " " + x.studentLastName) == comdeletestudent.SelectedItem.ToString());
            if (st != null) db.Students.Remove(st);
            db.SaveChanges();
            MessageBox.Show($"The Student {st.studentFirstName} {st.studentLastName} is deleted.");
            
        }

        private void comselectstudent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void commodification_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txteditstudent_TextChanged(object sender, EventArgs e)
        {

        }

        private void buteditstudent_Click(object sender, EventArgs e)
        {
            student st = db.Students.FirstOrDefault(x => (x.studentID+"- "+x.studentFirstName + " " + x.studentLastName) == comselectstudent.SelectedItem.ToString());
            if (st != null)
            {
                gender g = gender.unknown;
                int n = 0;
                switch (commodification.SelectedItem.ToString())
                {
                    case ("First Name"):
                        st.studentFirstName = txteditstudent.Text;
                        MessageBox.Show("You Succeeded To Update Student's First Name");
                        break;

                    case ("Last Name"):
                        st.studentLastName = txteditstudent.Text;
                        MessageBox.Show("You Succeeded To Update Student's Last Name");
                        break;

                    case ("User Name"):
                        st.userName = txteditstudent.Text;
                        MessageBox.Show("You Succeeded To Update Student's User Name");
                        break;

                    case ("Password"):
                        st.password = txteditstudent.Text;
                        MessageBox.Show("You Succeeded To Update Student's PassWord");
                        break;

                    case ("Email"):
                        st.email = txteditstudent.Text;
                        MessageBox.Show("You Succeeded To Update Student's E-mail");
                        break;

                    case ("Age"):
                        if (int.TryParse(txteditstudent.Text, out n))
                        {
                            if (n > 17 && n < 100)
                            {
                                st.studentAge = n;
                                MessageBox.Show("You Succeeded To Update Student's Age");
                            }
                            else MessageBox.Show("invalid value");
                        }
                        else MessageBox.Show("invalid value");
                        break;

                    case ("Gender"):
                        if (gender.TryParse(txteditstudent.Text, out g))
                        {

                            st.Gender = g;
                            MessageBox.Show("You Succeeded To Update Teacher's gender");
                        }
                        else MessageBox.Show("invalid value");
                        break;
                }
                db.Students.Update(st);
                db.SaveChanges();
            }
            else MessageBox.Show("Not Exist");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            mainBage newB = new mainBage();
            newB.Show();
        }
    }
}
