namespace TtyhLauncher.Win
{
    partial class ProfileEditorWindow
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
            System.Windows.Forms.Label lblVersion;
            System.Windows.Forms.Label lblPrefix;
            this.cbxPrefix = new System.Windows.Forms.ComboBox();
            this.cbxVersion = new System.Windows.Forms.ComboBox();
            this.chkNoCheck = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlSettings = new System.Windows.Forms.TableLayoutPanel();
            this.lblPrefixName = new System.Windows.Forms.Label();
            this.txtProfileName = new System.Windows.Forms.TextBox();
            lblVersion = new System.Windows.Forms.Label();
            lblPrefix = new System.Windows.Forms.Label();
            this.pnlSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVersion
            // 
            lblVersion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lblVersion.AutoSize = true;
            lblVersion.Location = new System.Drawing.Point(12, 69);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new System.Drawing.Size(42, 13);
            lblVersion.TabIndex = 1;
            lblVersion.Text = "Version";
            // 
            // lblPrefix
            // 
            lblPrefix.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lblPrefix.AutoSize = true;
            lblPrefix.Location = new System.Drawing.Point(12, 42);
            lblPrefix.Name = "lblPrefix";
            lblPrefix.Size = new System.Drawing.Size(33, 13);
            lblPrefix.TabIndex = 2;
            lblPrefix.Text = "Prefix";
            // 
            // cbxPrefix
            // 
            this.cbxPrefix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSettings.SetColumnSpan(this.cbxPrefix, 2);
            this.cbxPrefix.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPrefix.FormattingEnabled = true;
            this.cbxPrefix.Location = new System.Drawing.Point(83, 38);
            this.cbxPrefix.Name = "cbxPrefix";
            this.cbxPrefix.Size = new System.Drawing.Size(189, 21);
            this.cbxPrefix.TabIndex = 0;
            this.cbxPrefix.SelectedIndexChanged += new System.EventHandler(this.CbxProfile_SelectedIndexChanged);
            // 
            // cbxVersion
            // 
            this.cbxVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSettings.SetColumnSpan(this.cbxVersion, 2);
            this.cbxVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxVersion.FormattingEnabled = true;
            this.cbxVersion.Location = new System.Drawing.Point(83, 65);
            this.cbxVersion.Name = "cbxVersion";
            this.cbxVersion.Size = new System.Drawing.Size(189, 21);
            this.cbxVersion.TabIndex = 3;
            // 
            // chkNoCheck
            // 
            this.chkNoCheck.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkNoCheck.AutoSize = true;
            this.pnlSettings.SetColumnSpan(this.chkNoCheck, 2);
            this.chkNoCheck.Location = new System.Drawing.Point(12, 92);
            this.chkNoCheck.Name = "chkNoCheck";
            this.chkNoCheck.Size = new System.Drawing.Size(85, 17);
            this.chkNoCheck.TabIndex = 4;
            this.chkNoCheck.Text = "Check prefix";
            this.chkNoCheck.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.AutoSize = true;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlSettings.SetColumnSpan(this.btnSave, 2);
            this.btnSave.Location = new System.Drawing.Point(116, 226);
            this.btnSave.MinimumSize = new System.Drawing.Size(75, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "OK";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.AutoSize = true;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Location = new System.Drawing.Point(197, 226);
            this.btnCancel.MinimumSize = new System.Drawing.Size(75, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // pnlSettings
            // 
            this.pnlSettings.ColumnCount = 3;
            this.pnlSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlSettings.Controls.Add(this.btnSave, 0, 4);
            this.pnlSettings.Controls.Add(this.btnCancel, 2, 4);
            this.pnlSettings.Controls.Add(this.chkNoCheck, 0, 3);
            this.pnlSettings.Controls.Add(this.cbxVersion, 1, 2);
            this.pnlSettings.Controls.Add(this.cbxPrefix, 1, 1);
            this.pnlSettings.Controls.Add(lblVersion, 0, 2);
            this.pnlSettings.Controls.Add(lblPrefix, 0, 1);
            this.pnlSettings.Controls.Add(this.lblPrefixName, 0, 0);
            this.pnlSettings.Controls.Add(this.txtProfileName, 1, 0);
            this.pnlSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSettings.Location = new System.Drawing.Point(0, 0);
            this.pnlSettings.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Padding = new System.Windows.Forms.Padding(9);
            this.pnlSettings.RowCount = 5;
            this.pnlSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlSettings.Size = new System.Drawing.Size(284, 261);
            this.pnlSettings.TabIndex = 7;
            // 
            // lblPrefixName
            // 
            this.lblPrefixName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPrefixName.AutoSize = true;
            this.lblPrefixName.Location = new System.Drawing.Point(12, 15);
            this.lblPrefixName.Name = "lblPrefixName";
            this.lblPrefixName.Size = new System.Drawing.Size(65, 13);
            this.lblPrefixName.TabIndex = 7;
            this.lblPrefixName.Text = "Profile name";
            // 
            // txtProfileName
            // 
            this.txtProfileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSettings.SetColumnSpan(this.txtProfileName, 2);
            this.txtProfileName.Location = new System.Drawing.Point(83, 12);
            this.txtProfileName.Name = "txtProfileName";
            this.txtProfileName.Size = new System.Drawing.Size(189, 20);
            this.txtProfileName.TabIndex = 8;
            // 
            // ProfileEditorWindow
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.pnlSettings);
            this.MaximizeBox = false;
            this.Name = "ProfileEditorWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Profile editor";
            this.pnlSettings.ResumeLayout(false);
            this.pnlSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxPrefix;
        private System.Windows.Forms.ComboBox cbxVersion;
        private System.Windows.Forms.CheckBox chkNoCheck;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TableLayoutPanel pnlSettings;
        private System.Windows.Forms.Label lblPrefixName;
        private System.Windows.Forms.TextBox txtProfileName;
    }
}