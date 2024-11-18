using System;
using System.Windows.Forms;
using System.IO;

namespace Form2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btncreatefolder_Click(object sender, EventArgs e)
        {
            try
            {

                string path = @"D:\Dot_Net_14_Octomber\File_IO\File-IO";
                if (Directory.Exists(path))
                {

                    MessageBox.Show("Folder is exists");
                }
                else
                {
                    Directory.CreateDirectory(path);
                    MessageBox.Show("Created");

                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
