using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Database;
using Product;

namespace Admin
{
    public partial class AdminRoutine : MetroForm
    {
        string prfile;
        public AdminRoutine()
        {
            InitializeComponent();
        }

        public AdminRoutine(string name)
        {
            InitializeComponent();
            prfile = name;
        }

        private void AdminRoutine_Load(object sender, EventArgs e)
        {

        }

        private void addProduct_Click(object sender, EventArgs e)
        {
            ProductList ob = new ProductList(2);
            ob.Show();
        }

        private void addCategory_Click(object sender, EventArgs e)
        {
            ProductList ob = new ProductList(2);
            ob.Show();
        }

        private void addEmployee_Click(object sender, EventArgs e)
        {
            EmployeeAdd ob = new EmployeeAdd();
            ob.Show();
        }

        private void profile_Click(object sender, EventArgs e)
        {
            AdminProfile ob = new AdminProfile(prfile);
            ob.Show();
        }

        private void customer_Click(object sender, EventArgs e)
        {
            CustomerAdd ob = new CustomerAdd();
            ob.Show();
        }

        private void tdSale_Click(object sender, EventArgs e)
        {
            Server.Chat ob = new Server.Chat();
            ob.Show();

            //Server.Chat ob1 = new Server.Chat();
            //ob1.Show();
        }
    }
}
