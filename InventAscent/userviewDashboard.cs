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
    public partial class userviewDashboard : Form
    {
        public userviewDashboard()
        {
            InitializeComponent();
        }

        private void userviewDashboard_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Savindu\source\repos\InventAscent_InventoryMGTSystem\InventoryManagement.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "SELECT Count(*) FROM Category";
            string query2 = "SELECT Count(*) FROM ItemInfo";
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlDataAdapter sda2 = new SqlDataAdapter(query2, con);
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            sda.Fill(dt);
            sda2.Fill(dt2);
            category.Text = dt.Rows[0][0].ToString();
            item.Text = dt2.Rows[0][0].ToString();
            con.Close();
        }
    }
}
