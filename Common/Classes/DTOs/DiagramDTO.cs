using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Classes.DTOs
{
    public class DiagramDTO
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int ReportType { get; set; }
        public bool IsType { get; set; }
        public int ItemType { get; set; }
    }
}
