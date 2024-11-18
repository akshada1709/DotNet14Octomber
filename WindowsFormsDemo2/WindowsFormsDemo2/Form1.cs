using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDemo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (textusername.Text == "admin" && textpassword.Text == "admin123") 
            {
                MessageBox.Show("Success");
            }
            else 
            {
                MessageBox.Show("Fail to login");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textusername.Clear();
            textpassword.Clear();
        }

        private void textpassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
