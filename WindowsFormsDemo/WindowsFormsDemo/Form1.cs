//using System;
//using System.Windows.Forms;
//// For Bianry serialization
//using System.Runtime.Serialization.Formatters.Binary;
//// for xml serialization
//using System.Xml.Serialization;
////for soap
//using System.Runtime.Serialization.Formatters.Soap;
////for JSON
//using System.Text.Json;
//using System.IO;
//using System.Xml.Linq;


//namespace WindowsFormsDemo
//{
//    public partial class Form1 : Form
//    {
//        public Form1()
//        {
//            InitializeComponent();
//        }

//        private void label2_Click(object sender, EventArgs e)
//        {

//        }

//        private void btnBinaryWrite_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                FileStream fs = new FileStream(@"D:\binaryDemo.dat", FileMode.Create, FileAccess.Write);
//                BinaryFormatter binaryFormatter = new BinaryFormatter();
//                Employee emp = new Employee();
//                emp.Id = Convert.ToInt32(txtid.Text);
//                emp.Name = txtname.Text;
//                emp.Salary = Convert.ToInt32(txtsalary.Text);
//                binaryFormatter.Serialize(fs, emp);
//                fs.Close();
//                MessageBox.Show("Done");
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message);
//            }



//        }

//        private void btnbinaryRead_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                FileStream fs = new FileStream(@"D:\binaryDemo.dat", FileMode.Open, FileAccess.Read);
//                BinaryFormatter binaryFormatter = new BinaryFormatter();
//                Employee emp = new Employee();
//                emp = (Employee)binaryFormatter.Deserialize(fs);
//                txtid.Text = emp.Id.ToString();
//                txtname.Text = emp.Name;
//                txtsalary.Text = emp.Salary.ToString();

//                fs.Close();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message);
//            }

//        }

//        private void btnXmlWrite_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                FileStream fs = new FileStream(@"D:\binaryDemo.xml", FileMode.Create, FileAccess.Write);
//                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Employee));

//                Employee emp = new Employee();
//                emp.Id = Convert.ToInt32(txtid.Text);
//                emp.Name = txtname.Text;
//                emp.Salary = Convert.ToInt32(txtsalary.Text);
//                xmlSerializer.Serialize(fs, emp);

//                fs.Close();
//                MessageBox.Show("Done");
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message);
//            }

//        }

//        private void btnXmlRead_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                FileStream fs = new FileStream(@"D:\binaryDemo.xml", FileMode.Open, FileAccess.Read);
//                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Employee));

//                Employee emp = new Employee();
//                emp.Id = Convert.ToInt32(txtid.Text);
//                emp.Name = txtname.Text;
//                emp.Salary = Convert.ToInt32(txtsalary.Text);
//                xmlSerializer.Serialize(fs, emp);

//                fs.Close();
//                MessageBox.Show("Done");
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message);
//            }
//        }

//        private void btnclear_Click(object sender, EventArgs e)
//        {
//            txtid.Clear();
//            txtname.Clear();
//            txtsalary.Clear();

//        }

//        private void btnSoapWrite_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                FileStream fs = new FileStream(@"D:\soapDemo.soap", FileMode.Create, FileAccess.Write);
//                SoapFormatter soapFormatter = new SoapFormatter();

//                Employee emp = new Employee();
//                emp.Id = Convert.ToInt32(txtid.Text);
//                emp.Name = txtname.Text;
//                emp.Salary = Convert.ToInt32(txtsalary.Text);
//                soapFormatter.Serialize(fs, emp);
//                fs.Close();
//                MessageBox.Show("Done");
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message);
//            }

//        }

//        private void btnSoapRead_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                FileStream fs = new FileStream(@"D:\soapDemo.soap", FileMode.Open, FileAccess.Read);
//                SoapFormatter soapFormatter = new SoapFormatter();
//                Employee emp = new Employee();
//                emp = (Employee)soapFormatter.Deserialize(fs);

//                txtid.Text = emp.Id.ToString();
//                txtname.Text = emp.Name;
//                txtsalary.Text = emp.Salary.ToString();

//                fs.Close();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message);
//            }
//        }

//        private void txtid_TextChanged(object sender, EventArgs e)
//        {

//        }

//        private void butJSONWrite_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                FileStream fs = new FileStream(@"D:\jsonDemo.json", FileMode.Create, FileAccess.Write);
               
//                Employee emp = new Employee();
//                emp.Id = Convert.ToInt32(txtid.Text);
//                emp.Name = txtname.Text;
//                emp.Salary = Convert.ToInt32(txtsalary.Text);
//                JsonSerializer.Serialize<Employee>(fs, emp);
//                fs.Close();
//                MessageBox.Show("Done");
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message);
//            }
//        }

//        private void butJSONRead_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                FileStream fs = new FileStream(@"D:\json.json", FileMode.Open, FileAccess.Read);
               
//                Employee emp = new Employee();
//                emp = (Employee)JsonSerializer.Deserialize<Employee>(fs);

//                txtid.Text = emp.Id.ToString();
//                txtname.Text = emp.Name;
//                txtsalary.Text = emp.Salary.ToString();

//                fs.Close();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message);
//            }

//        }
//    }
//}
