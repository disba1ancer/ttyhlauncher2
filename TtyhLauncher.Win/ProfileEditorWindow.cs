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
using TtyhLauncher.Versions.Data;

namespace TtyhLauncher.Win
{
    public partial class ProfileEditorWindow : Form
    {
        private readonly CachedPrefixInfo[] prefixes;
        private readonly Action<string, ProfileData> save;

        public ProfileEditorWindow(string id, ProfileData profile, CachedPrefixInfo[] prefixes, Action<string, ProfileData> save)
        {
            this.prefixes = prefixes;
            this.save = save;
            InitializeComponent();
            txtProfileName.Text = id;
            cbxPrefix.Items.Clear();
            foreach (var prefix in prefixes)
            {
                var prefixIndex = cbxPrefix.Items.Add(prefix.About);
                if (prefix.Id == profile.FullVersion.Prefix)
                {
                    cbxPrefix.SelectedIndex = prefixIndex;
                }
            }
            UpdateVersions();
            cbxVersion.SelectedItem = profile.FullVersion.Version;
            chkNoCheck.Checked = profile.CheckVersionFiles;
        }

        private void CbxProfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateVersions();
        }

        private void UpdateVersions()
        {
            cbxVersion.Items.Clear();
            foreach (var version in prefixes[cbxPrefix.SelectedIndex].Versions)
            {
                cbxVersion.Items.Add(version);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var profileData = new ProfileData {
                FullVersion = new FullVersionId(
                    prefixes[cbxPrefix.SelectedIndex].Id,
                    prefixes[cbxPrefix.SelectedIndex].Versions[cbxVersion.SelectedIndex]),
                CheckVersionFiles = chkNoCheck.Checked
            };
            save.Invoke(txtProfileName.Text, profileData);
            Close();
        }
    }
}
