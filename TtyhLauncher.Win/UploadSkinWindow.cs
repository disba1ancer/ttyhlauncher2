using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TtyhLauncher.Master.Exceptions;

namespace TtyhLauncher.Win
{
    public partial class UploadSkinWindow : Form
    {
        private readonly Func<string, bool, Task> upload;

        public UploadSkinWindow(Func<string, bool, Task> upload)
        {
            this.upload = upload;
            InitializeComponent();
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            var result = openFileDlg.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                txtSkinPath.Text = openFileDlg.FileName;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void BtnUpload_Click(object sender, EventArgs e)
        {
            var rm = Properties.Resources.ResourceManager;
            try
            {
                await upload.Invoke(txtSkinPath.Text, chkSlimModel.Checked);
            }
            catch (ErrorAnswerException answerException)
            {
                MessageBox.Show(this, answerException.Message, rm.GetString("uploadSkinErrorTitle"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch
            {
                MessageBox.Show(this, rm.GetString("uploadSkinErrorUnknown"), rm.GetString("uploadSkinErrorTitle"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Close();
        }
    }
}
