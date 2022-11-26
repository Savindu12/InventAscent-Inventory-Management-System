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
    public partial class UDashboard : Form
    {
        public UDashboard()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditManager EM = new EditManager();
            EM.Show();
        }

        private void addManagerButton_Click(object sender, EventArgs e)
        {
            AddUser AM = new AddUser();
            AM.Show();
        }

        private void UDashboard_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Savindu\source\repos\InventAscent_InventoryMGTSystem\InventoryManagement.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "SELECT * FROM StoreManager";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sdr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            managerDataGrid.DataSource = dt;
            con.Close();
        }

        private void managerSearchBox_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Savindu\source\repos\InventAscent_InventoryMGTSystem\InventoryManagement.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "SELECT * FROM StoreManager WHERE Managername LIKE '" + managerSearchBox.Text + "%'  ";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sdr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            managerDataGrid.DataSource = dt;
            con.Close();
        }
    }
}
