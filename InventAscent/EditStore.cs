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
using System.Security.Cryptography.X509Certificates;

namespace InventAscent
{
    public partial class EditStore : Form
    {
        public EditStore()
        {
            InitializeComponent();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string storename = Convert.ToString(storenameBox.Text);
            string storelocation = storelocBox.Text;
            string storemanager = Convert.ToString(storemanBox.Text);
            DateTime createDate = createdDateBox.Value;
            string storedescription = storedesBox.Text;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Savindu\source\repos\InventAscent_InventoryMGTSystem\InventoryManagement.mdf;Integrated Security=True;Connect Timeout=30");

            if (storename != String.Empty || storelocation != String.Empty || storemanager != String.Empty || storedescription != String.Empty)
            {
                string query = "UPDATE StoreInfo SET Storename = '" + storename + "', Storeloc = '" + storelocation + "', StoreManager = '" + storemanager + "', CreatedDate = '" + createDate + "', StoreDes = '" + storedescription + "' WHERE Storename = '" + storename + "'";
                SqlCommand cmd = new SqlCommand(query, con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Store details Updated!","Store updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception eex)
                {
                    con.Close();
                    MessageBox.Show("Cannot update store details, Try Again!","Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter values for fields", "Inputs are not visible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

           
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            string storename = Convert.ToString(storenameBox.Text);

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Savindu\source\repos\InventAscent_InventoryMGTSystem\InventoryManagement.mdf;Integrated Security=True;Connect Timeout=30");

            if (storename == String.Empty)
            {
                MessageBox.Show("Please Select a store", "Store not selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string query = "DELETE FROM StoreInfo WHERE Storename = '" + storename + "'";
                SqlCommand cmd = new SqlCommand(query, con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Store details Deleted Successfully!", "Store Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception eex)
                {
                    con.Close();
                    MessageBox.Show("Cannor delete store, Try Again!", "Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cancelBox_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EditStore_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Savindu\source\repos\InventAscent_InventoryMGTSystem\InventoryManagement.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "SELECT Storename FROM StoreInfo";
            string query2 = "SELECT Managername FROM StoreManager";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlCommand cmd2 = new SqlCommand(query2, con);
            SqlDataAdapter da = new SqlDataAdapter();
            SqlDataAdapter da2 = new SqlDataAdapter();

            da.SelectCommand = cmd;
            da2.SelectCommand = cmd2;
            DataTable table1 = new DataTable();
            DataTable table2 = new DataTable();
            da.Fill(table1);
            da2.Fill(table2);

            storenameBox.DataSource = table1;
            storenameBox.DisplayMember = "Storename";
            storenameBox.ValueMember = "Storename";

            storemanBox.DataSource = table2;
            storemanBox.DisplayMember = "Managername";
            storemanBox.ValueMember = "Managername";
        }
    }
}
