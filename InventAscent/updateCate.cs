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
    public partial class updateCate : Form
    {
        public updateCate()
        {
            InitializeComponent();
        }

        private void cateupdateButton_Click(object sender, EventArgs e)
        {
            string categoryID = Convert.ToString(categoryIdDrop.Text);
            string storeName = Convert.ToString(storeNameBox.Text);
            string categoryName = catenameBox.Text;
            string cateDescription = cateDesBox.Text;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Savindu\source\repos\InventAscent_InventoryMGTSystem\InventoryManagement.mdf;Integrated Security=True;Connect Timeout=30");

            if (categoryID != String.Empty || categoryName != String.Empty)
            {
                try
                {
                    // string query = "UPDATE Category SET (CategoryName = '" + categoryName + "', CategoryDescription = '" + cateDescription + "', StoreName = '"+storeName+"') WHERE CategoryID = '" + categoryID + "' ";
                    string query = "UPDATE Category SET (CategoryID = '"+categoryID+"', CategoryName = '" + categoryName + "', CategoryDescription = '" + cateDescription + "', StoreName = '" + storeName + "') WHERE CategoryID = '" + categoryID + "'";
                    SqlCommand cmd = new SqlCommand(query, con);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Update Successfully !", "Category Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    categoryIdDrop.Text = null;
                    catenameBox.Text = null;
                    cateDesBox.Text = null;

                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                    categoryIdDrop.Text = null;
                    catenameBox.Text = null;
                    cateDesBox.Text = null;

                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Please input category details", "Inputs are not visible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

           
        }

        private void updateCate_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Savindu\source\repos\InventAscent_InventoryMGTSystem\InventoryManagement.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "SELECT CategoryId FROM Category";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = cmd;
            DataTable table1 = new DataTable();
            da.Fill(table1);

            categoryIdDrop.DataSource = table1;
            categoryIdDrop.DisplayMember = "CategoryId";
            categoryIdDrop.ValueMember = "CategoryId";

         
            string query2 = "SELECT Storename FROM StoreInfo";
            SqlCommand cmd2 = new SqlCommand(query2, con);
            SqlDataAdapter da2 = new SqlDataAdapter();

            da2.SelectCommand = cmd2;
            DataTable table2 = new DataTable();
            da2.Fill(table2);

            storeNameBox.DataSource = table2;
            storeNameBox.DisplayMember = "Storename";
            storeNameBox.ValueMember = "Storename";
        }
    }
}
