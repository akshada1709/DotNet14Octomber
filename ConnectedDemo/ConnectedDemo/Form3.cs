using System;
using System.Windows.Forms;
using System.Data.Sql;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Data;

namespace ConnectedDemo
{
    public partial class Form3 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;

        public Form3()
        {
            InitializeComponent();
            conn=new SqlConnection(ConfigurationManager.ConnectionStrings["defaultConn"].ConnectionString);
            
        }

        public void ClearFormFields() 
        {
           txtRollNo.Clear();
            txtName.Clear();
            txtPercentage.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "INSERT INTO Student VALUES (@RollNo, @Name, @Percentage, @Course)";
                cmd = new SqlCommand(qry, conn);

                cmd.Parameters.AddWithValue("@RollNo", Convert.ToInt32(txtRollNo.Text));
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Percentage", Convert.ToDouble(txtPercentage.Text));
                cmd.Parameters.AddWithValue("@Course", comboBox1.SelectedItem.ToString());

                conn.Open();
                int result = cmd.ExecuteNonQuery();

                if (result >= 1)
                {
                    MessageBox.Show("Student record added successfully");
                    ClearFormFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "SELECT Name, Percentage, Course FROM Student WHERE RollNo = @RollNo";
                cmd = new SqlCommand(qry, conn);
                cmd.Parameters.AddWithValue("@RollNo", Convert.ToInt32(txtRollNo.Text));

                conn.Open();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    if (dr.Read())
                    {
                        txtName.Text = dr["Name"].ToString();
                        txtPercentage.Text = dr["Percentage"].ToString();
                        comboBox1.SelectedItem = dr["Course"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Record not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "UPDATE Student SET Name = @Name, Percentage = @Percentage, Course = @Course WHERE RollNo = @RollNo";
                cmd = new SqlCommand(qry, conn);

                cmd.Parameters.AddWithValue("@RollNo", Convert.ToInt32(txtRollNo.Text));
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Percentage", Convert.ToDouble(txtPercentage.Text));
                cmd.Parameters.AddWithValue("@Course", comboBox1.SelectedItem.ToString());

                conn.Open();
                int result = cmd.ExecuteNonQuery();

                if (result >= 1)
                {
                    MessageBox.Show("Student record updated successfully");
                    ClearFormFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void bbtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "DELETE FROM Student WHERE RollNo = @RollNo";
                cmd = new SqlCommand(qry, conn);

                cmd.Parameters.AddWithValue("@RollNo", Convert.ToInt32(txtRollNo.Text));

                conn.Open();
                int result = cmd.ExecuteNonQuery();

                if (result >= 1)
                {
                    MessageBox.Show("Student record deleted successfully");
                    ClearFormFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "SELECT * FROM Student";
                cmd = new SqlCommand(qry, conn);

                conn.Open();
                dr = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(dr);

                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
    
}
