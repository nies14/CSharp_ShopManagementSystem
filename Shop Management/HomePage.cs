using MetroFramework.Forms;
using MetroFramework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using login_form;

namespace Shop_Management
{
    
    public partial class HomePage : MetroForm
    {
        SqlConnection emp = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nies_14\Documents\EmployeeData.mdf;Integrated Security=True;Connect Timeout=30");
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            int year = DateTime.Now.Year;
            string yr = year.ToString();
        }

        private void employee_Click(object sender, EventArgs e)
        {
            loginForm ob = new loginForm(1);  //1 means showw employee form
            ob.Show();
            //this.Hide();
        }

        private void admin_Click(object sender, EventArgs e)
        {
            loginForm ob = new loginForm(3);  //3 means showw employee form
            ob.Show();
            //this.Hide();
        }

        private void customer_Click(object sender, EventArgs e)
        {
            loginForm ob = new loginForm(2);  //2 means showw customer form
            ob.Show();
            //this.Hide();
        }

        private void metroTileItem5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this,"This Software was Developed by Md. Tanvir Hassan Nies.");
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "Helpline 016877-70366.");
        }

        private void metroTileItem4_Click(object sender, EventArgs e)
        {
            Customer.SignUpForm ob = new Customer.SignUpForm();
            ob.Show();
        }

        private void buy_product_Click(object sender, EventArgs e)
        {
            loginForm ob = new loginForm(2);
            ob.Show();
        }

        private void metroTileItem2_Click(object sender, EventArgs e)
        {
            loginForm ob = new loginForm(2);
            ob.Show();
        }

        private void metroTileItem3_Click(object sender, EventArgs e)
        {
            loginForm ob = new loginForm(2);
            ob.Show();
        }
    }
}
