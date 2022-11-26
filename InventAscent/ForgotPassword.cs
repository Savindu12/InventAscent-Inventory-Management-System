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
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginForm lGF = new LoginForm();
            lGF.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm LF = new LoginForm();
            LF.Show();
            this.Hide();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string username = FUname.Text;
            string role = Convert.ToString(FRole.Text);
            string newPassword = fNPswd.Text;
            string confirmPassword = fCNpwd.Text;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Savindu\source\repos\InventAscent_InventoryMGTSystem\InventoryManagement.mdf;Integrated Security=True;Connect Timeout=30");

            if (username != String.Empty || newPassword != String.Empty || confirmPassword != String.Empty)
            {
                if(role != String.Empty)
                {
                    string query = "UPDATE UserLogin SET Password = '" + newPassword + "', ConfirmPWD = '" + confirmPassword + "' WHERE Username = '" + username + "' AND Userrole = '" + role + "'";
                    SqlCommand cmd = new SqlCommand(query, con);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();

                        if (role == "Admin")
                        {
                            MessageBox.Show("Admin Password changed successfully!", "Password Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            FUname.Text = null;
                            FRole.Text = null;
                            fNPswd.Text = null;
                            fCNpwd.Text = null;

                            con.Close();
                        }
                        else
                        {
                            MessageBox.Show("User Password changed successfully!", "Password Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            FUname.Text = null;
                            FRole.Text = null;
                            fNPswd.Text = null;
                            fCNpwd.Text = null;

                            con.Close();
                        }    
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Cannot change password, Try Again!", "Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        FUname.Text = null;
                        FRole.Text = null;
                        fNPswd.Text = null;
                        fCNpwd.Text = null;

                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please Select your user role","User role not selected",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
               
            }
            else
            {
                MessageBox.Show("Please enter values", "Inputs are not visible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

           
        }

        private void showPswdBox_CheckedChanged(object sender, EventArgs e)
        {
            this.fNPswd.PasswordChar = this.showPswdBox.Checked ? char.MinValue : '*';
            this.fCNpwd.PasswordChar = this.showPswdBox.Checked ? char.MinValue : '*';
        }
    }
}
