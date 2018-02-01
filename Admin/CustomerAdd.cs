using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin
{
    public partial class CustomerAdd : MetroForm
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Documents\CustomerData.mdf;Integrated Security=True;Connect Timeout=30");
        public CustomerAdd()
        {
            InitializeComponent();
        }
        private void CustomerAdd_Load(object sender, EventArgs e)
        {
            Display();
        }

        public void Display()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from Customer";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void addCustomer_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "insert into Customer(Id,Name,User_Name,Age,Mobile,Address,Gender,Password) values('" + metroTextBox10.Text + "','" + metroTextBox1.Text + "','" + metroTextBox2.Text + "','" + metroTextBox3.Text + "','" + metroTextBox4.Text + "','" + metroTextBox5.Text + "','" + metroTextBox6.Text + "','" + metroTextBox7.Text + "')";
            //cmd.CommandText = "insert into Employee values('" + metroTextBox10.Text + "','" + metroTextBox1.Text +"','" + metroTextBox2.Text + "','" + metroTextBox3.Text + "','" + metroTextBox4.Text + "','" + metroTextBox5.Text + "','" + metroTextBox6.Text + "','" + metroComboBox1.Text + "','" + metroTextBox7.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();

            Display();
            setZero();

            MetroMessageBox.Show(this, "Added Successfully");
        }

        private void deleteCustomer_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "delete from Customer where name = '" + metroTextBox9.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();

            Display();
            setZero();

            MetroMessageBox.Show(this, "Deleted Successfully");
        }

        private void updateCustomer_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Customer set Name='" + metroTextBox1.Text + "', User_Name='" + metroTextBox2.Text + "', Age='" + metroTextBox3.Text + "', Mobile='" + metroTextBox4.Text + "', Address='" + metroTextBox5.Text + "', Gender='" + metroTextBox6.Text + "', Password='" + metroTextBox7.Text + "' where Name='" + metroTextBox9.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();

            Display();
            setZero();
            MetroMessageBox.Show(this, "Updated Successfully");
        }

        public void setZero()
        {
            foreach (Control c in this.Controls)
            {
                //MetroFramework.MetroMessageBox.Show(this,c.ToString());
                if (c.GetType().ToString() == "MetroFramework.Controls.MetroTextBox")
                {
                    c.Text = "";
                }
            }
        }
    }
}
