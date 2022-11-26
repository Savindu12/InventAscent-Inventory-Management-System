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
    public partial class EProfile : Form
    {
        public EProfile()
        {
            InitializeComponent();
        }

        private void EditImage_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files (*.jpg)|*.jpg| PNG files(*.png)|*.png| All files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;

                    imageBox.ImageLocation = imageLocation;
                }

            }catch (Exception ex)
            {
                MessageBox.Show("An Error Occured",ex.Message);
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

            string name = NameBox.Text;
            string username = UserNBox.Text;
            string email = EmailBox.Text;
        //  int phonenum = int.Parse(PNumBox.Text);

            int val;
            int.TryParse(PNumBox.Text, out val);

            string city = CityBox.Text;
            string address = AddBox.Text;
            Image image = imageBox.Image;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Savindu\source\repos\InventAscent_InventoryMGTSystem\InventoryManagement.mdf;Integrated Security=True;Connect Timeout=30");

            if (name != String.Empty || username != String.Empty || email != String.Empty || val != 0 || city != String.Empty || address != String.Empty)
            {
                string query = "UPDATE ProfileInfo SET Name = '" + name + "', Username = '" + username + "', Email = '" + email + "', Phonenumber = '" + val + "', City = '" + city + "', Address = '" + address + "', UserImage = '" + image + "' WHERE Username = '" + username + "'";
                SqlCommand cmd = new SqlCommand(query, con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Profile data update successfully!", "Profile data updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    NameBox.Text = null;
                    UserNBox.Text = null;
                    EmailBox.Text = null;
                    PNumBox.Text = null;
                    CityBox.Text = null;
                    AddBox.Text = null;

                    con.Close();
                }
                catch (Exception exe)
                {
                    MessageBox.Show("Cannot update user details, Try Again!", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    NameBox.Text = null;
                    UserNBox.Text = null;
                    EmailBox.Text = null;
                    PNumBox.Text = null;
                    CityBox.Text = null;
                    AddBox.Text = null;

                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Please enter user details to update", "Cannot update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
        }
    }
}
