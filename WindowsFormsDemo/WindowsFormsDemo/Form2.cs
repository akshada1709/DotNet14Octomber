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
            string city = txtCity.Text.Trim(); // Get the city name and trim whitespace

            if (string.IsNullOrEmpty(city))
            {
                MessageBox.Show("City name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cities.Contains(city))
            {
                MessageBox.Show("City already exists in the list.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                cities.Add(city); // Add city to the list
                listBoxCities.Items.Add(city); // Add city to the list box
                txtCity.Clear(); // Clear the input field
            }

        }

        private void butRemove_Click(object sender, EventArgs e)
        {
            if (listBoxCities.SelectedItem != null) // Check if an item is selected
            {
                string selectedCity = listBoxCities.SelectedItem.ToString();

                cities.Remove(selectedCity); // Remove the city from the list
                listBoxCities.Items.Remove(selectedCity); // Remove the city from the list box
            }
            else
            {
                MessageBox.Show("Please select a city to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
