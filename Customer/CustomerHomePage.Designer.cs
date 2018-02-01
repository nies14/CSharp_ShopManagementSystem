namespace Customer
{
    partial class CustomerHomePage
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.pending = new MetroFramework.Controls.MetroTile();
            this.delivered = new MetroFramework.Controls.MetroTile();
            this.prfl = new MetroFramework.Controls.MetroTile();
            this.buyProdct = new MetroFramework.Controls.MetroTile();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.metroPanel1.Controls.Add(this.pending);
            this.metroPanel1.Controls.Add(this.delivered);
            this.metroPanel1.Controls.Add(this.prfl);
            this.metroPanel1.Controls.Add(this.buyProdct);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 5);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(218, 510);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseCustomForeColor = true;
            this.metroPanel1.UseStyleColors = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // pending
            // 
            this.pending.ActiveControl = null;
            this.pending.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pending.BackColor = System.Drawing.Color.SeaGreen;
            this.pending.Location = new System.Drawing.Point(0, 246);
            this.pending.Name = "pending";
            this.pending.Size = new System.Drawing.Size(218, 52);
            this.pending.TabIndex = 5;
            this.pending.Text = "Pending Items";
            this.pending.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pending.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.pending.UseCustomBackColor = true;
            this.pending.UseSelectable = true;
            this.pending.Click += new System.EventHandler(this.pending_Click);
            // 
            // delivered
            // 
            this.delivered.ActiveControl = null;
            this.delivered.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.delivered.BackColor = System.Drawing.Color.SeaGreen;
            this.delivered.Location = new System.Drawing.Point(0, 295);
            this.delivered.Name = "delivered";
            this.delivered.Size = new System.Drawing.Size(218, 48);
            this.delivered.TabIndex = 4;
            this.delivered.Text = "Delivered Items";
            this.delivered.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.delivered.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.delivered.UseCustomBackColor = true;
            this.delivered.UseSelectable = true;
            this.delivered.Click += new System.EventHandler(this.delivered_Click);
            // 
            // prfl
            // 
            this.prfl.ActiveControl = null;
            this.prfl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.prfl.BackColor = System.Drawing.Color.SeaGreen;
            this.prfl.Location = new System.Drawing.Point(0, 199);
            this.prfl.Name = "prfl";
            this.prfl.Size = new System.Drawing.Size(218, 48);
            this.prfl.TabIndex = 3;
            this.prfl.Text = "Profile";
            this.prfl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.prfl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.prfl.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.prfl.UseCustomBackColor = true;
            this.prfl.UseSelectable = true;
            this.prfl.Click += new System.EventHandler(this.prfl_Click);
            // 
            // buyProdct
            // 
            this.buyProdct.ActiveControl = null;
            this.buyProdct.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buyProdct.BackColor = System.Drawing.Color.SeaGreen;
            this.buyProdct.Location = new System.Drawing.Point(0, 152);
            this.buyProdct.Name = "buyProdct";
            this.buyProdct.Size = new System.Drawing.Size(218, 50);
            this.buyProdct.TabIndex = 2;
            this.buyProdct.Text = "Buy Product";
            this.buyProdct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buyProdct.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.buyProdct.UseCustomBackColor = true;
            this.buyProdct.UseSelectable = true;
            this.buyProdct.Click += new System.EventHandler(this.buyProdct_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(291, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(374, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.Visible = false;
            // 
            // CustomerHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 516);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.metroPanel1);
            this.Name = "CustomerHomePage";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.CustomerHomePage_Load);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile pending;
        private MetroFramework.Controls.MetroTile delivered;
        private MetroFramework.Controls.MetroTile prfl;
        private MetroFramework.Controls.MetroTile buyProdct;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}