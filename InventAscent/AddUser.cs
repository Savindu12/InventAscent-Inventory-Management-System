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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void addManagerButton_Click(object sender, EventArgs e)
        {
            string managername = nameBox.Text;
            string position = Convert.ToString(mPositionBox.Text);
            string email = mEmailBox.Text;
            //int phonenumber = int.Parse(mPhoneBox.Text);

            int val;
            int.TryParse(mPhoneBox.Text, out val);

            string address = mAddressBox.Text;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Savindu\source\repos\InventAscent_InventoryMGTSystem\InventoryManagement.mdf;Integrated Security=True;Connect Timeout=30");

            if (managername != String.Empty || email != String.Empty || address != String.Empty)
            {
                if (position != String.Empty)
                {

                    string query = "INSERT INTO StoreManager VALUES ('" + managername + "', '" + position + "', '" + email + "', '" + val + "', '" + address + "')";
                    SqlCommand cmd = new SqlCommand(query, con);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Manager Added Successfully", "New Manager added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                      
                        nameBox.Text = null;
                        mPositionBox.Text = null;
                        mEmailBox.Text = null;
                        mPhoneBox.Text = null;
                        mAddressBox.Text = null;

                        con.Close();
                    }
                    catch (Exception SM)
                    {
                        MessageBox.Show("Cannot add manager, Try Again!", "Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        nameBox.Text = null;
                        mPositionBox.Text = null;
                        mEmailBox.Text = null;
                        mPhoneBox.Text = null;
                        mAddressBox.Text = null;

                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please select a position", "Manager position not selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }    
            }

            else 
            {
                MessageBox.Show("Please enter manager details", "Inputs fields are empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            nameBox.Text = null;
            mPositionBox.Text = null;
            mEmailBox.Text = null;
            mPhoneBox.Text = null;
            mAddressBox.Text = null;

            this.Hide();
        }
    }
}
