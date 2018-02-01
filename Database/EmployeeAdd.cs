using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using MetroFramework;

namespace Database
{
    public partial class EmployeeAdd : MetroForm
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Documents\EmployeeData.mdf;Integrated Security=True;Connect Timeout=30");
        public EmployeeAdd()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Display_Data();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "insert into Employee values('"+metroTextBox1.Text+"','"+metroTextBox2.Text + "','" + metroTextBox3.Text + "','" + metroTextBox4.Text + "','" + metroTextBox5.Text + "','" + metroTextBox6.Text + "','" + metroComboBox1.Text + "','" + metroTextBox7.Text+"')";
            cmd.ExecuteNonQuery();
            con.Close();

            Display_Data();

            MetroMessageBox.Show(this,"Added Successfully");
        }

        public void Display_Data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from Employee";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "delete from Employee where name = '"+metroTextBox2.Text+"'";
            cmd.ExecuteNonQuery();
            con.Close();

            Display_Data();

            MetroMessageBox.Show(this, "Deleted Successfully");
        }

        private void Update_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Employee set Name='" + metroTextBox1.Text + "', User_Name='" + metroTextBox2.Text + "', Age='" + metroTextBox3.Text + "', Mobile='" + metroTextBox4.Text + "', Address='" + metroTextBox5.Text + "', Gender='" + metroTextBox6.Text + "', Password='" + metroTextBox7.Text + "' where Name='" + metroTextBox8.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();

            Display_Data();

            MetroMessageBox.Show(this, "Updated Successfully");
        }

        private void Search_Click(object sender, EventArgs e)
        { 

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Employee where Name = '" + metroTextBox8.Text+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();

        }
        
    }
}
