using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TtyhLauncher.Profiles.Data;
using TtyhLauncher.Ui;
using TtyhLauncher.Utils.Data;
using TtyhLauncher.Versions.Data;

namespace TtyhLauncher.Win
{
    public partial class MainWindow : Form, ILauncherUi
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public bool OfflineMode { get => chkOffline.Checked; set => chkOffline.Checked = value; }
        public bool SavePassword { get => chkRemember.Checked; set => chkRemember.Checked = value; }
        public bool HideOnRun { get => chkHide.Checked; set => chkHide.Checked = value; }
        public string UserName { get => txtUsername.Text; set => txtUsername.Text = value; }
        public string Password { get => txtPassword.Text; set => txtPassword.Text = value; }

        public string SelectedProfile => cbxProfile.Text;

        public event Action OnExit;
        public event Action OnPlayButtonClicked;
        public event Action OnTaskCancelClicked;
        public event Action<bool> OnOfflineModeToggle;
        public event Action OnAddProfileClicked;
        public event Action OnEditProfileClicked;
        public event Action OnRemoveProfileClicked;
        public event Action OnUploadSkinClicked;

        public void AppendLog(string line)
        {
            line += Environment.NewLine;
            txtLog.AppendText(line);
        }

        public bool AskForDownloads(int filesCount, long totalSize)
        {
            var msg = new StringBuilder();
            var rm = Properties.Resources.ResourceManager;
            msg.AppendFormat(rm.GetString("downloadRequest"), filesCount, (Convert.ToDouble(totalSize) / 1024 / 1024).ToString("0.##"));
            var result = MessageBox.Show(this, msg.ToString(), rm.GetString("downloadTitle"), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }

        public void GetWindowSize(out int w, out int h)
        {
            w = Width;
            h = Height;
        }

        public void HideTask()
        {
            SetTaskState(false);
            progress.Value = progress.Minimum;
        }

        public void SetInteractable(bool interactable)
        {
            lblProfile.Enabled = interactable;
            cbxProfile.Enabled = interactable;
            lblUsername.Enabled = interactable;
            txtUsername.Enabled = interactable;
            lblPassword.Enabled = interactable;
            txtPassword.Enabled = interactable;
            chkRemember.Enabled = interactable;
            btnLogin.Enabled = interactable;
            chkOffline.Enabled = interactable;
        }

        public void SetProfiles(string[] names, string selected)
        {
            cbxProfile.Items.Clear();
            foreach (var profile in names)
            {
                cbxProfile.Items.Add(profile);
            }
            cbxProfile.SelectedItem = selected;
        }

        public void SetWindowSize(int w, int h)
        {
            Size = new Size(w, h);
        }

        public void SetWindowVisible(bool isVisible)
        {
            Visible = isVisible;
        }

        public IProgress<CheckingState> ShowCheckingTask()
        {
            SetTaskState(true);
            return new CheckingProgress(progress);
        }

        public IProgress<DownloadingState> ShowDownloadingTask()
        {
            SetTaskState(true);
            return new DownloadingProgress(progress);
        }

        public void ShowErrorMessage([Localizable(true)] string message, string details = null)
        {
            var rm = Properties.Resources.ResourceManager;
            MessageBox.Show(this, message, rm.GetString("errorTitle"), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ShowProfile(string id, ProfileData profile, CachedPrefixInfo[] prefixes, Action<string, ProfileData> save)
        {
            var settingsWindow = new ProfileEditorWindow(id, profile, prefixes, save);
            settingsWindow.ShowDialog(this);
        }

        public void ShowSkinUpload(Func<string, bool, Task> upload)
        {
            var skinDlg = new UploadSkinWindow(upload);
            skinDlg.ShowDialog(this);
        }

        private void SetTaskState(bool state)
        {
            btnCancel.Enabled = state;
            btnCancel.Visible = state;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            OnPlayButtonClicked?.Invoke();
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            OnExit?.Invoke();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            OnTaskCancelClicked?.Invoke();
        }

        private void ChkOffline_CheckedChanged(object sender, EventArgs e)
        {
            OnOfflineModeToggle?.Invoke(chkOffline.Checked);
        }

        private void BtnProfileEditor_Click(object sender, EventArgs e)
        {
            OnEditProfileClicked?.Invoke();
        }

        private void BtnAddProfile_Click(object sender, EventArgs e)
        {
            OnAddProfileClicked?.Invoke();
        }

        private void BtnRemoveProfile_Click(object sender, EventArgs e)
        {
            OnRemoveProfileClicked?.Invoke();
        }

        private void BtnUploadSkin_Click(object sender, EventArgs e)
        {
            OnUploadSkinClicked?.Invoke();
        }

        public bool ConfirmProfileDeletion(string id)
        {
            var msg = new StringBuilder();
            var rm = Properties.Resources.ResourceManager;
            msg.AppendFormat(rm.GetString("profileDeleteRequest"), id);
            var result = MessageBox.Show(this, msg.ToString(), rm.GetString("profileDeleteTitle"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            return result == DialogResult.Yes;
        }
    }
}
