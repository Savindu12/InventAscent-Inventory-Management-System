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
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm LF = new LoginForm();
            LF.Show();
            this.Hide();
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {
           
        }

        private void CreateAccButton_Click(object sender, EventArgs e)
        {
            string Username = UNameBox.Text;
            string role = Convert.ToString(roleBox.Text);
            string email = emailBox.Text;
            string password = pswdBox.Text;
            string cpassword = cpswdBox.Text;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Savindu\source\repos\InventAscent_InventoryMGTSystem\InventoryManagement.mdf;Integrated Security=True;Connect Timeout=30");

            if(Username != String.Empty || email != String.Empty || password != String.Empty || cpassword != String.Empty)
            {
                string query = "INSERT INTO UserLogin VALUES ('" + Username + "', '" + role + "', '" + email + "', '" + password + "', '" + cpassword + "')";
                SqlCommand cmd = new SqlCommand(query, con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();

                    if (role == "Admin")
                    {
                        MessageBox.Show("Admin details added succcessfully!", "New Admin Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        UNameBox.Text = null;
                        roleBox.Text = null;
                        emailBox.Text = null;
                        pswdBox.Text = null;
                        cpswdBox.Text = null;

                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("User details added successfully!", "New User Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        UNameBox.Text = null;
                        roleBox.Text = null;
                        emailBox.Text = null;
                        pswdBox.Text = null;
                        cpswdBox.Text = null;

                        con.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot add user, Try Again!", "Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    UNameBox.Text = null;
                    roleBox.Text = null;
                    emailBox.Text = null;
                    pswdBox.Text = null;
                    cpswdBox.Text = null;

                    con.Close();
                }

                
            }
            else if (role == "")
            {
                MessageBox.Show("Please select a user role", "User role not selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (password!=cpassword)
            {
                MessageBox.Show("Please enter same password in both","Passwords are not same", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Please enter user details", "Input fields are not visible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            this.pswdBox.PasswordChar = this.showPassword.Checked ? char.MinValue : '*';
            this.cpswdBox.PasswordChar = this.showPassword.Checked ? char.MinValue : '*';
        }
    }
}
