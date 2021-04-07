using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll
{
    public partial class AddDeptForm : Form
    {
        OleDbCommand cmd;
        OleDbCommand cmd1;
        private readonly OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|/payroll_db.accdb");

        public OleDbConnection Con => con;

        public AddDeptForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(DeptNameTextBox.Text))
            {
                MessageBox.Show("There's an Empty Field."+ Environment.NewLine + "Please Fill-up the form and Try again!", "Opps! Something went wrong!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DeptNameTextBox.Focus();
            }
            else 
            {
                string adminid = "admin";
                string action = "Add Department Record";
                string table = "dept";
                string eid = "N/A";
                string today = DateTime.Now.ToString("dd/MM/yyyy h:mm tt");
                const string sql1 = "insert into audittrail (adminname,[action],[tablename],eid,[accesstime]) values (@adminname,@action,@tablename,@eid,@accesstime)";
                cmd1 = new OleDbCommand(sql1, con);
                cmd1.Parameters.AddWithValue("@adminname", adminid);
                cmd1.Parameters.AddWithValue("[@action]", action);
                cmd1.Parameters.AddWithValue("[@tablename]", table);
                cmd1.Parameters.AddWithValue("[@eid]", eid);
                cmd1.Parameters.AddWithValue("[@accesstime]", today);

                const string sql = "insert into dept(dept) values(@deptname)";

                cmd = new OleDbCommand(sql, Con);
                Con.Open();
                cmd.Parameters.AddWithValue("@deptname", DeptNameTextBox.Text);
                cmd1.ExecuteNonQuery();
                int result = cmd.ExecuteNonQuery();

                if(result > 0)
                {
                MessageBox.Show("Record Saved Successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Con.Close();
                DeptForm form = new DeptForm();
                form.Show();
                Hide();
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(DeptNameTextBox.Text))
            {
                this.Hide();
            }
            else
            {
                var result = MessageBox.Show("There are still unsaved changes." + Environment.NewLine + "are you sure you want to continue?","Textbox has been filled!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if(result == DialogResult.Yes)
                {
                    DeptForm form = new DeptForm();
                    form.Show();
                } 
                else if (result == DialogResult.No)
                {
                    DeptNameTextBox.Focus();
                }
            } 
            
        }
    }
}
