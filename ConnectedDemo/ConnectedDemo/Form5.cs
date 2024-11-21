using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ConnectedDemo
{
    public partial class Form5 : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder cmd;
        public Form5()
        {
            InitializeComponent();
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["defaultConn"].ConnectionString);
        }

        private DataSet GetStudent()
        {
            da = new SqlDataAdapter("Select * from Student", conn);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            cmd = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "std");
            return ds;
        }
        private void ClearFormFileds()
        {
            txtRollNo.Clear();
            txtName.Clear();
            txtPercentage.Clear();
            comboBox1.SelectedIndex = 0;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetStudent();
                DataRow row = ds.Tables["std"].NewRow();
                row["name"] = txtName.Text;
                row["percentage"] = txtPercentage.Text;

                if (comboBox1.SelectedItem != null)
                {
                    row["Branch"] = comboBox1.SelectedItem.ToString(); // Assign selected course/branch.
                }
                else
                {
                    MessageBox.Show("Please select a course.");
                    return;
                }

                ds.Tables["std"].Rows.Add(row);
                int result = da.Update(ds.Tables["std"]);
                if (result >= 1)
                {
                    MessageBox.Show("Record inserted");
                    ClearFormFileds();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetStudent();
                DataRow row = ds.Tables["std"].Rows.Find(txtRollNo.Text);
                if (row != null)
                {
                   txtName.Text = row["name"].ToString();
                    txtPercentage.Text= row["percentage"].ToString();
                    comboBox1.SelectedItem = row["Branch"].ToString();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetStudent();
                DataRow row = ds.Tables["std"].Rows.Find(txtRollNo.Text);
                if (row != null)
                {
                    row["name"] = txtName.Text;
                    row["percentage"] = txtPercentage.Text;
                    int result = da.Update(ds.Tables["sttd"]);
                    if (result >= 1)
                    {
                        MessageBox.Show("Records update ");
                        ClearFormFileds();
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bbtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetStudent();
                DataRow row = ds.Tables["std"].Rows.Find(txtRollNo.Text);
                if (row != null)
                {
                    row.Delete();
                    int result = da.Update(ds.Tables["std"]);
                    if (result >= 1)
                    {
                        MessageBox.Show("Record deleted");
                        ClearFormFileds();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            ds = GetStudent();
            dataGridView1.DataSource = ds.Tables["std"];
        }
    }
}
