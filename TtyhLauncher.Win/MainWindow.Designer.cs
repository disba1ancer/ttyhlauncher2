namespace TtyhLauncher.Win
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.chkRemember = new System.Windows.Forms.CheckBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.cbxProfile = new System.Windows.Forms.ComboBox();
            this.lblProfile = new System.Windows.Forms.Label();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlMultibutton = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnProfileEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRemoveProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnUploadSkin = new System.Windows.Forms.ToolStripMenuItem();
            this.chkHide = new System.Windows.Forms.ToolStripMenuItem();
            this.chkOffline = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMultibutton.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            resources.ApplyResources(this.txtUsername, "txtUsername");
            this.pnlMain.SetColumnSpan(this.txtUsername, 2);
            this.txtUsername.Name = "txtUsername";
            // 
            // txtPassword
            // 
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.pnlMain.SetColumnSpan(this.txtPassword, 2);
            this.txtPassword.Name = "txtPassword";
            // 
            // btnLogin
            // 
            resources.ApplyResources(this.btnLogin, "btnLogin");
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // chkRemember
            // 
            resources.ApplyResources(this.chkRemember, "chkRemember");
            this.pnlMain.SetColumnSpan(this.chkRemember, 2);
            this.chkRemember.Name = "chkRemember";
            this.chkRemember.UseVisualStyleBackColor = true;
            // 
            // lblUsername
            // 
            resources.ApplyResources(this.lblUsername, "lblUsername");
            this.lblUsername.Name = "lblUsername";
            // 
            // lblPassword
            // 
            resources.ApplyResources(this.lblPassword, "lblPassword");
            this.lblPassword.Name = "lblPassword";
            // 
            // cbxProfile
            // 
            resources.ApplyResources(this.cbxProfile, "cbxProfile");
            this.pnlMain.SetColumnSpan(this.cbxProfile, 2);
            this.cbxProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProfile.FormattingEnabled = true;
            this.cbxProfile.Name = "cbxProfile";
            // 
            // lblProfile
            // 
            resources.ApplyResources(this.lblProfile, "lblProfile");
            this.lblProfile.Name = "lblProfile";
            // 
            // progress
            // 
            resources.ApplyResources(this.progress, "progress");
            this.pnlMain.SetColumnSpan(this.progress, 4);
            this.progress.Name = "progress";
            // 
            // txtLog
            // 
            resources.ApplyResources(this.txtLog, "txtLog");
            this.txtLog.BackColor = System.Drawing.SystemColors.Window;
            this.pnlMain.SetColumnSpan(this.txtLog, 4);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // pnlMultibutton
            // 
            resources.ApplyResources(this.pnlMultibutton, "pnlMultibutton");
            this.pnlMultibutton.Controls.Add(this.btnCancel);
            this.pnlMultibutton.Controls.Add(this.btnLogin);
            this.pnlMultibutton.Name = "pnlMultibutton";
            // 
            // pnlMain
            // 
            resources.ApplyResources(this.pnlMain, "pnlMain");
            this.pnlMain.Controls.Add(this.lblProfile, 1, 2);
            this.pnlMain.Controls.Add(this.txtLog, 0, 0);
            this.pnlMain.Controls.Add(this.lblUsername, 1, 3);
            this.pnlMain.Controls.Add(this.lblPassword, 1, 4);
            this.pnlMain.Controls.Add(this.txtPassword, 2, 4);
            this.pnlMain.Controls.Add(this.progress, 0, 1);
            this.pnlMain.Controls.Add(this.chkRemember, 1, 5);
            this.pnlMain.Controls.Add(this.cbxProfile, 2, 2);
            this.pnlMain.Controls.Add(this.pnlMultibutton, 3, 5);
            this.pnlMain.Controls.Add(this.txtUsername, 2, 3);
            this.pnlMain.Name = "pnlMain";
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            resources.ApplyResources(this.mnuMain, "mnuMain");
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnProfileEditor,
            this.toolStripMenuItem2,
            this.btnAddProfile,
            this.btnRemoveProfile,
            this.toolStripMenuItem1,
            this.btnUploadSkin,
            this.chkHide,
            this.chkOffline});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            resources.ApplyResources(this.optionsToolStripMenuItem, "optionsToolStripMenuItem");
            // 
            // btnProfileEditor
            // 
            this.btnProfileEditor.Name = "btnProfileEditor";
            resources.ApplyResources(this.btnProfileEditor, "btnProfileEditor");
            this.btnProfileEditor.Click += new System.EventHandler(this.BtnProfileEditor_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            // 
            // btnAddProfile
            // 
            this.btnAddProfile.Name = "btnAddProfile";
            resources.ApplyResources(this.btnAddProfile, "btnAddProfile");
            this.btnAddProfile.Click += new System.EventHandler(this.BtnAddProfile_Click);
            // 
            // btnRemoveProfile
            // 
            this.btnRemoveProfile.Name = "btnRemoveProfile";
            resources.ApplyResources(this.btnRemoveProfile, "btnRemoveProfile");
            this.btnRemoveProfile.Click += new System.EventHandler(this.BtnRemoveProfile_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // btnUploadSkin
            // 
            this.btnUploadSkin.Name = "btnUploadSkin";
            resources.ApplyResources(this.btnUploadSkin, "btnUploadSkin");
            this.btnUploadSkin.Click += new System.EventHandler(this.BtnUploadSkin_Click);
            // 
            // chkHide
            // 
            this.chkHide.CheckOnClick = true;
            this.chkHide.Name = "chkHide";
            resources.ApplyResources(this.chkHide, "chkHide");
            // 
            // chkOffline
            // 
            this.chkOffline.CheckOnClick = true;
            this.chkOffline.Name = "chkOffline";
            resources.ApplyResources(this.chkOffline, "chkOffline");
            this.chkOffline.CheckedChanged += new System.EventHandler(this.ChkOffline_CheckedChanged);
            // 
            // MainWindow
            // 
            this.AcceptButton = this.btnLogin;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.btnCancel;
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.Name = "MainWindow";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.pnlMultibutton.ResumeLayout(false);
            this.pnlMultibutton.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.CheckBox chkRemember;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.ComboBox cbxProfile;
        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chkOffline;
        private System.Windows.Forms.ToolStripMenuItem btnProfileEditor;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.Panel pnlMultibutton;
        private System.Windows.Forms.TableLayoutPanel pnlMain;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem btnAddProfile;
        private System.Windows.Forms.ToolStripMenuItem btnRemoveProfile;
        private System.Windows.Forms.ToolStripMenuItem chkHide;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem btnUploadSkin;
    }
}

