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
    public partial class priceDashboard : Form
    {
        public priceDashboard()
        {
            InitializeComponent();
        }

        private void addPriceButton_Click(object sender, EventArgs e)
        {
            AddPrice AP = new AddPrice();
            AP.Show();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            UpdatePrice UP = new UpdatePrice();
            UP.Show();
        }

        private void priceDashboard_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Savindu\source\repos\InventAscent_InventoryMGTSystem\InventoryManagement.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "SELECT * FROM PriceInfo";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sdr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            priceDataGrid.DataSource = dt;

            priceDataGrid.Update();
            priceDataGrid.Refresh();

            con.Close();
        }

        private void searchPriceName_TextChanged(object sender, EventArgs e)
        {
            string priceName = searchPriceName.Text;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Savindu\source\repos\InventAscent_InventoryMGTSystem\InventoryManagement.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "SELECT * FROM PriceInfo WHERE ItemName LIKE '" + priceName + "%'";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sdr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            priceDataGrid.DataSource = dt;
            con.Close();
        }
    }
}
