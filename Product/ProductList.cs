using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Product
{
    public partial class ProductList : MetroForm
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Documents\ProductData.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        int flag = 0;
        public ProductList()
        {
            InitializeComponent();
        }

        public ProductList(int n)
        {
            flag = n;
            InitializeComponent();
            if(n==2)
            {
                metroComboBox1.Visible = false;
                metroTextBox3.Visible = true;

                submit.Visible = false;
                adminsubmit.Visible = true;
            }

            if (n == 1)
            {
                metroComboBox1.Visible = true;
                metroTextBox3.Visible = false;

                submit.Visible = true;
                adminsubmit.Visible = false;
            }
        }

        private void ProductList_Load(object sender, EventArgs e)
        {
            display();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string x = (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value));
                metroComboBox1.Items.Add(x);
            }
        }

        string imgLocation = "";

        private void Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogue = new OpenFileDialog();
            dialogue.Filter = ("png files(*.png)|*.png|jpg files(*.jpg)|*jpg|All files(*.*)|*.*");

            if(dialogue.ShowDialog()==DialogResult.OK)
            {
                imgLocation = dialogue.FileName.ToString();
                pictureBox1.ImageLocation = imgLocation;
            }

        }

        private void submit_Click(object sender, EventArgs e)
        {
            /*int catg = 0;
            List < string > list = new List<string>();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                list.Add(Convert.ToString(dataGridView1.Rows[i].Cells[2].Value));
                list[i].TrimEnd();
                string a = metroComboBox1.Text;
                a.TrimEnd();
                if (a.Equals(list[i], StringComparison.InvariantCulture))
                {
                    //MetroMessageBox.Show(this,list[i]);
                    catg = 1;
                }
            }

            if(catg==0)
            {
                MetroMessageBox.Show(this,"Enter a valid category");
                return;
            }*/
                
            byte[] images = null;
            FileStream stream = new FileStream(imgLocation,FileMode.Open,FileAccess.Read);
            BinaryReader brs = new BinaryReader(stream);
            images = brs.ReadBytes((int)stream.Length);

            con.Open();
            string query = "insert into Product(Id,Name,Category,Stock,Price,Image) values('" + metroTextBox1.Text + "','" + metroTextBox2.Text + "','" + metroComboBox1.Text+ "','" + metroTextBox4.Text + "','"+ metroTextBox8.Text + "',+@images)";
            cmd = new SqlCommand(query,con);
            SqlParameter prm = new SqlParameter("images",SqlDbType.VarBinary,images.Length,ParameterDirection.Input,false,0,0,null,DataRowVersion.Current,images);
            cmd.Parameters.Add(prm);
            int N = cmd.ExecuteNonQuery();
            con.Close();

            MetroMessageBox.Show(this, "Data added Successfully");
            this.Hide();
        }

        public void display()
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

        private void adminsubmit_Click(object sender, EventArgs e)
        {
            byte[] images = null;
            FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(stream);
            images = brs.ReadBytes((int)stream.Length);

            con.Open();
            string query = "insert into Product(Id,Name,Category,Stock,Price,Image) values('" + metroTextBox1.Text + "','" + metroTextBox2.Text + "','" + metroTextBox3.Text + "','" + metroTextBox4.Text + "','" + metroTextBox8.Text + "',+@images)";
            cmd = new SqlCommand(query, con);
            SqlParameter prm = new SqlParameter("images", SqlDbType.VarBinary, images.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, images);
            cmd.Parameters.Add(prm);
            int N = cmd.ExecuteNonQuery();
            con.Close();

            MetroMessageBox.Show(this, "Data added Successfully");
            this.Hide();
        }
    }
}
