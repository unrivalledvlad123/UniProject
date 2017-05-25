using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Classes
{
    public class CommonSettings
    {
        public List<KeyValuePair<int,decimal>> VatSettingsByGroup { get; set; }
        public List<KeyValuePair<string,decimal>> VatSettingsByGroupName { get; set; }
        public string PdfSaveLocation { get; set; }
    }
}
