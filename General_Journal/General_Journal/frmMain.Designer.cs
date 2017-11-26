namespace General_Journal
{
    partial class frmMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAutoAcc = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnJournal = new System.Windows.Forms.Button();
            this.btnAccNO = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblCompanyName);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 80);
            this.panel1.TabIndex = 0;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblCompanyName.Location = new System.Drawing.Point(277, 20);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(209, 31);
            this.lblCompanyName.TabIndex = 0;
            this.lblCompanyName.Text = "Company Name";
            this.lblCompanyName.Click += new System.EventHandler(this.lblCompanyName_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnAutoAcc);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnReport);
            this.panel2.Controls.Add(this.btnJournal);
            this.panel2.Controls.Add(this.btnAccNO);
            this.panel2.Location = new System.Drawing.Point(0, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 600);
            this.panel2.TabIndex = 1;
            // 
            // btnAutoAcc
            // 
            this.btnAutoAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnAutoAcc.Location = new System.Drawing.Point(3, 58);
            this.btnAutoAcc.Name = "btnAutoAcc";
            this.btnAutoAcc.Size = new System.Drawing.Size(137, 56);
            this.btnAutoAcc.TabIndex = 3;
            this.btnAutoAcc.Text = "Automatic account";
            this.btnAutoAcc.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnExit.Location = new System.Drawing.Point(3, 543);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(137, 56);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit program";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnReport.Location = new System.Drawing.Point(3, 168);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(137, 56);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // btnJournal
            // 
            this.btnJournal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnJournal.Location = new System.Drawing.Point(3, 113);
            this.btnJournal.Name = "btnJournal";
            this.btnJournal.Size = new System.Drawing.Size(137, 56);
            this.btnJournal.TabIndex = 1;
            this.btnJournal.Text = "General Journal";
            this.btnJournal.UseVisualStyleBackColor = true;
            // 
            // btnAccNO
            // 
            this.btnAccNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnAccNO.Location = new System.Drawing.Point(3, 3);
            this.btnAccNO.Name = "btnAccNO";
            this.btnAccNO.Size = new System.Drawing.Size(137, 56);
            this.btnAccNO.TabIndex = 0;
            this.btnAccNO.Text = "Account No.";
            this.btnAccNO.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Location = new System.Drawing.Point(144, 90);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(640, 600);
            this.panel3.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::General_Journal.Properties.Resources.bk2;
            this.ClientSize = new System.Drawing.Size(784, 711);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnJournal;
        private System.Windows.Forms.Button btnAccNO;
        private System.Windows.Forms.Button btnAutoAcc;
    }
}