using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Classes
{
    public class CommonDiscounts
    {
        public int RowId { get; set; }
        public int PartnerType { get; set; }
        public string TypeName { get; set; }
        public decimal Discount { get; set; }
        public decimal RangeFrom { get; set; }
        public decimal RangeTo { get; set; }
    }
}
