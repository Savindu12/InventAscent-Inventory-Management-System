namespace InventAscent
{
    partial class AddCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCategory));
            this.panel1 = new System.Windows.Forms.Panel();
            this.storeNameBox = new System.Windows.Forms.ComboBox();
            this.cateCancelButton = new System.Windows.Forms.Button();
            this.addCateButton = new System.Windows.Forms.Button();
            this.cateDesBox = new System.Windows.Forms.TextBox();
            this.categoryNameBox = new System.Windows.Forms.TextBox();
            this.categoryIDBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.storeNameBox);
            this.panel1.Controls.Add(this.cateCancelButton);
            this.panel1.Controls.Add(this.addCateButton);
            this.panel1.Controls.Add(this.cateDesBox);
            this.panel1.Controls.Add(this.categoryNameBox);
            this.panel1.Controls.Add(this.categoryIDBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 458);
            this.panel1.TabIndex = 0;
            // 
            // storeNameBox
            // 
            this.storeNameBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.storeNameBox.FormattingEnabled = true;
            this.storeNameBox.Location = new System.Drawing.Point(286, 42);
            this.storeNameBox.Name = "storeNameBox";
            this.storeNameBox.Size = new System.Drawing.Size(188, 36);
            this.storeNameBox.TabIndex = 6;
            // 
            // cateCancelButton
            // 
            this.cateCancelButton.BackColor = System.Drawing.Color.SandyBrown;
            this.cateCancelButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cateCancelButton.ForeColor = System.Drawing.Color.Black;
            this.cateCancelButton.Location = new System.Drawing.Point(572, 373);
            this.cateCancelButton.Name = "cateCancelButton";
            this.cateCancelButton.Size = new System.Drawing.Size(110, 58);
            this.cateCancelButton.TabIndex = 5;
            this.cateCancelButton.Text = "Cancel";
            this.cateCancelButton.UseVisualStyleBackColor = false;
            this.cateCancelButton.Click += new System.EventHandler(this.cateCancelButton_Click);
            // 
            // addCateButton
            // 
            this.addCateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.addCateButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addCateButton.ForeColor = System.Drawing.Color.SandyBrown;
            this.addCateButton.Location = new System.Drawing.Point(385, 373);
            this.addCateButton.Name = "addCateButton";
            this.addCateButton.Size = new System.Drawing.Size(163, 59);
            this.addCateButton.TabIndex = 4;
            this.addCateButton.Text = "Add Category";
            this.addCateButton.UseVisualStyleBackColor = false;
            this.addCateButton.Click += new System.EventHandler(this.addCateButton_Click);
            // 
            // cateDesBox
            // 
            this.cateDesBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cateDesBox.Location = new System.Drawing.Point(286, 233);
            this.cateDesBox.Multiline = true;
            this.cateDesBox.Name = "cateDesBox";
            this.cateDesBox.PlaceholderText = "Type here about category";
            this.cateDesBox.Size = new System.Drawing.Size(396, 125);
            this.cateDesBox.TabIndex = 3;
            // 
            // categoryNameBox
            // 
            this.categoryNameBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.categoryNameBox.Location = new System.Drawing.Point(286, 169);
            this.categoryNameBox.Multiline = true;
            this.categoryNameBox.Name = "categoryNameBox";
            this.categoryNameBox.PlaceholderText = "Enter Category Name";
            this.categoryNameBox.Size = new System.Drawing.Size(292, 41);
            this.categoryNameBox.TabIndex = 3;
            // 
            // categoryIDBox
            // 
            this.categoryIDBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.categoryIDBox.Location = new System.Drawing.Point(286, 100);
            this.categoryIDBox.Multiline = true;
            this.categoryIDBox.Name = "categoryIDBox";
            this.categoryIDBox.PlaceholderText = "Enter Category ID";
            this.categoryIDBox.Size = new System.Drawing.Size(292, 41);
            this.categoryIDBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(36, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "Category Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(36, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Category Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(36, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "Store Name ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(36, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Category ID";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(269, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(457, 51);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(119, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Category";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SandyBrown;
            this.panel3.Location = new System.Drawing.Point(269, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(457, 32);
            this.panel3.TabIndex = 0;
            // 
            // AddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 560);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddCategory";
            this.Text = "AddCategory";
            this.Load += new System.EventHandler(this.AddCategory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private TextBox cateDesBox;
        private TextBox categoryNameBox;
        private TextBox categoryIDBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button addCateButton;
        private Button cateCancelButton;
        private ComboBox storeNameBox;
        private Label label5;
    }
}