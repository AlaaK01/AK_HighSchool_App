using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AK_HighSchool_App.screen
{
    public partial class mainBage : Form
    {
        public mainBage()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Teachers Tch = new Teachers();
            Tch.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
           A St = new A();
            St.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Courses cour = new Courses();
            cour.Show();
        }
    }
}
