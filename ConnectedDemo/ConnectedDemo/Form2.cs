using System;
using System.Windows.Forms;
using System.Data.Sql;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Data;

namespace ConnectedDemo
{
   
   

    public partial class Form2 : Form
    {
        //create obj of 3 classes
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;
        public Form2()
        {
            InitializeComponent();
            conn=new SqlConnection(ConfigurationManager.ConnectionStrings["defaultConn"].ConnectionString);
        }

        private void ClearFormFields() 
        {
           txtId.Clear();
            txtName.Clear();
            txtPrice.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //write query
                string qry = "insert into product values(@name,@price)";
                cmd=new SqlCommand(qry,conn);
                //initilized values
                cmd.Parameters.AddWithValue("@name",txtName.Text);
                cmd.Parameters.AddWithValue("@price",txtPrice.Text);
                conn.Open();
                int result=cmd.ExecuteNonQuery();
                if (result >= 1) 
                {
                    MessageBox.Show("Product added successfully");
                    ClearFormFields();
                
                }

            }
            catch(Exception ex)
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
                string qry = "select name,price from product where pid=@id";
                cmd = new SqlCommand(qry, conn);
                cmd.Parameters.AddWithValue("@id",Convert.ToInt32(txtId.Text));
                conn.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    if (dr.Read())
                    {
                        txtName.Text = dr["name"].ToString();
                        txtPrice.Text = dr["price"].ToString();
                       
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
                conn.Close() ;
            
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //write query
                string qry = "update product set name=@name,price=@price where pid=@id";
                cmd = new SqlCommand(qry, conn);
                //initilized values
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtId.Text));
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@price", txtPrice.Text);
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                if (result >= 1)
                {
                    MessageBox.Show("Product updated successfully");
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //write query
                string qry = "delete from product where pid=@id";
                cmd = new SqlCommand(qry, conn);
                //initilized values
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtId.Text));
            
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                if (result >= 1)
                {
                    MessageBox.Show("Product deleted successfully");
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
                //write query
                string qry = "select * from product";
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
              conn.Close() ;
            }

        }
    }
}
