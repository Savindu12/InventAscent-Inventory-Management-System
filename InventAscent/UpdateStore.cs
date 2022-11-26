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
    public partial class UpdateStore : Form
    {
        public UpdateStore()
        {
            InitializeComponent();
        }

        private void UpdateStore_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Savindu\source\repos\InventAscent_InventoryMGTSystem\InventoryManagement.mdf;Integrated Security=True;Connect Timeout=30");
           
            string query = "SELECT CategoryName FROM Category";
            string itemq = "SELECT ItemName FROM ItemInfo";

            SqlCommand cmd = new SqlCommand(query, con);
            SqlCommand cmd2 = new SqlCommand(itemq, con);

            SqlDataAdapter da = new SqlDataAdapter();
            SqlDataAdapter da2 = new SqlDataAdapter();

            da.SelectCommand = cmd;
            da2.SelectCommand = cmd2;

            DataTable table1 = new DataTable();
            DataTable table2 = new DataTable();
            da.Fill(table1);
            da2.Fill(table2);

            cateDropDown.DataSource = table1;
            cateDropDown.DisplayMember = "CategoryName";
            cateDropDown.ValueMember = "CategoryName";

            itemDropDown.DataSource = table2;
            itemDropDown.DisplayMember = "ItemName";
            itemDropDown.ValueMember = "ItemName";
        }

        public void load_Panel(object Form)
        {
            if (this.updatePanel.Controls.Count > 0)
                this.updatePanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.updatePanel.Controls.Add(f);
            this.updatePanel.Tag = f;
            f.Show();
        }

        private void cateUpdateButton_Click(object sender, EventArgs e)
        {
                load_Panel(new updateCate());  
        }

        private void itemUpdateButton_Click(object sender, EventArgs e)
        {
            load_Panel(new updateItem());
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cateDeleteButton_Click(object sender, EventArgs e)
        {
            string categoryName = Convert.ToString(cateDropDown.Text);
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Savindu\source\repos\InventAscent_InventoryMGTSystem\InventoryManagement.mdf;Integrated Security=True;Connect Timeout=30");

            if(categoryName != null)
            {
                string query = "DELETE FROM Category WHERE CategoryName = '" + categoryName + "'";
                SqlCommand cmd = new SqlCommand(query, con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Deleted Successfully!","Category Deleted");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot delete category, Try Again!","Error occured");
                }
            }
            else
            {
                MessageBox.Show("Please Select a category", "Category not Selected");
            }

            
        }

        private void itemDeleteButton_Click(object sender, EventArgs e)
        {
            string itemName = Convert.ToString(itemDropDown.Text);
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Savindu\source\repos\InventAscent_InventoryMGTSystem\InventoryManagement.mdf;Integrated Security=True;Connect Timeout=30");

            if (itemName != null)
            {
                string query = "DELETE FROM ItemInfo WHERE ItemName = '" + itemName + "'";
                SqlCommand cmd = new SqlCommand(query, con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item Deleted Successfully!","Item Deleted");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot delete item, Try Again!","Error occured");
                }
            }
            else
            {
                MessageBox.Show("Please select an item", "Item not selected");
            }

         
        }
    }
}
