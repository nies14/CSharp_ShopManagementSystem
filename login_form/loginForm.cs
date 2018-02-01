using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using Admin;
using MetroFramework;

namespace login_form
{
    public partial class loginForm : MetroForm
    {
        int form = 0;
        SqlConnection emp = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Documents\EmployeeData.mdf;Integrated Security=True;Connect Timeout=30");
        SqlConnection cus = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Documents\CustomerData.mdf;Integrated Security=True;Connect Timeout=30");
        public loginForm()
        {
            InitializeComponent();
        }

        public loginForm(int n)
        {
            InitializeComponent();
            form = n;
        }

        private void login_form_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if(form==1) // 1 means show employee
            {
                emp.Open();
                SqlCommand cmd = emp.CreateCommand();
                cmd.CommandType = CommandType.Text;
                string b = "Employee";
                cmd.CommandText = "select * from Employee where User_Name = '" + metroTextBox1.Text + "' AND Password='" + metroTextBox3.Text +"' AND Position='"+b +"'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    MetroMessageBox.Show(this, "You Are Successfully logged in as an Employee");
                    string n = metroTextBox1.Text;
                    Employee_Form.EmployeeRoutine empl = new Employee_Form.EmployeeRoutine(n); 
                    empl.Show();
                    this.Hide();
                }
                else
                {
                    MetroMessageBox.Show(this,"Wrong User Name or Password");
                }
                emp.Close();
                

            }

            else if(form ==2) //2 means customer
            {
                cus.Open();
                SqlCommand cmd = cus.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Customer where User_Name = '" + metroTextBox1.Text + "' AND Password='" + metroTextBox3.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    Customer.CustomerHomePage ob = new Customer.CustomerHomePage(metroTextBox1.Text);
                    ob.Show();
                    this.Hide();
                    MetroMessageBox.Show(this, "You are successfully logged in as a Customer");
                }
                else
                {
                    MetroMessageBox.Show(this, "Wrong User Name or Password");
                }

                cus.Close();

            }

            if (form == 3) // 3 means show Admin
            {
                emp.Open();
                SqlCommand cmd = emp.CreateCommand();
                cmd.CommandType = CommandType.Text;
                string admin = "Admin";
                cmd.CommandText = "select * from Employee where User_Name = '" + metroTextBox1.Text + "' AND Password='" + metroTextBox3.Text + "' AND Position='"+admin+"'";

                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    MetroMessageBox.Show(this, "You Are Successfully logged in as an Admin");

                    AdminRoutine admn = new AdminRoutine(metroTextBox1.Text);
                    admn.Show();
                    this.Hide();
                }
                else
                {
                    MetroMessageBox.Show(this, "Wrong User Name or Password");
                }

                emp.Close();

            }

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
