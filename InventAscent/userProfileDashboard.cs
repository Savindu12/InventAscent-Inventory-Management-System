using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventAscent
{
    public partial class userProfileDashboard : Form
    {
        public userProfileDashboard()
        {
            InitializeComponent();
        }

        private void saveUser_Click(object sender, EventArgs e)
        {
            string name = nameBox.Text;
            string username = usernameBox.Text;
            string email = emailBox.Text;
            //int phonenum = int.Parse(phonenumBox.Text);

            int val;
            int.TryParse(phonenumBox.Text, out val);
            
            string city = cityBox.Text;
            string address = addressBox.Text;
            Image image = profilePicBox.Image;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Savindu\source\repos\InventAscent_InventoryMGTSystem\InventoryManagement.mdf;Integrated Security=True;Connect Timeout=30");

            if (name != String.Empty || username != String.Empty || email != String.Empty || val != 0 || city != String.Empty || address != String.Empty)
            {
                string query = "UPDATE ProfileInfo SET Name = '" + name + "', Username = '" + username + "', Email = '" + email + "', Phonenumber = '" + val + "', City = '" + city + "', Address = '" + address + "', UserImage = '" + image + "' WHERE Username = '" + username + "'";
                SqlCommand cmd = new SqlCommand(query, con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Profile data update successfully!", "Profile data updated",MessageBoxButtons.OK,MessageBoxIcon.Information);

                    nameBox.Text = null;
                    usernameBox.Text = null;
                    emailBox.Text = null;
                    phonenumBox.Text = null;
                    cityBox.Text = null;
                    addressBox.Text = null;

                    con.Close();
                }
                catch (Exception exe)
                {
                    MessageBox.Show("Cannot update user details, Try Again!", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    nameBox.Text = null;
                    usernameBox.Text = null;
                    emailBox.Text = null;
                    phonenumBox.Text = null;
                    cityBox.Text = null;
                    addressBox.Text = null;

                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Please enter user details to update", "Cannot update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void editImageButton_Click(object sender, EventArgs e)
        {
           
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files (*.jpg)|*.jpg| PNG files(*.png)|*.png| All files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string imageLocation = dialog.FileName;

                    profilePicBox.ImageLocation = imageLocation;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Profile picture cannot update, Try Again!","An Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
