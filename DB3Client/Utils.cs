using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;

namespace DB3Client
{
    public class Utils
    {
        public static void AjustUserAccess(int userType, params Control[] controls)
        {
            if (DataHolder.UserType == userType && DataHolder.IsRestricted)
            {
                foreach (var control in controls)
                {
                    control.Enabled = false;
                }
            }
        }
    }
}
