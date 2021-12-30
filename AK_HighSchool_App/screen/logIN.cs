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
    public partial class logIN : Form
    {
        AbbDbContext db = new AbbDbContext();
        public logIN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           var st = db.Students.FirstOrDefault(x => x.userName == txtusername.Text && x.password == txtpassword.Text);
            if (st != null)
            {
                mainBage mainB = new mainBage();
                mainB.Show();
            }
            else MessageBox.Show("It is not existed");
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            
            newStudent newS = new newStudent();
            newS.Show();
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //void openForm()
        //{
        //    Application.Run(new mainBage());
        //}
    }
}
