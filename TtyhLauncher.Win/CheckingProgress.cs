using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TtyhLauncher.Utils.Data;

namespace TtyhLauncher.Win
{
    class CheckingProgress : IProgress<CheckingState>
    {
        private readonly ProgressBar progress;

        public CheckingProgress(ProgressBar progress)
        {
            this.progress = progress;
        }

        public void Report(CheckingState value)
        {
            progress.Value = value.CurrentFile;
            progress.Maximum = value.TotalFiles;
        }
    }
}
