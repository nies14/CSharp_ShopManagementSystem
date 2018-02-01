namespace Order
{
    partial class OrderPage
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Order = new MetroFramework.Controls.MetroTile();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.search = new MetroFramework.Controls.MetroTile();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(108, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(568, 183);
            this.dataGridView1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(74, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(473, 62);
            this.label2.TabIndex = 34;
            this.label2.Text = "Shop Management";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(75, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 65);
            this.label1.TabIndex = 33;
            this.label1.Text = "Good Evening.\r\nWelcome to Office Management Software. Order Your Product.\r\nHave a" +
    " Nice Day.";
            // 
            // Order
            // 
            this.Order.ActiveControl = null;
            this.Order.BackColor = System.Drawing.Color.SeaGreen;
            this.Order.Location = new System.Drawing.Point(332, 530);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(140, 45);
            this.Order.TabIndex = 35;
            this.Order.Text = "Order";
            this.Order.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Order.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.Order.UseCustomBackColor = true;
            this.Order.UseSelectable = true;
            this.Order.Click += new System.EventHandler(this.order_Click);
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(188, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(43, 43);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[] {
        "Enter Product Name"};
            this.metroTextBox1.Location = new System.Drawing.Point(108, 450);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(232, 45);
            this.metroTextBox1.TabIndex = 36;
            this.metroTextBox1.Text = "Enter Product Name";
            this.metroTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // search
            // 
            this.search.ActiveControl = null;
            this.search.BackColor = System.Drawing.Color.SeaGreen;
            this.search.Location = new System.Drawing.Point(545, 450);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(131, 45);
            this.search.TabIndex = 37;
            this.search.Text = "Search";
            this.search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.search.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.search.UseCustomBackColor = true;
            this.search.UseSelectable = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // metroTextBox2
            // 
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(59, 1);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(43, 43);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.Lines = new string[] {
        "Stock"};
            this.metroTextBox2.Location = new System.Drawing.Point(397, 450);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.ShortcutsEnabled = true;
            this.metroTextBox2.Size = new System.Drawing.Size(103, 45);
            this.metroTextBox2.TabIndex = 38;
            this.metroTextBox2.Text = "Stock";
            this.metroTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // OrderPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 598);
            this.Controls.Add(this.metroTextBox2);
            this.Controls.Add(this.search);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.Order);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OrderPage";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.OrderPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTile Order;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroTile search;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
    }
}

