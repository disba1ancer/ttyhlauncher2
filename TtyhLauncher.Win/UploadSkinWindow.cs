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
            openFileDlg.ShowDialog(this);
            txtSkinPath.Text = openFileDlg.FileName;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void BtnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                await upload.Invoke(txtSkinPath.Text, chkSlimModel.Checked);
            }
            catch (ErrorAnswerException answerException)
            {
                MessageBox.Show(this, "Failed to upload skin!", answerException.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch
            {
                MessageBox.Show(this, "Failed to upload skin!", "Unknown error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Close();
        }
    }
}
