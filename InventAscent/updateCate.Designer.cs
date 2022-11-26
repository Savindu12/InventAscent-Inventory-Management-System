namespace InventAscent
{
    partial class updateCate
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.catenameBox = new System.Windows.Forms.TextBox();
            this.cateDesBox = new System.Windows.Forms.TextBox();
            this.cateupdateButton = new System.Windows.Forms.Button();
            this.categoryIdDrop = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.storeNameBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(25, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(25, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description";
            // 
            // catenameBox
            // 
            this.catenameBox.Location = new System.Drawing.Point(186, 119);
            this.catenameBox.Multiline = true;
            this.catenameBox.Name = "catenameBox";
            this.catenameBox.PlaceholderText = "Enter new category name";
            this.catenameBox.Size = new System.Drawing.Size(250, 34);
            this.catenameBox.TabIndex = 3;
            // 
            // cateDesBox
            // 
            this.cateDesBox.Location = new System.Drawing.Point(186, 169);
            this.cateDesBox.Multiline = true;
            this.cateDesBox.Name = "cateDesBox";
            this.cateDesBox.PlaceholderText = "Enter new category description";
            this.cateDesBox.Size = new System.Drawing.Size(250, 69);
            this.cateDesBox.TabIndex = 3;
            // 
            // cateupdateButton
            // 
            this.cateupdateButton.BackColor = System.Drawing.Color.SandyBrown;
            this.cateupdateButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cateupdateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.cateupdateButton.Location = new System.Drawing.Point(538, 12);
            this.cateupdateButton.Name = "cateupdateButton";
            this.cateupdateButton.Size = new System.Drawing.Size(137, 53);
            this.cateupdateButton.TabIndex = 4;
            this.cateupdateButton.Text = "Update ";
            this.cateupdateButton.UseVisualStyleBackColor = false;
            this.cateupdateButton.Click += new System.EventHandler(this.cateupdateButton_Click);
            // 
            // categoryIdDrop
            // 
            this.categoryIdDrop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.categoryIdDrop.FormattingEnabled = true;
            this.categoryIdDrop.Location = new System.Drawing.Point(186, 19);
            this.categoryIdDrop.Name = "categoryIdDrop";
            this.categoryIdDrop.Size = new System.Drawing.Size(206, 36);
            this.categoryIdDrop.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(23, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Store Name";
            // 
            // storeNameBox
            // 
            this.storeNameBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.storeNameBox.FormattingEnabled = true;
            this.storeNameBox.Location = new System.Drawing.Point(186, 65);
            this.storeNameBox.Name = "storeNameBox";
            this.storeNameBox.Size = new System.Drawing.Size(206, 36);
            this.storeNameBox.TabIndex = 5;
            // 
            // updateCate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(687, 250);
            this.Controls.Add(this.storeNameBox);
            this.Controls.Add(this.categoryIdDrop);
            this.Controls.Add(this.cateupdateButton);
            this.Controls.Add(this.cateDesBox);
            this.Controls.Add(this.catenameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "updateCate";
            this.Text = "updateCate";
            this.Load += new System.EventHandler(this.updateCate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox catenameBox;
        private TextBox cateDesBox;
        private Button cateupdateButton;
        private ComboBox categoryIdDrop;
        private Label label4;
        private ComboBox storeNameBox;
    }
}