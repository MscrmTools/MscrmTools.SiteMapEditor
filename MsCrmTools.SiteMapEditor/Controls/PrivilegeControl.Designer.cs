namespace MsCrmTools.SiteMapEditor.Controls
{
    partial class PrivilegeControl
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
            this.txtPrivilegeEntity = new System.Windows.Forms.TextBox();
            this.lblPrivilegeEntity = new System.Windows.Forms.Label();
            this.chkPrivilegeWrite = new System.Windows.Forms.CheckBox();
            this.chkPrivilegeAppend = new System.Windows.Forms.CheckBox();
            this.chkPrivilegeAppendTo = new System.Windows.Forms.CheckBox();
            this.chkPrivilegeCreate = new System.Windows.Forms.CheckBox();
            this.chkPrivilegeDelete = new System.Windows.Forms.CheckBox();
            this.chkPrivilegeShare = new System.Windows.Forms.CheckBox();
            this.chkPrivilegeAssign = new System.Windows.Forms.CheckBox();
            this.chkPrivilegeAll = new System.Windows.Forms.CheckBox();
            this.chkPrivilegeAllowQuickCampaign = new System.Windows.Forms.CheckBox();
            this.chkPrivilegeUseInternetMarketing = new System.Windows.Forms.CheckBox();
            this.lblPrivilegePrivileges = new System.Windows.Forms.Label();
            this.chkPrivilegeRead = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtPrivilegeEntity
            // 
            this.txtPrivilegeEntity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrivilegeEntity.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrivilegeEntity.Location = new System.Drawing.Point(315, 5);
            this.txtPrivilegeEntity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrivilegeEntity.Name = "txtPrivilegeEntity";
            this.txtPrivilegeEntity.Size = new System.Drawing.Size(418, 29);
            this.txtPrivilegeEntity.TabIndex = 1;
            // 
            // lblPrivilegeEntity
            // 
            this.lblPrivilegeEntity.AutoSize = true;
            this.lblPrivilegeEntity.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrivilegeEntity.Location = new System.Drawing.Point(4, 9);
            this.lblPrivilegeEntity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrivilegeEntity.Name = "lblPrivilegeEntity";
            this.lblPrivilegeEntity.Size = new System.Drawing.Size(53, 23);
            this.lblPrivilegeEntity.TabIndex = 7;
            this.lblPrivilegeEntity.Text = "Entity";
            // 
            // chkPrivilegeWrite
            // 
            this.chkPrivilegeWrite.AutoSize = true;
            this.chkPrivilegeWrite.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPrivilegeWrite.Location = new System.Drawing.Point(315, 115);
            this.chkPrivilegeWrite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkPrivilegeWrite.Name = "chkPrivilegeWrite";
            this.chkPrivilegeWrite.Size = new System.Drawing.Size(77, 27);
            this.chkPrivilegeWrite.TabIndex = 4;
            this.chkPrivilegeWrite.Text = "Write";
            this.chkPrivilegeWrite.UseVisualStyleBackColor = true;
            // 
            // chkPrivilegeAppend
            // 
            this.chkPrivilegeAppend.AutoSize = true;
            this.chkPrivilegeAppend.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPrivilegeAppend.Location = new System.Drawing.Point(314, 186);
            this.chkPrivilegeAppend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkPrivilegeAppend.Name = "chkPrivilegeAppend";
            this.chkPrivilegeAppend.Size = new System.Drawing.Size(96, 27);
            this.chkPrivilegeAppend.TabIndex = 6;
            this.chkPrivilegeAppend.Text = "Append";
            this.chkPrivilegeAppend.UseVisualStyleBackColor = true;
            // 
            // chkPrivilegeAppendTo
            // 
            this.chkPrivilegeAppendTo.AutoSize = true;
            this.chkPrivilegeAppendTo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPrivilegeAppendTo.Location = new System.Drawing.Point(314, 222);
            this.chkPrivilegeAppendTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkPrivilegeAppendTo.Name = "chkPrivilegeAppendTo";
            this.chkPrivilegeAppendTo.Size = new System.Drawing.Size(117, 27);
            this.chkPrivilegeAppendTo.TabIndex = 7;
            this.chkPrivilegeAppendTo.Text = "Append to";
            this.chkPrivilegeAppendTo.UseVisualStyleBackColor = true;
            // 
            // chkPrivilegeCreate
            // 
            this.chkPrivilegeCreate.AutoSize = true;
            this.chkPrivilegeCreate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPrivilegeCreate.Location = new System.Drawing.Point(315, 45);
            this.chkPrivilegeCreate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkPrivilegeCreate.Name = "chkPrivilegeCreate";
            this.chkPrivilegeCreate.Size = new System.Drawing.Size(86, 27);
            this.chkPrivilegeCreate.TabIndex = 2;
            this.chkPrivilegeCreate.Text = "Create";
            this.chkPrivilegeCreate.UseVisualStyleBackColor = true;
            // 
            // chkPrivilegeDelete
            // 
            this.chkPrivilegeDelete.AutoSize = true;
            this.chkPrivilegeDelete.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPrivilegeDelete.Location = new System.Drawing.Point(315, 151);
            this.chkPrivilegeDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkPrivilegeDelete.Name = "chkPrivilegeDelete";
            this.chkPrivilegeDelete.Size = new System.Drawing.Size(85, 27);
            this.chkPrivilegeDelete.TabIndex = 5;
            this.chkPrivilegeDelete.Text = "Delete";
            this.chkPrivilegeDelete.UseVisualStyleBackColor = true;
            // 
            // chkPrivilegeShare
            // 
            this.chkPrivilegeShare.AutoSize = true;
            this.chkPrivilegeShare.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPrivilegeShare.Location = new System.Drawing.Point(465, 45);
            this.chkPrivilegeShare.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkPrivilegeShare.Name = "chkPrivilegeShare";
            this.chkPrivilegeShare.Size = new System.Drawing.Size(79, 27);
            this.chkPrivilegeShare.TabIndex = 8;
            this.chkPrivilegeShare.Text = "Share";
            this.chkPrivilegeShare.UseVisualStyleBackColor = true;
            // 
            // chkPrivilegeAssign
            // 
            this.chkPrivilegeAssign.AutoSize = true;
            this.chkPrivilegeAssign.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPrivilegeAssign.Location = new System.Drawing.Point(465, 80);
            this.chkPrivilegeAssign.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkPrivilegeAssign.Name = "chkPrivilegeAssign";
            this.chkPrivilegeAssign.Size = new System.Drawing.Size(85, 27);
            this.chkPrivilegeAssign.TabIndex = 9;
            this.chkPrivilegeAssign.Text = "Assign";
            this.chkPrivilegeAssign.UseVisualStyleBackColor = true;
            // 
            // chkPrivilegeAll
            // 
            this.chkPrivilegeAll.AutoSize = true;
            this.chkPrivilegeAll.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPrivilegeAll.Location = new System.Drawing.Point(465, 115);
            this.chkPrivilegeAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkPrivilegeAll.Name = "chkPrivilegeAll";
            this.chkPrivilegeAll.Size = new System.Drawing.Size(55, 27);
            this.chkPrivilegeAll.TabIndex = 10;
            this.chkPrivilegeAll.Text = "All";
            this.chkPrivilegeAll.UseVisualStyleBackColor = true;
            // 
            // chkPrivilegeAllowQuickCampaign
            // 
            this.chkPrivilegeAllowQuickCampaign.AutoSize = true;
            this.chkPrivilegeAllowQuickCampaign.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPrivilegeAllowQuickCampaign.Location = new System.Drawing.Point(465, 151);
            this.chkPrivilegeAllowQuickCampaign.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkPrivilegeAllowQuickCampaign.Name = "chkPrivilegeAllowQuickCampaign";
            this.chkPrivilegeAllowQuickCampaign.Size = new System.Drawing.Size(208, 27);
            this.chkPrivilegeAllowQuickCampaign.TabIndex = 11;
            this.chkPrivilegeAllowQuickCampaign.Text = "Allow Quick Campaign";
            this.chkPrivilegeAllowQuickCampaign.UseVisualStyleBackColor = true;
            // 
            // chkPrivilegeUseInternetMarketing
            // 
            this.chkPrivilegeUseInternetMarketing.AutoSize = true;
            this.chkPrivilegeUseInternetMarketing.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPrivilegeUseInternetMarketing.Location = new System.Drawing.Point(465, 186);
            this.chkPrivilegeUseInternetMarketing.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkPrivilegeUseInternetMarketing.Name = "chkPrivilegeUseInternetMarketing";
            this.chkPrivilegeUseInternetMarketing.Size = new System.Drawing.Size(212, 27);
            this.chkPrivilegeUseInternetMarketing.TabIndex = 12;
            this.chkPrivilegeUseInternetMarketing.Text = "Use Internet Marketing";
            this.chkPrivilegeUseInternetMarketing.UseVisualStyleBackColor = true;
            // 
            // lblPrivilegePrivileges
            // 
            this.lblPrivilegePrivileges.AutoSize = true;
            this.lblPrivilegePrivileges.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrivilegePrivileges.Location = new System.Drawing.Point(4, 46);
            this.lblPrivilegePrivileges.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrivilegePrivileges.Name = "lblPrivilegePrivileges";
            this.lblPrivilegePrivileges.Size = new System.Drawing.Size(81, 23);
            this.lblPrivilegePrivileges.TabIndex = 20;
            this.lblPrivilegePrivileges.Text = "Privileges";
            // 
            // chkPrivilegeRead
            // 
            this.chkPrivilegeRead.AutoSize = true;
            this.chkPrivilegeRead.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPrivilegeRead.Location = new System.Drawing.Point(315, 80);
            this.chkPrivilegeRead.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkPrivilegeRead.Name = "chkPrivilegeRead";
            this.chkPrivilegeRead.Size = new System.Drawing.Size(74, 27);
            this.chkPrivilegeRead.TabIndex = 3;
            this.chkPrivilegeRead.Text = "Read";
            this.chkPrivilegeRead.UseVisualStyleBackColor = true;
            // 
            // PrivilegeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkPrivilegeWrite);
            this.Controls.Add(this.chkPrivilegeAppend);
            this.Controls.Add(this.chkPrivilegeAppendTo);
            this.Controls.Add(this.chkPrivilegeCreate);
            this.Controls.Add(this.chkPrivilegeDelete);
            this.Controls.Add(this.chkPrivilegeShare);
            this.Controls.Add(this.chkPrivilegeAssign);
            this.Controls.Add(this.chkPrivilegeAll);
            this.Controls.Add(this.chkPrivilegeAllowQuickCampaign);
            this.Controls.Add(this.chkPrivilegeUseInternetMarketing);
            this.Controls.Add(this.lblPrivilegePrivileges);
            this.Controls.Add(this.chkPrivilegeRead);
            this.Controls.Add(this.txtPrivilegeEntity);
            this.Controls.Add(this.lblPrivilegeEntity);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PrivilegeControl";
            this.Size = new System.Drawing.Size(750, 615);
            this.Leave += new System.EventHandler(this.SiteMapControl_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrivilegeEntity;
        private System.Windows.Forms.Label lblPrivilegeEntity;
        private System.Windows.Forms.CheckBox chkPrivilegeWrite;
        private System.Windows.Forms.CheckBox chkPrivilegeAppend;
        private System.Windows.Forms.CheckBox chkPrivilegeAppendTo;
        private System.Windows.Forms.CheckBox chkPrivilegeCreate;
        private System.Windows.Forms.CheckBox chkPrivilegeDelete;
        private System.Windows.Forms.CheckBox chkPrivilegeShare;
        private System.Windows.Forms.CheckBox chkPrivilegeAssign;
        private System.Windows.Forms.CheckBox chkPrivilegeAll;
        private System.Windows.Forms.CheckBox chkPrivilegeAllowQuickCampaign;
        private System.Windows.Forms.CheckBox chkPrivilegeUseInternetMarketing;
        private System.Windows.Forms.Label lblPrivilegePrivileges;
        private System.Windows.Forms.CheckBox chkPrivilegeRead;
    }
}
