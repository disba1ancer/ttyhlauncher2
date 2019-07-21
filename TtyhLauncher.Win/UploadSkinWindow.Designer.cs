namespace TtyhLauncher.Win
{
    partial class UploadSkinWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UploadSkinWindow));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSkinPath = new System.Windows.Forms.Label();
            this.txtSkinPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chkSlimModel = new System.Windows.Forms.CheckBox();
            this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.lblSkinPath, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtSkinPath, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBrowse, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnUpload, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.chkSlimModel, 0, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // lblSkinPath
            // 
            resources.ApplyResources(this.lblSkinPath, "lblSkinPath");
            this.lblSkinPath.Name = "lblSkinPath";
            // 
            // txtSkinPath
            // 
            resources.ApplyResources(this.txtSkinPath, "txtSkinPath");
            this.tableLayoutPanel1.SetColumnSpan(this.txtSkinPath, 2);
            this.txtSkinPath.Name = "txtSkinPath";
            // 
            // btnBrowse
            // 
            resources.ApplyResources(this.btnBrowse, "btnBrowse");
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // btnUpload
            // 
            resources.ApplyResources(this.btnUpload, "btnUpload");
            this.tableLayoutPanel1.SetColumnSpan(this.btnUpload, 2);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.BtnUpload_Click);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.tableLayoutPanel1.SetColumnSpan(this.btnCancel, 2);
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // chkSlimModel
            // 
            resources.ApplyResources(this.chkSlimModel, "chkSlimModel");
            this.tableLayoutPanel1.SetColumnSpan(this.chkSlimModel, 4);
            this.chkSlimModel.Name = "chkSlimModel";
            this.chkSlimModel.UseVisualStyleBackColor = true;
            // 
            // openFileDlg
            // 
            resources.ApplyResources(this.openFileDlg, "openFileDlg");
            // 
            // UploadSkinWindow
            // 
            this.AcceptButton = this.btnUpload;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "UploadSkinWindow";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblSkinPath;
        private System.Windows.Forms.TextBox txtSkinPath;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDlg;
        private System.Windows.Forms.CheckBox chkSlimModel;
    }
}