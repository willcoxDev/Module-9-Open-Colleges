namespace Acme_Project.Presentation_Layer.ProductTypes
{
    partial class frmUpdateProductTypes
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
            this.btnUpdateProductTypes = new System.Windows.Forms.Button();
            this.grpUpdateProductTypes = new System.Windows.Forms.GroupBox();
            this.txtProductType = new System.Windows.Forms.TextBox();
            this.txtProductTypeID = new System.Windows.Forms.TextBox();
            this.lblProductTypeID = new System.Windows.Forms.Label();
            this.lblProductType = new System.Windows.Forms.Label();
            this.pnlUpdateProductTypes = new System.Windows.Forms.Panel();
            this.grpUpdateProductTypes.SuspendLayout();
            this.pnlUpdateProductTypes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdateProductTypes
            // 
            this.btnUpdateProductTypes.Location = new System.Drawing.Point(111, 38);
            this.btnUpdateProductTypes.Name = "btnUpdateProductTypes";
            this.btnUpdateProductTypes.Size = new System.Drawing.Size(105, 36);
            this.btnUpdateProductTypes.TabIndex = 0;
            this.btnUpdateProductTypes.Text = "Update Product Type";
            this.btnUpdateProductTypes.UseVisualStyleBackColor = true;
            this.btnUpdateProductTypes.Click += new System.EventHandler(this.btnUpdateProductTypes_Click);
            // 
            // grpUpdateProductTypes
            // 
            this.grpUpdateProductTypes.Controls.Add(this.txtProductType);
            this.grpUpdateProductTypes.Controls.Add(this.txtProductTypeID);
            this.grpUpdateProductTypes.Controls.Add(this.lblProductTypeID);
            this.grpUpdateProductTypes.Controls.Add(this.lblProductType);
            this.grpUpdateProductTypes.Location = new System.Drawing.Point(111, 224);
            this.grpUpdateProductTypes.Name = "grpUpdateProductTypes";
            this.grpUpdateProductTypes.Size = new System.Drawing.Size(378, 126);
            this.grpUpdateProductTypes.TabIndex = 10;
            this.grpUpdateProductTypes.TabStop = false;
            this.grpUpdateProductTypes.Text = "Add Product Type";
            // 
            // txtProductType
            // 
            this.txtProductType.Location = new System.Drawing.Point(117, 73);
            this.txtProductType.Name = "txtProductType";
            this.txtProductType.Size = new System.Drawing.Size(167, 20);
            this.txtProductType.TabIndex = 1;
            // 
            // txtProductTypeID
            // 
            this.txtProductTypeID.Location = new System.Drawing.Point(117, 27);
            this.txtProductTypeID.Name = "txtProductTypeID";
            this.txtProductTypeID.ReadOnly = true;
            this.txtProductTypeID.Size = new System.Drawing.Size(167, 20);
            this.txtProductTypeID.TabIndex = 0;
            // 
            // lblProductTypeID
            // 
            this.lblProductTypeID.AutoSize = true;
            this.lblProductTypeID.Location = new System.Drawing.Point(19, 30);
            this.lblProductTypeID.Name = "lblProductTypeID";
            this.lblProductTypeID.Size = new System.Drawing.Size(88, 13);
            this.lblProductTypeID.TabIndex = 0;
            this.lblProductTypeID.Text = "Product Type ID:";
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Location = new System.Drawing.Point(19, 76);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(74, 13);
            this.lblProductType.TabIndex = 1;
            this.lblProductType.Text = "Product Type:";
            // 
            // pnlUpdateProductTypes
            // 
            this.pnlUpdateProductTypes.Controls.Add(this.btnUpdateProductTypes);
            this.pnlUpdateProductTypes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlUpdateProductTypes.Location = new System.Drawing.Point(0, 511);
            this.pnlUpdateProductTypes.Name = "pnlUpdateProductTypes";
            this.pnlUpdateProductTypes.Size = new System.Drawing.Size(934, 100);
            this.pnlUpdateProductTypes.TabIndex = 11;
            // 
            // frmUpdateProductTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.pnlUpdateProductTypes);
            this.Controls.Add(this.grpUpdateProductTypes);
            this.Name = "frmUpdateProductTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Product Types";
            this.grpUpdateProductTypes.ResumeLayout(false);
            this.grpUpdateProductTypes.PerformLayout();
            this.pnlUpdateProductTypes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateProductTypes;
        private System.Windows.Forms.GroupBox grpUpdateProductTypes;
        private System.Windows.Forms.TextBox txtProductType;
        private System.Windows.Forms.TextBox txtProductTypeID;
        private System.Windows.Forms.Label lblProductTypeID;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.Panel pnlUpdateProductTypes;
    }
}