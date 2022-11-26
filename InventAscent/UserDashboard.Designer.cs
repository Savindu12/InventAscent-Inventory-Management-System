namespace InventAscent
{
    partial class UserDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDashboard));
            this.timer1_Tick = new System.Windows.Forms.Timer(this.components);
            this.DateLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.Appbar = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.ProfileButton = new System.Windows.Forms.Button();
            this.UserButton = new System.Windows.Forms.Button();
            this.StoreButton = new System.Windows.Forms.Button();
            this.DashboardButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.Appbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1_Tick
            // 
            this.timer1_Tick.Tick += new System.EventHandler(this.timer1_Tick_Tick);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DateLabel.Location = new System.Drawing.Point(297, 43);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(41, 20);
            this.DateLabel.TabIndex = 0;
            this.DateLabel.Text = "Date";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TimeLabel.Location = new System.Drawing.Point(297, 10);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(42, 20);
            this.TimeLabel.TabIndex = 1;
            this.TimeLabel.Text = "Time";
            // 
            // Appbar
            // 
            this.Appbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.Appbar.Controls.Add(this.label3);
            this.Appbar.Controls.Add(this.label2);
            this.Appbar.Controls.Add(this.label1);
            this.Appbar.Controls.Add(this.userName);
            this.Appbar.Controls.Add(this.panel2);
            this.Appbar.Controls.Add(this.panel1);
            this.Appbar.Controls.Add(this.pictureBox1);
            this.Appbar.Controls.Add(this.DateLabel);
            this.Appbar.Controls.Add(this.TimeLabel);
            this.Appbar.Location = new System.Drawing.Point(-2, 1);
            this.Appbar.Name = "Appbar";
            this.Appbar.Size = new System.Drawing.Size(1129, 81);
            this.Appbar.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(945, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Admin";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(871, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Role:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(871, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userName.ForeColor = System.Drawing.Color.White;
            this.userName.Location = new System.Drawing.Point(945, 3);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(65, 28);
            this.userName.TabIndex = 4;
            this.userName.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SandyBrown;
            this.panel2.Location = new System.Drawing.Point(1078, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(18, 53);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(1102, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(18, 53);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.SidePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SidePanel.Controls.Add(this.button4);
            this.SidePanel.Controls.Add(this.ProfileButton);
            this.SidePanel.Controls.Add(this.UserButton);
            this.SidePanel.Controls.Add(this.StoreButton);
            this.SidePanel.Controls.Add(this.DashboardButton);
            this.SidePanel.Location = new System.Drawing.Point(1, 80);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(279, 536);
            this.SidePanel.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.Location = new System.Drawing.Point(2, 466);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(273, 65);
            this.button4.TabIndex = 4;
            this.button4.Text = "Sign Out";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ProfileButton
            // 
            this.ProfileButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProfileButton.Image = ((System.Drawing.Image)(resources.GetObject("ProfileButton.Image")));
            this.ProfileButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ProfileButton.Location = new System.Drawing.Point(3, 304);
            this.ProfileButton.Name = "ProfileButton";
            this.ProfileButton.Size = new System.Drawing.Size(272, 95);
            this.ProfileButton.TabIndex = 4;
            this.ProfileButton.Text = "Profile  ";
            this.ProfileButton.UseVisualStyleBackColor = true;
            this.ProfileButton.Click += new System.EventHandler(this.ProfileButton_Click);
            // 
            // UserButton
            // 
            this.UserButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserButton.Image = ((System.Drawing.Image)(resources.GetObject("UserButton.Image")));
            this.UserButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UserButton.Location = new System.Drawing.Point(3, 101);
            this.UserButton.Name = "UserButton";
            this.UserButton.Size = new System.Drawing.Size(272, 95);
            this.UserButton.TabIndex = 4;
            this.UserButton.Text = "Manager";
            this.UserButton.UseVisualStyleBackColor = true;
            this.UserButton.Click += new System.EventHandler(this.UserButton_Click);
            // 
            // StoreButton
            // 
            this.StoreButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StoreButton.Image = ((System.Drawing.Image)(resources.GetObject("StoreButton.Image")));
            this.StoreButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StoreButton.Location = new System.Drawing.Point(3, 202);
            this.StoreButton.Name = "StoreButton";
            this.StoreButton.Size = new System.Drawing.Size(272, 96);
            this.StoreButton.TabIndex = 4;
            this.StoreButton.Text = "Stores  ";
            this.StoreButton.UseVisualStyleBackColor = true;
            this.StoreButton.Click += new System.EventHandler(this.StoreButton_Click);
            // 
            // DashboardButton
            // 
            this.DashboardButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DashboardButton.Image = ((System.Drawing.Image)(resources.GetObject("DashboardButton.Image")));
            this.DashboardButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DashboardButton.Location = new System.Drawing.Point(2, 7);
            this.DashboardButton.Name = "DashboardButton";
            this.DashboardButton.Size = new System.Drawing.Size(272, 88);
            this.DashboardButton.TabIndex = 4;
            this.DashboardButton.Text = "Dashboard";
            this.DashboardButton.UseVisualStyleBackColor = true;
            this.DashboardButton.Click += new System.EventHandler(this.DashboardButton_Click_1);
            this.DashboardButton.MouseLeave += new System.EventHandler(this.DashboardButton_MouseLeave);
            this.DashboardButton.MouseHover += new System.EventHandler(this.DashboardButton_MouseHover);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mainPanel.Location = new System.Drawing.Point(286, 88);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(841, 528);
            this.mainPanel.TabIndex = 4;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // UserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 619);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.SidePanel);
            this.Controls.Add(this.Appbar);
            this.Name = "UserDashboard";
            this.Text = "UserDashboard";
            this.Load += new System.EventHandler(this.UserDashboard_Load);
            this.Appbar.ResumeLayout(false);
            this.Appbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.SidePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1_Tick;
        private Label DateLabel;
        private Label TimeLabel;
        private Panel Appbar;
        private PictureBox pictureBox1;
        private Panel SidePanel;
        private Button button4;
        private Button ProfileButton;
        private Button UserButton;
        private Button StoreButton;
        private Button DashboardButton;
        private Panel mainPanel;
        private Panel panel2;
        private Panel panel1;
        private Label userName;
        private Label label1;
        private Label label3;
        private Label label2;
    }
}