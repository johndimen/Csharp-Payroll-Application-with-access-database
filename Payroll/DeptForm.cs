    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Payroll
{
    public partial class DeptForm : Form
    {
     
        public DeptForm()
        {
            InitializeComponent();
        }

        public static string id;

        public static string ID
        {
            get
            {
                return id;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddDeptForm adddeptform = new AddDeptForm();
            adddeptform.Show();
            Hide();
            /* 
            try
            {
                
                    if (DeptTextBox.Text != "") { 
                    const string sql = "insert into department(deptname) values (@deptname)";
                    cmd = new OleDbCommand(sql, con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@deptname", DeptTextBox.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Saved Successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form1 form1 = new Form1();
                    form1.Show(); 
                    this.Hide();
                
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please Provide Details!", "Opps! Something went wrong!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            */
        }
        private void DeptForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'payroll_dept_DataSet1.dept' table. You can move, or remove it, as needed.
            this.deptTableAdapter1.Fill(this.payroll_dept_DataSet1.dept);

            /*
                DataGridViewButtonColumn delbtn = new DataGridViewButtonColumn();
                DataGridViewButtonColumn editbtn = new DataGridViewButtonColumn();
                DeptDataGridView.Columns.Add(delbtn);
                DeptDataGridView.Columns.Add(editbtn);
                delbtn.Width = 60;
                editbtn.Width = 60;
                delbtn.HeaderText = "Actions";
                editbtn.Text = "Edit";
                delbtn.Text = "Delete";
                delbtn.UseColumnTextForButtonValue = true;
                editbtn.UseColumnTextForButtonValue = true;

            */
        }


    }

}
