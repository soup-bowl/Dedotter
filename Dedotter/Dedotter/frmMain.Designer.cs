namespace Dedotter
{
    partial class frmMain
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
            this.pnlBrowse = new System.Windows.Forms.Panel();
            this.txtWorkingDirectory = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lstDotfiles = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnStart = new System.Windows.Forms.Button();
            this.chkDelete = new System.Windows.Forms.CheckBox();
            this.fbdDirectoryBrowse = new System.Windows.Forms.FolderBrowserDialog();
            this.lblDotfileCount = new System.Windows.Forms.Label();
            this.btnDeselectAll = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.pnlBrowse.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBrowse
            // 
            this.pnlBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBrowse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBrowse.Controls.Add(this.txtWorkingDirectory);
            this.pnlBrowse.Controls.Add(this.btnBrowse);
            this.pnlBrowse.Location = new System.Drawing.Point(12, 9);
            this.pnlBrowse.Name = "pnlBrowse";
            this.pnlBrowse.Size = new System.Drawing.Size(663, 29);
            this.pnlBrowse.TabIndex = 0;
            // 
            // txtWorkingDirectory
            // 
            this.txtWorkingDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWorkingDirectory.Location = new System.Drawing.Point(3, 3);
            this.txtWorkingDirectory.Name = "txtWorkingDirectory";
            this.txtWorkingDirectory.Size = new System.Drawing.Size(574, 20);
            this.txtWorkingDirectory.TabIndex = 5;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(583, 2);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.btnSelectAll);
            this.pnlMain.Controls.Add(this.btnDeselectAll);
            this.pnlMain.Controls.Add(this.lstDotfiles);
            this.pnlMain.Location = new System.Drawing.Point(12, 41);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(663, 298);
            this.pnlMain.TabIndex = 1;
            // 
            // lstDotfiles
            // 
            this.lstDotfiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstDotfiles.CheckBoxes = true;
            this.lstDotfiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName});
            this.lstDotfiles.Location = new System.Drawing.Point(3, 32);
            this.lstDotfiles.Name = "lstDotfiles";
            this.lstDotfiles.Size = new System.Drawing.Size(655, 261);
            this.lstDotfiles.TabIndex = 1;
            this.lstDotfiles.UseCompatibleStateImageBehavior = false;
            this.lstDotfiles.View = System.Windows.Forms.View.List;
            // 
            // colName
            // 
            this.colName.Text = "Path";
            this.colName.Width = 1200;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(600, 345);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // chkDelete
            // 
            this.chkDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkDelete.AutoSize = true;
            this.chkDelete.Location = new System.Drawing.Point(481, 349);
            this.chkDelete.Name = "chkDelete";
            this.chkDelete.Size = new System.Drawing.Size(109, 17);
            this.chkDelete.TabIndex = 3;
            this.chkDelete.Text = "Delete, don\'t hide";
            this.chkDelete.UseVisualStyleBackColor = true;
            // 
            // fbdDirectoryBrowse
            // 
            this.fbdDirectoryBrowse.Description = "Select the top level directory where you wish to look for dot files.";
            // 
            // lblDotfileCount
            // 
            this.lblDotfileCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDotfileCount.AutoSize = true;
            this.lblDotfileCount.Location = new System.Drawing.Point(13, 349);
            this.lblDotfileCount.Name = "lblDotfileCount";
            this.lblDotfileCount.Size = new System.Drawing.Size(98, 13);
            this.lblDotfileCount.TabIndex = 4;
            this.lblDotfileCount.Text = "0 Dotfle(s) selected";
            // 
            // btnDeselectAll
            // 
            this.btnDeselectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeselectAll.Location = new System.Drawing.Point(583, 3);
            this.btnDeselectAll.Name = "btnDeselectAll";
            this.btnDeselectAll.Size = new System.Drawing.Size(75, 23);
            this.btnDeselectAll.TabIndex = 2;
            this.btnDeselectAll.Text = "Deselect all";
            this.btnDeselectAll.UseVisualStyleBackColor = true;
            this.btnDeselectAll.Click += new System.EventHandler(this.btnDeselectAll_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectAll.Location = new System.Drawing.Point(502, 3);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(75, 23);
            this.btnSelectAll.TabIndex = 3;
            this.btnSelectAll.Text = "Select all";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 380);
            this.Controls.Add(this.lblDotfileCount);
            this.Controls.Add(this.chkDelete);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlBrowse);
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.Text = "Dedotter";
            this.pnlBrowse.ResumeLayout(false);
            this.pnlBrowse.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBrowse;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtWorkingDirectory;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.CheckBox chkDelete;
        private System.Windows.Forms.FolderBrowserDialog fbdDirectoryBrowse;
        private System.Windows.Forms.Label lblDotfileCount;
        private System.Windows.Forms.ListView lstDotfiles;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnDeselectAll;
    }
}

