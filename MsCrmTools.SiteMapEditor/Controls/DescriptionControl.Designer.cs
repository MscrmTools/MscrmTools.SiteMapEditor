namespace MsCrmTools.SiteMapEditor.Controls
{
    partial class DescriptionControl
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
            this.txtDescriptionLCID = new System.Windows.Forms.TextBox();
            this.txtDescriptionDescription = new System.Windows.Forms.TextBox();
            this.lblDescriptionLCID = new System.Windows.Forms.Label();
            this.lblDescriptionDescription = new System.Windows.Forms.Label();
            this.lblRequired = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDescriptionLCID
            // 
            this.txtDescriptionLCID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescriptionLCID.Location = new System.Drawing.Point(315, 5);
            this.txtDescriptionLCID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescriptionLCID.Name = "txtDescriptionLCID";
            this.txtDescriptionLCID.Size = new System.Drawing.Size(418, 26);
            this.txtDescriptionLCID.TabIndex = 1;
            // 
            // txtDescriptionDescription
            // 
            this.txtDescriptionDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescriptionDescription.Location = new System.Drawing.Point(315, 45);
            this.txtDescriptionDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescriptionDescription.Name = "txtDescriptionDescription";
            this.txtDescriptionDescription.Size = new System.Drawing.Size(418, 26);
            this.txtDescriptionDescription.TabIndex = 2;
            // 
            // lblDescriptionLCID
            // 
            this.lblDescriptionLCID.AutoSize = true;
            this.lblDescriptionLCID.Location = new System.Drawing.Point(4, 9);
            this.lblDescriptionLCID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescriptionLCID.Name = "lblDescriptionLCID";
            this.lblDescriptionLCID.Size = new System.Drawing.Size(46, 20);
            this.lblDescriptionLCID.TabIndex = 8;
            this.lblDescriptionLCID.Text = "LCID";
            // 
            // lblDescriptionDescription
            // 
            this.lblDescriptionDescription.AutoSize = true;
            this.lblDescriptionDescription.Location = new System.Drawing.Point(4, 49);
            this.lblDescriptionDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescriptionDescription.Name = "lblDescriptionDescription";
            this.lblDescriptionDescription.Size = new System.Drawing.Size(89, 20);
            this.lblDescriptionDescription.TabIndex = 7;
            this.lblDescriptionDescription.Text = "Description";
            // 
            // lblRequired
            // 
            this.lblRequired.AutoSize = true;
            this.lblRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequired.ForeColor = System.Drawing.Color.Red;
            this.lblRequired.Location = new System.Drawing.Point(51, 9);
            this.lblRequired.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRequired.Name = "lblRequired";
            this.lblRequired.Size = new System.Drawing.Size(15, 20);
            this.lblRequired.TabIndex = 23;
            this.lblRequired.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(94, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "*";
            // 
            // DescriptionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRequired);
            this.Controls.Add(this.txtDescriptionLCID);
            this.Controls.Add(this.txtDescriptionDescription);
            this.Controls.Add(this.lblDescriptionLCID);
            this.Controls.Add(this.lblDescriptionDescription);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DescriptionControl";
            this.Size = new System.Drawing.Size(750, 615);
            this.Leave += new System.EventHandler(this.SiteMapControl_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescriptionLCID;
        private System.Windows.Forms.TextBox txtDescriptionDescription;
        private System.Windows.Forms.Label lblDescriptionLCID;
        private System.Windows.Forms.Label lblDescriptionDescription;
        private System.Windows.Forms.Label lblRequired;
        private System.Windows.Forms.Label label1;


    }
}
