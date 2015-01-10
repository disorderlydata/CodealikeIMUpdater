using CodealikeIMUpdater.MVP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodealikeIMUpdater
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var mainView = new MainForm();
            var presenter = new Presenter(mainView);

            Application.Run(mainView);
        }
    }
}
