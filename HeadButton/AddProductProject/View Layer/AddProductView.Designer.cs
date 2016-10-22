namespace AddProductProject.View_Layer
{
    partial class AddProductView
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
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblSupplierID = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblQuantityPerUnit = new System.Windows.Forms.Label();
            this.lblRecorderLevel = new System.Windows.Forms.Label();
            this.lblUnitsInOrder = new System.Windows.Forms.Label();
            this.lblUnitsInStock = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.txtRecorderLevel = new System.Windows.Forms.TextBox();
            this.txtUnitsInOrder = new System.Windows.Forms.TextBox();
            this.txtUnitsInStock = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.ddlCategory = new System.Windows.Forms.ComboBox();
            this.ddlSupplier = new System.Windows.Forms.ComboBox();
            this.lblDiscontinued = new System.Windows.Forms.Label();
            this.ddlDiscontinued = new System.Windows.Forms.ComboBox();
            this.btnAddRecord = new System.Windows.Forms.Button();
            this.btnClearText = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(15, 19);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(73, 13);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Product name";
            // 
            // lblSupplierID
            // 
            this.lblSupplierID.AutoSize = true;
            this.lblSupplierID.Location = new System.Drawing.Point(43, 97);
            this.lblSupplierID.Name = "lblSupplierID";
            this.lblSupplierID.Size = new System.Drawing.Size(45, 13);
            this.lblSupplierID.TabIndex = 1;
            this.lblSupplierID.Text = "Supplier";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(39, 70);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Category";
            // 
            // lblQuantityPerUnit
            // 
            this.lblQuantityPerUnit.AutoSize = true;
            this.lblQuantityPerUnit.Location = new System.Drawing.Point(27, 202);
            this.lblQuantityPerUnit.Name = "lblQuantityPerUnit";
            this.lblQuantityPerUnit.Size = new System.Drawing.Size(61, 13);
            this.lblQuantityPerUnit.TabIndex = 3;
            this.lblQuantityPerUnit.Text = "Qty per unit";
            // 
            // lblRecorderLevel
            // 
            this.lblRecorderLevel.AutoSize = true;
            this.lblRecorderLevel.Location = new System.Drawing.Point(188, 177);
            this.lblRecorderLevel.Name = "lblRecorderLevel";
            this.lblRecorderLevel.Size = new System.Drawing.Size(70, 13);
            this.lblRecorderLevel.TabIndex = 7;
            this.lblRecorderLevel.Text = "Reorder level";
            // 
            // lblUnitsInOrder
            // 
            this.lblUnitsInOrder.AutoSize = true;
            this.lblUnitsInOrder.Location = new System.Drawing.Point(189, 151);
            this.lblUnitsInOrder.Name = "lblUnitsInOrder";
            this.lblUnitsInOrder.Size = new System.Drawing.Size(69, 13);
            this.lblUnitsInOrder.TabIndex = 6;
            this.lblUnitsInOrder.Text = "Units in order";
            this.lblUnitsInOrder.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblUnitsInStock
            // 
            this.lblUnitsInStock.AutoSize = true;
            this.lblUnitsInStock.Location = new System.Drawing.Point(17, 176);
            this.lblUnitsInStock.Name = "lblUnitsInStock";
            this.lblUnitsInStock.Size = new System.Drawing.Size(71, 13);
            this.lblUnitsInStock.TabIndex = 5;
            this.lblUnitsInStock.Text = "Units in stock";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(36, 150);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(52, 13);
            this.lblUnitPrice.TabIndex = 4;
            this.lblUnitPrice.Text = "Unit price";
            // 
            // txtRecorderLevel
            // 
            this.txtRecorderLevel.Location = new System.Drawing.Point(258, 174);
            this.txtRecorderLevel.Name = "txtRecorderLevel";
            this.txtRecorderLevel.Size = new System.Drawing.Size(80, 20);
            this.txtRecorderLevel.TabIndex = 6;
            // 
            // txtUnitsInOrder
            // 
            this.txtUnitsInOrder.Location = new System.Drawing.Point(258, 148);
            this.txtUnitsInOrder.Name = "txtUnitsInOrder";
            this.txtUnitsInOrder.Size = new System.Drawing.Size(80, 20);
            this.txtUnitsInOrder.TabIndex = 4;
            // 
            // txtUnitsInStock
            // 
            this.txtUnitsInStock.Location = new System.Drawing.Point(88, 173);
            this.txtUnitsInStock.Name = "txtUnitsInStock";
            this.txtUnitsInStock.Size = new System.Drawing.Size(80, 20);
            this.txtUnitsInStock.TabIndex = 5;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(88, 147);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(80, 20);
            this.txtUnitPrice.TabIndex = 3;
            // 
            // txtQuantityPerUnit
            // 
            this.txtQuantityPerUnit.Location = new System.Drawing.Point(88, 198);
            this.txtQuantityPerUnit.Name = "txtQuantityPerUnit";
            this.txtQuantityPerUnit.Size = new System.Drawing.Size(80, 20);
            this.txtQuantityPerUnit.TabIndex = 7;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(88, 16);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(250, 20);
            this.txtProductName.TabIndex = 0;
            // 
            // ddlCategory
            // 
            this.ddlCategory.FormattingEnabled = true;
            this.ddlCategory.Location = new System.Drawing.Point(88, 66);
            this.ddlCategory.Name = "ddlCategory";
            this.ddlCategory.Size = new System.Drawing.Size(250, 21);
            this.ddlCategory.TabIndex = 1;
            // 
            // ddlSupplier
            // 
            this.ddlSupplier.FormattingEnabled = true;
            this.ddlSupplier.Location = new System.Drawing.Point(88, 93);
            this.ddlSupplier.Name = "ddlSupplier";
            this.ddlSupplier.Size = new System.Drawing.Size(250, 21);
            this.ddlSupplier.TabIndex = 2;
            // 
            // lblDiscontinued
            // 
            this.lblDiscontinued.AutoSize = true;
            this.lblDiscontinued.Location = new System.Drawing.Point(189, 204);
            this.lblDiscontinued.Name = "lblDiscontinued";
            this.lblDiscontinued.Size = new System.Drawing.Size(69, 13);
            this.lblDiscontinued.TabIndex = 8;
            this.lblDiscontinued.Text = "Discontinued";
            // 
            // ddlDiscontinued
            // 
            this.ddlDiscontinued.FormattingEnabled = true;
            this.ddlDiscontinued.Location = new System.Drawing.Point(258, 200);
            this.ddlDiscontinued.Name = "ddlDiscontinued";
            this.ddlDiscontinued.Size = new System.Drawing.Size(80, 21);
            this.ddlDiscontinued.TabIndex = 8;
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.Location = new System.Drawing.Point(258, 267);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(80, 28);
            this.btnAddRecord.TabIndex = 9;
            this.btnAddRecord.Text = "Add product";
            this.btnAddRecord.UseVisualStyleBackColor = true;
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // btnClearText
            // 
            this.btnClearText.Location = new System.Drawing.Point(12, 267);
            this.btnClearText.Name = "btnClearText";
            this.btnClearText.Size = new System.Drawing.Size(74, 28);
            this.btnClearText.TabIndex = 15;
            this.btnClearText.Text = "Clear text";
            this.btnClearText.UseVisualStyleBackColor = true;
            this.btnClearText.Click += new System.EventHandler(this.btnClearText_Click);
            // 
            // AddProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 307);
            this.Controls.Add(this.btnClearText);
            this.Controls.Add(this.btnAddRecord);
            this.Controls.Add(this.ddlDiscontinued);
            this.Controls.Add(this.ddlSupplier);
            this.Controls.Add(this.ddlCategory);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtQuantityPerUnit);
            this.Controls.Add(this.txtUnitsInStock);
            this.Controls.Add(this.txtUnitsInOrder);
            this.Controls.Add(this.txtRecorderLevel);
            this.Controls.Add(this.lblDiscontinued);
            this.Controls.Add(this.lblRecorderLevel);
            this.Controls.Add(this.lblUnitsInOrder);
            this.Controls.Add(this.lblUnitsInStock);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.lblQuantityPerUnit);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblSupplierID);
            this.Controls.Add(this.lblProductName);
            this.Name = "AddProductView";
            this.Text = "New product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblSupplierID;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblQuantityPerUnit;
        private System.Windows.Forms.Label lblRecorderLevel;
        private System.Windows.Forms.Label lblUnitsInOrder;
        private System.Windows.Forms.Label lblUnitsInStock;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.TextBox txtRecorderLevel;
        private System.Windows.Forms.TextBox txtUnitsInOrder;
        private System.Windows.Forms.TextBox txtUnitsInStock;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtQuantityPerUnit;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.ComboBox ddlCategory;
        private System.Windows.Forms.ComboBox ddlSupplier;
        private System.Windows.Forms.Label lblDiscontinued;
        private System.Windows.Forms.ComboBox ddlDiscontinued;
        private System.Windows.Forms.Button btnAddRecord;
        private System.Windows.Forms.Button btnClearText;
    }
}