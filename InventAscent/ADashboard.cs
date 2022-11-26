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
using static InventAscent.LoginForm;

namespace InventAscent
{
    public partial class ADashboard : Form
    {   
        public ADashboard()
        {
            InitializeComponent();
        }
        private void ADashboard_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Savindu\source\repos\InventAscent_InventoryMGTSystem\InventoryManagement.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "SELECT Count(*) FROM StoreInfo";
            string query2 = "SELECT Count(*) FROM StoreManager";
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlDataAdapter sda2 = new SqlDataAdapter(query2, con);
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            sda.Fill(dt);
            sda2.Fill(dt2);
            stores.Text = dt.Rows[0][0].ToString();
            storemanagers.Text = dt2.Rows[0][0].ToString();
            con.Close();
        }
    }
}
