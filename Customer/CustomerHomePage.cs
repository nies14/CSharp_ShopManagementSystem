using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Customer
{
    public partial class CustomerHomePage : MetroForm
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Documents\ProductData.mdf;Integrated Security=True;Connect Timeout=30");
        string prof;
        public CustomerHomePage()
        {
            InitializeComponent();
        }

        public CustomerHomePage(string name)
        {
            prof = name;
            InitializeComponent();
            
        }

        private void CustomerHomePage_Load(object sender, EventArgs e)
        {

        }

        private void buyProdct_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            Order.OrderPage ob = new Order.OrderPage(prof);
            ob.Show();
        }

        private void prfl_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            Customer.Profile ob = new Customer.Profile(prof);
            ob.Show();
        }

        private void pending_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Pending where Ordered_By = '" + prof + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void delivered_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Delivered where Ordered_By = '" + prof + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }

    }
}
