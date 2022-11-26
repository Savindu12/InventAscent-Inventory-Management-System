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
    public partial class UpdatePrice : Form
    {
        public UpdatePrice()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void UpdatePrice_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Savindu\source\repos\InventAscent_InventoryMGTSystem\InventoryManagement.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "SELECT ItemId FROM ItemInfo";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = cmd;
            DataTable table1 = new DataTable();
            da.Fill(table1);

            itemIDCombo.DataSource = table1;
            itemIDCombo.DisplayMember = "ItemId";
            itemIDCombo.ValueMember = "ItemId";
        }

        private void itemIDCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemid = Convert.ToString(itemIDCombo.Text);

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Savindu\source\repos\InventAscent_InventoryMGTSystem\InventoryManagement.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string query = "SELECT * FROM ItemInfo WHERE ItemId = '" + itemid + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                itemNameBox.Text = dr["ItemName"].ToString();
                itemCateBox.Text = dr["CategoryName"].ToString();
            }
            con.Close();
        }

        private void updatePriceButton_Click(object sender, EventArgs e)
        {
            string itemid = Convert.ToString(itemIDCombo.Text);
            string quantityType = Convert.ToString(quntityTypeBox.Text);

            int val;
            int.TryParse(quantityBox.Text, out val);
            float result;
            float.TryParse(priceBox.Text, out result);

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Savindu\source\repos\InventAscent_InventoryMGTSystem\InventoryManagement.mdf;Integrated Security=True;Connect Timeout=30");
           
            if (quantityType != String.Empty)
            {
                if (val != 0)
                {
                    if (result != 0)
                    {
                        string query = "UPDATE PriceInfo SET (Quantity = '" + val + "', QuantityType = '" + quantityType + "', Price = '" + result + "', Date = '" + this.updatePriceDate + "') WHERE ItemId = '" + itemid + "'";
                        SqlCommand cmd = new SqlCommand(query, con);

                        try
                        {
                            con.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Price details updated Successfully!", "Price updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            itemIDCombo.Text = null;
                            quntityTypeBox.Text = null;
                            quantityBox.Text = null;
                            priceBox.Text = null;

                            con.Close();
                        }
                        catch (Exception Ex)
                        {
                            MessageBox.Show("Cannot update price, Try Again!", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);


                            itemIDCombo.Text = null;
                            quntityTypeBox.Text = null;
                            quantityBox.Text = null;
                            priceBox.Text = null;

                            con.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter price", "Inputs are not visible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("Please enter quantity", "Inputs are not visible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please select Quantity Type", "Quantity type not selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string itemid = Convert.ToString(itemIDCombo.Text);

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Savindu\source\repos\InventAscent_InventoryMGTSystem\InventoryManagement.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "DELETE FROM PriceInfo WHERE ItemId = '" + itemid + "'";
            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Price details Deleted Successfully!","Price deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Cannot delete price details,Try Again!","Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
