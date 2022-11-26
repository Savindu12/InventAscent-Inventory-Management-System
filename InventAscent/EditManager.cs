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
    public partial class EditManager : Form
    {
        public EditManager()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mangername = Convert.ToString(mNameBox.Text);
            string position = Convert.ToString(positionBox.Text);
            string email = emailBox.Text;
            //int phonenumber = int.Parse(phoneNumBox.Text);

            int val;
            int.TryParse(phoneNumBox.Text, out val);

            string address = addressBox.Text;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Savindu\source\repos\InventAscent_InventoryMGTSystem\InventoryManagement.mdf;Integrated Security=True;Connect Timeout=30");

            if (email != String.Empty || val == 0 || address != String.Empty)
            {
                string query = "UPDATE StoreManager SET Managername = '" + mangername + "', Position = '" + position + "', Email = '" + email + "', Phonenumber = '" + val + "', Address = '" + address + "' WHERE Managername = '" + mangername + "'";
                SqlCommand cmd = new SqlCommand(query, con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Manager details changed successfully", "Storemanager updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    mNameBox.Text = null;
                    positionBox.Text = null;
                    emailBox.Text = null;
                    phoneNumBox.Text = null;
                    addressBox.Text = null;

                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot update manager details, Try Again!", "Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    mNameBox.Text = null;
                    positionBox.Text = null;
                    emailBox.Text = null;
                    phoneNumBox.Text = null;
                    addressBox.Text = null;

                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Please enter manager details", "Inputs are not visible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
        }

        private void EditManager_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Savindu\source\repos\InventAscent_InventoryMGTSystem\InventoryManagement.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "SELECT Managername FROM StoreManager";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = cmd;
            DataTable table1 = new DataTable();
            da.Fill(table1);

            mNameBox.DataSource = table1;
            mNameBox.DisplayMember = "Managername";
            mNameBox.ValueMember = "Managername";
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string mangername = Convert.ToString(mNameBox.Text);

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Savindu\source\repos\InventAscent_InventoryMGTSystem\InventoryManagement.mdf;Integrated Security=True;Connect Timeout=30");

            if(mangername != String.Empty)
            {
                string query = "DELETE FROM StoreManager WHERE Managername = '" + mangername + "'";
                SqlCommand cmd = new SqlCommand(query, con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Store Manager details deleted Successfully", "Manager deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    mNameBox.Text = null;
                    positionBox.Text = null;

                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot delete store manager,Try Again!", "Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    mNameBox.Text = null;
                    positionBox.Text = null;

                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Please select manager", "Manager not selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
