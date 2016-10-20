namespace HeadButton.View_Layer
{
    partial class MainView
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
            this.lstCategories = new System.Windows.Forms.ListBox();
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtNewUnitPrice = new System.Windows.Forms.TextBox();
            this.lblUP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewProductName = new System.Windows.Forms.TextBox();
            this.lblNewName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panelTxtBoxes = new System.Windows.Forms.Panel();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.panelTxtBoxes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstCategories
            // 
            this.lstCategories.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstCategories.FormattingEnabled = true;
            this.lstCategories.Location = new System.Drawing.Point(0, 0);
            this.lstCategories.Name = "lstCategories";
            this.lstCategories.Size = new System.Drawing.Size(151, 363);
            this.lstCategories.TabIndex = 0;
            this.lstCategories.SelectedIndexChanged += new System.EventHandler(this.lstCategories_SelectedIndexChanged);
            // 
            // lstProducts
            // 
            this.lstProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.Location = new System.Drawing.Point(151, 0);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(283, 363);
            this.lstProducts.TabIndex = 1;
            this.lstProducts.SelectedIndexChanged += new System.EventHandler(this.lstProducts_SelectedIndexChanged);
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(67, 88);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.ReadOnly = true;
            this.txtUnitPrice.Size = new System.Drawing.Size(193, 20);
            this.txtUnitPrice.TabIndex = 2;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(67, 20);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.ReadOnly = true;
            this.txtProductName.Size = new System.Drawing.Size(193, 20);
            this.txtProductName.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(184, 152);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(76, 27);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtNewUnitPrice
            // 
            this.txtNewUnitPrice.Location = new System.Drawing.Point(67, 114);
            this.txtNewUnitPrice.Name = "txtNewUnitPrice";
            this.txtNewUnitPrice.Size = new System.Drawing.Size(193, 20);
            this.txtNewUnitPrice.TabIndex = 5;
            // 
            // lblUP
            // 
            this.lblUP.AutoSize = true;
            this.lblUP.Location = new System.Drawing.Point(35, 91);
            this.lblUP.Name = "lblUP";
            this.lblUP.Size = new System.Drawing.Size(31, 13);
            this.lblUP.TabIndex = 6;
            this.lblUP.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "New price";
            // 
            // txtNewProductName
            // 
            this.txtNewProductName.Location = new System.Drawing.Point(67, 46);
            this.txtNewProductName.Name = "txtNewProductName";
            this.txtNewProductName.Size = new System.Drawing.Size(193, 20);
            this.txtNewProductName.TabIndex = 7;
            // 
            // lblNewName
            // 
            this.lblNewName.AutoSize = true;
            this.lblNewName.Location = new System.Drawing.Point(6, 49);
            this.lblNewName.Name = "lblNewName";
            this.lblNewName.Size = new System.Drawing.Size(60, 13);
            this.lblNewName.TabIndex = 8;
            this.lblNewName.Text = "New Name";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(31, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Name";
            // 
            // panelTxtBoxes
            // 
            this.panelTxtBoxes.Controls.Add(this.btnAddProduct);
            this.panelTxtBoxes.Controls.Add(this.lblName);
            this.panelTxtBoxes.Controls.Add(this.btnSave);
            this.panelTxtBoxes.Controls.Add(this.lblNewName);
            this.panelTxtBoxes.Controls.Add(this.txtUnitPrice);
            this.panelTxtBoxes.Controls.Add(this.txtProductName);
            this.panelTxtBoxes.Controls.Add(this.txtNewProductName);
            this.panelTxtBoxes.Controls.Add(this.txtNewUnitPrice);
            this.panelTxtBoxes.Controls.Add(this.label1);
            this.panelTxtBoxes.Controls.Add(this.lblUP);
            this.panelTxtBoxes.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelTxtBoxes.Location = new System.Drawing.Point(434, 0);
            this.panelTxtBoxes.Name = "panelTxtBoxes";
            this.panelTxtBoxes.Size = new System.Drawing.Size(269, 363);
            this.panelTxtBoxes.TabIndex = 10;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(113, 312);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(75, 23);
            this.btnAddProduct.TabIndex = 11;
            this.btnAddProduct.Text = "Add product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 363);
            this.Controls.Add(this.lstProducts);
            this.Controls.Add(this.panelTxtBoxes);
            this.Controls.Add(this.lstCategories);
            this.Name = "MainView";
            this.Text = "Form1";
            this.panelTxtBoxes.ResumeLayout(false);
            this.panelTxtBoxes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstCategories;
        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtNewUnitPrice;
        private System.Windows.Forms.Label lblUP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewProductName;
        private System.Windows.Forms.Label lblNewName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panelTxtBoxes;
        private System.Windows.Forms.Button btnAddProduct;
    }
}

