using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Payroll
{
    public partial class Form1 : Form
    {

        readonly OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|/payroll_db.accdb");
        OleDbCommand cmd;
        OleDbCommand cmd1;
        //readonly OleDbDataReader dr;
        public Form1()
        {
            InitializeComponent();
            adminlabel.Text = Login.ID;
        }

        public static string id;

        public static string ID
        {
            get
            {
                return id;
            }
        }


        readonly int Pay = 537;
        int initialpay;
        int totweekhour;
        int latefee;
        double deduc;
        double OTrate;
        double totOT;
        string directory;
        int grosspay;
        double finalpay;
        int hours;
        string date;
        int weeks;
        string empid;
        string employeename;
        string department;
        int week;
        int lates;

        private void ExitButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(empidtxt.Text) || !string.IsNullOrWhiteSpace(EmployeeNameText.Text) || WeekChooser.Minimum >= 1 || HoursWorked.Minimum >= 1)
            {
                var result = MessageBox.Show("There are still unsaved changes." + Environment.NewLine + "are you sure you want to continue?", "Textbox has been filled!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else if (result == DialogResult.No)
                {
                    CalcButton.Focus();
                }
            }
            else
            { 
                Application.Exit();
            }

        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            hours = (int)HoursWorked.Value;
            week = (int)WeekChooser.Value;
            lates = (int)latechooser.Value;
            EmptyError.Hide();
            EmptyError1.Hide();
            totweekhour = (int)WeekChooser.Value * 40;
            latefee = Pay / 60 * (int)latechooser.Value;
            OTrate = Pay * 0.25;
            totOT = OTrate / 60 * hours;
            grosspay = Pay * totweekhour;
            GrossPayText.Text = "₱" + grosspay.ToString();
            deduc = grosspay * 0.20 + latefee;
            finalpay = grosspay - deduc + totOT;
            DeductionsText.Text = "₱" + deduc.ToString();
            NetPayText.Text = "₱" + finalpay.ToString();
            otPaytxt.Text = "₱" + totOT.ToString();
            totallatetxt.Text = "₱" + latefee.ToString();
            totWeektxt.Text = week.ToString();
            totlatetxt.Text = lates.ToString();
            totOTtxt.Text = hours.ToString();
            GenInvoice.Enabled = true;

            //(EmployeeNameText.TextLength >= 1 && empidtxt.TextLength >= 1 && WeekChooser.Minimum >= 1 && HoursWorked.Minimum >= 1)

            if (string.IsNullOrWhiteSpace(empidtxt.Text) || string.IsNullOrWhiteSpace(EmployeeNameText.Text) || WeekChooser.Minimum >= 1 && HoursWorked.Minimum >= 1)
            {
                var result = MessageBox.Show("Opps! Something went wrong!", "Please Provide Details!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                EmptyError.Show();
                EmptyError1.Show();
                //MessageBox.Show("There are still unsaved changes." + Environment.NewLine + "are you sure you want to continue?", "Textbox has been filled!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    empidtxt.Focus();
                    EmployeeNameText.Focus();
                    WeekChooser.Focus();
                    HoursWorked.Focus();
                }
            }
            else
            {

                string action = "Add Employee Record";
                string table = "employee";
                string eid = "N/A";
                string today = DateTime.Now.ToString("dd/MM/yyyy h:mm tt");
                const string sql1 = "insert into audittrail (adminname,[action],[tablename],eid,[accesstime]) values (@adminname,@action,@tablename,@eid,@accesstime)";
                cmd1 = new OleDbCommand(sql1, con);
                cmd1.Parameters.AddWithValue("@adminname", adminlabel.Text);
                cmd1.Parameters.AddWithValue("[@action]", action);
                cmd1.Parameters.AddWithValue("[@tablename]", table);
                cmd1.Parameters.AddWithValue("[@eid]", eid);
                cmd1.Parameters.AddWithValue("[@accesstime]", today);

                const string sql = "insert into employee(empid,empname,deptid,dept) values (@empid,@empname,@deptid,@dept)";
                cmd = new OleDbCommand(sql, con);
                cmd.Parameters.AddWithValue("@empid", empidtxt.Text);
                cmd.Parameters.AddWithValue("@empname", EmployeeNameText.Text);
                cmd.Parameters.AddWithValue("@deptid", DepartmentText.SelectedValue);
                cmd.Parameters.AddWithValue("@dept", DepartmentText.Text);

                con.Open();
                int result = cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Record Saved Successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                }
                else
                {
                    MessageBox.Show("It seems that the record does not saved successfully", "Opps! Something went wrong!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    con.Close();
                }
            }


            /*
            if (!string.IsNullOrWhiteSpace(empidtxt.Text) && !string.IsNullOrWhiteSpace(EmployeeNameText.Text) && WeekChooser.Minimum >= 1 && HoursWorked.Minimum >= 1)
            {
                empidtxt.Focus();
                MessageBox.Show("Opps! Something went wrong!", "Please Provide Details!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                EmptyError.Show();
                EmptyError1.Show();
            }
            else
            {
                const string sql = "insert into employee(empid,empname,deptid,dept) values (@empid,@empname,@deptid,@dept)";
                cmd = new OleDbCommand(sql, con);
                con.Open();
                cmd.Parameters.AddWithValue("@empid", empidtxt.Text);
                cmd.Parameters.AddWithValue("@empname", EmployeeNameText.Text);
                cmd.Parameters.AddWithValue("@deptid", DepartmentText.SelectedValue);
                cmd.Parameters.AddWithValue("@dept", DepartmentText.Text);
                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Record Saved Successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Opps! Something went wrong!", "Please Provide Details!!!!!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    con.Close();
                }
            }
            else if (string.IsNullOrWhiteSpace(EmployeeNameText.Text) || string.IsNullOrWhiteSpace(empidtxt.Text) || WeekChooser.Minimum == 0 || HoursWorked.Minimum == 0)
            {
                empidtxt.Focus();
                MessageBox.Show("Opps! Something went wrong!", "Please Provide Details!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                EmptyError.Show();
                EmptyError1.Show();
            }*/
        }
        /*
        private void EmployeeNameText_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EmployeeNameText.Text))
            {
                EmployeeNameText.Text = "Enter Name";
            }
        }
        private void Empidtxt_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(empidtxt.Text))
            {
                empidtxt.Text = "Enter Employee ID";
            }
        }
        */

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            HoursWorked.Value = 0;
            DepartmentText.SelectedIndex = 1;
            EmployeeNameText.Text = "";
            empidtxt.Text = "";
            HoursWorked.Value = 0;
            latechooser.Value = 0;
            totallatetxt.Text = "";
            totlatetxt.Text = "";
            totWeektxt.Text = "";
            totOTtxt.Text = "";
            otPaytxt.Text = "";
            WeekChooser.Value = 1;
            DatePicker.ResetText();
            GrossPayText.Text = "";
            DeductionsText.Text = "";
            NetPayText.Text = "";
        }

        private void ChooseDirectory_Click(object sender, EventArgs e)
        {
            if (FolderBrowser.ShowDialog() == DialogResult.OK)
            {
                DirectoryText.Text = FolderBrowser.SelectedPath;
                directory = DirectoryText.Text;
            }
        }

        private void GenInvoice_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(empidtxt.Text) || !string.IsNullOrWhiteSpace(EmployeeNameText.Text) || WeekChooser.Minimum >= 1 || HoursWorked.Minimum >= 1)
            {
                EmptyError.Hide();
                EmptyError1.Hide();
                empid = empidtxt.Text;
                employeename = EmployeeNameText.Text;
                date = DatePicker.Text;
                weeks = (int)WeekChooser.Value;
                department = DepartmentText.Text;
                hours = (int)HoursWorked.Value;
                directory = DirectoryText.Text;
                if(System.IO.Directory.Exists(directory))
                {
                    string path = directory + @"\" + employeename + @" Payslip.txt";
                    if (!System.IO.File.Exists(path))
                    {

                        string action = "Generate Employee Payslip";
                        string table = "employee";
                        string eid = "N/A";
                        string today = DateTime.Now.ToString("dd/MM/yyyy h:mm tt");
                        const string sql1 = "insert into audittrail (adminname,[action],[tablename],eid,[accesstime]) values (@adminname,@action,@tablename,@eid,@accesstime)";
                        cmd1 = new OleDbCommand(sql1, con);
                        cmd1.Parameters.AddWithValue("@adminname", adminlabel.Text);
                        cmd1.Parameters.AddWithValue("[@action]", action) ;
                        cmd1.Parameters.AddWithValue("[@tablename]", table);
                        cmd1.Parameters.AddWithValue("[@eid]", eid);
                        cmd1.Parameters.AddWithValue("[@accesstime]", today);
                        con.Open();
                        cmd1.ExecuteNonQuery();
                        con.Close();


                        string[] createText = {"Pay Slip",
                                           "\n ==================== \n",
                                           "Employer Name: iTec-Ming-Ming corp.",
                                           "ID: " + empid,
                                           "Name: " + employeename,
                                           "Department: " + department,
                                           "\n -------------------- \n",
                                           "Date of Pay: " + date.ToString(),
                                           "Number of Week(s): " + weeks.ToString(),
                                           "OverTime Hours Worked: " + hours.ToString() + " Hr(s)",
                                           "Late: " + totlatetxt.Text + " Minute(s)",
                                           "\n -------------------- \n",
                                           "Deductions:",
                                           "Pag-ibig, SSS, HMO, Etc: 20% of Gross Pay",
                                           "Late: " + latefee,
                                           "Total Deductions: " + DeductionsText.Text,
                                           "\n -------------------- \n",
                                           "Gross Pay: " + GrossPayText.Text,
                                           "Overtime Pay: " + otPaytxt.Text,
                                           "Net Pay: " + NetPayText.Text,
                                           "\n ==================== \n",
                                           "This Serves as Official Payslip for " + employeename,
                                           "Date of Payment: " + DateTime.Now.ToShortDateString(),
                                           "Date Printed: " + DateTime.Now.ToLongDateString(),
                                           "\n ==================== \n",
                                        };

                        System.IO.File.WriteAllLines(path, createText);
                        MessageBox.Show("Payslip has been created for " + employeename,"Success!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Payslip for " + employeename + " already exists!","Opps! Something went wrong!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                else
                {
                    MessageBox.Show("The directory does not exist!", "Opps! Something went wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                EmptyError.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'payroll_Emp_DataSet.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.payroll_Emp_DataSet.employee);
            // TODO: This line of code loads data into the 'payroll_Dept_DataSet.dept' table. You can move, or remove it, as needed.
            this.deptTableAdapter.Fill(this.payroll_Dept_DataSet.dept);
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(empidtxt.Text) || !string.IsNullOrWhiteSpace(EmployeeNameText.Text) || WeekChooser.Minimum >= 1 || HoursWorked.Minimum >= 1)
            {
                var result = MessageBox.Show("There are still unsaved changes." + Environment.NewLine + "are you sure you want to continue?", "Textbox has been filled!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Clear();
                    Login login = new Login();
                    login.Show();
                    Hide();
                }
                else if (result == DialogResult.No)
                {
                    CalcButton.Focus();
                }
            }
            else
            {
                Clear();
                Login login = new Login();
                login.Show();
                Hide();
            }

        }

        


        private void InvoicesButton_Click(object sender, EventArgs e)
        {
            directory = DirectoryText.Text;
            if (System.IO.Directory.Exists(directory))
            {
                Process.Start(directory);
            }
            else
            {
                MessageBox.Show("The Directory or File Path does not exist!");
            }
        }

        private void Empidtxt_Click(object sender, EventArgs e)
        {
            empidtxt.Text = "";
            EmptyError.Hide();
            EmptyError1.Hide();
        }

        private void EmployeeNameText_Click(object sender, EventArgs e)
        {
            EmployeeNameText.Text = "";
            EmptyError.Hide();
            EmptyError1.Hide();
        }

        private void DepartmentText_Click(object sender, EventArgs e)
        {
            EmptyError.Hide();
            EmptyError1.Hide();
        }

        private void HoursWorked_Click(object sender, EventArgs e)
        {
            EmptyError.Hide();
            EmptyError1.Hide();
        }

        private void WeekChooser_Click(object sender, EventArgs e)
        {
            EmptyError.Hide();
            EmptyError1.Hide();
        }

        private void DeptButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(empidtxt.Text) || !string.IsNullOrWhiteSpace(EmployeeNameText.Text) || WeekChooser.Minimum >= 1 || HoursWorked.Minimum >= 1)
            {
                var result = MessageBox.Show("There are still unsaved changes." + Environment.NewLine + "are you sure you want to continue?", "Textbox has been filled!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DeptForm form = new DeptForm();
                    form.Show();
                    Hide();
                    id = DeptForm.ID;
                }
                else if (result == DialogResult.No)
                {
                    CalcButton.Focus();
                }
            }
            else
            {
                DeptForm form = new DeptForm();
                form.Show();
                Hide();
                id = DeptForm.ID;
            }

        }

        private void Recordbtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(empidtxt.Text) || !string.IsNullOrWhiteSpace(EmployeeNameText.Text) || WeekChooser.Minimum >= 1 || HoursWorked.Minimum >= 1)
            {
                var result = MessageBox.Show("There are still unsaved changes." + Environment.NewLine + "are you sure you want to continue?", "Textbox has been filled!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Record form = new Record();
                    form.Show();
                    Hide();
                }
                else if (result == DialogResult.No)
                {
                    CalcButton.Focus();
                }
            }
            else
            {
                Record form = new Record();
                form.Show();
                Hide();
            }


        }
    }
}
