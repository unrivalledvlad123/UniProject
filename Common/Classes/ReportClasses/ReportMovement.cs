using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Classes.ReportClasses
{
    public class ReportMovement
    {
        public string Name { get; set; }
        public Dictionary<DateTime,int> QuantityesList { get; set; }
    }
}
