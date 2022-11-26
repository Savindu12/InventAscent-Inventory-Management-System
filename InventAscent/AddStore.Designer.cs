namespace InventAscent
{
    partial class AddStore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStore));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.storeManBox = new System.Windows.Forms.ComboBox();
            this.createdDate = new System.Windows.Forms.DateTimePicker();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddStoreButton = new System.Windows.Forms.Button();
            this.storeDesBox = new System.Windows.Forms.TextBox();
            this.storeLocBox = new System.Windows.Forms.TextBox();
            this.storeNameBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(580, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 558);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Location = new System.Drawing.Point(3, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(105, 558);
            this.panel6.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SandyBrown;
            this.panel3.Location = new System.Drawing.Point(114, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(32, 555);
            this.panel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(76, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add New Store";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.storeManBox);
            this.panel2.Controls.Add(this.createdDate);
            this.panel2.Controls.Add(this.CancelButton);
            this.panel2.Controls.Add(this.AddStoreButton);
            this.panel2.Controls.Add(this.storeDesBox);
            this.panel2.Controls.Add(this.storeLocBox);
            this.panel2.Controls.Add(this.storeNameBox);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(23, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(551, 473);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // storeManBox
            // 
            this.storeManBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.storeManBox.FormattingEnabled = true;
            this.storeManBox.Location = new System.Drawing.Point(35, 175);
            this.storeManBox.Name = "storeManBox";
            this.storeManBox.Size = new System.Drawing.Size(221, 36);
            this.storeManBox.TabIndex = 9;
            // 
            // createdDate
            // 
            this.createdDate.CustomFormat = "yyyy-MM-dd";
            this.createdDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createdDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.createdDate.Location = new System.Drawing.Point(288, 175);
            this.createdDate.Name = "createdDate";
            this.createdDate.Size = new System.Drawing.Size(226, 34);
            this.createdDate.TabIndex = 8;
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.SandyBrown;
            this.CancelButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CancelButton.ForeColor = System.Drawing.Color.Black;
            this.CancelButton.Location = new System.Drawing.Point(395, 395);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(119, 56);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddStoreButton
            // 
            this.AddStoreButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.AddStoreButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddStoreButton.ForeColor = System.Drawing.Color.SandyBrown;
            this.AddStoreButton.Location = new System.Drawing.Point(213, 394);
            this.AddStoreButton.Name = "AddStoreButton";
            this.AddStoreButton.Size = new System.Drawing.Size(157, 57);
            this.AddStoreButton.TabIndex = 6;
            this.AddStoreButton.Text = "Add Store";
            this.AddStoreButton.UseVisualStyleBackColor = false;
            this.AddStoreButton.Click += new System.EventHandler(this.AddStoreButton_Click);
            // 
            // storeDesBox
            // 
            this.storeDesBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.storeDesBox.Location = new System.Drawing.Point(35, 277);
            this.storeDesBox.Multiline = true;
            this.storeDesBox.Name = "storeDesBox";
            this.storeDesBox.PlaceholderText = "Type here about store";
            this.storeDesBox.Size = new System.Drawing.Size(479, 98);
            this.storeDesBox.TabIndex = 5;
            // 
            // storeLocBox
            // 
            this.storeLocBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.storeLocBox.Location = new System.Drawing.Point(288, 69);
            this.storeLocBox.Multiline = true;
            this.storeLocBox.Name = "storeLocBox";
            this.storeLocBox.PlaceholderText = "Enter a location";
            this.storeLocBox.Size = new System.Drawing.Size(226, 43);
            this.storeLocBox.TabIndex = 5;
            // 
            // storeNameBox
            // 
            this.storeNameBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.storeNameBox.Location = new System.Drawing.Point(35, 69);
            this.storeNameBox.Multiline = true;
            this.storeNameBox.Name = "storeNameBox";
            this.storeNameBox.PlaceholderText = "Enter a store name";
            this.storeNameBox.Size = new System.Drawing.Size(221, 43);
            this.storeNameBox.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(35, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 32);
            this.label6.TabIndex = 4;
            this.label6.Text = "Store Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(35, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 32);
            this.label5.TabIndex = 3;
            this.label5.Text = "Store Manager";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(288, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "Created At";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(288, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Store Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(35, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Store Name";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SandyBrown;
            this.panel4.Location = new System.Drawing.Point(50, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(20, 52);
            this.panel4.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.panel5.Location = new System.Drawing.Point(23, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(21, 52);
            this.panel5.TabIndex = 4;
            // 
            // AddStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 560);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddStore";
            this.Text = "AddStore";
            this.Load += new System.EventHandler(this.AddStore_Load);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private DateTimePicker createdDate;
        private Button CancelButton;
        private Button AddStoreButton;
        private TextBox storeDesBox;
        private TextBox storeLocBox;
        private TextBox storeNameBox;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox storeManBox;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private PictureBox pictureBox1;
    }
}