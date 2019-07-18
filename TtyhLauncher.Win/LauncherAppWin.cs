using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TtyhLauncher.Ui;

namespace TtyhLauncher.Win
{
    class LauncherAppWin : LauncherApp
    {
        MainWindow mainWindow;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var app = new LauncherAppWin();
            app.Run();
        }

        LauncherAppWin()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainWindow = new MainWindow();
        }

        protected override ILauncherUi CreateUi(string title)
        {
            return mainWindow;
        }

        protected override void RunEventLoop()
        {
            Application.Run(mainWindow);
        }
    }
}
