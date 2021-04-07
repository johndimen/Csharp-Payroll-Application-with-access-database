
namespace Payroll
{
    partial class Record
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Record));
            this.recordlbl = new System.Windows.Forms.Label();
            this.tabRecord = new System.Windows.Forms.TabControl();
            this.employeeTab = new System.Windows.Forms.TabPage();
            this.empgeneratebtn = new System.Windows.Forms.Button();
            this.empDataGridView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.payroll_Employee_DataSet = new Payroll.payroll_Employee_DataSet();
            this.tabAudit = new System.Windows.Forms.TabPage();
            this.auditgeneratebtn = new System.Windows.Forms.Button();
            this.auditDataGridView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accesstimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.audittrailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.payroll_Audittrail_DataSet = new Payroll.payroll_Audittrail_DataSet();
            this.backbtn = new System.Windows.Forms.Button();
            this.audittrailTableAdapter = new Payroll.payroll_Audittrail_DataSetTableAdapters.audittrailTableAdapter();
            this.employeeTableAdapter = new Payroll.payroll_Employee_DataSetTableAdapters.employeeTableAdapter();
            this.tabRecord.SuspendLayout();
            this.employeeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payroll_Employee_DataSet)).BeginInit();
            this.tabAudit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.auditDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.audittrailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payroll_Audittrail_DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // recordlbl
            // 
            this.recordlbl.AutoSize = true;
            this.recordlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordlbl.Location = new System.Drawing.Point(13, 12);
            this.recordlbl.Name = "recordlbl";
            this.recordlbl.Size = new System.Drawing.Size(61, 20);
            this.recordlbl.TabIndex = 1;
            this.recordlbl.Text = "Record";
            // 
            // tabRecord
            // 
            this.tabRecord.Controls.Add(this.employeeTab);
            this.tabRecord.Controls.Add(this.tabAudit);
            this.tabRecord.Location = new System.Drawing.Point(12, 35);
            this.tabRecord.Name = "tabRecord";
            this.tabRecord.SelectedIndex = 0;
            this.tabRecord.Size = new System.Drawing.Size(477, 241);
            this.tabRecord.TabIndex = 2;
            // 
            // employeeTab
            // 
            this.employeeTab.Controls.Add(this.empgeneratebtn);
            this.employeeTab.Controls.Add(this.empDataGridView);
            this.employeeTab.Location = new System.Drawing.Point(4, 22);
            this.employeeTab.Name = "employeeTab";
            this.employeeTab.Padding = new System.Windows.Forms.Padding(3);
            this.employeeTab.Size = new System.Drawing.Size(469, 215);
            this.employeeTab.TabIndex = 0;
            this.employeeTab.Text = "Employee Record";
            this.employeeTab.UseVisualStyleBackColor = true;
            // 
            // empgeneratebtn
            // 
            this.empgeneratebtn.Location = new System.Drawing.Point(371, 185);
            this.empgeneratebtn.Name = "empgeneratebtn";
            this.empgeneratebtn.Size = new System.Drawing.Size(92, 24);
            this.empgeneratebtn.TabIndex = 6;
            this.empgeneratebtn.Text = "Generate";
            this.empgeneratebtn.UseVisualStyleBackColor = true;
            this.empgeneratebtn.Click += new System.EventHandler(this.Empgeneratebtn_Click);
            // 
            // empDataGridView
            // 
            this.empDataGridView.AllowUserToAddRows = false;
            this.empDataGridView.AllowUserToDeleteRows = false;
            this.empDataGridView.AutoGenerateColumns = false;
            this.empDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.empidDataGridViewTextBoxColumn,
            this.empnameDataGridViewTextBoxColumn,
            this.deptDataGridViewTextBoxColumn});
            this.empDataGridView.DataSource = this.employeeBindingSource;
            this.empDataGridView.Location = new System.Drawing.Point(3, 6);
            this.empDataGridView.Name = "empDataGridView";
            this.empDataGridView.ReadOnly = true;
            this.empDataGridView.Size = new System.Drawing.Size(460, 173);
            this.empDataGridView.TabIndex = 3;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn1.Width = 30;
            // 
            // empidDataGridViewTextBoxColumn
            // 
            this.empidDataGridViewTextBoxColumn.DataPropertyName = "empid";
            this.empidDataGridViewTextBoxColumn.HeaderText = "Employee ID";
            this.empidDataGridViewTextBoxColumn.Name = "empidDataGridViewTextBoxColumn";
            this.empidDataGridViewTextBoxColumn.ReadOnly = true;
            this.empidDataGridViewTextBoxColumn.Width = 120;
            // 
            // empnameDataGridViewTextBoxColumn
            // 
            this.empnameDataGridViewTextBoxColumn.DataPropertyName = "empname";
            this.empnameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.empnameDataGridViewTextBoxColumn.Name = "empnameDataGridViewTextBoxColumn";
            this.empnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.empnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // deptDataGridViewTextBoxColumn
            // 
            this.deptDataGridViewTextBoxColumn.DataPropertyName = "dept";
            this.deptDataGridViewTextBoxColumn.HeaderText = "Department";
            this.deptDataGridViewTextBoxColumn.Name = "deptDataGridViewTextBoxColumn";
            this.deptDataGridViewTextBoxColumn.ReadOnly = true;
            this.deptDataGridViewTextBoxColumn.Width = 97;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "employee";
            this.employeeBindingSource.DataSource = this.payroll_Employee_DataSet;
            // 
            // payroll_Employee_DataSet
            // 
            this.payroll_Employee_DataSet.DataSetName = "payroll_Employee_DataSet";
            this.payroll_Employee_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabAudit
            // 
            this.tabAudit.Controls.Add(this.auditgeneratebtn);
            this.tabAudit.Controls.Add(this.auditDataGridView);
            this.tabAudit.Location = new System.Drawing.Point(4, 22);
            this.tabAudit.Name = "tabAudit";
            this.tabAudit.Padding = new System.Windows.Forms.Padding(3);
            this.tabAudit.Size = new System.Drawing.Size(469, 215);
            this.tabAudit.TabIndex = 1;
            this.tabAudit.Text = "Audit Trail";
            this.tabAudit.UseVisualStyleBackColor = true;
            // 
            // auditgeneratebtn
            // 
            this.auditgeneratebtn.Location = new System.Drawing.Point(371, 185);
            this.auditgeneratebtn.Name = "auditgeneratebtn";
            this.auditgeneratebtn.Size = new System.Drawing.Size(92, 24);
            this.auditgeneratebtn.TabIndex = 10;
            this.auditgeneratebtn.Text = "Generate";
            this.auditgeneratebtn.UseVisualStyleBackColor = true;
            this.auditgeneratebtn.Click += new System.EventHandler(this.Auditgeneratebtn_Click);
            // 
            // auditDataGridView
            // 
            this.auditDataGridView.AllowUserToAddRows = false;
            this.auditDataGridView.AllowUserToDeleteRows = false;
            this.auditDataGridView.AutoGenerateColumns = false;
            this.auditDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.auditDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.adminnameDataGridViewTextBoxColumn,
            this.actionDataGridViewTextBoxColumn,
            this.tablenameDataGridViewTextBoxColumn,
            this.accesstimeDataGridViewTextBoxColumn});
            this.auditDataGridView.DataSource = this.audittrailBindingSource;
            this.auditDataGridView.Location = new System.Drawing.Point(3, 6);
            this.auditDataGridView.Name = "auditDataGridView";
            this.auditDataGridView.ReadOnly = true;
            this.auditDataGridView.Size = new System.Drawing.Size(460, 173);
            this.auditDataGridView.TabIndex = 2;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 30;
            // 
            // adminnameDataGridViewTextBoxColumn
            // 
            this.adminnameDataGridViewTextBoxColumn.DataPropertyName = "adminname";
            this.adminnameDataGridViewTextBoxColumn.HeaderText = "User Name";
            this.adminnameDataGridViewTextBoxColumn.Name = "adminnameDataGridViewTextBoxColumn";
            this.adminnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // actionDataGridViewTextBoxColumn
            // 
            this.actionDataGridViewTextBoxColumn.DataPropertyName = "action";
            this.actionDataGridViewTextBoxColumn.HeaderText = "Action Taken";
            this.actionDataGridViewTextBoxColumn.Name = "actionDataGridViewTextBoxColumn";
            this.actionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tablenameDataGridViewTextBoxColumn
            // 
            this.tablenameDataGridViewTextBoxColumn.DataPropertyName = "tablename";
            this.tablenameDataGridViewTextBoxColumn.HeaderText = "Table";
            this.tablenameDataGridViewTextBoxColumn.Name = "tablenameDataGridViewTextBoxColumn";
            this.tablenameDataGridViewTextBoxColumn.ReadOnly = true;
            this.tablenameDataGridViewTextBoxColumn.Width = 75;
            // 
            // accesstimeDataGridViewTextBoxColumn
            // 
            this.accesstimeDataGridViewTextBoxColumn.DataPropertyName = "accesstime";
            this.accesstimeDataGridViewTextBoxColumn.HeaderText = "Time of Access";
            this.accesstimeDataGridViewTextBoxColumn.Name = "accesstimeDataGridViewTextBoxColumn";
            this.accesstimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.accesstimeDataGridViewTextBoxColumn.Width = 110;
            // 
            // audittrailBindingSource
            // 
            this.audittrailBindingSource.DataMember = "audittrail";
            this.audittrailBindingSource.DataSource = this.payroll_Audittrail_DataSet;
            // 
            // payroll_Audittrail_DataSet
            // 
            this.payroll_Audittrail_DataSet.DataSetName = "payroll_Audittrail_DataSet";
            this.payroll_Audittrail_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(407, 12);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(75, 23);
            this.backbtn.TabIndex = 1;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // audittrailTableAdapter
            // 
            this.audittrailTableAdapter.ClearBeforeFill = true;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 288);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.tabRecord);
            this.Controls.Add(this.recordlbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Record";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Record";
            this.Load += new System.EventHandler(this.Record_Load);
            this.tabRecord.ResumeLayout(false);
            this.employeeTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.empDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payroll_Employee_DataSet)).EndInit();
            this.tabAudit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.auditDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.audittrailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payroll_Audittrail_DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label recordlbl;
        private System.Windows.Forms.TabControl tabRecord;
        private System.Windows.Forms.TabPage employeeTab;
        private System.Windows.Forms.DataGridView empDataGridView;
        private System.Windows.Forms.TabPage tabAudit;
        private System.Windows.Forms.DataGridView auditDataGridView;
        private System.Windows.Forms.Button backbtn;
        private payroll_Audittrail_DataSet payroll_Audittrail_DataSet;
        private System.Windows.Forms.BindingSource audittrailBindingSource;
        private payroll_Audittrail_DataSetTableAdapters.audittrailTableAdapter audittrailTableAdapter;
        private payroll_Employee_DataSet payroll_Employee_DataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private payroll_Employee_DataSetTableAdapters.employeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn empidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tablenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accesstimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button empgeneratebtn;
        private System.Windows.Forms.Button auditgeneratebtn;
    }
}