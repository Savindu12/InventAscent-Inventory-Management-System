using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InventAscent
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public class userName
        {
            public string username;
        }

        private void AccountLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateAccount fm = new CreateAccount();
            fm.Show();
            this.Hide();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Savindu\source\repos\InventAscent_InventoryMGTSystem\InventoryManagement.mdf;Integrated Security=True;Connect Timeout=30");

        private void SignInButton_Click(object sender, EventArgs e)
        {
            string username = UNameBox.Text;
            string password = PasswordBox.Text;

            if (username != String.Empty || password != String.Empty)
            {
                con.Open();
                string query = "SELECT Userrole FROM UserLogin WHERE Username = '" + username + "' and Password = '" + password + "'";
                userName Un = new userName();
                userName Cn = new userName();
                Un.username = UNameBox.Text;
                Cn.username = UNameBox.Text;
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    string roles = dt.Rows[0][0].ToString();
                    if (roles == "Admin")
                    {
                        UserDashboard UD = new UserDashboard(Un);
                        UD.Show();
                        this.Hide();
                        con.Close();
                    }

                    else if (roles == "User")
                    {
                        ClientDashboard CD = new ClientDashboard(Cn);
                        CD.Show();
                        this.Hide();
                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password!","Doesn't existing this account", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    con.Close();
                }
            }

            else
            {
                MessageBox.Show("Username and Password cannot be empty!","Inputs are not visible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
            

        private void ForgotPWDLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword FP = new ForgotPassword();
            FP.Show();
            this.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void showPaswordBox_CheckedChanged(object sender, EventArgs e)
        {
            this.PasswordBox.PasswordChar = this.showPaswordBox.Checked ? char.MinValue : '*';
        }
    }
}
