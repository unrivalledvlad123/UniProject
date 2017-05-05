using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Classes.DTOs
{
    public class ReportDTO
    {
        public int ReportType { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public bool IsItem { get; set; }
        public string ItemCode { get; set; }
        public bool IsType { get; set; }
        public int ItemType { get; set; }
    }
}
