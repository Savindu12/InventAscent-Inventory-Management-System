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
    public partial class itemdashboard : Form
    {
        public itemdashboard()
        {
            InitializeComponent();
        }

        private void updateBotton_Click(object sender, EventArgs e)
        {
            UpdateStore US = new UpdateStore();
            US.Show();
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            AddItem AI = new AddItem();
            
            AI.Show();
        }

        private void addCategoryButton_Click(object sender, EventArgs e)
        {
            AddCategory AC = new AddCategory();
            AC.Show();
        }
        
        private void itemdashboard_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Savindu\source\repos\InventAscent_InventoryMGTSystem\InventoryManagement.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "SELECT * FROM ItemInfo";
            string cate = "SELECT * FROM Category";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlCommand cmd2 = new SqlCommand(cate, con);
            SqlDataAdapter sdr = new SqlDataAdapter(cmd);
            SqlDataAdapter sdr2 = new SqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            sdr.Fill(dt);
            sdr2.Fill(dt2);
            itemDataGrid.DataSource = dt;
            cateDataGrid.DataSource = dt2;
            con.Close();
        }

        private void searchItemBox_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Savindu\source\repos\InventAscent_InventoryMGTSystem\InventoryManagement.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "SELECT * FROM ItemInfo WHERE ItemName LIKE '" + searchItemBox.Text + "%'  ";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sdr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            itemDataGrid.DataSource = dt;
            con.Close();
        }

        private void searchCateBox_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Savindu\source\repos\InventAscent_InventoryMGTSystem\InventoryManagement.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "SELECT * FROM Category WHERE CategoryName LIKE '" + searchCateBox.Text + "%'  ";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sdr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            cateDataGrid.DataSource = dt;
            con.Close();
        }
    }
}
