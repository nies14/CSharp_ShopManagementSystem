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

namespace Employee_Form
{
    public partial class DeliveredForm : MetroForm
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Documents\ProductData.mdf;Integrated Security=True;Connect Timeout=30");
        public DeliveredForm()
        {
            InitializeComponent();
        }

        private void DeliveredForm_Load(object sender, EventArgs e)
        {
            Display();
        }
        private void done_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Display()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from Delivered";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }

        
    }
}
