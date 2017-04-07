using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Http;
using Microsoft.Owin.Hosting;

namespace DB3Server
{
    static class BD3Service
    {
        static void Main(string[] args)
        {
            string procName = Process.GetCurrentProcess().ProcessName;
            if (Process.GetProcessesByName(procName).Length > 1)
            {
                MessageBox.Show("Only one instance of " + procName + " can be running at time.", "BD3 Service",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
            else
            {
                AppSettingsReader configurationAppSettings = new AppSettingsReader();
                String baseAddress = (string) configurationAppSettings.GetValue("ServerAddress", typeof(string));

                WebApp.Start<Startup>(url: baseAddress);


                // Start OWIN host 
                BD3Server.Run(args);
                
            }
        }
    }
}
