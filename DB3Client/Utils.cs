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
            List<Control> allcontrols = GetAllButtonControls(rootControl).ToList();
            List<KeyValuePair<Guid, bool>> userPermissions = new List<KeyValuePair<Guid, bool>>();
            userPermissions.Add(new KeyValuePair<Guid, bool>(Guid.Parse("DCBB98FB-5B18-4395-AF8C-B332C15A9151"), true)); // get from DB 
            foreach (var control in allcontrols)
            {
                if (control.Tag == null) continue;
                KeyValuePair<Guid, bool> sincedRow = userPermissions.FirstOrDefault(p => p.Key == Guid.Parse(control.Tag.ToString()));
                if (sincedRow.Key != Guid.Empty)
                {
                    control.Enabled = sincedRow.Value;
                }
                else
                {
                    control.Enabled = false;
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

        public static IEnumerable<Control> GetAllButtonControls(Control container)
        {
            List<Control> controlList = new List<Control>();
            foreach (Control c in container.Controls)
            {
                controlList.AddRange(GetAllButtonControls(c));
                if (c is Button)
                    controlList.Add(c);
            }
            return controlList;
        }








    }
}
