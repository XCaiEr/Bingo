﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Bingo
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        static Thread thrdNetworkMsg;
        [STAThread]
        static void Main()
        {
            thrdNetworkMsg = new Thread(new ThreadStart(NetworkMessage.DoWork));
            thrdNetworkMsg.Start();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Logon());

        }
    }
}
