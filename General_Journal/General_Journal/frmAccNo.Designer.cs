namespace General_Journal
{
    partial class frmAccNo
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
            this.components = new System.ComponentModel.Container();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAccName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAccNo = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGAccNo = new System.Windows.Forms.DataGridView();
            this.aCCNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCCNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCCCATEGORYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountNoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.general_JournalDataSet = new General_Journal.General_JournalDataSet();
            this.accountNoTableAdapter = new General_Journal.General_JournalDataSetTableAdapters.accountNoTableAdapter();
            this.accountNoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGAccNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountNoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.general_JournalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountNoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Account No.";
            // 
            // txtAccName
            // 
            this.txtAccName.Location = new System.Drawing.Point(185, 123);
            this.txtAccName.Name = "txtAccName";
            this.txtAccName.Size = new System.Drawing.Size(121, 20);
            this.txtAccName.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Account Name";
            // 
            // txtAccNo
            // 
            this.txtAccNo.Location = new System.Drawing.Point(185, 78);
            this.txtAccNo.Name = "txtAccNo";
            this.txtAccNo.Size = new System.Drawing.Size(121, 20);
            this.txtAccNo.TabIndex = 8;
            this.txtAccNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAccNo_KeyPress);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(420, 76);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 22);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(420, 104);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(83, 22);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(420, 132);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 22);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "สินทรัพย์",
            "หนี้สิน",
            "ส่วนของเจ้าของ",
            "รายได้",
            "ค่าใช้จ่าย"});
            this.cmbCategory.Location = new System.Drawing.Point(185, 170);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(121, 21);
            this.cmbCategory.TabIndex = 19;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Account Category";
            // 
            // dataGAccNo
            // 
            this.dataGAccNo.AllowUserToAddRows = false;
            this.dataGAccNo.AllowUserToDeleteRows = false;
            this.dataGAccNo.AllowUserToOrderColumns = true;
            this.dataGAccNo.AutoGenerateColumns = false;
            this.dataGAccNo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGAccNo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aCCNODataGridViewTextBoxColumn,
            this.aCCNAMEDataGridViewTextBoxColumn,
            this.aCCCATEGORYDataGridViewTextBoxColumn});
            this.dataGAccNo.DataSource = this.accountNoBindingSource;
            this.dataGAccNo.Location = new System.Drawing.Point(74, 244);
            this.dataGAccNo.Name = "dataGAccNo";
            this.dataGAccNo.ReadOnly = true;
            this.dataGAccNo.Size = new System.Drawing.Size(493, 272);
            this.dataGAccNo.TabIndex = 20;
            // 
            // aCCNODataGridViewTextBoxColumn
            // 
            this.aCCNODataGridViewTextBoxColumn.DataPropertyName = "ACC_NO";
            this.aCCNODataGridViewTextBoxColumn.HeaderText = "เลขที่บัญชี";
            this.aCCNODataGridViewTextBoxColumn.Name = "aCCNODataGridViewTextBoxColumn";
            this.aCCNODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aCCNAMEDataGridViewTextBoxColumn
            // 
            this.aCCNAMEDataGridViewTextBoxColumn.DataPropertyName = "ACC_NAME";
            this.aCCNAMEDataGridViewTextBoxColumn.HeaderText = "ชื่อบัญชี";
            this.aCCNAMEDataGridViewTextBoxColumn.Name = "aCCNAMEDataGridViewTextBoxColumn";
            this.aCCNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.aCCNAMEDataGridViewTextBoxColumn.Width = 200;
            // 
            // aCCCATEGORYDataGridViewTextBoxColumn
            // 
            this.aCCCATEGORYDataGridViewTextBoxColumn.DataPropertyName = "ACC_CATEGORY";
            this.aCCCATEGORYDataGridViewTextBoxColumn.HeaderText = "หมวดหมู่";
            this.aCCCATEGORYDataGridViewTextBoxColumn.Name = "aCCCATEGORYDataGridViewTextBoxColumn";
            this.aCCCATEGORYDataGridViewTextBoxColumn.ReadOnly = true;
            this.aCCCATEGORYDataGridViewTextBoxColumn.Width = 150;
            // 
            // accountNoBindingSource
            // 
            this.accountNoBindingSource.DataMember = "accountNo";
            this.accountNoBindingSource.DataSource = this.general_JournalDataSet;
            // 
            // general_JournalDataSet
            // 
            this.general_JournalDataSet.DataSetName = "General_JournalDataSet";
            this.general_JournalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountNoTableAdapter
            // 
            this.accountNoTableAdapter.ClearBeforeFill = true;
            // 
            // accountNoBindingSource1
            // 
            this.accountNoBindingSource1.DataMember = "accountNo";
            this.accountNoBindingSource1.DataSource = this.general_JournalDataSet;
            // 
            // frmAccNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 600);
            this.ControlBox = false;
            this.Controls.Add(this.dataGAccNo);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAccName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAccNo);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAccNo";
            this.Text = "frmAccNo";
            this.Load += new System.EventHandler(this.frmAccNo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGAccNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountNoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.general_JournalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountNoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAccName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAccNo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGAccNo;
        private General_JournalDataSet general_JournalDataSet;
        private System.Windows.Forms.BindingSource accountNoBindingSource;
        private General_JournalDataSetTableAdapters.accountNoTableAdapter accountNoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCCNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCCNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCCCATEGORYDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource accountNoBindingSource1;
    }
}