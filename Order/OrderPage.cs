using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using System.Data.SqlClient;
using Employee_Form;
using System.IO;

namespace Order
{
    public partial class OrderPage : MetroForm
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Documents\ProductData.mdf;Integrated Security=True;Connect Timeout=30");
        SqlConnection des = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Documents\ProductData.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        string prfl="";
        private void OrderPage_Load(object sender, EventArgs e)
        {
            DisplayProduct();
        }
        public OrderPage()
        {
            InitializeComponent();
        }

        public OrderPage(string name)
        {
            prfl = name;
            InitializeComponent();
        }

        private void order_Click(object sender, EventArgs e)
        {
            Insert();
            update();
            updatePending();
            MetroMessageBox.Show(this, "Thanks for Buying the Product.");
            string items = metroTextBox1.Text;
            int stk = Convert.ToInt32(metroTextBox2.Text);
            EmployeeRoutine ob = new EmployeeRoutine(items,stk);
            this.Close();
        }

        public void update()
        {
            
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update Product set Stock = Stock -'" + Convert.ToInt32(metroTextBox2.Text) + "' where Name='" + metroTextBox1.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                
            }
            
            catch(Exception e)
            {

            }

        }

        public void updatePending()
        {

            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update Pending set Stock='" + Convert.ToInt32(metroTextBox2.Text) + "', Ordered_By='" + prfl + "' where Name='" + metroTextBox1.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();

            }

            catch (Exception e)
            {

            }

        }

        public void DisplayProduct()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from Product";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void search_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Product where Name = '" + metroTextBox1.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }

        public void Insert()
        {
            try
            {
                con.Open();
                des.Open();
                cmd = new SqlCommand("select Id,Name,Category,Stock,Price,Image from Product where Name = '" + metroTextBox1.Text + "'", con);
                SqlDataReader reader = cmd.ExecuteReader();
                SqlBulkCopy bulkData = new SqlBulkCopy(des);
                bulkData.DestinationTableName = "Pending";
                bulkData.WriteToServer(reader);
                bulkData.Close();
                des.Close();
                con.Close();
            }
            catch(Exception e)
            {
                MetroMessageBox.Show(this,"Please Try Again");
            }
            
        }
    }
}
