﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace General_Journal
{   
    static class Program
    {
        public static Int32 ACTIVE_COMPANY_ID =0;
        public static Int32 ACTIVE_USER_ID = 0;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();            
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }

    }
}
