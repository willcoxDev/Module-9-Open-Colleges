namespace Acme_Project.Presentation_Layer.Tutorial
{
    partial class frmMainTutorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainTutorial));
            this.movTutorial = new AxShockwaveFlashObjects.AxShockwaveFlash();
            ((System.ComponentModel.ISupportInitialize)(this.movTutorial)).BeginInit();
            this.SuspendLayout();
            // 
            // movTutorial
            // 
            this.movTutorial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.movTutorial.Enabled = true;
            this.movTutorial.Location = new System.Drawing.Point(1, -1);
            this.movTutorial.Name = "movTutorial";
            this.movTutorial.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("movTutorial.OcxState")));
            this.movTutorial.Size = new System.Drawing.Size(934, 613);
            this.movTutorial.TabIndex = 0;
            // 
            // frmMainTutorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.movTutorial);
            this.Name = "frmMainTutorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainTutorial";
            ((System.ComponentModel.ISupportInitialize)(this.movTutorial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxShockwaveFlashObjects.AxShockwaveFlash movTutorial;
    }
}