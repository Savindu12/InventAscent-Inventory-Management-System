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
    public partial class AddStore : Form
    {
        public AddStore()
        {
            InitializeComponent();
        }

        private void AddStoreButton_Click(object sender, EventArgs e)
        {
            string storename = storeNameBox.Text;
            string storelocation = storeLocBox.Text;
            string storemanager = Convert.ToString(storeManBox.Text);
            DateTime longdate = createdDate.Value;
            string storedes = storeDesBox.Text;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Savindu\source\repos\InventAscent_InventoryMGTSystem\InventoryManagement.mdf;Integrated Security=True;Connect Timeout=30");

            if (storename == null || storelocation == null )
            {
                MessageBox.Show("Storename & Store location cannot be empty!", "Inputs are not visible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string query = "INSERT INTO StoreInfo VALUES ('" + storename + "','" + storelocation + "', '" + storemanager + "', '" + longdate + "', '" + storedes + "')";
                SqlCommand cmd = new SqlCommand(query, con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Store Data Added Successfully","Add new Store Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    storeNameBox.Text = null;
                    storeLocBox.Text = null;
                    storeManBox.Text = null;
                    storeDesBox.Text = null;

                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot add Store details, Try Again!","Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    storeNameBox.Text = null;
                    storeLocBox.Text = null;
                    storeManBox.Text = null;
                    storeDesBox.Text = null;

                    con.Close();
                }
            }
            
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            storeNameBox.Text = null;
            storeLocBox.Text = null;
            storeManBox.Text = null;
            storeDesBox.Text = null;

            this.Hide();
        }

        private void AddStore_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Savindu\source\repos\InventAscent_InventoryMGTSystem\InventoryManagement.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "SELECT Managername FROM StoreManager";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = cmd;
            DataTable table1 = new DataTable();
            da.Fill(table1);
            storeManBox.DataSource = table1;
            storeManBox.DisplayMember = "Managername";
            storeManBox.ValueMember = "Managername";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
