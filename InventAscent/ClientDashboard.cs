using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventAscent
{
    public partial class ClientDashboard : Form
    {
        LoginForm.userName Un;
        public string sa;
        public ClientDashboard(LoginForm.userName Un1)
        {
            InitializeComponent();
            loadForm(new userviewDashboard());
            Un = Un1;
        }

        private void ClientDashboard_Load(object sender, EventArgs e)
        {
            timer2Click.Start();
            sa = Un.username;
            userName.Text = Un.username;
        }

        private void timer2Click_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToLongTimeString();
            dateLabel.Text = DateTime.Now.ToLongDateString();
        }

        public void loadForm(object Form)
        {
            if (this.cMainPanel.Controls.Count > 0)
                this.cMainPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.cMainPanel.Controls.Add(f);
            this.cMainPanel.Tag = f;
            f.Show();
        }

        private void UserDashboard_Click(object sender, EventArgs e)
        {
            loadForm(new userviewDashboard());
        }

        private void signOutButton_Click(object sender, EventArgs e)
        {
            LoginForm LF = new LoginForm();
            LF.Show();
            this.Hide();
        }

        private void ItemsButton_Click(object sender, EventArgs e)
        {
            loadForm(new itemdashboard());
        }

        private void PricesButton_Click(object sender, EventArgs e)
        {
            loadForm(new priceDashboard());
        }

        private void ProfileButtton_Click(object sender, EventArgs e)
        {
            loadForm(new userProfileDashboard());
        }
    }
}
