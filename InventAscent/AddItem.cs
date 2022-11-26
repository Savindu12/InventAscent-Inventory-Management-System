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
    public partial class AddItem : Form
    {
        public AddItem()
        {
            InitializeComponent();
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            string itemID = itemIDBox.Text;
            string itemName = itemNameBox.Text;
            string cate = Convert.ToString(cateNameDrop.Text);
            string description = itemDesBox.Text;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Savindu\source\repos\InventAscent_InventoryMGTSystem\InventoryManagement.mdf;Integrated Security=True;Connect Timeout=30");

            if (itemID != String.Empty || itemName != String.Empty)
            {
                if (cate == "")
                {
                    MessageBox.Show("Please Select a category", "Category is empty", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    string query = "INSERT INTO ItemInfo VALUES ('" + itemID + "','" + itemName + "','" + description + "', '" + cate + "')";
                    SqlCommand cmd = new SqlCommand(query, con);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("New Item Added Successfully", "Item Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        itemIDBox.Text = null;
                        itemNameBox.Text = null;
                        itemDesBox.Text = null;

                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Cannot Add Items, Try Again", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        itemIDBox.Text = null;
                        itemNameBox.Text = null;
                        itemDesBox.Text = null;

                        con.Close();
                    }
                }
            }
            
            else
            {
                MessageBox.Show("Please Input values to Item ID & Item Name", "Inputs are not visible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void AddItem_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Savindu\source\repos\InventAscent_InventoryMGTSystem\InventoryManagement.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "SELECT CategoryName FROM Category";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = cmd;
            DataTable table1 = new DataTable();
            da.Fill(table1);

            cateNameDrop.DataSource = table1;
            cateNameDrop.DisplayMember = "CategoryName";
            cateNameDrop.ValueMember = "CategoryName";
        }

        private void cancelItemButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
