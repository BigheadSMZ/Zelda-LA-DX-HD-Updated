﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LADXHD_Migrater
{
    internal static class Initialization
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Initialize the classes.
            Forms.Initialize();
            Config.Initialize();
            XDelta3.Initialize();

            // Only run if "xdelta3.exe" is found.
            if (XDelta3.Exists())
                Forms.mainDialog.ShowDialog();
        }
    }
}
