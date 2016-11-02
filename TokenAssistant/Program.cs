using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TokenAssistant
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
            //UI.user.UserList form = new UI.user.UserList();
            //Application.Run(form);

            Main mainForm = new Main();
            mainForm.StartPosition = FormStartPosition.CenterScreen;
            Application.Run(mainForm);

        }
    }
}
