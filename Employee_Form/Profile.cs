using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Profile;

namespace Employee_Form
{
    public partial class Profile : Form1
    {
        string name, prflName="";
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Documents\EmployeeData.mdf;Integrated Security=True;Connect Timeout=30");
        public Profile()
        {
            InitializeComponent();
            prflName = "";
        }

        public Profile(string userName)
        {
            InitializeComponent();
            prflName = userName;
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            name = prflName;
            display();
        }

        private void metroTextBox6_Click(object sender, EventArgs e)
        {

        }

        private void done_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            EditEmployeeInfo ob = new EditEmployeeInfo(prflName);
            ob.Show();
            this.Close();
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
    }
}
