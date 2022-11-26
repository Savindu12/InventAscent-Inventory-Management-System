namespace InventAscent
{
    partial class SDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SDashboard));
            this.smainPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.editStoreButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.storeGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.smainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // smainPanel
            // 
            this.smainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smainPanel.Controls.Add(this.panel2);
            this.smainPanel.Controls.Add(this.panel1);
            this.smainPanel.Controls.Add(this.editStoreButton);
            this.smainPanel.Controls.Add(this.pictureBox1);
            this.smainPanel.Controls.Add(this.searchBox);
            this.smainPanel.Controls.Add(this.button1);
            this.smainPanel.Controls.Add(this.storeGrid);
            this.smainPanel.Controls.Add(this.label1);
            this.smainPanel.Location = new System.Drawing.Point(12, 12);
            this.smainPanel.Name = "smainPanel";
            this.smainPanel.Size = new System.Drawing.Size(817, 504);
            this.smainPanel.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SandyBrown;
            this.panel2.Location = new System.Drawing.Point(71, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(25, 44);
            this.panel2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.panel1.Location = new System.Drawing.Point(40, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(25, 44);
            this.panel1.TabIndex = 6;
            // 
            // editStoreButton
            // 
            this.editStoreButton.BackColor = System.Drawing.Color.SandyBrown;
            this.editStoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editStoreButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editStoreButton.ForeColor = System.Drawing.Color.Black;
            this.editStoreButton.Location = new System.Drawing.Point(651, 437);
            this.editStoreButton.Name = "editStoreButton";
            this.editStoreButton.Size = new System.Drawing.Size(150, 53);
            this.editStoreButton.TabIndex = 5;
            this.editStoreButton.Text = "Edit Store";
            this.editStoreButton.UseVisualStyleBackColor = false;
            this.editStoreButton.Click += new System.EventHandler(this.editStoreButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(762, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchBox.Location = new System.Drawing.Point(536, 23);
            this.searchBox.Multiline = true;
            this.searchBox.Name = "searchBox";
            this.searchBox.PlaceholderText = "Search by Store name";
            this.searchBox.Size = new System.Drawing.Size(265, 44);
            this.searchBox.TabIndex = 3;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.SandyBrown;
            this.button1.Location = new System.Drawing.Point(470, 437);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 53);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add New Store";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // storeGrid
            // 
            this.storeGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.storeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.storeGrid.Location = new System.Drawing.Point(27, 95);
            this.storeGrid.Name = "storeGrid";
            this.storeGrid.RowHeadersWidth = 51;
            this.storeGrid.RowTemplate.Height = 29;
            this.storeGrid.Size = new System.Drawing.Size(774, 316);
            this.storeGrid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(113, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Store Details";
            // 
            // SDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(841, 528);
            this.Controls.Add(this.smainPanel);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SDashboard";
            this.Text = "SDashboard";
            this.Load += new System.EventHandler(this.SDashboard_Load);
            this.smainPanel.ResumeLayout(false);
            this.smainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel smainPanel;
        private Label label1;
        private TextBox searchBox;
        private Button button1;
        private DataGridView storeGrid;
        private PictureBox pictureBox1;
        private Button editStoreButton;
        private Panel panel2;
        private Panel panel1;
    }
}