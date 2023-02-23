using CRUD_MySQL.model.dol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD_MySQL.view;

namespace CRUD_MySQL.main
{
    internal static class Main
    {

   
            /// <summary>
            /// The main entry point for the application.
            /// </summary>
            [STAThread]
            static void MainMethod()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Login());
            }
        
    }
}
