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

namespace Customer
{
    public partial class Profile : MetroForm
    {
        string prflName="";
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Documents\CustomerData.mdf;Integrated Security=True;Connect Timeout=30");

        public Profile()
        {
            InitializeComponent();
            //prflName= "Rashiq";
        }

        public Profile(string name)
        {
            prflName = name;
            InitializeComponent();
           
        }


        private void Profile_Load(object sender, EventArgs e)
        {
            display();
        }

        private void edit_Click(object sender, EventArgs e)
        {

        }

        public void display()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Customer where User_Name = '" + prflName + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            int i = 0, j = 7;

            foreach (Control c in this.Controls)
            {
                //MetroFramework.MetroMessageBox.Show(this,c.ToString());
                if (c.GetType().ToString() == "MetroFramework.Controls.MetroTextBox")
                {
                    object a = dataGridView1.Rows[i].Cells[j].Value;
                    c.Text = a.ToString();
                    j--;
                }
            }
            con.Close();
        }

        private void done_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
