namespace Employee_Form
{
    partial class EmployeeRoutine
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
            this.chat = new MetroFramework.Controls.MetroTile();
            this.chkout = new MetroFramework.Controls.MetroTile();
            this.pending = new MetroFramework.Controls.MetroTile();
            this.chkin = new MetroFramework.Controls.MetroTile();
            this.delivered = new MetroFramework.Controls.MetroTile();
            this.prfl = new MetroFramework.Controls.MetroTile();
            this.addProdct = new MetroFramework.Controls.MetroTile();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.metroPanel1.Controls.Add(this.chat);
            this.metroPanel1.Controls.Add(this.chkout);
            this.metroPanel1.Controls.Add(this.pending);
            this.metroPanel1.Controls.Add(this.chkin);
            this.metroPanel1.Controls.Add(this.delivered);
            this.metroPanel1.Controls.Add(this.prfl);
            this.metroPanel1.Controls.Add(this.addProdct);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(1, 6);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(216, 576);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseCustomForeColor = true;
            this.metroPanel1.UseStyleColors = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // chat
            // 
            this.chat.ActiveControl = null;
            this.chat.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chat.BackColor = System.Drawing.Color.SeaGreen;
            this.chat.Location = new System.Drawing.Point(0, 473);
            this.chat.Name = "chat";
            this.chat.Size = new System.Drawing.Size(219, 60);
            this.chat.TabIndex = 8;
            this.chat.Text = "Chat";
            this.chat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chat.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.chat.UseCustomBackColor = true;
            this.chat.UseSelectable = true;
            this.chat.Click += new System.EventHandler(this.chat_Click);
            // 
            // chkout
            // 
            this.chkout.ActiveControl = null;
            this.chkout.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkout.BackColor = System.Drawing.Color.SeaGreen;
            this.chkout.Location = new System.Drawing.Point(0, 290);
            this.chkout.Name = "chkout";
            this.chkout.Size = new System.Drawing.Size(219, 60);
            this.chkout.TabIndex = 7;
            this.chkout.Text = "Check Out";
            this.chkout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkout.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.chkout.UseCustomBackColor = true;
            this.chkout.UseSelectable = true;
            this.chkout.Click += new System.EventHandler(this.chkout_Click);
            // 
            // pending
            // 
            this.pending.ActiveControl = null;
            this.pending.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pending.BackColor = System.Drawing.Color.SeaGreen;
            this.pending.Location = new System.Drawing.Point(0, 349);
            this.pending.Name = "pending";
            this.pending.Size = new System.Drawing.Size(219, 67);
            this.pending.TabIndex = 5;
            this.pending.Text = "Pending Items";
            this.pending.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pending.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.pending.UseCustomBackColor = true;
            this.pending.UseSelectable = true;
            this.pending.Click += new System.EventHandler(this.pending_Click);
            // 
            // chkin
            // 
            this.chkin.ActiveControl = null;
            this.chkin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkin.BackColor = System.Drawing.Color.SeaGreen;
            this.chkin.Location = new System.Drawing.Point(0, 232);
            this.chkin.Name = "chkin";
            this.chkin.Size = new System.Drawing.Size(219, 60);
            this.chkin.TabIndex = 6;
            this.chkin.Text = "Check In";
            this.chkin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkin.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.chkin.UseCustomBackColor = true;
            this.chkin.UseSelectable = true;
            this.chkin.Click += new System.EventHandler(this.chkin_Click);
            // 
            // delivered
            // 
            this.delivered.ActiveControl = null;
            this.delivered.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.delivered.BackColor = System.Drawing.Color.SeaGreen;
            this.delivered.Location = new System.Drawing.Point(0, 415);
            this.delivered.Name = "delivered";
            this.delivered.Size = new System.Drawing.Size(219, 60);
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
            this.prfl.Location = new System.Drawing.Point(0, 172);
            this.prfl.Name = "prfl";
            this.prfl.Size = new System.Drawing.Size(219, 60);
            this.prfl.TabIndex = 3;
            this.prfl.Text = "Profile";
            this.prfl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.prfl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.prfl.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.prfl.UseCustomBackColor = true;
            this.prfl.UseSelectable = true;
            this.prfl.Click += new System.EventHandler(this.prfl_Click);
            // 
            // addProdct
            // 
            this.addProdct.ActiveControl = null;
            this.addProdct.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addProdct.BackColor = System.Drawing.Color.SeaGreen;
            this.addProdct.Location = new System.Drawing.Point(0, 113);
            this.addProdct.Name = "addProdct";
            this.addProdct.Size = new System.Drawing.Size(219, 60);
            this.addProdct.TabIndex = 2;
            this.addProdct.Text = "Add Product";
            this.addProdct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addProdct.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.addProdct.UseCustomBackColor = true;
            this.addProdct.UseSelectable = true;
            this.addProdct.Click += new System.EventHandler(this.addProdct_Click);
            // 
            // EmployeeRoutine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 583);
            this.Controls.Add(this.metroPanel1);
            this.Name = "EmployeeRoutine";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.routine_Load);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile chkout;
        private MetroFramework.Controls.MetroTile pending;
        private MetroFramework.Controls.MetroTile chkin;
        private MetroFramework.Controls.MetroTile delivered;
        private MetroFramework.Controls.MetroTile prfl;
        private MetroFramework.Controls.MetroTile addProdct;
        private MetroFramework.Controls.MetroTile chat;
    }
}