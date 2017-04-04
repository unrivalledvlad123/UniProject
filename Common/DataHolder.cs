using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using Common.Resourses;

namespace Common
{
    public class DataHolder
    {
        #region // <====== Private Fileds ======> //

        private static ResourceManager resMan;
        private static string username;
        private static Guid curentUserId;
        private static Enums.UserRoles userType;
        private static CultureInfo userCulture;
        private static CultureInfo defaultCultureInfo = new CultureInfo("en-US");


        #endregion

        #region // <====== Public Fields =======> //


        public static string Username
        {
            get { return username; }
            set { username = value; }
        }

        public static Guid CurrnetUserId
        {
            get { return curentUserId; }
            set { curentUserId = value; }
        }

        public static CultureInfo UserCulture
        {
            get { return userCulture; }
            set { userCulture = value; }
        }

        public static Enums.UserRoles UserType
        {
            get { return userType; }
            set { userType = value; }
        }

        public static string ServerAddress { get; set; }

        #endregion

        #region // <====== Global Methodts =======> //

        public static string GetString(string key)
        {

            if (resMan != null)
            {
                string result = resMan.GetString(key.ToUpper(CultureInfo.InvariantCulture),
                    userCulture ?? defaultCultureInfo);
                return string.IsNullOrEmpty(result) ? key : result;
            }
            else
            {
                return key;
            }
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
