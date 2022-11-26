namespace InventAscent
{
    partial class AddPrice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPrice));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.priceDateTime = new System.Windows.Forms.DateTimePicker();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addPriceButton = new System.Windows.Forms.Button();
            this.itmQuantityType = new System.Windows.Forms.ComboBox();
            this.itmPrice = new System.Windows.Forms.TextBox();
            this.itmQuantity = new System.Windows.Forms.TextBox();
            this.itmCategory = new System.Windows.Forms.TextBox();
            this.itmName = new System.Windows.Forms.TextBox();
            this.itemIDComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(8, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(416, 57);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(90, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Prices";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(456, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.priceDateTime);
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Controls.Add(this.addPriceButton);
            this.panel1.Controls.Add(this.itmQuantityType);
            this.panel1.Controls.Add(this.itmPrice);
            this.panel1.Controls.Add(this.itmQuantity);
            this.panel1.Controls.Add(this.itmCategory);
            this.panel1.Controls.Add(this.itmName);
            this.panel1.Controls.Add(this.itemIDComboBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(8, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 452);
            this.panel1.TabIndex = 4;
            // 
            // priceDateTime
            // 
            this.priceDateTime.CustomFormat = "";
            this.priceDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.priceDateTime.Location = new System.Drawing.Point(542, 17);
            this.priceDateTime.Name = "priceDateTime";
            this.priceDateTime.Size = new System.Drawing.Size(154, 34);
            this.priceDateTime.TabIndex = 6;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.SandyBrown;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancelButton.ForeColor = System.Drawing.Color.Black;
            this.cancelButton.Location = new System.Drawing.Point(554, 373);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(130, 55);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addPriceButton
            // 
            this.addPriceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.addPriceButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addPriceButton.ForeColor = System.Drawing.Color.SandyBrown;
            this.addPriceButton.Location = new System.Drawing.Point(380, 373);
            this.addPriceButton.Name = "addPriceButton";
            this.addPriceButton.Size = new System.Drawing.Size(158, 55);
            this.addPriceButton.TabIndex = 4;
            this.addPriceButton.Text = "Add Price";
            this.addPriceButton.UseVisualStyleBackColor = false;
            this.addPriceButton.Click += new System.EventHandler(this.addPriceButton_Click);
            // 
            // itmQuantityType
            // 
            this.itmQuantityType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.itmQuantityType.FormattingEnabled = true;
            this.itmQuantityType.Items.AddRange(new object[] {
            "g (gram)",
            "Kg (Kilogram)",
            "Ml (Milileter)",
            "L (Leter)",
            "Count"});
            this.itmQuantityType.Location = new System.Drawing.Point(239, 236);
            this.itmQuantityType.Name = "itmQuantityType";
            this.itmQuantityType.Size = new System.Drawing.Size(81, 36);
            this.itmQuantityType.TabIndex = 3;
            // 
            // itmPrice
            // 
            this.itmPrice.Location = new System.Drawing.Point(239, 291);
            this.itmPrice.Multiline = true;
            this.itmPrice.Name = "itmPrice";
            this.itmPrice.PlaceholderText = "Enter a price";
            this.itmPrice.Size = new System.Drawing.Size(226, 41);
            this.itmPrice.TabIndex = 2;
            // 
            // itmQuantity
            // 
            this.itmQuantity.Location = new System.Drawing.Point(326, 236);
            this.itmQuantity.Multiline = true;
            this.itmQuantity.Name = "itmQuantity";
            this.itmQuantity.PlaceholderText = "Enter quantity value";
            this.itmQuantity.Size = new System.Drawing.Size(213, 40);
            this.itmQuantity.TabIndex = 2;
            // 
            // itmCategory
            // 
            this.itmCategory.Location = new System.Drawing.Point(239, 181);
            this.itmCategory.Multiline = true;
            this.itmCategory.Name = "itmCategory";
            this.itmCategory.Size = new System.Drawing.Size(300, 38);
            this.itmCategory.TabIndex = 2;
            // 
            // itmName
            // 
            this.itmName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.itmName.Location = new System.Drawing.Point(239, 128);
            this.itmName.Multiline = true;
            this.itmName.Name = "itmName";
            this.itmName.Size = new System.Drawing.Size(300, 38);
            this.itmName.TabIndex = 2;
            // 
            // itemIDComboBox
            // 
            this.itemIDComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.itemIDComboBox.FormattingEnabled = true;
            this.itemIDComboBox.Location = new System.Drawing.Point(239, 76);
            this.itemIDComboBox.Name = "itemIDComboBox";
            this.itemIDComboBox.Size = new System.Drawing.Size(161, 36);
            this.itemIDComboBox.TabIndex = 1;
            this.itemIDComboBox.SelectedIndexChanged += new System.EventHandler(this.itemIDComboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(400, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "Created At";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(89, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(89, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(89, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Category ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(89, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Item Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(89, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Item ID";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SandyBrown;
            this.panel3.Location = new System.Drawing.Point(8, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(416, 35);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(432, -1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(18, 98);
            this.panel4.TabIndex = 1;
            // 
            // AddPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 560);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddPrice";
            this.Text = "AddPrice";
            this.Load += new System.EventHandler(this.AddPrice_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button cancelButton;
        private Button addPriceButton;
        private ComboBox itmQuantityType;
        private TextBox itmPrice;
        private TextBox itmQuantity;
        private TextBox itmCategory;
        private TextBox itmName;
        private ComboBox itemIDComboBox;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker priceDateTime;
        private Label label7;
        private Panel panel3;
        private Panel panel4;
    }
}