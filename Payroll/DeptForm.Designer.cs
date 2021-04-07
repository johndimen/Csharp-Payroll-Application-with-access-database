namespace Payroll
{
    partial class DeptForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeptForm));
            this.BackButton = new System.Windows.Forms.Button();
            this.DeptLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeptDataGridView = new System.Windows.Forms.DataGridView();
            this.payroll_dept_DataSet1 = new Payroll.payroll_dept_DataSet();
            this.deptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deptTableAdapter1 = new Payroll.payroll_dept_DataSetTableAdapters.deptTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DeptDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payroll_dept_DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deptBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(255, 199);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // DeptLabel
            // 
            this.DeptLabel.AutoSize = true;
            this.DeptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeptLabel.Location = new System.Drawing.Point(114, 9);
            this.DeptLabel.Name = "DeptLabel";
            this.DeptLabel.Size = new System.Drawing.Size(133, 25);
            this.DeptLabel.TabIndex = 1;
            this.DeptLabel.Text = "Department";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(12, 199);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeptDataGridView
            // 
            this.DeptDataGridView.AllowUserToAddRows = false;
            this.DeptDataGridView.AllowUserToDeleteRows = false;
            this.DeptDataGridView.AutoGenerateColumns = false;
            this.DeptDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeptDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.DeptDataGridView.DataSource = this.deptBindingSource;
            this.DeptDataGridView.Location = new System.Drawing.Point(41, 43);
            this.DeptDataGridView.Name = "DeptDataGridView";
            this.DeptDataGridView.ReadOnly = true;
            this.DeptDataGridView.Size = new System.Drawing.Size(255, 150);
            this.DeptDataGridView.TabIndex = 6;
            // 
            // payroll_dept_DataSet1
            // 
            this.payroll_dept_DataSet1.DataSetName = "payroll_dept_DataSet";
            this.payroll_dept_DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deptBindingSource
            // 
            this.deptBindingSource.DataMember = "dept";
            this.deptBindingSource.DataSource = this.payroll_dept_DataSet1;
            // 
            // deptTableAdapter1
            // 
            this.deptTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "dept";
            this.dataGridViewTextBoxColumn2.HeaderText = "Department Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 155;
            // 
            // DeptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 234);
            this.Controls.Add(this.DeptDataGridView);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.DeptLabel);
            this.Controls.Add(this.BackButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeptForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.DeptForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DeptDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payroll_dept_DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deptBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label DeptLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridView DeptDataGridView;
        private payroll_dept_DataSet payroll_dept_DataSet1;
        private System.Windows.Forms.BindingSource deptBindingSource;
        private payroll_dept_DataSetTableAdapters.deptTableAdapter deptTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}