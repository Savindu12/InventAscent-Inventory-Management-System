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
using System.Xml.Linq;

namespace InventAscent
{
    public partial class AddCategory : Form
    {
        public AddCategory()
        {
            InitializeComponent();
        }

        private void cateCancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void addCateButton_Click(object sender, EventArgs e)
        {
            string categoryID = categoryIDBox.Text;
            string categoryName = categoryNameBox.Text;
            string cateDescription = cateDesBox.Text;
            string storename = Convert.ToString(storeNameBox.Text);

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Savindu\source\repos\InventAscent_InventoryMGTSystem\InventoryManagement.mdf;Integrated Security=True;Connect Timeout=30");

            if (categoryID != String.Empty || categoryName != String.Empty)
            {
                string query = "INSERT INTO Category VALUES ('" + categoryID + "', '" + categoryName + "','" + cateDescription + "','" + storename + "')";
                SqlCommand cmd = new SqlCommand(query, con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New Category Added Successfully", "Category Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    categoryIDBox.Text = null;
                    categoryNameBox.Text = null;
                    cateDesBox.Text = null;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot add Category, Try Again", "Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    categoryIDBox.Text = null;
                    categoryNameBox.Text = null;
                    cateDesBox.Text = null;
                }
            }
            else
            {
                MessageBox.Show("Please Input Category ID & Category Name", "Inputs are not visible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void AddCategory_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Savindu\source\repos\InventAscent_InventoryMGTSystem\InventoryManagement.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "SELECT Storename FROM StoreInfo";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = cmd;
            DataTable table1 = new DataTable();
            da.Fill(table1);

            storeNameBox.DataSource = table1;
            storeNameBox.DisplayMember = "Storename";
            storeNameBox.ValueMember = "Storename";
        }
    }
}
