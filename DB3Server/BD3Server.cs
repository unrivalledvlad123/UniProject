using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB3Server
{
    class BD3Server
    {
        //        private static string connectionString = String.Empty;
        //        private static StringWriter output = null;
        //        public static int ArchiveGroupJobInterval = 60;
        //        public static int LiveMonitoredJobInterval = 15;
        //        public static int SystemJobInterval = 1440;
        //        public static int SystemLicenseCheckInterval = 1440;
        //        public static int AlarmJobInterval = 60;
        //        public static int TimeWaitBeforeSecondWinCCQuery = 60;
        //        public static int MaxTagsCountPerQuery = 60;
        //        public static int OpcTagsSaveInterval = 300;

        //        public static EasyUAClient OpcClient = new EasyUAClient();

        //        //OPC client variables
        //        public static Dictionary<int, List<RSRTWinCcTag>> OpcValues = new Dictionary<int, List<RSRTWinCcTag>>();
        //        public static List<OpcArchiveGroup> OpcArchiveGroups = new List<OpcArchiveGroup>();
        //        public static List<OpcTags> AllSubscribedTags = new List<OpcTags>();
        //        public static List<string> CurrentlySubscribedTags = new List<string>();
        //        public static List<OpcChannelState> OpcChannelState = new List<OpcChannelState>();




        //        //WinCCReader client connected variables
        //        public static int WinCcReaderRefreshTime = 15;

        //        public static List<WinCcReaderApplicationPostbacks> WinCcReaderAppPostbacks =
        //            new List<WinCcReaderApplicationPostbacks>();

        //        public static List<RSRTWinCcTag> RTLastData = new List<RSRTWinCcTag>();
        //        public static List<RsRuntimeDataInternal> PrimaryServerData = new List<RsRuntimeDataInternal>();
        //        public static List<RsRuntimeDataInternal> SecondaryServerData = new List<RsRuntimeDataInternal>();
        //        public static bool RTTagsFileReady = false;
        //        //private static System.Timers.Timer tArchiveGroup;
        //        //private static System.Timers.Timer tLiveMonitoredArchiveGroup;

        //        //private static Timer timerArchiveGroup;
        //        //private static Timer timerLiveMonitored;
        //        private static Timer timerSystemTasks;
        //        private static Timer timerGetWinCCAlarms;
        //        private static Timer timerLicenseCheck;
        //        private static Timer timerOpcSubscribe;

        //        public static bool IsService { get; set; }

        //        public static string ConnString
        //        {
        //            get { return connectionString; }
        //            set { connectionString = value; }
        //        }

        //        public static StringWriter Out
        //        {
        //            get { return output; }
        //            set
        //            {
        //                if (value != output)
        //                {
        //                    output = value;
        //                    Console.SetOut(output);
        //                }
        //            }
        //        }

        //        public static void Output(Exception e)
        //        {
        //            Output(e.ToString());
        //        }

        //        public static void Output(string message, params object[] args)
        //        {
        //            string msg = message;
        //            if (args.Length > 0)
        //                try
        //                {
        //                    msg = string.Format(message, args);
        //                }
        //                catch
        //                {
        //                    foreach (object item in args)
        //                        msg += "\r\n" + item.ToString();
        //                }

        //            Console.WriteLine(string.Format("{0} - {1}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"), msg));
        //        }


        public static void Run(string[] args)
        {
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            // This Row MUST be first!!!
            Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!


            MessageBox.Show("success", "BD3 Service",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            //SqlServerTypesUtil.LoadNativeAssemblies();

            //#region Initialize Settings from App.Config

            //AppSettingsReader configurationAppSettings = new AppSettingsReader();
            //connectionString = (string)configurationAppSettings.GetValue("DBConnectionString", typeof(string));

            //try
            //{
            //    ArchiveGroupJobInterval =
            //        (int)configurationAppSettings.GetValue("ArchiveGroupJobIntervalInMinutes", typeof(int));
            //}
            //catch
            //{
            //    CASServer.Output("Invalid or missing parameter 'ArchiveGroupJobIntervalInMinutes' in .confing file.");
            //}

            //try
            //{
            //    LiveMonitoredJobInterval =
            //        (int)configurationAppSettings.GetValue("LiveMonitoredJobIntervalInMinutes", typeof(int));
            //}
            //catch
            //{
            //    CASServer.Output("Invalid or missing parameter 'LiveMonitoredJobIntervalInMinutes' in .confing file.");
            //}

            //try
            //{
            //    SystemJobInterval = (int)configurationAppSettings.GetValue("SystemJobIntervalInMinutes", typeof(int));
            //}
            //catch
            //{
            //    Output("Invalid or missing parameter 'SystemJobIntervalInMinutes' in .confing file.");
            //}

            //try
            //{
            //    AlarmJobInterval = (int)configurationAppSettings.GetValue("AlarmJobIntervalInMinutes", typeof(int));
            //}
            //catch
            //{
            //    Output("Invalid or missing parameter 'AlarmJobIntervalInMinutes' in .confing file.");
            //}

            //try
            //{
            //    TimeWaitBeforeSecondWinCCQuery =
            //        (int)configurationAppSettings.GetValue("TimeWaitBeforeSecondWinCCQueryInSeconds", typeof(int));
            //}
            //catch
            //{
            //    Output("Invalid or missing parameter 'TimeWaitBeforeSecondWinCCQueryInSeconds' in .confing file.");
            //}

            //try
            //{
            //    MaxTagsCountPerQuery =
            //        (int)configurationAppSettings.GetValue("WinCCMaxTagsCountPerQuery", typeof(int));
            //}
            //catch
            //{
            //    Output("Invalid or missing parameter 'WinCCMaxTagsCountPerQuery' in .confing file.");
            //}

            //if (BLLicenseManager.Current.IsModuleLicensed("RT View"))
            //{
            //    try
            //    {
            //        WinCcReaderRefreshTime =
            //            (int)configurationAppSettings.GetValue("WinCcReaderRefreshTime", typeof(int));
            //    }
            //    catch
            //    {
            //        Output("Invalid or missing parameter 'WinCcReaderRefreshTime' in .confing file.");
            //    }

            //    try
            //    {
            //        List<ClientAppInfo> winCcClientApplications = BLWinCcReader.GetAllClientApplications();
            //        foreach (ClientAppInfo clientApp in winCcClientApplications)
            //        {
            //            RSPostBackData postBackData = new RSPostBackData
            //            {
            //                IsTagListRequired = true,
            //                NewRefreshTime = WinCcReaderRefreshTime,
            //                NewRuntimeTags =
            //                    BLWinCcReader.GetClientTags(clientApp.ClientAppId.HasValue
            //                        ? clientApp.ClientAppId.Value
            //                        : Guid.NewGuid())
            //            };
            //            WinCcReaderApplicationPostbacks appPostbacks = new WinCcReaderApplicationPostbacks
            //            {
            //                ClientAppId = clientApp.ClientAppId.Value,
            //                PostBackData = postBackData
            //            };
            //            WinCcReaderAppPostbacks.Add(appPostbacks);
            //        }
            //    }
            //    catch
            //    {
            //        Output("Problem loading WinCC Reader Applications");
            //    }
        }

            //            #endregion

            //            //cache connection string
            //            Cache.CacheObject(connectionString, "DBConnectionString");

            //            Version ver = Environment.Version;
            //            Console.WriteLine(string.Format("Application Server Environment .NET Framework version : {0}.{1}.{2}.{3}",
            //                ver.Major, ver.Minor, ver.Build, ver.Revision));

            //            Output("Application Server license checking ...");
            //            Log.AddMessage("Application Server license checking ...");

            //            if (!BLLicenseManager.Current.IsLicensed)
            //            {
            //                Output(BLLicenseManager.Current.NotLicensedReason);
            //                Log.AddMessage(BLLicenseManager.Current.NotLicensedReason);
            //#if !DEBUG
            //				EventLog.WriteEntry("CASServer", BLLicenseManager.Current.NotLicensedReason, EventLogEntryType.Error);
            //				Environment.Exit(777);
            //#endif
            //            }
            //            Output("Application Server license validated.");
            //            Log.AddMessage("Application Server license validated.");
            //            //TODO Test zone marker




            //            #region <!--- Background Jobs --->

            //            Output("=== Sync Channel's WinCC Version ===");
            //            Log.AddMessage("=== Sync Channel's WinCC Version ===");
            //            WinCCJobs.SyncChannelWinccVersion();

            //            //DateTime now;
            //            //DateTime nextInterval;
            //            TimeSpan dueTime;
            //            TimeSpan period;

            //            // timerArchiveGroup
            //            Task.Factory.StartNew(() => WinCCJobs.ArchiveGroups());

            //            // timerLiveMonitored
            //            Task.Factory.StartNew(() => WinCCJobs.LiveMonitoredArchiveGroups());

            //            // timerRTViewArchiveGroup

            //            if (BLLicenseManager.Current.IsModuleLicensed("RT View"))
            //            {
            //                Task.Factory.StartNew(() => WinCCJobs.RTViewArchiveGroups());
            //                Task.Factory.StartNew(() => BLWinCcReader.SaveRTViewData());
            //            }


            //            // license check
            //            if (BLLicenseManager.Current.LicensedUntil < DateTime.MaxValue)
            //            {
            //                dueTime = TimeSpan.Zero;
            //                period = TimeSpan.FromMinutes(SystemLicenseCheckInterval);
            //                timerLicenseCheck = new Timer(CheckLicense, null, dueTime, period);
            //                GC.KeepAlive(timerLicenseCheck);
            //            }


            //            // timerSystemTasks
            //            if (SystemJobInterval > 0)
            //            {
            //                Output("=== Start System Jobs ===");
            //                Log.AddMessage("=== Start System Jobs ===");
            //                dueTime = TimeSpan.Zero;
            //                period = TimeSpan.FromMinutes(SystemJobInterval);
            //                timerSystemTasks = new Timer(SystemJobs.Execute, null, dueTime, period);
            //                GC.KeepAlive(timerSystemTasks);
            //            }

            //            // timerGetWinCCAlarms
            //            if (AlarmJobInterval > 0)
            //            {
            //                Output("=== Start Alarm Jobs ===");
            //                Log.AddMessage("=== Start Alarm Jobs ===");
            //                dueTime = TimeSpan.Zero;
            //                period = TimeSpan.FromMinutes(AlarmJobInterval);
            //                timerGetWinCCAlarms = new Timer(WinCCJobs.ExecuteAlarms, null, dueTime, period);
            //                GC.KeepAlive(timerGetWinCCAlarms);
            //            }

            //            //test
            //            //string filePath = Path.Combine(Path.GetTempPath(), Constants.TempPath, "tags.def");
            //            //RSAllRTClientsTags tags = BLWinCcReader.ReadFromBinaryFile(filePath);

            //            if (BLLicenseManager.Current.IsModuleLicensed("OPC"))
            //            {
            //                Output("=== Start OPC Data Subscription ===");
            //                Log.AddMessage("=== Start OPC Data Subscription ===");
            //                BLOPC.SubscribeToMany();

            //                Output("=== Start OPC Saving To DB ===");
            //                Log.AddMessage("=== Start OPC Saving To DB ===");
            //                OpcManager.Initialize();
            //                Task.Factory.StartNew(() => OpcManager.SaveOpcLastValues());
            //            }

            //            #endregion

            //            Output("Application Server has been started successfully.");
            //            Log.AddMessage("Application Server has been started successfully.");

            //            if (!IsService)
            //            {
            //                Console.WriteLine("Press Enter to stop it.");
            //                Console.ReadLine();
            //            }

            //        }


            //        /// <summary>
            //        /// Determines whether license is expired.
            //        /// </summary>
            //        /// <returns></returns>
            //        internal static void CheckLicense(object data)
            //        {
            //            if (BLLicenseManager.Current.LicensedUntil < DateTime.UtcNow)
            //            {
            //                Output("SAS license expired");
            //                Log.AddMessage("SAS license expired");
            //#if !DEBUG
            //				EventLog.WriteEntry("CASServer","SAS license expired", EventLogEntryType.Error);
            //				Environment.Exit(777);
            //#endif
            //            }
            //        }

            //        [Serializable]
            //        public class WinCcReaderApplicationPostbacks
            //        {
            //            public Guid ClientAppId { get; set; }
            //            public RSPostBackData PostBackData { get; set; }
            //        }


            //    }

            //    public class OpcTags
            //    {
            //        public int ID { get; set; }
            //        public string PrimaryAdress { get; set; }
            //        public string SecondaryAdress { get; set; }
            //    }

            //    public class OpcChannelState
            //    {
            //        public int ChannelId { get; set; }
            //        public bool IsConnectionOk { get; set; }
            //        public bool IsConnectionOkPrevious { get; set; }
            //        public DateTime LatestChange { get; set; }


            //    }

        }
}
