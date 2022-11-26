namespace InventAscent
{
    partial class updateItem
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
            this.label4 = new System.Windows.Forms.Label();
            this.itemidBox = new System.Windows.Forms.TextBox();
            this.itemnameBox = new System.Windows.Forms.TextBox();
            this.storenameCombo = new System.Windows.Forms.ComboBox();
            this.itemdesBox = new System.Windows.Forms.TextBox();
            this.updateitemButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(34, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(34, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(34, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(34, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description";
            // 
            // itemidBox
            // 
            this.itemidBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.itemidBox.Location = new System.Drawing.Point(143, 21);
            this.itemidBox.Name = "itemidBox";
            this.itemidBox.Size = new System.Drawing.Size(222, 30);
            this.itemidBox.TabIndex = 4;
            // 
            // itemnameBox
            // 
            this.itemnameBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.itemnameBox.Location = new System.Drawing.Point(143, 62);
            this.itemnameBox.Name = "itemnameBox";
            this.itemnameBox.Size = new System.Drawing.Size(222, 30);
            this.itemnameBox.TabIndex = 4;
            // 
            // storenameCombo
            // 
            this.storenameCombo.FormattingEnabled = true;
            this.storenameCombo.Location = new System.Drawing.Point(143, 110);
            this.storenameCombo.Name = "storenameCombo";
            this.storenameCombo.Size = new System.Drawing.Size(151, 28);
            this.storenameCombo.TabIndex = 5;
            // 
            // itemdesBox
            // 
            this.itemdesBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.itemdesBox.Location = new System.Drawing.Point(143, 164);
            this.itemdesBox.Multiline = true;
            this.itemdesBox.Name = "itemdesBox";
            this.itemdesBox.PlaceholderText = "Enter new item description";
            this.itemdesBox.Size = new System.Drawing.Size(347, 74);
            this.itemdesBox.TabIndex = 6;
            // 
            // updateitemButton
            // 
            this.updateitemButton.BackColor = System.Drawing.Color.SandyBrown;
            this.updateitemButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.updateitemButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.updateitemButton.Location = new System.Drawing.Point(502, 12);
            this.updateitemButton.Name = "updateitemButton";
            this.updateitemButton.Size = new System.Drawing.Size(173, 56);
            this.updateitemButton.TabIndex = 7;
            this.updateitemButton.Text = "Update Item";
            this.updateitemButton.UseVisualStyleBackColor = false;
            this.updateitemButton.Click += new System.EventHandler(this.updateitemButton_Click);
            // 
            // updateItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(687, 250);
            this.Controls.Add(this.updateitemButton);
            this.Controls.Add(this.itemdesBox);
            this.Controls.Add(this.storenameCombo);
            this.Controls.Add(this.itemnameBox);
            this.Controls.Add(this.itemidBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "updateItem";
            this.Text = "updateItem";
            this.Load += new System.EventHandler(this.updateItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox itemidBox;
        private TextBox itemnameBox;
        private ComboBox storenameCombo;
        private TextBox itemdesBox;
        private Button updateitemButton;
    }
}