using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        public bool OfflineMode { get => false; set { } }
        public bool SavePassword { get => chkRemember.Checked; set => chkRemember.Checked = value; }
        public bool HideOnRun { get => false; set { } }
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
            txtLog.AppendText(line + "\r\n");
        }

        public bool AskForDownloads(int filesCount, long totalSize)
        {
            return true;
        }

        public void GetWindowSize(out int w, out int h)
        {
            w = Width;
            h = Height;
        }

        public void HideTask()
        {
            progress.Value = progress.Minimum;
        }

        public void SetInteractable(bool interactable)
        {
            
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
            
        }

        public IProgress<CheckingState> ShowCheckingTask()
        {
            return new CheckingProgress(progress);
        }

        public IProgress<DownloadingState> ShowDownloadingTask()
        {
            return new DownloadingProgress(progress);
        }

        public void ShowErrorMessage([Localizable(true)] string message, string details = null)
        {
            MessageBox.Show(this, message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ShowProfile(string id, ProfileData profile, CachedPrefixInfo[] prefixes, Action<string, ProfileData> save)
        {
            throw new NotImplementedException();
        }

        public void ShowSkinUpload(Func<string, bool, Task> upload)
        {
            throw new NotImplementedException();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            OnPlayButtonClicked?.Invoke();
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            OnExit?.Invoke();
        }
    }
}
