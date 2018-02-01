using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using Product;
using System.Data.SqlClient;

namespace Employee_Form
{
    public partial class EmployeeRoutine : MetroForm
    {
        string profile;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Documents\ProductData.mdf;Integrated Security=True;Connect Timeout=30");
        int checkIn = 0,stock;
        string pendingOrder;

        public EmployeeRoutine()
        {
            InitializeComponent();
        }

        public EmployeeRoutine(string name)
        {
            profile = name;
            InitializeComponent();
            
        }

        public EmployeeRoutine(string Items,int stk)
        {
            InitializeComponent();
            pendingOrder = Items;
            stock = stk;
        }

        private void routine_Load(object sender, EventArgs e)
        {

        }

        private void addProdct_Click(object sender, EventArgs e)
        {
            ProductList ob = new ProductList(1);
            ob.Show();
            //this.Hide();
        }

        private void prfl_Click(object sender, EventArgs e)
        {
            //EditEmployeeInfo ob = new EditEmployeeInfo(profile);
            //ob.Show();
            Profile prfl = new Profile(profile);
            prfl.Show();
        }

        private void chkin_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            MetroMessageBox.Show(this,"Your Check in Time is "+now.ToString());
            checkIn = 1;
        }

        private void chkout_Click(object sender, EventArgs e)
        {
            if(checkIn==1)
            {
                DateTime now = DateTime.Now;
                MetroMessageBox.Show(this, "Your Check out Time is " + now.ToString());
                checkIn = 0;
            }

            else
            {
                MetroMessageBox.Show(this,"You Have not Checked In Yet");
            }
            
        }

        private void chat_Click(object sender, EventArgs e)
        {
            Server.Chat ob = new Server.Chat();
            ob.Show();
            //Server.Chat ob1 = new Server.Chat();
            //ob1.Show();
        }

        private void delivered_Click(object sender, EventArgs e)
        {
            PendingForm ob = new PendingForm();
            ob.Show();
        }

        private void pending_Click(object sender, EventArgs e)
        {
            PendingForm ob = new PendingForm();
            ob.Show();
        }
    }
}
