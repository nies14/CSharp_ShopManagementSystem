using MetroFramework;
using MetroFramework.Forms;
using Person;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Employee_Form
{
    public partial class EditEmployeeInfo : MetroForm
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Documents\EmployeeData.mdf;Integrated Security=True;Connect Timeout=30");
        string profl;
        public EditEmployeeInfo()
        {
            InitializeComponent();
        }

        public EditEmployeeInfo(string n)
        {
            profl = n;
            InitializeComponent();
        }


        private void Edit_Info_Load(object sender, EventArgs e)
        {
            display();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Employee set Name='" + metroTextBox1.Text + "', User_Name='" + metroTextBox2.Text + "', Age='" + metroTextBox3.Text + "', Mobile='" + metroTextBox4.Text + "', Address='" + metroTextBox5.Text + "', Gender='" + metroTextBox6.Text + "', Password='" + metroTextBox7.Text + "' where User_Name='" + profl + "'";
            cmd.ExecuteNonQuery();
            con.Close();

            MetroMessageBox.Show(this, "Updated Successfully");
        }

        public void display()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Employee where User_Name = '" + profl + "'";
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
