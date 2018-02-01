namespace Admin
{
    partial class AdminRoutine
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.customer = new MetroFramework.Controls.MetroTile();
            this.profile = new MetroFramework.Controls.MetroTile();
            this.tdSale = new MetroFramework.Controls.MetroTile();
            this.addEmployee = new MetroFramework.Controls.MetroTile();
            this.addCategory = new MetroFramework.Controls.MetroTile();
            this.addProduct = new MetroFramework.Controls.MetroTile();
            this.metroPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel3
            // 
            this.metroPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.metroPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.metroPanel3.Controls.Add(this.customer);
            this.metroPanel3.Controls.Add(this.profile);
            this.metroPanel3.Controls.Add(this.tdSale);
            this.metroPanel3.Controls.Add(this.addEmployee);
            this.metroPanel3.Controls.Add(this.addCategory);
            this.metroPanel3.Controls.Add(this.addProduct);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(0, 5);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(216, 536);
            this.metroPanel3.TabIndex = 4;
            this.metroPanel3.UseCustomBackColor = true;
            this.metroPanel3.UseCustomForeColor = true;
            this.metroPanel3.UseStyleColors = true;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // customer
            // 
            this.customer.ActiveControl = null;
            this.customer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.customer.BackColor = System.Drawing.Color.SeaGreen;
            this.customer.Location = new System.Drawing.Point(0, 205);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(216, 60);
            this.customer.TabIndex = 8;
            this.customer.Text = "Customer List";
            this.customer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.customer.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.customer.UseCustomBackColor = true;
            this.customer.UseSelectable = true;
            this.customer.Click += new System.EventHandler(this.customer_Click);
            // 
            // profile
            // 
            this.profile.ActiveControl = null;
            this.profile.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.profile.BackColor = System.Drawing.Color.SeaGreen;
            this.profile.Location = new System.Drawing.Point(0, 319);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(216, 60);
            this.profile.TabIndex = 7;
            this.profile.Text = "Profile";
            this.profile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.profile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.profile.UseCustomBackColor = true;
            this.profile.UseSelectable = true;
            this.profile.Click += new System.EventHandler(this.profile_Click);
            // 
            // tdSale
            // 
            this.tdSale.ActiveControl = null;
            this.tdSale.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tdSale.BackColor = System.Drawing.Color.SeaGreen;
            this.tdSale.Location = new System.Drawing.Point(0, 376);
            this.tdSale.Name = "tdSale";
            this.tdSale.Size = new System.Drawing.Size(216, 60);
            this.tdSale.TabIndex = 5;
            this.tdSale.Text = "Chat";
            this.tdSale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tdSale.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tdSale.UseCustomBackColor = true;
            this.tdSale.UseSelectable = true;
            this.tdSale.Click += new System.EventHandler(this.tdSale_Click);
            // 
            // addEmployee
            // 
            this.addEmployee.ActiveControl = null;
            this.addEmployee.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addEmployee.BackColor = System.Drawing.Color.SeaGreen;
            this.addEmployee.Location = new System.Drawing.Point(0, 263);
            this.addEmployee.Name = "addEmployee";
            this.addEmployee.Size = new System.Drawing.Size(216, 60);
            this.addEmployee.TabIndex = 6;
            this.addEmployee.Text = "Employee List";
            this.addEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addEmployee.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.addEmployee.UseCustomBackColor = true;
            this.addEmployee.UseSelectable = true;
            this.addEmployee.Click += new System.EventHandler(this.addEmployee_Click);
            // 
            // addCategory
            // 
            this.addCategory.ActiveControl = null;
            this.addCategory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addCategory.BackColor = System.Drawing.Color.SeaGreen;
            this.addCategory.Location = new System.Drawing.Point(0, 146);
            this.addCategory.Name = "addCategory";
            this.addCategory.Size = new System.Drawing.Size(216, 60);
            this.addCategory.TabIndex = 3;
            this.addCategory.Text = "Add Category";
            this.addCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addCategory.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.addCategory.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.addCategory.UseCustomBackColor = true;
            this.addCategory.UseSelectable = true;
            this.addCategory.Click += new System.EventHandler(this.addCategory_Click);
            // 
            // addProduct
            // 
            this.addProduct.ActiveControl = null;
            this.addProduct.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addProduct.BackColor = System.Drawing.Color.SeaGreen;
            this.addProduct.Location = new System.Drawing.Point(0, 87);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(216, 60);
            this.addProduct.TabIndex = 2;
            this.addProduct.Text = "Add Product";
            this.addProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addProduct.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.addProduct.UseCustomBackColor = true;
            this.addProduct.UseSelectable = true;
            this.addProduct.Click += new System.EventHandler(this.addProduct_Click);
            // 
            // AdminRoutine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 541);
            this.Controls.Add(this.metroPanel3);
            this.Name = "AdminRoutine";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.AdminRoutine_Load);
            this.metroPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroTile profile;
        private MetroFramework.Controls.MetroTile tdSale;
        private MetroFramework.Controls.MetroTile addEmployee;
        private MetroFramework.Controls.MetroTile addCategory;
        private MetroFramework.Controls.MetroTile addProduct;
        private MetroFramework.Controls.MetroTile customer;
    }
}