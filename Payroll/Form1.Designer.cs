namespace Payroll
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.WeekChooser = new System.Windows.Forms.NumericUpDown();
            this.PayDateLabel = new System.Windows.Forms.Label();
            this.WeekLabel = new System.Windows.Forms.Label();
            this.EmployeeNameLabel = new System.Windows.Forms.Label();
            this.DepartmentLabel = new System.Windows.Forms.Label();
            this.HoursLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.GrossPayLabel = new System.Windows.Forms.Label();
            this.DeductionsLabel = new System.Windows.Forms.Label();
            this.NetPayLabel = new System.Windows.Forms.Label();
            this.CalcButton = new System.Windows.Forms.Button();
            this.FolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.DirectoryText = new System.Windows.Forms.TextBox();
            this.GenInvoice = new System.Windows.Forms.Button();
            this.SaveFile = new System.Windows.Forms.SaveFileDialog();
            this.HoursWorked = new System.Windows.Forms.NumericUpDown();
            this.FormTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.EmptyError = new System.Windows.Forms.Label();
            this.InvoicesButton = new System.Windows.Forms.Button();
            this.MandarinLabel = new System.Windows.Forms.Label();
            this.DeptButton = new System.Windows.Forms.Button();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.ChooseDirectory = new System.Windows.Forms.Button();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.payroll_Emp_DataSet = new Payroll.payroll_Emp_DataSet();
            this.EmployeeNameText = new System.Windows.Forms.TextBox();
            this.DepartmentText = new System.Windows.Forms.ComboBox();
            this.deptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.payroll_Dept_DataSet = new Payroll.Payroll_Dept_DataSet();
            this.departmentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.deptTableAdapter = new Payroll.Payroll_Dept_DataSetTableAdapters.deptTableAdapter();
            this.employeeTableAdapter = new Payroll.payroll_Emp_DataSetTableAdapters.employeeTableAdapter();
            this.empidtxt = new System.Windows.Forms.TextBox();
            this.empnotxt = new System.Windows.Forms.Label();
            this.adminlbl = new System.Windows.Forms.Label();
            this.adminlabel = new System.Windows.Forms.Label();
            this.GrossPayText = new System.Windows.Forms.Label();
            this.DeductionsText = new System.Windows.Forms.Label();
            this.NetPayText = new System.Windows.Forms.Label();
            this.recordbtn = new System.Windows.Forms.Button();
            this.optionBox = new System.Windows.Forms.GroupBox();
            this.EmptyError1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WeekChooser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoursWorked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payroll_Emp_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payroll_Dept_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(95, 200);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(199, 20);
            this.DatePicker.TabIndex = 0;
            // 
            // WeekChooser
            // 
            this.WeekChooser.Location = new System.Drawing.Point(95, 226);
            this.WeekChooser.Maximum = new decimal(new int[] {
            52,
            0,
            0,
            0});
            this.WeekChooser.Name = "WeekChooser";
            this.WeekChooser.Size = new System.Drawing.Size(135, 20);
            this.WeekChooser.TabIndex = 5;
            this.WeekChooser.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.WeekChooser.Click += new System.EventHandler(this.WeekChooser_Click);
            // 
            // PayDateLabel
            // 
            this.PayDateLabel.AutoSize = true;
            this.PayDateLabel.Location = new System.Drawing.Point(14, 204);
            this.PayDateLabel.Name = "PayDateLabel";
            this.PayDateLabel.Size = new System.Drawing.Size(51, 13);
            this.PayDateLabel.TabIndex = 6;
            this.PayDateLabel.Text = "Pay Date";
            // 
            // WeekLabel
            // 
            this.WeekLabel.AutoSize = true;
            this.WeekLabel.Location = new System.Drawing.Point(13, 228);
            this.WeekLabel.Name = "WeekLabel";
            this.WeekLabel.Size = new System.Drawing.Size(36, 13);
            this.WeekLabel.TabIndex = 7;
            this.WeekLabel.Text = "Week";
            // 
            // EmployeeNameLabel
            // 
            this.EmployeeNameLabel.AutoSize = true;
            this.EmployeeNameLabel.Location = new System.Drawing.Point(16, 130);
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            this.EmployeeNameLabel.Size = new System.Drawing.Size(35, 13);
            this.EmployeeNameLabel.TabIndex = 8;
            this.EmployeeNameLabel.Text = "Name";
            // 
            // DepartmentLabel
            // 
            this.DepartmentLabel.AutoSize = true;
            this.DepartmentLabel.Location = new System.Drawing.Point(14, 77);
            this.DepartmentLabel.Name = "DepartmentLabel";
            this.DepartmentLabel.Size = new System.Drawing.Size(62, 13);
            this.DepartmentLabel.TabIndex = 9;
            this.DepartmentLabel.Text = "Department";
            // 
            // HoursLabel
            // 
            this.HoursLabel.AutoSize = true;
            this.HoursLabel.Location = new System.Drawing.Point(14, 254);
            this.HoursLabel.Name = "HoursLabel";
            this.HoursLabel.Size = new System.Drawing.Size(76, 13);
            this.HoursLabel.TabIndex = 10;
            this.HoursLabel.Text = "Hours Worked";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(628, 384);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 12;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(52, 299);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 13;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // GrossPayLabel
            // 
            this.GrossPayLabel.AutoSize = true;
            this.GrossPayLabel.Location = new System.Drawing.Point(72, 338);
            this.GrossPayLabel.Name = "GrossPayLabel";
            this.GrossPayLabel.Size = new System.Drawing.Size(55, 13);
            this.GrossPayLabel.TabIndex = 14;
            this.GrossPayLabel.Text = "Gross Pay";
            // 
            // DeductionsLabel
            // 
            this.DeductionsLabel.AutoSize = true;
            this.DeductionsLabel.Location = new System.Drawing.Point(66, 374);
            this.DeductionsLabel.Name = "DeductionsLabel";
            this.DeductionsLabel.Size = new System.Drawing.Size(61, 13);
            this.DeductionsLabel.TabIndex = 16;
            this.DeductionsLabel.Text = "Deductions";
            // 
            // NetPayLabel
            // 
            this.NetPayLabel.AutoSize = true;
            this.NetPayLabel.Location = new System.Drawing.Point(82, 408);
            this.NetPayLabel.Name = "NetPayLabel";
            this.NetPayLabel.Size = new System.Drawing.Size(45, 13);
            this.NetPayLabel.TabIndex = 18;
            this.NetPayLabel.Text = "Net Pay";
            // 
            // CalcButton
            // 
            this.CalcButton.Location = new System.Drawing.Point(198, 299);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(75, 23);
            this.CalcButton.TabIndex = 20;
            this.CalcButton.Text = "Calculate";
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // DirectoryText
            // 
            this.DirectoryText.Location = new System.Drawing.Point(426, 295);
            this.DirectoryText.Name = "DirectoryText";
            this.DirectoryText.Size = new System.Drawing.Size(172, 20);
            this.DirectoryText.TabIndex = 22;
            this.DirectoryText.Text = "Select Directory";
            // 
            // GenInvoice
            // 
            this.GenInvoice.Enabled = false;
            this.GenInvoice.Location = new System.Drawing.Point(111, 437);
            this.GenInvoice.Name = "GenInvoice";
            this.GenInvoice.Size = new System.Drawing.Size(104, 23);
            this.GenInvoice.TabIndex = 23;
            this.GenInvoice.Text = "Generate Invoice";
            this.GenInvoice.UseVisualStyleBackColor = true;
            this.GenInvoice.Click += new System.EventHandler(this.GenInvoice_Click);
            // 
            // HoursWorked
            // 
            this.HoursWorked.Location = new System.Drawing.Point(95, 252);
            this.HoursWorked.Maximum = new decimal(new int[] {
            8760,
            0,
            0,
            0});
            this.HoursWorked.Name = "HoursWorked";
            this.HoursWorked.Size = new System.Drawing.Size(135, 20);
            this.HoursWorked.TabIndex = 24;
            this.HoursWorked.Click += new System.EventHandler(this.HoursWorked_Click);
            // 
            // FormTitle
            // 
            this.FormTitle.AutoSize = true;
            this.FormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormTitle.Location = new System.Drawing.Point(401, 34);
            this.FormTitle.Name = "FormTitle";
            this.FormTitle.Size = new System.Drawing.Size(271, 39);
            this.FormTitle.TabIndex = 25;
            this.FormTitle.Text = "iTec-Ming-Ming";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Employee Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "Pay Details";
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(628, 355);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(75, 23);
            this.LogoutButton.TabIndex = 29;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // EmptyError
            // 
            this.EmptyError.AutoSize = true;
            this.EmptyError.BackColor = System.Drawing.SystemColors.Control;
            this.EmptyError.ForeColor = System.Drawing.Color.Red;
            this.EmptyError.Location = new System.Drawing.Point(82, 150);
            this.EmptyError.Name = "EmptyError";
            this.EmptyError.Size = new System.Drawing.Size(111, 13);
            this.EmptyError.TabIndex = 30;
            this.EmptyError.Text = "There are empty fields";
            this.EmptyError.Visible = false;
            // 
            // InvoicesButton
            // 
            this.InvoicesButton.Location = new System.Drawing.Point(364, 355);
            this.InvoicesButton.Name = "InvoicesButton";
            this.InvoicesButton.Size = new System.Drawing.Size(75, 23);
            this.InvoicesButton.TabIndex = 31;
            this.InvoicesButton.Text = "Invoices";
            this.InvoicesButton.UseVisualStyleBackColor = true;
            this.InvoicesButton.Click += new System.EventHandler(this.InvoicesButton_Click);
            // 
            // MandarinLabel
            // 
            this.MandarinLabel.AutoSize = true;
            this.MandarinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MandarinLabel.Location = new System.Drawing.Point(493, 73);
            this.MandarinLabel.Name = "MandarinLabel";
            this.MandarinLabel.Size = new System.Drawing.Size(78, 25);
            this.MandarinLabel.TabIndex = 32;
            this.MandarinLabel.Text = "伊泰明";
            // 
            // DeptButton
            // 
            this.DeptButton.Location = new System.Drawing.Point(498, 355);
            this.DeptButton.Name = "DeptButton";
            this.DeptButton.Size = new System.Drawing.Size(75, 23);
            this.DeptButton.TabIndex = 33;
            this.DeptButton.Text = "Department";
            this.DeptButton.UseVisualStyleBackColor = true;
            this.DeptButton.Click += new System.EventHandler(this.DeptButton_Click);
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoPictureBox.Image")));
            this.LogoPictureBox.Location = new System.Drawing.Point(354, 139);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(359, 114);
            this.LogoPictureBox.TabIndex = 28;
            this.LogoPictureBox.TabStop = false;
            // 
            // ChooseDirectory
            // 
            this.ChooseDirectory.BackgroundImage = global::Payroll.Properties.Resources.download;
            this.ChooseDirectory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ChooseDirectory.Image = global::Payroll.Properties.Resources.download_LEp_icon;
            this.ChooseDirectory.Location = new System.Drawing.Point(604, 287);
            this.ChooseDirectory.Name = "ChooseDirectory";
            this.ChooseDirectory.Size = new System.Drawing.Size(32, 34);
            this.ChooseDirectory.TabIndex = 21;
            this.ChooseDirectory.UseVisualStyleBackColor = true;
            this.ChooseDirectory.Click += new System.EventHandler(this.ChooseDirectory_Click);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "employee";
            this.employeeBindingSource.DataSource = this.payroll_Emp_DataSet;
            // 
            // payroll_Emp_DataSet
            // 
            this.payroll_Emp_DataSet.DataSetName = "payroll_Emp_DataSet";
            this.payroll_Emp_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EmployeeNameText
            // 
            this.EmployeeNameText.Location = new System.Drawing.Point(83, 127);
            this.EmployeeNameText.Name = "EmployeeNameText";
            this.EmployeeNameText.Size = new System.Drawing.Size(202, 20);
            this.EmployeeNameText.TabIndex = 2;
            this.EmployeeNameText.Click += new System.EventHandler(this.EmployeeNameText_Click);
            // 
            // DepartmentText
            // 
            this.DepartmentText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.DepartmentText.DataSource = this.deptBindingSource;
            this.DepartmentText.DisplayMember = "dept";
            this.DepartmentText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DepartmentText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DepartmentText.FormattingEnabled = true;
            this.DepartmentText.Location = new System.Drawing.Point(83, 74);
            this.DepartmentText.Name = "DepartmentText";
            this.DepartmentText.Size = new System.Drawing.Size(202, 21);
            this.DepartmentText.TabIndex = 35;
            this.DepartmentText.ValueMember = "ID";
            // 
            // deptBindingSource
            // 
            this.deptBindingSource.DataMember = "dept";
            this.deptBindingSource.DataSource = this.payroll_Dept_DataSet;
            // 
            // payroll_Dept_DataSet
            // 
            this.payroll_Dept_DataSet.DataSetName = "Payroll_Dept_DataSet";
            this.payroll_Dept_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentBindingSource1
            // 
            this.departmentBindingSource1.DataMember = "department";
            // 
            // deptTableAdapter
            // 
            this.deptTableAdapter.ClearBeforeFill = true;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // empidtxt
            // 
            this.empidtxt.Location = new System.Drawing.Point(83, 101);
            this.empidtxt.Name = "empidtxt";
            this.empidtxt.Size = new System.Drawing.Size(202, 20);
            this.empidtxt.TabIndex = 36;
            this.empidtxt.Click += new System.EventHandler(this.Empidtxt_Click);
            // 
            // empnotxt
            // 
            this.empnotxt.AutoSize = true;
            this.empnotxt.Location = new System.Drawing.Point(16, 104);
            this.empnotxt.Name = "empnotxt";
            this.empnotxt.Size = new System.Drawing.Size(28, 13);
            this.empnotxt.TabIndex = 37;
            this.empnotxt.Text = "ID #";
            // 
            // adminlbl
            // 
            this.adminlbl.AutoSize = true;
            this.adminlbl.Location = new System.Drawing.Point(13, 9);
            this.adminlbl.Name = "adminlbl";
            this.adminlbl.Size = new System.Drawing.Size(32, 13);
            this.adminlbl.TabIndex = 38;
            this.adminlbl.Text = "User:";
            // 
            // adminlabel
            // 
            this.adminlabel.AutoSize = true;
            this.adminlabel.Location = new System.Drawing.Point(55, 9);
            this.adminlabel.Name = "adminlabel";
            this.adminlabel.Size = new System.Drawing.Size(0, 13);
            this.adminlabel.TabIndex = 39;
            // 
            // GrossPayText
            // 
            this.GrossPayText.AutoSize = true;
            this.GrossPayText.Location = new System.Drawing.Point(130, 338);
            this.GrossPayText.Name = "GrossPayText";
            this.GrossPayText.Size = new System.Drawing.Size(0, 13);
            this.GrossPayText.TabIndex = 41;
            // 
            // DeductionsText
            // 
            this.DeductionsText.AutoSize = true;
            this.DeductionsText.Location = new System.Drawing.Point(130, 374);
            this.DeductionsText.Name = "DeductionsText";
            this.DeductionsText.Size = new System.Drawing.Size(0, 13);
            this.DeductionsText.TabIndex = 42;
            // 
            // NetPayText
            // 
            this.NetPayText.AutoSize = true;
            this.NetPayText.Location = new System.Drawing.Point(130, 408);
            this.NetPayText.Name = "NetPayText";
            this.NetPayText.Size = new System.Drawing.Size(0, 13);
            this.NetPayText.TabIndex = 43;
            // 
            // recordbtn
            // 
            this.recordbtn.Location = new System.Drawing.Point(498, 384);
            this.recordbtn.Name = "recordbtn";
            this.recordbtn.Size = new System.Drawing.Size(75, 23);
            this.recordbtn.TabIndex = 44;
            this.recordbtn.Text = "Record";
            this.recordbtn.UseVisualStyleBackColor = true;
            this.recordbtn.Click += new System.EventHandler(this.Recordbtn_Click);
            // 
            // optionBox
            // 
            this.optionBox.Location = new System.Drawing.Point(354, 329);
            this.optionBox.Name = "optionBox";
            this.optionBox.Size = new System.Drawing.Size(359, 100);
            this.optionBox.TabIndex = 45;
            this.optionBox.TabStop = false;
            this.optionBox.Text = "Options";
            // 
            // EmptyError1
            // 
            this.EmptyError1.AutoSize = true;
            this.EmptyError1.BackColor = System.Drawing.SystemColors.Control;
            this.EmptyError1.ForeColor = System.Drawing.Color.Red;
            this.EmptyError1.Location = new System.Drawing.Point(104, 277);
            this.EmptyError1.Name = "EmptyError1";
            this.EmptyError1.Size = new System.Drawing.Size(111, 13);
            this.EmptyError1.TabIndex = 46;
            this.EmptyError1.Text = "There are empty fields";
            this.EmptyError1.Visible = false;
            // 
            // Form1
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(725, 472);
            this.Controls.Add(this.EmptyError1);
            this.Controls.Add(this.recordbtn);
            this.Controls.Add(this.NetPayText);
            this.Controls.Add(this.DeductionsText);
            this.Controls.Add(this.GrossPayText);
            this.Controls.Add(this.adminlabel);
            this.Controls.Add(this.adminlbl);
            this.Controls.Add(this.empnotxt);
            this.Controls.Add(this.empidtxt);
            this.Controls.Add(this.DepartmentText);
            this.Controls.Add(this.DeptButton);
            this.Controls.Add(this.MandarinLabel);
            this.Controls.Add(this.InvoicesButton);
            this.Controls.Add(this.EmptyError);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.LogoPictureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FormTitle);
            this.Controls.Add(this.HoursWorked);
            this.Controls.Add(this.GenInvoice);
            this.Controls.Add(this.DirectoryText);
            this.Controls.Add(this.ChooseDirectory);
            this.Controls.Add(this.CalcButton);
            this.Controls.Add(this.NetPayLabel);
            this.Controls.Add(this.DeductionsLabel);
            this.Controls.Add(this.GrossPayLabel);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.HoursLabel);
            this.Controls.Add(this.DepartmentLabel);
            this.Controls.Add(this.EmployeeNameLabel);
            this.Controls.Add(this.WeekLabel);
            this.Controls.Add(this.PayDateLabel);
            this.Controls.Add(this.WeekChooser);
            this.Controls.Add(this.EmployeeNameText);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.optionBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payroll";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WeekChooser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoursWorked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payroll_Emp_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payroll_Dept_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.NumericUpDown WeekChooser;
        private System.Windows.Forms.Label PayDateLabel;
        private System.Windows.Forms.Label WeekLabel;
        private System.Windows.Forms.Label EmployeeNameLabel;
        private System.Windows.Forms.Label DepartmentLabel;
        private System.Windows.Forms.Label HoursLabel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label GrossPayLabel;
        private System.Windows.Forms.Label DeductionsLabel;
        private System.Windows.Forms.Label NetPayLabel;
        private System.Windows.Forms.Button CalcButton;
        private System.Windows.Forms.Button ChooseDirectory;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowser;
        private System.Windows.Forms.TextBox DirectoryText;
        private System.Windows.Forms.Button GenInvoice;
        private System.Windows.Forms.SaveFileDialog SaveFile;
        private System.Windows.Forms.NumericUpDown HoursWorked;
        private System.Windows.Forms.Label FormTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Label EmptyError;
        private System.Windows.Forms.Button InvoicesButton;
        private System.Windows.Forms.Label MandarinLabel;
        private System.Windows.Forms.Button DeptButton;
        private System.Windows.Forms.TextBox EmployeeNameText;
        private System.Windows.Forms.ComboBox DepartmentText;
        private System.Windows.Forms.BindingSource departmentBindingSource1;
        private Payroll_Dept_DataSet payroll_Dept_DataSet;
        private System.Windows.Forms.BindingSource deptBindingSource;
        private Payroll_Dept_DataSetTableAdapters.deptTableAdapter deptTableAdapter;
        private payroll_Emp_DataSet payroll_Emp_DataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private payroll_Emp_DataSetTableAdapters.employeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.TextBox empidtxt;
        private System.Windows.Forms.Label empnotxt;
        private System.Windows.Forms.Label adminlbl;
        private System.Windows.Forms.Label adminlabel;
        private System.Windows.Forms.Label GrossPayText;
        private System.Windows.Forms.Label DeductionsText;
        private System.Windows.Forms.Label NetPayText;
        private System.Windows.Forms.Button recordbtn;
        private System.Windows.Forms.GroupBox optionBox;
        private System.Windows.Forms.Label EmptyError1;
    }
}

