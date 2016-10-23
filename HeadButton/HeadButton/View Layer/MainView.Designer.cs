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
            this.panelTxtBoxes = new System.Windows.Forms.Panel();
            this.btnEditSelected = new System.Windows.Forms.Button();
            this.btnDeleteRecord = new System.Windows.Forms.Button();
            this.btnAddRecord = new System.Windows.Forms.Button();
            this.panelForLists = new System.Windows.Forms.Panel();
            this.panelTxtBoxes.SuspendLayout();
            this.panelForLists.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstCategories
            // 
            this.lstCategories.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstCategories.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCategories.FormattingEnabled = true;
            this.lstCategories.ItemHeight = 15;
            this.lstCategories.Location = new System.Drawing.Point(0, 0);
            this.lstCategories.Name = "lstCategories";
            this.lstCategories.Size = new System.Drawing.Size(177, 404);
            this.lstCategories.TabIndex = 1;
            this.lstCategories.SelectedIndexChanged += new System.EventHandler(this.lstCategories_SelectedIndexChanged);
            // 
            // lstProducts
            // 
            this.lstProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstProducts.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.ItemHeight = 15;
            this.lstProducts.Location = new System.Drawing.Point(177, 0);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(269, 404);
            this.lstProducts.TabIndex = 2;
            this.lstProducts.SelectedIndexChanged += new System.EventHandler(this.lstProducts_SelectedIndexChanged);
            // 
            // panelTxtBoxes
            // 
            this.panelTxtBoxes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelTxtBoxes.Controls.Add(this.btnEditSelected);
            this.panelTxtBoxes.Controls.Add(this.btnDeleteRecord);
            this.panelTxtBoxes.Controls.Add(this.btnAddRecord);
            this.panelTxtBoxes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTxtBoxes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTxtBoxes.Location = new System.Drawing.Point(0, 0);
            this.panelTxtBoxes.Name = "panelTxtBoxes";
            this.panelTxtBoxes.Size = new System.Drawing.Size(446, 47);
            this.panelTxtBoxes.TabIndex = 10;
            // 
            // btnEditSelected
            // 
            this.btnEditSelected.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnEditSelected.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEditSelected.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnEditSelected.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditSelected.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSelected.Location = new System.Drawing.Point(220, 10);
            this.btnEditSelected.Name = "btnEditSelected";
            this.btnEditSelected.Size = new System.Drawing.Size(104, 27);
            this.btnEditSelected.TabIndex = 4;
            this.btnEditSelected.Text = "Edit selected";
            this.btnEditSelected.UseVisualStyleBackColor = false;
            this.btnEditSelected.Click += new System.EventHandler(this.btnEditSelected_Click);
            // 
            // btnDeleteRecord
            // 
            this.btnDeleteRecord.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnDeleteRecord.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteRecord.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteRecord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnDeleteRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteRecord.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRecord.Location = new System.Drawing.Point(330, 10);
            this.btnDeleteRecord.Name = "btnDeleteRecord";
            this.btnDeleteRecord.Size = new System.Drawing.Size(104, 27);
            this.btnDeleteRecord.TabIndex = 5;
            this.btnDeleteRecord.Text = "Delete selected";
            this.btnDeleteRecord.UseVisualStyleBackColor = false;
            this.btnDeleteRecord.Click += new System.EventHandler(this.btnDeleteRecord_Click);
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnAddRecord.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddRecord.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnAddRecord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRecord.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRecord.Location = new System.Drawing.Point(12, 10);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(104, 27);
            this.btnAddRecord.TabIndex = 3;
            this.btnAddRecord.Text = "Add product";
            this.btnAddRecord.UseVisualStyleBackColor = false;
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // panelForLists
            // 
            this.panelForLists.Controls.Add(this.lstProducts);
            this.panelForLists.Controls.Add(this.lstCategories);
            this.panelForLists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForLists.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelForLists.Location = new System.Drawing.Point(0, 47);
            this.panelForLists.Name = "panelForLists";
            this.panelForLists.Size = new System.Drawing.Size(446, 404);
            this.panelForLists.TabIndex = 11;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 451);
            this.Controls.Add(this.panelForLists);
            this.Controls.Add(this.panelTxtBoxes);
            this.Name = "MainView";
            this.ShowIcon = false;
            this.Text = "Products";
            this.panelTxtBoxes.ResumeLayout(false);
            this.panelForLists.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstCategories;
        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.Panel panelTxtBoxes;
        private System.Windows.Forms.Button btnAddRecord;
        private System.Windows.Forms.Button btnDeleteRecord;
        private System.Windows.Forms.Panel panelForLists;
        private System.Windows.Forms.Button btnEditSelected;
    }
}

