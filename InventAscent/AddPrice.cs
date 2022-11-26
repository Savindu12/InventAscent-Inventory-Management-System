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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace InventAscent
{
    public partial class AddPrice : Form
    {
        public AddPrice()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AddPrice_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Savindu\source\repos\InventAscent_InventoryMGTSystem\InventoryManagement.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "SELECT ItemId FROM ItemInfo";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = cmd;
            DataTable table1 = new DataTable();
            da.Fill(table1);

            itemIDComboBox.DataSource = table1;
            itemIDComboBox.DisplayMember = "ItemId";
            itemIDComboBox.ValueMember = "ItemId";
        }

        private void itemIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemid = Convert.ToString(itemIDComboBox.Text);

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Savindu\source\repos\InventAscent_InventoryMGTSystem\InventoryManagement.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string query = "SELECT * FROM ItemInfo WHERE ItemId = '" + itemid + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                itmName.Text = dr["ItemName"].ToString();
                itmCategory.Text = dr["CategoryName"].ToString();
            }
            con.Close();
        }

        private void addPriceButton_Click(object sender, EventArgs e)
        {
            string itemid = Convert.ToString(itemIDComboBox.Text);
            string itemName = itmName.Text;
            string categoryName = itmCategory.Text;
            string quantityType = Convert.ToString(itmQuantityType.Text);
            int val;
            int.TryParse(itmQuantity.Text, out val);
            float result;
            float.TryParse(itmPrice.Text, out result);


            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Savindu\source\repos\InventAscent_InventoryMGTSystem\InventoryManagement.mdf;Integrated Security=True;Connect Timeout=30");
            
            if(quantityType != String.Empty)
            {
                if (val != 0)
                {
                    string query = "INSERT INTO PriceInfo VALUES ('" + itemid + "','" + itemName + "', '" + categoryName + "', '" + val + "', '" + quantityType + "', '" + result + "', '" + this.priceDateTime.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Price Added Successfully", "Price Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        itemIDComboBox.Text = null;
                        itmName.Text = null;
                        itmCategory.Text = null;
                        itmQuantityType.Text = null;
                        itmQuantity.Text = null;
                        itmPrice.Text = null;

                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Cannot add price, Try Again!", "Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        itemIDComboBox.Text = null;
                        itmName.Text = null;
                        itmCategory.Text = null;
                        itmQuantityType.Text = null;
                        itmQuantity.Text = null;
                        itmPrice.Text = null;

                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a value for item quantity", "Quantity field is empty", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

               
            }
            else
            { 
                MessageBox.Show("Please select a quantity type", "Quantity type not selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
