using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MAPMAClient.GUI;

namespace MAPMAClient {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new CreateBooking());
            //Application.Run(new CreateEscapeRoom());
            Application.Run(new GUI.MainMenu());
            //Application.Run(new CreateEscapeRoom());
            Application.Run(new ReadBooking());

        }
    }
}
