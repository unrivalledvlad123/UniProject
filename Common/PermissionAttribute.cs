using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Common
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = true)]
    public class PermissionAttribute : Attribute
    {
        ///<summary>
        /// Newly generated GUID as string - example: "DCBB98FB-5B18-4395-AF8C-B332C15A91E1"
        ///</summary>
        public string PermissionId { get; set; }

        ///<summary>
        ///The name on the permission - example: can_edit_user. Must be added to resourses for ML support!
        ///</summary>
        public string PermissionName { get; set; }

        ///<summary>
        ///The name on the control that contains this permission - add_edit_form. MUST be added to resourses for ML support!
        ///</summary>
        public string PermissionLocation { get; set; }

        ///<summary>
        ///The name on the Main Control that contains this permission - admin_control. MUST be added to resourses for ML support!
        /// If Main Control is the same as the control that contains the permission, must be same as PermissionLocation Property!
        ///</summary>
        public string PermissionControlRoot { get; set; }
    }
}
