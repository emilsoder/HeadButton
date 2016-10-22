namespace EditProductProject.View_Layer
{
    partial class EditProductView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUnitPrice = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblUP = new System.Windows.Forms.Label();
            this.lblNewName = new System.Windows.Forms.Label();
            this.txtNewProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.TextBox();
            this.txtNewUnitPrice = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblUnitPrice);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblUP);
            this.panel1.Controls.Add(this.lblNewName);
            this.panel1.Controls.Add(this.txtNewProductName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblProductName);
            this.panel1.Controls.Add(this.txtNewUnitPrice);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 197);
            this.panel1.TabIndex = 13;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblUnitPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitPrice.Location = new System.Drawing.Point(75, 81);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.ReadOnly = true;
            this.lblUnitPrice.Size = new System.Drawing.Size(161, 16);
            this.lblUnitPrice.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(134, 157);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 27);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save changes";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(20, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 15);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Product:";
            // 
            // lblUP
            // 
            this.lblUP.AutoSize = true;
            this.lblUP.BackColor = System.Drawing.Color.Transparent;
            this.lblUP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUP.Location = new System.Drawing.Point(11, 81);
            this.lblUP.Name = "lblUP";
            this.lblUP.Size = new System.Drawing.Size(61, 15);
            this.lblUP.TabIndex = 6;
            this.lblUP.Text = "Unit price:";
            // 
            // lblNewName
            // 
            this.lblNewName.AutoSize = true;
            this.lblNewName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewName.Location = new System.Drawing.Point(42, 40);
            this.lblNewName.Name = "lblNewName";
            this.lblNewName.Size = new System.Drawing.Size(30, 15);
            this.lblNewName.TabIndex = 8;
            this.lblNewName.Text = "Edit:";
            // 
            // txtNewProductName
            // 
            this.txtNewProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewProductName.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtNewProductName.Location = new System.Drawing.Point(75, 38);
            this.txtNewProductName.Name = "txtNewProductName";
            this.txtNewProductName.Size = new System.Drawing.Size(161, 22);
            this.txtNewProductName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Edit:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProductName
            // 
            this.lblProductName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblProductName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(75, 13);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.ReadOnly = true;
            this.lblProductName.Size = new System.Drawing.Size(161, 16);
            this.lblProductName.TabIndex = 3;
            // 
            // txtNewUnitPrice
            // 
            this.txtNewUnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewUnitPrice.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtNewUnitPrice.Location = new System.Drawing.Point(75, 103);
            this.txtNewUnitPrice.Name = "txtNewUnitPrice";
            this.txtNewUnitPrice.Size = new System.Drawing.Size(161, 22);
            this.txtNewUnitPrice.TabIndex = 1;
            // 
            // EditProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 197);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditProductView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Edit product";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox lblUnitPrice;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblUP;
        private System.Windows.Forms.Label lblNewName;
        private System.Windows.Forms.TextBox txtNewProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lblProductName;
        private System.Windows.Forms.TextBox txtNewUnitPrice;
    }
}

