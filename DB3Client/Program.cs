using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;
using DB3Client.Forms;
using Common.Resourses;
namespace DB3Client
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        static Mutex mutex = new Mutex(true, "{0757C217-6E1F-410A-9455-2B9AAFA37F76}");

        [STAThread]
        static void Main()
        {
            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new LoginForm());
                mutex.ReleaseMutex();
            }
            else
            {
               MessageBox.Show(DataHolder.GetString("only_one_instance_at_a_time"));
            }
        }
    }
}
