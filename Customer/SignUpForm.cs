using MetroFramework.Forms;
using Person;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using MetroFramework;

namespace Customer
{
    public partial class SignUpForm : MetroForm
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Documents\CustomerData.mdf;Integrated Security=True;Connect Timeout=30");
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            int a = rowCount();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "insert into Customer values('" + a + "','" + metroTextBox1.Text + "','" + metroTextBox2.Text + "','" + metroTextBox3.Text + "','" + metroTextBox4.Text + "','" + metroTextBox5.Text + "','" + metroTextBox6.Text + "','" + metroTextBox7.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();

            MetroMessageBox.Show(this, "Added Successfully");
            this.Close();
        }

        public int rowCount()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM Customer";
            Int32 count = cmd.ExecuteNonQuery();
            con.Close();

            return count+1;
        }
    }
}
