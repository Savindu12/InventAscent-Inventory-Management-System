namespace InventAscent
{
    partial class AddItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItem));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancelItemButton = new System.Windows.Forms.Button();
            this.addItemButton = new System.Windows.Forms.Button();
            this.cateNameDrop = new System.Windows.Forms.ComboBox();
            this.itemDesBox = new System.Windows.Forms.TextBox();
            this.itemNameBox = new System.Windows.Forms.TextBox();
            this.itemIDBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cancelItemButton);
            this.panel1.Controls.Add(this.addItemButton);
            this.panel1.Controls.Add(this.cateNameDrop);
            this.panel1.Controls.Add(this.itemDesBox);
            this.panel1.Controls.Add(this.itemNameBox);
            this.panel1.Controls.Add(this.itemIDBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 458);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cancelItemButton
            // 
            this.cancelItemButton.BackColor = System.Drawing.Color.SandyBrown;
            this.cancelItemButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancelItemButton.ForeColor = System.Drawing.Color.Black;
            this.cancelItemButton.Location = new System.Drawing.Point(544, 379);
            this.cancelItemButton.Name = "cancelItemButton";
            this.cancelItemButton.Size = new System.Drawing.Size(145, 63);
            this.cancelItemButton.TabIndex = 8;
            this.cancelItemButton.Text = "Cancel";
            this.cancelItemButton.UseVisualStyleBackColor = false;
            this.cancelItemButton.Click += new System.EventHandler(this.cancelItemButton_Click);
            // 
            // addItemButton
            // 
            this.addItemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.addItemButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addItemButton.ForeColor = System.Drawing.Color.SandyBrown;
            this.addItemButton.Location = new System.Drawing.Point(368, 379);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(170, 64);
            this.addItemButton.TabIndex = 6;
            this.addItemButton.Text = "Add Item";
            this.addItemButton.UseVisualStyleBackColor = false;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // cateNameDrop
            // 
            this.cateNameDrop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cateNameDrop.FormattingEnabled = true;
            this.cateNameDrop.Location = new System.Drawing.Point(267, 176);
            this.cateNameDrop.Name = "cateNameDrop";
            this.cateNameDrop.Size = new System.Drawing.Size(262, 36);
            this.cateNameDrop.TabIndex = 5;
            // 
            // itemDesBox
            // 
            this.itemDesBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.itemDesBox.Location = new System.Drawing.Point(267, 243);
            this.itemDesBox.Multiline = true;
            this.itemDesBox.Name = "itemDesBox";
            this.itemDesBox.PlaceholderText = "Type here about Item";
            this.itemDesBox.Size = new System.Drawing.Size(422, 101);
            this.itemDesBox.TabIndex = 4;
            // 
            // itemNameBox
            // 
            this.itemNameBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.itemNameBox.Location = new System.Drawing.Point(267, 103);
            this.itemNameBox.Multiline = true;
            this.itemNameBox.Name = "itemNameBox";
            this.itemNameBox.PlaceholderText = "Enter Item Name";
            this.itemNameBox.Size = new System.Drawing.Size(262, 45);
            this.itemNameBox.TabIndex = 4;
            // 
            // itemIDBox
            // 
            this.itemIDBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.itemIDBox.Location = new System.Drawing.Point(267, 41);
            this.itemIDBox.Multiline = true;
            this.itemIDBox.Name = "itemIDBox";
            this.itemIDBox.PlaceholderText = "Enter Item ID";
            this.itemIDBox.Size = new System.Drawing.Size(262, 44);
            this.itemIDBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(50, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 32);
            this.label5.TabIndex = 3;
            this.label5.Text = "Category Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(50, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "Item Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(50, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Item Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(50, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Item ID";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SandyBrown;
            this.panel2.Location = new System.Drawing.Point(280, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(446, 36);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(280, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(446, 51);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(157, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Item";
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 560);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddItem";
            this.Text = "AddItem";
            this.Load += new System.EventHandler(this.AddItem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Button addItemButton;
        private ComboBox cateNameDrop;
        private TextBox itemDesBox;
        private TextBox itemNameBox;
        private TextBox itemIDBox;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button cancelItemButton;
    }
}