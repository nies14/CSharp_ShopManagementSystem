namespace Admin
{
    partial class EditAdminInfo
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
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroTile2.BackColor = System.Drawing.Color.SeaGreen;
            this.metroTile2.Location = new System.Drawing.Point(247, 707);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(105, 48);
            this.metroTile2.TabIndex = 18;
            this.metroTile2.Text = "Submit";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.UseCustomBackColor = true;
            this.metroTile2.UseSelectable = true;
            // 
            // EditAdminInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 765);
            this.Controls.Add(this.metroTile2);
            this.Name = "EditAdminInfo";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Controls.SetChildIndex(this.metroTile2, 0);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTile metroTile2;
    }
}

