using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Profile;
using System.Data.SqlClient;

namespace Admin
{
    public partial class AdminProfile : Form1
    {
        string name, prflName = "";
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Documents\EmployeeData.mdf;Integrated Security=True;Connect Timeout=30");
        public AdminProfile()
        {
            InitializeComponent();
        }

        public AdminProfile(string n)
        {
            prflName = n;
            InitializeComponent();
            
        }

        private void AdminProfile_Load(object sender, EventArgs e)
        {
            display();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            Database.EmployeeAdd ob = new Database.EmployeeAdd();
            ob.Show();
            this.Hide();
        }

        private void done_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void display()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Employee where User_Name = '" + prflName + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            int j = 7;

            foreach (Control c in this.Controls)
            {
                //MetroFramework.MetroMessageBox.Show(this,c.ToString());
                if (c.GetType().ToString() == "MetroFramework.Controls.MetroTextBox")
                {
                    object a = dataGridView1.Rows[0].Cells[j].Value;
                    c.Text = a.ToString();
                    j--;
                }
            }
            con.Close();
        }
    }
}
