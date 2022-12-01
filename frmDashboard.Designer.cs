namespace InventorySystem
{
    partial class frmDashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMProducts = new System.Windows.Forms.Button();
            this.btnMCategories = new System.Windows.Forms.Button();
            this.btnMSuppliers = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.dashboardMenu = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAboutUs = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.dashboardMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InventorySystem.Properties.Resources.delivery_box;
            this.pictureBox1.Location = new System.Drawing.Point(57, 261);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(217, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "STOCK MANAGEMENT SYSTEM";
            // 
            // btnMProducts
            // 
            this.btnMProducts.BackColor = System.Drawing.Color.LightGray;
            this.btnMProducts.Location = new System.Drawing.Point(57, 423);
            this.btnMProducts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMProducts.Name = "btnMProducts";
            this.btnMProducts.Size = new System.Drawing.Size(127, 49);
            this.btnMProducts.TabIndex = 3;
            this.btnMProducts.Text = "Manage Products";
            this.btnMProducts.UseVisualStyleBackColor = false;
            this.btnMProducts.Click += new System.EventHandler(this.btnMProducts_Click);
            // 
            // btnMCategories
            // 
            this.btnMCategories.BackColor = System.Drawing.Color.LightGray;
            this.btnMCategories.Location = new System.Drawing.Point(265, 423);
            this.btnMCategories.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMCategories.Name = "btnMCategories";
            this.btnMCategories.Size = new System.Drawing.Size(134, 49);
            this.btnMCategories.TabIndex = 4;
            this.btnMCategories.Text = "Manage Categories";
            this.btnMCategories.UseVisualStyleBackColor = false;
            this.btnMCategories.Click += new System.EventHandler(this.btnMCategories_Click);
            // 
            // btnMSuppliers
            // 
            this.btnMSuppliers.BackColor = System.Drawing.Color.LightGray;
            this.btnMSuppliers.Location = new System.Drawing.Point(483, 423);
            this.btnMSuppliers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMSuppliers.Name = "btnMSuppliers";
            this.btnMSuppliers.Size = new System.Drawing.Size(127, 49);
            this.btnMSuppliers.TabIndex = 5;
            this.btnMSuppliers.Text = "Manage Suppliers";
            this.btnMSuppliers.UseVisualStyleBackColor = false;
            this.btnMSuppliers.Click += new System.EventHandler(this.btnMSuppliers_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.LightGray;
            this.btnReport.Location = new System.Drawing.Point(707, 423);
            this.btnReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(127, 49);
            this.btnReport.TabIndex = 6;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::InventorySystem.Properties.Resources.classification;
            this.pictureBox2.Location = new System.Drawing.Point(272, 261);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(127, 132);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::InventorySystem.Properties.Resources.packages;
            this.pictureBox3.Location = new System.Drawing.Point(483, 261);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(127, 132);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::InventorySystem.Properties.Resources.checklist;
            this.pictureBox4.Location = new System.Drawing.Point(707, 261);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(127, 132);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // dashboardMenu
            // 
            this.dashboardMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.dashboardMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.dashboardMenu.Location = new System.Drawing.Point(0, 0);
            this.dashboardMenu.Name = "dashboardMenu";
            this.dashboardMenu.Size = new System.Drawing.Size(915, 28);
            this.dashboardMenu.TabIndex = 11;
            this.dashboardMenu.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEditAccount,
            this.menuExit,
            this.menuAboutUs});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.settingsToolStripMenuItem.Text = "SETTINGS";
            // 
            // menuEditAccount
            // 
            this.menuEditAccount.Name = "menuEditAccount";
            this.menuEditAccount.Size = new System.Drawing.Size(176, 26);
            this.menuEditAccount.Text = "Edit Account";
            this.menuEditAccount.Click += new System.EventHandler(this.menuEditAccount_Click);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(176, 26);
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // menuAboutUs
            // 
            this.menuAboutUs.Name = "menuAboutUs";
            this.menuAboutUs.Size = new System.Drawing.Size(176, 26);
            this.menuAboutUs.Text = "About";
            this.menuAboutUs.Click += new System.EventHandler(this.menuAboutUs_Click);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(915, 610);
            this.Controls.Add(this.dashboardMenu);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnMSuppliers);
            this.Controls.Add(this.btnMCategories);
            this.Controls.Add(this.btnMProducts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.dashboardMenu.ResumeLayout(false);
            this.dashboardMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button btnMCategories;
        private Button btnMSuppliers;
        private Button btnReport;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private MenuStrip dashboardMenu;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem menuEditAccount;
        private ToolStripMenuItem menuExit;
        private ToolStripMenuItem menuAboutUs;
        private Button btnMProducts;
    }
}