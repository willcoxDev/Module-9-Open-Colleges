namespace Acme_Project.Presentation_Layer.ProductTypes
{
    partial class frmAddProductTypes
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
            this.btnAddProductTypes = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtProductType = new System.Windows.Forms.TextBox();
            this.txtProductTypeID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddProductTypes
            // 
            this.btnAddProductTypes.Location = new System.Drawing.Point(593, 285);
            this.btnAddProductTypes.Name = "btnAddProductTypes";
            this.btnAddProductTypes.Size = new System.Drawing.Size(105, 32);
            this.btnAddProductTypes.TabIndex = 7;
            this.btnAddProductTypes.Text = "Add Product Type";
            this.btnAddProductTypes.UseVisualStyleBackColor = true;
            this.btnAddProductTypes.Click += new System.EventHandler(this.btnAddProductTypes_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtProductType);
            this.groupBox1.Controls.Add(this.txtProductTypeID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(107, 228);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 135);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Product Type";
            // 
            // txtProductType
            // 
            this.txtProductType.Location = new System.Drawing.Point(117, 73);
            this.txtProductType.Name = "txtProductType";
            this.txtProductType.Size = new System.Drawing.Size(167, 20);
            this.txtProductType.TabIndex = 5;
            // 
            // txtProductTypeID
            // 
            this.txtProductTypeID.Location = new System.Drawing.Point(117, 27);
            this.txtProductTypeID.Name = "txtProductTypeID";
            this.txtProductTypeID.Size = new System.Drawing.Size(167, 20);
            this.txtProductTypeID.TabIndex = 4;
            this.txtProductTypeID.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Type ID:";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Type:";
            // 
            // frmAddProductTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.btnAddProductTypes);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAddProductTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Product Types";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddProductTypes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtProductType;
        private System.Windows.Forms.TextBox txtProductTypeID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}