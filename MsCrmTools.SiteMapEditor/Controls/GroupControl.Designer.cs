namespace MsCrmTools.SiteMapEditor.Controls
{
    partial class GroupControl
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
            this.chkGroupIsProfile = new System.Windows.Forms.CheckBox();
            this.txtGroupId = new System.Windows.Forms.TextBox();
            this.txtGroupUrl = new System.Windows.Forms.TextBox();
            this.lblGroupId = new System.Windows.Forms.Label();
            this.lblGroupUrl = new System.Windows.Forms.Label();
            this.lblGroupIsProfile = new System.Windows.Forms.Label();
            this.lblGroupDescriptionResourceId = new System.Windows.Forms.Label();
            this.lblGroupResourceId = new System.Windows.Forms.Label();
            this.txtGroupDescriptionResourceId = new System.Windows.Forms.TextBox();
            this.txtGroupResourceId = new System.Windows.Forms.TextBox();
            this.lblRequired = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtGroupDescription = new System.Windows.Forms.TextBox();
            this.txtGroupTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkGroupIsProfile
            // 
            this.chkGroupIsProfile.AutoSize = true;
            this.chkGroupIsProfile.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.chkGroupIsProfile.Location = new System.Drawing.Point(315, 89);
            this.chkGroupIsProfile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkGroupIsProfile.Name = "chkGroupIsProfile";
            this.chkGroupIsProfile.Size = new System.Drawing.Size(22, 21);
            this.chkGroupIsProfile.TabIndex = 3;
            this.chkGroupIsProfile.UseVisualStyleBackColor = true;
            // 
            // txtGroupId
            // 
            this.txtGroupId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGroupId.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtGroupId.Location = new System.Drawing.Point(315, 5);
            this.txtGroupId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGroupId.Name = "txtGroupId";
            this.txtGroupId.Size = new System.Drawing.Size(418, 29);
            this.txtGroupId.TabIndex = 1;
            // 
            // txtGroupUrl
            // 
            this.txtGroupUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGroupUrl.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtGroupUrl.Location = new System.Drawing.Point(315, 48);
            this.txtGroupUrl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGroupUrl.Name = "txtGroupUrl";
            this.txtGroupUrl.Size = new System.Drawing.Size(418, 29);
            this.txtGroupUrl.TabIndex = 2;
            // 
            // lblGroupId
            // 
            this.lblGroupId.AutoSize = true;
            this.lblGroupId.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblGroupId.Location = new System.Drawing.Point(4, 9);
            this.lblGroupId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGroupId.Name = "lblGroupId";
            this.lblGroupId.Size = new System.Drawing.Size(25, 23);
            this.lblGroupId.TabIndex = 10;
            this.lblGroupId.Text = "Id";
            // 
            // lblGroupUrl
            // 
            this.lblGroupUrl.AutoSize = true;
            this.lblGroupUrl.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblGroupUrl.Location = new System.Drawing.Point(4, 52);
            this.lblGroupUrl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGroupUrl.Name = "lblGroupUrl";
            this.lblGroupUrl.Size = new System.Drawing.Size(32, 23);
            this.lblGroupUrl.TabIndex = 9;
            this.lblGroupUrl.Text = "Url";
            // 
            // lblGroupIsProfile
            // 
            this.lblGroupIsProfile.AutoSize = true;
            this.lblGroupIsProfile.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblGroupIsProfile.Location = new System.Drawing.Point(4, 91);
            this.lblGroupIsProfile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGroupIsProfile.Name = "lblGroupIsProfile";
            this.lblGroupIsProfile.Size = new System.Drawing.Size(75, 23);
            this.lblGroupIsProfile.TabIndex = 8;
            this.lblGroupIsProfile.Text = "Is Profile";
            // 
            // lblGroupDescriptionResourceId
            // 
            this.lblGroupDescriptionResourceId.AutoSize = true;
            this.lblGroupDescriptionResourceId.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblGroupDescriptionResourceId.Location = new System.Drawing.Point(4, 165);
            this.lblGroupDescriptionResourceId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGroupDescriptionResourceId.Name = "lblGroupDescriptionResourceId";
            this.lblGroupDescriptionResourceId.Size = new System.Drawing.Size(190, 23);
            this.lblGroupDescriptionResourceId.TabIndex = 14;
            this.lblGroupDescriptionResourceId.Text = "Description Resource Id";
            // 
            // lblGroupResourceId
            // 
            this.lblGroupResourceId.AutoSize = true;
            this.lblGroupResourceId.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblGroupResourceId.Location = new System.Drawing.Point(4, 125);
            this.lblGroupResourceId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGroupResourceId.Name = "lblGroupResourceId";
            this.lblGroupResourceId.Size = new System.Drawing.Size(99, 23);
            this.lblGroupResourceId.TabIndex = 15;
            this.lblGroupResourceId.Text = "Resource Id";
            // 
            // txtGroupDescriptionResourceId
            // 
            this.txtGroupDescriptionResourceId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGroupDescriptionResourceId.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtGroupDescriptionResourceId.Location = new System.Drawing.Point(315, 160);
            this.txtGroupDescriptionResourceId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGroupDescriptionResourceId.Name = "txtGroupDescriptionResourceId";
            this.txtGroupDescriptionResourceId.ReadOnly = true;
            this.txtGroupDescriptionResourceId.Size = new System.Drawing.Size(418, 29);
            this.txtGroupDescriptionResourceId.TabIndex = 5;
            // 
            // txtGroupResourceId
            // 
            this.txtGroupResourceId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGroupResourceId.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtGroupResourceId.Location = new System.Drawing.Point(315, 120);
            this.txtGroupResourceId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGroupResourceId.Name = "txtGroupResourceId";
            this.txtGroupResourceId.ReadOnly = true;
            this.txtGroupResourceId.Size = new System.Drawing.Size(418, 29);
            this.txtGroupResourceId.TabIndex = 4;
            // 
            // lblRequired
            // 
            this.lblRequired.AutoSize = true;
            this.lblRequired.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblRequired.ForeColor = System.Drawing.Color.Red;
            this.lblRequired.Location = new System.Drawing.Point(28, 9);
            this.lblRequired.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRequired.Name = "lblRequired";
            this.lblRequired.Size = new System.Drawing.Size(17, 23);
            this.lblRequired.TabIndex = 24;
            this.lblRequired.Text = "*";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.panel1.Location = new System.Drawing.Point(9, 226);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 0);
            this.panel1.TabIndex = 91;
            // 
            // txtGroupDescription
            // 
            this.txtGroupDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGroupDescription.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtGroupDescription.Location = new System.Drawing.Point(315, 277);
            this.txtGroupDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGroupDescription.Name = "txtGroupDescription";
            this.txtGroupDescription.Size = new System.Drawing.Size(418, 29);
            this.txtGroupDescription.TabIndex = 90;
            // 
            // txtGroupTitle
            // 
            this.txtGroupTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGroupTitle.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtGroupTitle.Location = new System.Drawing.Point(316, 237);
            this.txtGroupTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGroupTitle.Name = "txtGroupTitle";
            this.txtGroupTitle.Size = new System.Drawing.Size(418, 29);
            this.txtGroupTitle.TabIndex = 89;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label3.Location = new System.Drawing.Point(4, 282);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 23);
            this.label3.TabIndex = 88;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label2.Location = new System.Drawing.Point(4, 242);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 23);
            this.label2.TabIndex = 87;
            this.label2.Text = "Title";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label1.Location = new System.Drawing.Point(4, 202);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 23);
            this.label1.TabIndex = 86;
            this.label1.Text = "Deprecated attributes";
            // 
            // GroupControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtGroupDescription);
            this.Controls.Add(this.txtGroupTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRequired);
            this.Controls.Add(this.txtGroupResourceId);
            this.Controls.Add(this.txtGroupDescriptionResourceId);
            this.Controls.Add(this.lblGroupResourceId);
            this.Controls.Add(this.lblGroupDescriptionResourceId);
            this.Controls.Add(this.chkGroupIsProfile);
            this.Controls.Add(this.txtGroupId);
            this.Controls.Add(this.txtGroupUrl);
            this.Controls.Add(this.lblGroupId);
            this.Controls.Add(this.lblGroupUrl);
            this.Controls.Add(this.lblGroupIsProfile);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GroupControl";
            this.Size = new System.Drawing.Size(750, 615);
            this.Leave += new System.EventHandler(this.SiteMapControl_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkGroupIsProfile;
        private System.Windows.Forms.TextBox txtGroupId;
        private System.Windows.Forms.TextBox txtGroupUrl;
        private System.Windows.Forms.Label lblGroupId;
        private System.Windows.Forms.Label lblGroupUrl;
        private System.Windows.Forms.Label lblGroupIsProfile;
        private System.Windows.Forms.Label lblGroupDescriptionResourceId;
        private System.Windows.Forms.Label lblGroupResourceId;
        private System.Windows.Forms.TextBox txtGroupDescriptionResourceId;
        private System.Windows.Forms.TextBox txtGroupResourceId;
        private System.Windows.Forms.Label lblRequired;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtGroupDescription;
        private System.Windows.Forms.TextBox txtGroupTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

    }
}
