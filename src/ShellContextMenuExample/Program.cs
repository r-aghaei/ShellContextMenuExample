using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShellContextMenuExample
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string folderName = null;
            if (Environment.GetCommandLineArgs().Length > 1)
                folderName = Environment.GetCommandLineArgs()[1];

            if (string.IsNullOrEmpty(folderName))
                MessageBox.Show("After installing the application, " +
                    "Right click on a folder an select 'Open with my App'");
            else
                MessageBox.Show($"Selected folder: '{folderName}'");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            Application.Run(new Form1());
        }
    }
}
