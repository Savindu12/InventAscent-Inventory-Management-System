namespace InventAscent
{
    partial class UDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UDashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.editManagerButton = new System.Windows.Forms.Button();
            this.addManagerButton = new System.Windows.Forms.Button();
            this.managerDataGrid = new System.Windows.Forms.DataGridView();
            this.managerSearchBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(106, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Store Manager Details";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.editManagerButton);
            this.panel1.Controls.Add(this.addManagerButton);
            this.panel1.Controls.Add(this.managerDataGrid);
            this.panel1.Controls.Add(this.managerSearchBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(817, 504);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SandyBrown;
            this.panel3.Location = new System.Drawing.Point(76, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(24, 43);
            this.panel3.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.panel2.Location = new System.Drawing.Point(46, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(24, 43);
            this.panel2.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(761, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // editManagerButton
            // 
            this.editManagerButton.BackColor = System.Drawing.Color.SandyBrown;
            this.editManagerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editManagerButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editManagerButton.ForeColor = System.Drawing.Color.Black;
            this.editManagerButton.Location = new System.Drawing.Point(644, 430);
            this.editManagerButton.Name = "editManagerButton";
            this.editManagerButton.Size = new System.Drawing.Size(154, 53);
            this.editManagerButton.TabIndex = 4;
            this.editManagerButton.Text = "Edit Manager";
            this.editManagerButton.UseVisualStyleBackColor = false;
            this.editManagerButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // addManagerButton
            // 
            this.addManagerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.addManagerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addManagerButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addManagerButton.ForeColor = System.Drawing.Color.SandyBrown;
            this.addManagerButton.Location = new System.Drawing.Point(464, 430);
            this.addManagerButton.Name = "addManagerButton";
            this.addManagerButton.Size = new System.Drawing.Size(164, 53);
            this.addManagerButton.TabIndex = 3;
            this.addManagerButton.Text = "Add Manager";
            this.addManagerButton.UseVisualStyleBackColor = false;
            this.addManagerButton.Click += new System.EventHandler(this.addManagerButton_Click);
            // 
            // managerDataGrid
            // 
            this.managerDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.managerDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.managerDataGrid.Location = new System.Drawing.Point(46, 88);
            this.managerDataGrid.Name = "managerDataGrid";
            this.managerDataGrid.RowHeadersWidth = 51;
            this.managerDataGrid.RowTemplate.Height = 29;
            this.managerDataGrid.Size = new System.Drawing.Size(752, 324);
            this.managerDataGrid.TabIndex = 2;
            // 
            // managerSearchBox
            // 
            this.managerSearchBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.managerSearchBox.Location = new System.Drawing.Point(542, 30);
            this.managerSearchBox.Multiline = true;
            this.managerSearchBox.Name = "managerSearchBox";
            this.managerSearchBox.PlaceholderText = "Search by Name";
            this.managerSearchBox.Size = new System.Drawing.Size(256, 39);
            this.managerSearchBox.TabIndex = 1;
            this.managerSearchBox.TextChanged += new System.EventHandler(this.managerSearchBox_TextChanged);
            // 
            // UDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(841, 528);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UDashboard";
            this.Text = "UDashboard";
            this.Load += new System.EventHandler(this.UDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TextBox managerSearchBox;
        private DataGridView managerDataGrid;
        private Button editManagerButton;
        private Button addManagerButton;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Panel panel2;
    }
}