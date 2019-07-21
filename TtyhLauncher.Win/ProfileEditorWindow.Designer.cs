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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileEditorWindow));
            System.Windows.Forms.Label lblPrefix;
            this.cbxPrefix = new System.Windows.Forms.ComboBox();
            this.cbxVersion = new System.Windows.Forms.ComboBox();
            this.chkNoCheck = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlSettings = new System.Windows.Forms.TableLayoutPanel();
            this.lblPrefixName = new System.Windows.Forms.Label();
            this.txtProfileName = new System.Windows.Forms.TextBox();
            this.chkCustomJava = new System.Windows.Forms.CheckBox();
            this.txtCustomJava = new System.Windows.Forms.TextBox();
            this.chkJavaArgs = new System.Windows.Forms.CheckBox();
            this.txtJavaArgs = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.dlgSelectJava = new System.Windows.Forms.OpenFileDialog();
            this.lblPlaceholder = new System.Windows.Forms.Label();
            lblVersion = new System.Windows.Forms.Label();
            lblPrefix = new System.Windows.Forms.Label();
            this.pnlSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVersion
            // 
            resources.ApplyResources(lblVersion, "lblVersion");
            lblVersion.Name = "lblVersion";
            // 
            // lblPrefix
            // 
            resources.ApplyResources(lblPrefix, "lblPrefix");
            lblPrefix.Name = "lblPrefix";
            // 
            // cbxPrefix
            // 
            resources.ApplyResources(this.cbxPrefix, "cbxPrefix");
            this.pnlSettings.SetColumnSpan(this.cbxPrefix, 3);
            this.cbxPrefix.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPrefix.FormattingEnabled = true;
            this.cbxPrefix.Name = "cbxPrefix";
            this.cbxPrefix.SelectedIndexChanged += new System.EventHandler(this.CbxProfile_SelectedIndexChanged);
            // 
            // cbxVersion
            // 
            resources.ApplyResources(this.cbxVersion, "cbxVersion");
            this.pnlSettings.SetColumnSpan(this.cbxVersion, 3);
            this.cbxVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxVersion.FormattingEnabled = true;
            this.cbxVersion.Name = "cbxVersion";
            // 
            // chkNoCheck
            // 
            resources.ApplyResources(this.chkNoCheck, "chkNoCheck");
            this.chkNoCheck.Name = "chkNoCheck";
            this.chkNoCheck.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.pnlSettings.SetColumnSpan(this.btnSave, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.pnlSettings.SetColumnSpan(this.btnCancel, 2);
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // pnlSettings
            // 
            resources.ApplyResources(this.pnlSettings, "pnlSettings");
            this.pnlSettings.Controls.Add(this.chkNoCheck, 0, 3);
            this.pnlSettings.Controls.Add(this.cbxVersion, 1, 2);
            this.pnlSettings.Controls.Add(this.cbxPrefix, 1, 1);
            this.pnlSettings.Controls.Add(lblVersion, 0, 2);
            this.pnlSettings.Controls.Add(lblPrefix, 0, 1);
            this.pnlSettings.Controls.Add(this.lblPrefixName, 0, 0);
            this.pnlSettings.Controls.Add(this.txtProfileName, 1, 0);
            this.pnlSettings.Controls.Add(this.chkCustomJava, 0, 4);
            this.pnlSettings.Controls.Add(this.txtCustomJava, 1, 4);
            this.pnlSettings.Controls.Add(this.chkJavaArgs, 0, 5);
            this.pnlSettings.Controls.Add(this.txtJavaArgs, 1, 5);
            this.pnlSettings.Controls.Add(this.btnBrowse, 3, 4);
            this.pnlSettings.Controls.Add(this.btnSave, 0, 7);
            this.pnlSettings.Controls.Add(this.btnCancel, 2, 7);
            this.pnlSettings.Controls.Add(this.lblPlaceholder, 1, 6);
            this.pnlSettings.Name = "pnlSettings";
            // 
            // lblPrefixName
            // 
            resources.ApplyResources(this.lblPrefixName, "lblPrefixName");
            this.lblPrefixName.Name = "lblPrefixName";
            // 
            // txtProfileName
            // 
            resources.ApplyResources(this.txtProfileName, "txtProfileName");
            this.pnlSettings.SetColumnSpan(this.txtProfileName, 3);
            this.txtProfileName.Name = "txtProfileName";
            // 
            // chkCustomJava
            // 
            resources.ApplyResources(this.chkCustomJava, "chkCustomJava");
            this.chkCustomJava.Name = "chkCustomJava";
            this.chkCustomJava.UseVisualStyleBackColor = true;
            this.chkCustomJava.CheckedChanged += new System.EventHandler(this.ChkCustomJava_CheckedChanged);
            // 
            // txtCustomJava
            // 
            resources.ApplyResources(this.txtCustomJava, "txtCustomJava");
            this.pnlSettings.SetColumnSpan(this.txtCustomJava, 2);
            this.txtCustomJava.Name = "txtCustomJava";
            // 
            // chkJavaArgs
            // 
            resources.ApplyResources(this.chkJavaArgs, "chkJavaArgs");
            this.chkJavaArgs.Name = "chkJavaArgs";
            this.chkJavaArgs.UseVisualStyleBackColor = true;
            this.chkJavaArgs.CheckedChanged += new System.EventHandler(this.ChkJavaArgs_CheckedChanged);
            // 
            // txtJavaArgs
            // 
            resources.ApplyResources(this.txtJavaArgs, "txtJavaArgs");
            this.pnlSettings.SetColumnSpan(this.txtJavaArgs, 3);
            this.txtJavaArgs.Name = "txtJavaArgs";
            // 
            // btnBrowse
            // 
            resources.ApplyResources(this.btnBrowse, "btnBrowse");
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // dlgSelectJava
            // 
            resources.ApplyResources(this.dlgSelectJava, "dlgSelectJava");
            // 
            // lblPlaceholder
            // 
            resources.ApplyResources(this.lblPlaceholder, "lblPlaceholder");
            this.lblPlaceholder.Name = "lblPlaceholder";
            // 
            // ProfileEditorWindow
            // 
            this.AcceptButton = this.btnSave;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.btnCancel;
            this.Controls.Add(this.pnlSettings);
            this.MaximizeBox = false;
            this.Name = "ProfileEditorWindow";
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
        private System.Windows.Forms.CheckBox chkCustomJava;
        private System.Windows.Forms.TextBox txtCustomJava;
        private System.Windows.Forms.CheckBox chkJavaArgs;
        private System.Windows.Forms.TextBox txtJavaArgs;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.OpenFileDialog dlgSelectJava;
        private System.Windows.Forms.Label lblPlaceholder;
    }
}