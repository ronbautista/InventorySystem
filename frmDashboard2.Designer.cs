namespace InventorySystem
{
    partial class frmDashboard2
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
            this.scDashboard = new System.Windows.Forms.SplitContainer();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.scDashboard)).BeginInit();
            this.scDashboard.Panel1.SuspendLayout();
            this.scDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // scDashboard
            // 
            this.scDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scDashboard.Location = new System.Drawing.Point(0, 0);
            this.scDashboard.Name = "scDashboard";
            // 
            // scDashboard.Panel1
            // 
            this.scDashboard.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.scDashboard.Panel1.Controls.Add(this.btnSettings);
            this.scDashboard.Panel1.Controls.Add(this.btnReports);
            this.scDashboard.Panel1.Controls.Add(this.btnSuppliers);
            this.scDashboard.Panel1.Controls.Add(this.btnCategories);
            this.scDashboard.Panel1.Controls.Add(this.btnProducts);
            this.scDashboard.Size = new System.Drawing.Size(915, 610);
            this.scDashboard.SplitterDistance = 220;
            this.scDashboard.TabIndex = 0;
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSettings.Location = new System.Drawing.Point(3, 436);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSettings.Size = new System.Drawing.Size(214, 61);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            this.btnReports.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReports.Location = new System.Drawing.Point(3, 369);
            this.btnReports.Name = "btnReports";
            this.btnReports.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnReports.Size = new System.Drawing.Size(214, 61);
            this.btnReports.TabIndex = 3;
            this.btnReports.Text = "Reports";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.UseVisualStyleBackColor = true;
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuppliers.FlatAppearance.BorderSize = 0;
            this.btnSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuppliers.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSuppliers.Location = new System.Drawing.Point(3, 302);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSuppliers.Size = new System.Drawing.Size(214, 61);
            this.btnSuppliers.TabIndex = 2;
            this.btnSuppliers.Text = "Suppliers";
            this.btnSuppliers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuppliers.UseVisualStyleBackColor = true;
            // 
            // btnCategories
            // 
            this.btnCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCategories.FlatAppearance.BorderSize = 0;
            this.btnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategories.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCategories.Location = new System.Drawing.Point(3, 235);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnCategories.Size = new System.Drawing.Size(214, 61);
            this.btnCategories.TabIndex = 1;
            this.btnCategories.Text = "Categories";
            this.btnCategories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategories.UseVisualStyleBackColor = true;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProducts.Location = new System.Drawing.Point(3, 168);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnProducts.Size = new System.Drawing.Size(214, 61);
            this.btnProducts.TabIndex = 0;
            this.btnProducts.Text = "Products";
            this.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // frmDashboard2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 610);
            this.Controls.Add(this.scDashboard);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDashboard2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmDashboard2";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.scDashboard.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scDashboard)).EndInit();
            this.scDashboard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer scDashboard;
        private Button btnProducts;
        private Button btnReports;
        private Button btnSuppliers;
        private Button btnCategories;
        private Button btnSettings;
    }
}