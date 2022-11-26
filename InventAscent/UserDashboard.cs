using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventAscent
{
    public partial class UserDashboard : Form
    {
        LoginForm.userName Un;
        public string sa;
        public UserDashboard(LoginForm.userName U1)
        {
            InitializeComponent();
            loadForm(new ADashboard());
            Un = U1;
        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {
            timer1_Tick.Start();
            sa = Un.username;
            userName.Text = Un.username;
        }

        public void loadForm (object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();
        }

        private void timer1_Tick_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.ToLongTimeString();
            DateLabel.Text = DateTime.Now.ToLongDateString();
        }

        //private void myBtnSetting (object sender, EventArgs e)
        //{
         //   foreach (Control c in SidePanel.Controls)
         //   {
         //       c.BackColor = Color.White;
         //       c.ForeColor = Color.Black;
         //   }

        //    Control click = (Control)sender;
       //     click.BackColor = Color.Black;
       //     click.ForeColor = Color.White;
       // }

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            loadForm(new ADashboard());
        }

        private void StoreButton_Click(object sender, EventArgs e)
        {
            loadForm(new SDashboard());
        }

        private void UserButton_Click(object sender, EventArgs e)
        {
            loadForm(new UDashboard());
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            loadForm(new EProfile());
        }

        private void DashboardButton_Click_1(object sender, EventArgs e)
        {
            loadForm(new ADashboard());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoginForm LF = new LoginForm();
            LF.Show();
            this.Hide();
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DashboardButton_MouseHover(object sender, EventArgs e)
        {
           // DashboardButton.BackColor = Color.AliceBlue;
            //DashboardButton.ForeColor = Color.DarkBlue;
        }

        private void DashboardButton_MouseLeave(object sender, EventArgs e)
        {
            //DashboardButton.BackColor = SystemColors.Control;
           //DashboardButton.ForeColor = SystemColors.Control;
        }
    }
}
