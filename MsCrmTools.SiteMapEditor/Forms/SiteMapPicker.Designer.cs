namespace MsCrmTools.SiteMapEditor.Forms
{
    partial class SiteMapPicker
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lvSitemaps = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnComponentPickerCancel = new System.Windows.Forms.Button();
            this.btnComponentPickerValidate = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(808, 60);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(3, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(222, 38);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Sitemap selection";
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.btnComponentPickerCancel);
            this.pnlFooter.Controls.Add(this.btnComponentPickerValidate);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 452);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(808, 50);
            this.pnlFooter.TabIndex = 1;
            // 
            // lvSitemaps
            // 
            this.lvSitemaps.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName});
            this.lvSitemaps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSitemaps.FullRowSelect = true;
            this.lvSitemaps.HideSelection = false;
            this.lvSitemaps.Location = new System.Drawing.Point(0, 60);
            this.lvSitemaps.Name = "lvSitemaps";
            this.lvSitemaps.Size = new System.Drawing.Size(808, 392);
            this.lvSitemaps.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvSitemaps.TabIndex = 2;
            this.lvSitemaps.UseCompatibleStateImageBehavior = false;
            this.lvSitemaps.View = System.Windows.Forms.View.Details;
            this.lvSitemaps.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvSitemaps_ColumnClick);
            this.lvSitemaps.DoubleClick += new System.EventHandler(this.lvSitemaps_DoubleClick);
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 200;
            // 
            // btnComponentPickerCancel
            // 
            this.btnComponentPickerCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnComponentPickerCancel.Location = new System.Drawing.Point(683, 8);
            this.btnComponentPickerCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnComponentPickerCancel.Name = "btnComponentPickerCancel";
            this.btnComponentPickerCancel.Size = new System.Drawing.Size(112, 35);
            this.btnComponentPickerCancel.TabIndex = 7;
            this.btnComponentPickerCancel.Text = "Cancel";
            this.btnComponentPickerCancel.UseVisualStyleBackColor = true;
            this.btnComponentPickerCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnComponentPickerValidate
            // 
            this.btnComponentPickerValidate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnComponentPickerValidate.Location = new System.Drawing.Point(562, 8);
            this.btnComponentPickerValidate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnComponentPickerValidate.Name = "btnComponentPickerValidate";
            this.btnComponentPickerValidate.Size = new System.Drawing.Size(112, 35);
            this.btnComponentPickerValidate.TabIndex = 6;
            this.btnComponentPickerValidate.Text = "OK";
            this.btnComponentPickerValidate.UseVisualStyleBackColor = true;
            this.btnComponentPickerValidate.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // SiteMapPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 502);
            this.Controls.Add(this.lvSitemaps);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.Name = "SiteMapPicker";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.ListView lvSitemaps;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.Button btnComponentPickerCancel;
        private System.Windows.Forms.Button btnComponentPickerValidate;
    }
}