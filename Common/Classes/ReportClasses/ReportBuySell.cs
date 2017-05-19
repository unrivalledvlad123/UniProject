using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Classes.ReportClasses
{
    public class ReportBuySell
    {
        public DateTime Date { get; set; }
        public decimal PriceEach { get; set; }
        public decimal Quantity { get; set; }
        public int Unit { get; set; }
        public decimal Total { get; set; }
        public string UnitString { get; set; }
        public string Name { get; set; }
    }
}
