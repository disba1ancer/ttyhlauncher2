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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.chkOffline = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRemoveProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.chkHide = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnUploadSkin = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMultibutton.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.SetColumnSpan(this.txtUsername, 2);
            this.txtUsername.Location = new System.Drawing.Point(638, 339);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(150, 20);
            this.txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.SetColumnSpan(this.txtPassword, 2);
            this.txtPassword.Location = new System.Drawing.Point(638, 365);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(150, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSize = true;
            this.btnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLogin.Location = new System.Drawing.Point(0, 0);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(43, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // chkRemember
            // 
            this.chkRemember.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkRemember.AutoSize = true;
            this.pnlMain.SetColumnSpan(this.chkRemember, 2);
            this.chkRemember.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkRemember.Location = new System.Drawing.Point(577, 394);
            this.chkRemember.Name = "chkRemember";
            this.chkRemember.Size = new System.Drawing.Size(94, 17);
            this.chkRemember.TabIndex = 3;
            this.chkRemember.Text = "Remember me";
            this.chkRemember.UseVisualStyleBackColor = true;
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUsername.AutoSize = true;
            this.lblUsername.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblUsername.Location = new System.Drawing.Point(577, 342);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(3);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPassword.AutoSize = true;
            this.lblPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPassword.Location = new System.Drawing.Point(577, 368);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(3);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password";
            // 
            // cbxProfile
            // 
            this.cbxProfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.SetColumnSpan(this.cbxProfile, 2);
            this.cbxProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProfile.FormattingEnabled = true;
            this.cbxProfile.Location = new System.Drawing.Point(638, 312);
            this.cbxProfile.Name = "cbxProfile";
            this.cbxProfile.Size = new System.Drawing.Size(150, 21);
            this.cbxProfile.TabIndex = 6;
            // 
            // lblProfile
            // 
            this.lblProfile.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblProfile.AutoSize = true;
            this.lblProfile.Location = new System.Drawing.Point(577, 316);
            this.lblProfile.Margin = new System.Windows.Forms.Padding(3);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(36, 13);
            this.lblProfile.TabIndex = 7;
            this.lblProfile.Text = "Profile";
            // 
            // progress
            // 
            this.progress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.SetColumnSpan(this.progress, 4);
            this.progress.Location = new System.Drawing.Point(12, 283);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(776, 23);
            this.progress.TabIndex = 8;
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.BackColor = System.Drawing.SystemColors.Window;
            this.pnlMain.SetColumnSpan(this.txtLog, 4);
            this.txtLog.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLog.Location = new System.Drawing.Point(12, 12);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(776, 265);
            this.txtLog.TabIndex = 9;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(0, 0);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(50, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // pnlMultibutton
            // 
            this.pnlMultibutton.AutoSize = true;
            this.pnlMultibutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlMultibutton.Controls.Add(this.btnCancel);
            this.pnlMultibutton.Controls.Add(this.btnLogin);
            this.pnlMultibutton.Location = new System.Drawing.Point(738, 391);
            this.pnlMultibutton.Name = "pnlMultibutton";
            this.pnlMultibutton.Size = new System.Drawing.Size(50, 23);
            this.pnlMultibutton.TabIndex = 13;
            // 
            // pnlMain
            // 
            this.pnlMain.ColumnCount = 4;
            this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
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
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 24);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(9);
            this.pnlMain.RowCount = 6;
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlMain.Size = new System.Drawing.Size(800, 426);
            this.pnlMain.TabIndex = 15;
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mnuMain.Size = new System.Drawing.Size(800, 24);
            this.mnuMain.TabIndex = 14;
            this.mnuMain.Text = "menuStrip1";
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
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // btnProfileEditor
            // 
            this.btnProfileEditor.Name = "btnProfileEditor";
            this.btnProfileEditor.Size = new System.Drawing.Size(180, 22);
            this.btnProfileEditor.Text = "Edit profile";
            this.btnProfileEditor.Click += new System.EventHandler(this.BtnProfileEditor_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // chkOffline
            // 
            this.chkOffline.CheckOnClick = true;
            this.chkOffline.Name = "chkOffline";
            this.chkOffline.Size = new System.Drawing.Size(180, 22);
            this.chkOffline.Text = "Offline mode";
            this.chkOffline.CheckedChanged += new System.EventHandler(this.ChkOffline_CheckedChanged);
            // 
            // btnAddProfile
            // 
            this.btnAddProfile.Name = "btnAddProfile";
            this.btnAddProfile.Size = new System.Drawing.Size(180, 22);
            this.btnAddProfile.Text = "Add profile";
            this.btnAddProfile.Click += new System.EventHandler(this.BtnAddProfile_Click);
            // 
            // btnRemoveProfile
            // 
            this.btnRemoveProfile.Name = "btnRemoveProfile";
            this.btnRemoveProfile.Size = new System.Drawing.Size(180, 22);
            this.btnRemoveProfile.Text = "Remove profile";
            this.btnRemoveProfile.Click += new System.EventHandler(this.BtnRemoveProfile_Click);
            // 
            // chkHide
            // 
            this.chkHide.CheckOnClick = true;
            this.chkHide.Name = "chkHide";
            this.chkHide.Size = new System.Drawing.Size(180, 22);
            this.chkHide.Text = "Hide after launch";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // btnUploadSkin
            // 
            this.btnUploadSkin.Name = "btnUploadSkin";
            this.btnUploadSkin.Size = new System.Drawing.Size(180, 22);
            this.btnUploadSkin.Text = "Upload skin";
            this.btnUploadSkin.Click += new System.EventHandler(this.BtnUploadSkin_Click);
            // 
            // MainWindow
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.Name = "MainWindow";
            this.Text = "Ttyh Launcher";
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

