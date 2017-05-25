using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Common.Classes;
using Common.Resourses;

namespace Common
{
    public static class DataHolder
    {
        #region // <====== Private Fileds ======> //

        private static ResourceManager resMan;
        private static CultureInfo userCulture;
        private static CultureInfo defaultCultureInfo = new CultureInfo("en-US");
        private static Guid ownerId;
        private static CompanyOwner owner;
        private static string username;
        private static Guid userId;
        private static int userType;
        private static string serverAddress;
        private static CommonMol primeryMol;
        private static CommonSettings settings;

        #endregion

        #region // <====== Public Fields =======> //

        public static Guid OwnerId
        {
            get { return ownerId; }
            set { ownerId = value; }
        }
        public static CommonSettings Settings
        {
            get { return settings; }
            set { settings = value; }
        }

        public static CommonMol PrimeryMol
        {
            get { return primeryMol; }
            set { primeryMol = value; }
        }

        public static CompanyOwner Owner
        {
            get { return owner; }
            set { owner = value; }
        }

        public static bool DesignMode
        {
            get { return resMan == null; }
        }

        public static string Username
        {
            get { return username; }
            set { username = value; }
        }

        public static Guid CurrnetUserId
        {
            get { return userId; }
            set { userId = value; }
        }

        public static CultureInfo UserCulture
        {
            get { return userCulture; }
            set { userCulture = value; }
        }

        public static int UserType
        {
            get { return userType; }
            set { userType = value; }
        }

        public static string ServerAddress
        {
            get { return serverAddress; }
            set { serverAddress = value; }
        }

        #endregion

        #region // <====== Global Methodts =======> //

        public static string GetString(string key)
        {
            if (DesignMode)
                return key;
            
            string result = resMan.GetString(key.ToUpper(CultureInfo.InvariantCulture),
                userCulture ?? defaultCultureInfo);
            return string.IsNullOrEmpty(result) ? key : result;
        }

        public static string GetString(string key, params object[] args)
        {
            return string.Format(GetString(key), args);
        }



        #endregion

        public static void Init()
        {
            resMan = new ResourceManager(typeof(RH));
            resMan.IgnoreCase = true;
        }

        
    }
}
