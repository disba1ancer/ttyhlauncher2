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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSkinPath = new System.Windows.Forms.Label();
            this.txtSkinPath = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.chkSlimModel = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lblSkinPath, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtSkinPath, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBrowse, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnUpload, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.chkSlimModel, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(9);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 261);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblSkinPath
            // 
            this.lblSkinPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSkinPath.AutoSize = true;
            this.lblSkinPath.Location = new System.Drawing.Point(12, 17);
            this.lblSkinPath.Name = "lblSkinPath";
            this.lblSkinPath.Size = new System.Drawing.Size(52, 13);
            this.lblSkinPath.TabIndex = 0;
            this.lblSkinPath.Text = "Skin path";
            // 
            // txtSkinPath
            // 
            this.txtSkinPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.txtSkinPath, 2);
            this.txtSkinPath.Location = new System.Drawing.Point(70, 13);
            this.txtSkinPath.Name = "txtSkinPath";
            this.txtSkinPath.Size = new System.Drawing.Size(144, 20);
            this.txtSkinPath.TabIndex = 1;
            // 
            // btnUpload
            // 
            this.btnUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpload.AutoSize = true;
            this.btnUpload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.SetColumnSpan(this.btnUpload, 2);
            this.btnUpload.Location = new System.Drawing.Point(116, 226);
            this.btnUpload.MinimumSize = new System.Drawing.Size(75, 0);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 2;
            this.btnUpload.Text = "OK";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.BtnUpload_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.AutoSize = true;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.SetColumnSpan(this.btnCancel, 2);
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(197, 226);
            this.btnCancel.MinimumSize = new System.Drawing.Size(75, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnBrowse.AutoSize = true;
            this.btnBrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBrowse.Location = new System.Drawing.Point(220, 12);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(52, 23);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // openFileDlg
            // 
            this.openFileDlg.Filter = "PNG Images|*.png";
            this.openFileDlg.Title = "Select skin file";
            // 
            // chkSlimModel
            // 
            this.chkSlimModel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkSlimModel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.chkSlimModel, 2);
            this.chkSlimModel.Location = new System.Drawing.Point(12, 41);
            this.chkSlimModel.Name = "chkSlimModel";
            this.chkSlimModel.Size = new System.Drawing.Size(96, 17);
            this.chkSlimModel.TabIndex = 5;
            this.chkSlimModel.Text = "Use slim model";
            this.chkSlimModel.UseVisualStyleBackColor = true;
            // 
            // UploadSkinWindow
            // 
            this.AcceptButton = this.btnUpload;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "UploadSkinWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Upload skin";
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