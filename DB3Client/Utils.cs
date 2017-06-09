using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;
using DB3Client.Controls;
using Newtonsoft.Json;

namespace DB3Client
{
    public class Utils
    {
        public static void AjustUserAccess(Control rootControl)
        {
            List<Control> allcontrols = GetAllControls(rootControl).ToList();
            Dictionary<string, bool> userPermission = JsonConvert.DeserializeObject<Dictionary<string, bool>>(DataHolder.UserPermissions);
            foreach (var control in allcontrols)
            {
                if (control.Tag == null) continue;
                if (userPermission == null)
                {
                    control.Enabled = false;
                }
                else
                {
                    if (userPermission.ContainsKey(control.Tag.ToString()))
                    {
                        control.Enabled = userPermission[control.Tag.ToString()];
                    }
                    else
                    {
                        control.Enabled = false;
                    }
                }
            }
        }

        public static List<PermissionAttribute> GetPermissionAttributes()
        {
            List<PermissionAttribute> allAttributes = new List<PermissionAttribute>();
            foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                foreach (Type type in assembly.GetTypes())
                {
                    var attribs = type.GetCustomAttributes(typeof(PermissionAttribute), false);
                    if (attribs != null && attribs.Length > 0)
                    {
                        foreach (var attribute in attribs)
                        {
                            allAttributes.Add((PermissionAttribute) attribute);
                        }
                    }
                }
            }
            return allAttributes;
        }

        public static IEnumerable<Control> GetAllControls(Control container)
        {
            List<Control> controlList = new List<Control>();
            foreach (Control c in container.Controls)
            {
                controlList.AddRange(GetAllControls(c));
                if (c != null)
                    controlList.Add(c);
            }
            return controlList;
        }








    }
}
