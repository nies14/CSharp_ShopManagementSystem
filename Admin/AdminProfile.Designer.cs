namespace Admin
{
    partial class AdminProfile
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
            this.done = new MetroFramework.Controls.MetroTile();
            this.edit = new MetroFramework.Controls.MetroTile();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // done
            // 
            this.done.ActiveControl = null;
            this.done.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.done.BackColor = System.Drawing.Color.SeaGreen;
            this.done.Location = new System.Drawing.Point(170, 666);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(107, 36);
            this.done.TabIndex = 135;
            this.done.Text = "Done";
            this.done.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.done.UseCustomBackColor = true;
            this.done.UseSelectable = true;
            this.done.Click += new System.EventHandler(this.done_Click);
            // 
            // edit
            // 
            this.edit.ActiveControl = null;
            this.edit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edit.BackColor = System.Drawing.Color.SeaGreen;
            this.edit.Location = new System.Drawing.Point(324, 666);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(109, 36);
            this.edit.TabIndex = 136;
            this.edit.Text = "Edit";
            this.edit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.edit.UseCustomBackColor = true;
            this.edit.UseSelectable = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(547, 365);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(41, 150);
            this.dataGridView1.TabIndex = 137;
            this.dataGridView1.Visible = false;
            // 
            // AdminProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 738);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.done);
            this.Name = "AdminProfile";
            this.Load += new System.EventHandler(this.AdminProfile_Load);
            this.Controls.SetChildIndex(this.done, 0);
            this.Controls.SetChildIndex(this.edit, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile done;
        private MetroFramework.Controls.MetroTile edit;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}