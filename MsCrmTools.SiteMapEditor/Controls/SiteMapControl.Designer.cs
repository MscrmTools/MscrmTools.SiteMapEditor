namespace MsCrmTools.SiteMapEditor.Controls
{
    partial class SiteMapControl
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

            tip.Dispose();

            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSiteMapUrl = new System.Windows.Forms.TextBox();
            this.lblSiteMapUrl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSiteMapUrl
            // 
            this.txtSiteMapUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSiteMapUrl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSiteMapUrl.Location = new System.Drawing.Point(315, 5);
            this.txtSiteMapUrl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSiteMapUrl.Name = "txtSiteMapUrl";
            this.txtSiteMapUrl.Size = new System.Drawing.Size(418, 29);
            this.txtSiteMapUrl.TabIndex = 8;
            // 
            // lblSiteMapUrl
            // 
            this.lblSiteMapUrl.AutoSize = true;
            this.lblSiteMapUrl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSiteMapUrl.Location = new System.Drawing.Point(4, 9);
            this.lblSiteMapUrl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSiteMapUrl.Name = "lblSiteMapUrl";
            this.lblSiteMapUrl.Size = new System.Drawing.Size(32, 23);
            this.lblSiteMapUrl.TabIndex = 7;
            this.lblSiteMapUrl.Text = "Url";
            // 
            // SiteMapControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtSiteMapUrl);
            this.Controls.Add(this.lblSiteMapUrl);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SiteMapControl";
            this.Size = new System.Drawing.Size(750, 615);
            this.Leave += new System.EventHandler(this.SiteMapControl_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSiteMapUrl;
        private System.Windows.Forms.Label lblSiteMapUrl;
    }
}
