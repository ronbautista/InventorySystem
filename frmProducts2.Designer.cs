namespace InventorySystem
{
    partial class frmProducts2
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
            this.lblProductMod = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProductMod
            // 
            this.lblProductMod.AutoSize = true;
            this.lblProductMod.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProductMod.Location = new System.Drawing.Point(13, 14);
            this.lblProductMod.Name = "lblProductMod";
            this.lblProductMod.Size = new System.Drawing.Size(190, 41);
            this.lblProductMod.TabIndex = 0;
            this.lblProductMod.Text = "Add Product";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Qty:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Category:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Supplier:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(20, 109);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(264, 32);
            this.txtName.TabIndex = 5;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(20, 246);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(134, 32);
            this.txtQty.TabIndex = 6;
            // 
            // cbCategory
            // 
            this.cbCategory.AccessibleName = "";
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(20, 177);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(264, 32);
            this.cbCategory.TabIndex = 7;
            // 
            // cbSupplier
            // 
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(20, 315);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(264, 32);
            this.cbSupplier.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(433, 299);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(175, 62);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmProducts2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 386);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbSupplier);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblProductMod);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmProducts2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblProductMod;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtName;
        private TextBox txtQty;
        private ComboBox cbCategory;
        private ComboBox cbSupplier;
        private Button btnSave;
    }
}