using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TtyhLauncher.Utils.Data;

namespace TtyhLauncher.Win
{
    class DownloadingProgress : IProgress<DownloadingState>
    {
        private readonly ProgressBar progress;

        public DownloadingProgress(ProgressBar progress)
        {
            this.progress = progress;
        }

        public void Report(DownloadingState value)
        {
            progress.Value = value.CurrentFile;
            progress.Maximum = value.TotalFiles;
        }
    }
}
