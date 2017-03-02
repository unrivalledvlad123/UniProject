using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;

namespace DB3Server
{
    class BD3Server
    {
        // Global variables goes here!



        // Global methods goes here!



        public static void Run(string[] args)
        {
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            // This Row MUST be first!!!
            Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

            Output("{0} started successfully!", Constants.Projectname);

            Output("Press any key to close the service.");
            Console.Read();

        }

        public static void Output(string message, params object[] args)
        {
            string msg = message;
            if (args.Length > 0)
                try
                {
                    msg = string.Format(message, args);
                }
                catch
                {
                    foreach (object item in args)
                        msg += "\r\n" + item;
                }
            Console.WriteLine($@"{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff} - {msg}");
        }


    }
}
