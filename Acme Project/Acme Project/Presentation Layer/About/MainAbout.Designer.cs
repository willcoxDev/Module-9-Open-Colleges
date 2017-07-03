namespace Acme_Project.Presentation_Layer.About
{
    partial class frmMainAbout
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
            this.lblAbout = new System.Windows.Forms.Label();
            this.lblAbout1 = new System.Windows.Forms.Label();
            this.lblAbout2 = new System.Windows.Forms.Label();
            this.lblAbout3 = new System.Windows.Forms.Label();
            this.lblAbout4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.Location = new System.Drawing.Point(316, 195);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(192, 13);
            this.lblAbout.TabIndex = 0;
            this.lblAbout.Text = "This is the Acme Database Application.";
            // 
            // lblAbout1
            // 
            this.lblAbout1.AutoSize = true;
            this.lblAbout1.Location = new System.Drawing.Point(316, 282);
            this.lblAbout1.Name = "lblAbout1";
            this.lblAbout1.Size = new System.Drawing.Size(296, 13);
            this.lblAbout1.TabIndex = 1;
            this.lblAbout1.Text = "The intention of this database is too allow employees to easily";
            // 
            // lblAbout2
            // 
            this.lblAbout2.AutoSize = true;
            this.lblAbout2.Location = new System.Drawing.Point(316, 304);
            this.lblAbout2.Name = "lblAbout2";
            this.lblAbout2.Size = new System.Drawing.Size(322, 13);
            this.lblAbout2.TabIndex = 2;
            this.lblAbout2.Text = "Add, Delete, Update and Search for entires in the Acme Database.";
            // 
            // lblAbout3
            // 
            this.lblAbout3.AutoSize = true;
            this.lblAbout3.Location = new System.Drawing.Point(316, 386);
            this.lblAbout3.Name = "lblAbout3";
            this.lblAbout3.Size = new System.Drawing.Size(181, 13);
            this.lblAbout3.TabIndex = 3;
            this.lblAbout3.Text = "Software made Willcox Development";
            // 
            // lblAbout4
            // 
            this.lblAbout4.AutoSize = true;
            this.lblAbout4.Location = new System.Drawing.Point(316, 409);
            this.lblAbout4.Name = "lblAbout4";
            this.lblAbout4.Size = new System.Drawing.Size(159, 13);
            this.lblAbout4.TabIndex = 4;
            this.lblAbout4.Text = "Support: willcoxdev@wdev.com";
            // 
            // frmMainAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.lblAbout4);
            this.Controls.Add(this.lblAbout3);
            this.Controls.Add(this.lblAbout2);
            this.Controls.Add(this.lblAbout1);
            this.Controls.Add(this.lblAbout);
            this.Name = "frmMainAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.Label lblAbout1;
        private System.Windows.Forms.Label lblAbout2;
        private System.Windows.Forms.Label lblAbout3;
        private System.Windows.Forms.Label lblAbout4;
    }
}