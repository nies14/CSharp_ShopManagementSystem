using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Form
{
    public partial class PendingForm : MetroForm
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Documents\ProductData.mdf;Integrated Security=True;Connect Timeout=30");
        SqlConnection des = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Documents\ProductData.mdf;Integrated Security=True;Connect Timeout=30");
        string pnding;
        int pndingstk=0;
        public PendingForm()
        {
            InitializeComponent();
        }

        public PendingForm(string itms,int stk)
        {
            InitializeComponent();
            pnding = itms;
            pndingstk = stk;
        }

        private void PendingForm_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void delivered_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "delete from Pending where name = '" + metroTextBox1.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();

            Display();

            MetroMessageBox.Show(this, "Delivered Successfully");

            con.Open();
            des.Open();
            cmd = con.CreateCommand();
            cmd = new SqlCommand("select * from Pending where Name = '" + metroTextBox1 + "'", con);
            SqlDataReader reader = cmd.ExecuteReader();
            SqlBulkCopy bulkData = new SqlBulkCopy(des);
            bulkData.DestinationTableName = "Delivered";
            bulkData.WriteToServer(reader);
            bulkData.Close();
            des.Close();
            con.Close();
        }

        public void Display()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from Pending";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }
        
    }
}
