namespace General_Journal
{
    partial class frmReport
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
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateStop = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtJournalNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCredit = new System.Windows.Forms.TextBox();
            this.txtDebit = new System.Windows.Forms.TextBox();
            this.lblGeneralJournal = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.GJ_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACC_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACC_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACC_DEBIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACC_CREDIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(408, 38);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(200, 20);
            this.dateStart.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "DateStart";
            // 
            // dateStop
            // 
            this.dateStop.Location = new System.Drawing.Point(408, 64);
            this.dateStop.Name = "dateStop";
            this.dateStop.Size = new System.Drawing.Size(200, 20);
            this.dateStop.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "DateStop";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GJ_DATE,
            this.DESCRIPTION,
            this.ACC_NAME,
            this.ACC_NO,
            this.ACC_DEBIT,
            this.ACC_CREDIT});
            this.dataGridView1.Location = new System.Drawing.Point(13, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(583, 333);
            this.dataGridView1.TabIndex = 7;
            // 
            // txtJournalNo
            // 
            this.txtJournalNo.Location = new System.Drawing.Point(408, 90);
            this.txtJournalNo.Name = "txtJournalNo";
            this.txtJournalNo.Size = new System.Drawing.Size(121, 20);
            this.txtJournalNo.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "general journal No.";
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(408, 116);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 18;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCredit);
            this.groupBox1.Controls.Add(this.txtDebit);
            this.groupBox1.Controls.Add(this.lblGeneralJournal);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.lblCompanyName);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 430);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "general journal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Total";
            // 
            // txtCredit
            // 
            this.txtCredit.Location = new System.Drawing.Point(497, 404);
            this.txtCredit.Name = "txtCredit";
            this.txtCredit.ReadOnly = true;
            this.txtCredit.Size = new System.Drawing.Size(99, 20);
            this.txtCredit.TabIndex = 20;
            // 
            // txtDebit
            // 
            this.txtDebit.Location = new System.Drawing.Point(392, 404);
            this.txtDebit.Name = "txtDebit";
            this.txtDebit.ReadOnly = true;
            this.txtDebit.Size = new System.Drawing.Size(99, 20);
            this.txtDebit.TabIndex = 19;
            // 
            // lblGeneralJournal
            // 
            this.lblGeneralJournal.AutoSize = true;
            this.lblGeneralJournal.Location = new System.Drawing.Point(223, 49);
            this.lblGeneralJournal.Name = "lblGeneralJournal";
            this.lblGeneralJournal.Size = new System.Drawing.Size(81, 13);
            this.lblGeneralJournal.TabIndex = 18;
            this.lblGeneralJournal.Text = "General Journal";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(223, 79);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 13);
            this.lblDate.TabIndex = 17;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(223, 16);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(50, 13);
            this.lblCompanyName.TabIndex = 16;
            this.lblCompanyName.Text = "company";
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Enabled = false;
            this.btnExportExcel.Location = new System.Drawing.Point(489, 116);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(75, 23);
            this.btnExportExcel.TabIndex = 20;
            this.btnExportExcel.Text = "Export Excel";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // GJ_DATE
            // 
            this.GJ_DATE.HeaderText = "DATE";
            this.GJ_DATE.Name = "GJ_DATE";
            this.GJ_DATE.ReadOnly = true;
            this.GJ_DATE.Width = 60;
            // 
            // DESCRIPTION
            // 
            this.DESCRIPTION.HeaderText = "DESCRIPTION";
            this.DESCRIPTION.Name = "DESCRIPTION";
            this.DESCRIPTION.ReadOnly = true;
            this.DESCRIPTION.Width = 180;
            // 
            // ACC_NAME
            // 
            this.ACC_NAME.HeaderText = "NAME";
            this.ACC_NAME.Name = "ACC_NAME";
            this.ACC_NAME.ReadOnly = true;
            // 
            // ACC_NO
            // 
            this.ACC_NO.FillWeight = 80F;
            this.ACC_NO.HeaderText = "AccountNo.";
            this.ACC_NO.Name = "ACC_NO";
            this.ACC_NO.ReadOnly = true;
            this.ACC_NO.Width = 80;
            // 
            // ACC_DEBIT
            // 
            this.ACC_DEBIT.HeaderText = "DEBIT";
            this.ACC_DEBIT.Name = "ACC_DEBIT";
            this.ACC_DEBIT.ReadOnly = true;
            this.ACC_DEBIT.Width = 60;
            // 
            // ACC_CREDIT
            // 
            this.ACC_CREDIT.HeaderText = "CREDIT";
            this.ACC_CREDIT.Name = "ACC_CREDIT";
            this.ACC_CREDIT.ReadOnly = true;
            this.ACC_CREDIT.Width = 60;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 600);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.txtJournalNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateStop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReport";
            this.Text = "frmReport";
            this.Load += new System.EventHandler(this.frmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateStop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtJournalNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblGeneralJournal;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.TextBox txtCredit;
        private System.Windows.Forms.TextBox txtDebit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn GJ_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACC_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACC_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACC_DEBIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACC_CREDIT;
    }
}