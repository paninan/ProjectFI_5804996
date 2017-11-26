namespace General_Journal
{
    partial class frmCompany
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
            this.dataGCompany = new System.Windows.Forms.DataGridView();
            this.cOMPANYIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMPANYNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.general_JournalDataSet = new General_Journal.General_JournalDataSet();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new General_Journal.General_JournalDataSetTableAdapters.usersTableAdapter();
            this.companyTableAdapter = new General_Journal.General_JournalDataSetTableAdapters.companyTableAdapter();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.general_JournalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGCompany
            // 
            this.dataGCompany.AllowUserToAddRows = false;
            this.dataGCompany.AllowUserToDeleteRows = false;
            this.dataGCompany.AllowUserToOrderColumns = true;
            this.dataGCompany.AutoGenerateColumns = false;
            this.dataGCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGCompany.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cOMPANYIDDataGridViewTextBoxColumn,
            this.cOMPANYNAMEDataGridViewTextBoxColumn});
            this.dataGCompany.DataSource = this.companyBindingSource;
            this.dataGCompany.Location = new System.Drawing.Point(169, 147);
            this.dataGCompany.Name = "dataGCompany";
            this.dataGCompany.ReadOnly = true;
            this.dataGCompany.Size = new System.Drawing.Size(443, 237);
            this.dataGCompany.TabIndex = 0;
            this.dataGCompany.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGCmpany_RowHeaderMouseDoubleClick);
            // 
            // cOMPANYIDDataGridViewTextBoxColumn
            // 
            this.cOMPANYIDDataGridViewTextBoxColumn.DataPropertyName = "COMPANY_ID";
            this.cOMPANYIDDataGridViewTextBoxColumn.HeaderText = "COMPANY_ID";
            this.cOMPANYIDDataGridViewTextBoxColumn.Name = "cOMPANYIDDataGridViewTextBoxColumn";
            this.cOMPANYIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cOMPANYIDDataGridViewTextBoxColumn.Width = 200;
            // 
            // cOMPANYNAMEDataGridViewTextBoxColumn
            // 
            this.cOMPANYNAMEDataGridViewTextBoxColumn.DataPropertyName = "COMPANY_NAME";
            this.cOMPANYNAMEDataGridViewTextBoxColumn.HeaderText = "COMPANY_NAME";
            this.cOMPANYNAMEDataGridViewTextBoxColumn.Name = "cOMPANYNAMEDataGridViewTextBoxColumn";
            this.cOMPANYNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.cOMPANYNAMEDataGridViewTextBoxColumn.Width = 200;
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataMember = "company";
            this.companyBindingSource.DataSource = this.general_JournalDataSet;
            // 
            // general_JournalDataSet
            // 
            this.general_JournalDataSet.DataSetName = "General_JournalDataSet";
            this.general_JournalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(367, 390);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(452, 390);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(537, 390);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(661, 643);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Choose company";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.general_JournalDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // companyTableAdapter
            // 
            this.companyTableAdapter.ClearBeforeFill = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(169, 390);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 711);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGCompany);
            this.Name = "frmCompany";
            this.Text = "Company";
            this.Load += new System.EventHandler(this.frmCompany_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.general_JournalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGCompany;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private General_JournalDataSet general_JournalDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private General_JournalDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private General_JournalDataSetTableAdapters.companyTableAdapter companyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOMPANYIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOMPANYNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnRefresh;
    }
}