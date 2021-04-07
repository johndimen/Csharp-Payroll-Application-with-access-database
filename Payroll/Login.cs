using System;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Drawing;
using System.ComponentModel;


namespace Payroll
{
    public partial class Login : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;

        public static string id;

        public static string ID 
        { 
            get 
            { 
                return id; 
            } 
        }

        public Login()
        {
            InitializeComponent();

        }
        public void LoginButton_Click(object sender, EventArgs e)
        {
            
            string user = UsernameText.Text;
            string pass = PasswordText.Text;
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|/payroll_db.accdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM login where username='" + user + "' AND password='" + pass + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                id = UsernameText.Text;

                new Form1().Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Username or password is incorrect");
                ErrorLabel.Show();
            }

            con.Close();
        }

        /*{
            if(UsernameText.Text == "admin" && PasswordText.Text == "admin")
            {
                Form1 form = new Payroll.Form1();
                form.Show();
                this.Hide();
            }
            else
            {
                ErrorLabel.Show();
            }
        }*/

        private void PasswordText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginButton.PerformClick();
                e.SuppressKeyPress = true;
            }
            /*
            if (e.KeyCode == Keys.Enter)
            {
                LoginButton.PerformClick();
                e.SuppressKeyPress = true;
                {
                    string user = UsernameText.Text;
                    string pass = PasswordText.Text;
                    con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source =C:\\Users\\KLG\\Desktop\\repos\\College-PayrollApplication-master\\Payroll\\payroll_db.accdb");
                    cmd = new OleDbCommand();
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT * FROM login where username='" + user + "' AND password='" + pass + "'";
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        Form1 form = new Form1();
                        form.Show();
                    }
                    else
                    {
                        MessageBox.Show("Username or password is incorrect");
                        ErrorLabel.Show();
                    }

                    con.Close();
                }
            }
            */
        }

        private void UsernameText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginButton.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            UsernameText.Select();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PasswordText_Click(object sender, EventArgs e)
        {
            ErrorLabel.Hide();
        }

        private void UsernameText_Click(object sender, EventArgs e)
        {
            ErrorLabel.Hide();
        }

        private void UsernameText_TextChanged(object sender, EventArgs e)
        {
            ErrorLabel.Hide();
        }

        private void PasswordText_TextChanged(object sender, EventArgs e)
        {
            ErrorLabel.Hide();
        }
    }
}
