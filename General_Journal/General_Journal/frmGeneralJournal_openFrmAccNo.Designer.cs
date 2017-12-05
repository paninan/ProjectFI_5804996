namespace General_Journal
{
    partial class frmGeneralJournal_openFrmAccNo
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
            this.dataGaccNo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGaccNo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGaccNo
            // 
            this.dataGaccNo.AllowUserToAddRows = false;
            this.dataGaccNo.AllowUserToDeleteRows = false;
            this.dataGaccNo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGaccNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGaccNo.Location = new System.Drawing.Point(0, 0);
            this.dataGaccNo.Name = "dataGaccNo";
            this.dataGaccNo.ReadOnly = true;
            this.dataGaccNo.Size = new System.Drawing.Size(355, 380);
            this.dataGaccNo.TabIndex = 0;
            this.dataGaccNo.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // frmGeneralJournal_openFrmAccNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 380);
            this.Controls.Add(this.dataGaccNo);
            this.Name = "frmGeneralJournal_openFrmAccNo";
            this.Text = "Account No.";
            this.Load += new System.EventHandler(this.frmGeneralJournal_openFrmAccNo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGaccNo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGaccNo;
    }
}