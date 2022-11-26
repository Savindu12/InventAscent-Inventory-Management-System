namespace InventAscent
{
    partial class priceDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(priceDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.updateButton = new System.Windows.Forms.Button();
            this.priceDataGrid = new System.Windows.Forms.DataGridView();
            this.addPriceButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchPriceName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.searchPriceName);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(817, 504);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SandyBrown;
            this.panel4.Location = new System.Drawing.Point(48, 16);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(26, 51);
            this.panel4.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.panel3.Location = new System.Drawing.Point(16, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(26, 51);
            this.panel3.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.updateButton);
            this.panel2.Controls.Add(this.priceDataGrid);
            this.panel2.Controls.Add(this.addPriceButton);
            this.panel2.Location = new System.Drawing.Point(-1, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(817, 430);
            this.panel2.TabIndex = 1;
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.SandyBrown;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.updateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.updateButton.Location = new System.Drawing.Point(679, 361);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(122, 52);
            this.updateButton.TabIndex = 3;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // priceDataGrid
            // 
            this.priceDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.priceDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.priceDataGrid.Location = new System.Drawing.Point(16, 24);
            this.priceDataGrid.Name = "priceDataGrid";
            this.priceDataGrid.RowHeadersWidth = 51;
            this.priceDataGrid.RowTemplate.Height = 29;
            this.priceDataGrid.Size = new System.Drawing.Size(785, 318);
            this.priceDataGrid.TabIndex = 0;
            // 
            // addPriceButton
            // 
            this.addPriceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.addPriceButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addPriceButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addPriceButton.ForeColor = System.Drawing.Color.SandyBrown;
            this.addPriceButton.Location = new System.Drawing.Point(515, 361);
            this.addPriceButton.Name = "addPriceButton";
            this.addPriceButton.Size = new System.Drawing.Size(148, 52);
            this.addPriceButton.TabIndex = 2;
            this.addPriceButton.Text = "Add Price";
            this.addPriceButton.UseVisualStyleBackColor = false;
            this.addPriceButton.Click += new System.EventHandler(this.addPriceButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(765, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(92, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Price Management";
            // 
            // searchPriceName
            // 
            this.searchPriceName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchPriceName.Location = new System.Drawing.Point(552, 20);
            this.searchPriceName.Multiline = true;
            this.searchPriceName.Name = "searchPriceName";
            this.searchPriceName.PlaceholderText = "Search by Item Name";
            this.searchPriceName.Size = new System.Drawing.Size(249, 39);
            this.searchPriceName.TabIndex = 4;
            this.searchPriceName.TextChanged += new System.EventHandler(this.searchPriceName_TextChanged);
            // 
            // priceDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(841, 528);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "priceDashboard";
            this.Text = "priceDashboard";
            this.Load += new System.EventHandler(this.priceDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.priceDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private TextBox searchPriceName;
        private Button updateButton;
        private Button addPriceButton;
        private DataGridView priceDataGrid;
        private PictureBox pictureBox1;
        private Panel panel4;
        private Panel panel3;
    }
}