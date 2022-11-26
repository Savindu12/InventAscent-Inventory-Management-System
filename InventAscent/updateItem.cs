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
    public partial class updateItem : Form
    {
        public updateItem()
        {
            InitializeComponent();
        }

        private void updateitemButton_Click(object sender, EventArgs e)
        {
            string itemid = itemidBox.Text;
            string itemname = itemnameBox.Text;
            string category = Convert.ToString(storenameCombo.Text);
            string description = itemdesBox.Text;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Savindu\source\repos\InventAscent_InventoryMGTSystem\InventoryManagement.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "UPDATE ItemInfo SET (ItemId = '" + itemid + "', ItemName = '" + itemname + "', ItemDescription = '" + description+ "', CategoryName = '"+category+"') WHERE Category ID = '" + itemid + "'";
            SqlCommand cmd = new SqlCommand(query, con);

            if (itemid != String.Empty || itemname != String.Empty)
            {
                if (category != String.Empty)
                {
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Category Update Successfully!","Category Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        itemidBox.Text = null;
                        itemnameBox.Text = null;
                        itemdesBox.Text = null;
                        storenameCombo.Text = null;

                    }
                    catch (Exception ex)
                    {
                        itemidBox.Text = null;
                        itemnameBox.Text = null;
                        itemdesBox.Text = null;
                        storenameCombo.Text = null;

                        MessageBox.Show("Cannot update category, Try Again!","Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please select category", "Category not selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please enter details for update item", "Inputs are not visible",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void updateItem_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Savindu\source\repos\InventAscent_InventoryMGTSystem\InventoryManagement.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "SELECT CategoryName FROM Category";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = cmd;
            DataTable table1 = new DataTable();
            da.Fill(table1);

            storenameCombo.DataSource = table1;
            storenameCombo.DisplayMember = "CategoryName";
            storenameCombo.ValueMember = "CategoryName";

        }
    }
}
