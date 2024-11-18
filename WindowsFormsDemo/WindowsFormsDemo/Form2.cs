using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDemo
{
    public partial class Form2 : Form
    {
        private List<string> cities = new List<string>();
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string city= txtCity.Text;
            if (cities.Contains(city))
            {
                MessageBox.Show("City is exist");

            }
            else 
            {
                cities.Add(city);
            }
            

        }

        private void butRemove_Click(object sender, EventArgs e)
        {
            if (listBoxCities.SelectedItems != null) 
            {
               string selectcity=listBoxCities.SelectedItems.ToString();
                listBoxCities.

            }

        }
    }
}
