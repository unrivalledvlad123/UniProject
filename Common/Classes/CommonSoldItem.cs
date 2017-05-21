using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Classes
{
    public class CommonSoldItem
    {
        public Decimal Price { get; set; }
        public int Quantity { get; set; }
        public Guid ItemId { get; set; }
        public Guid SaleId { get; set; }
    }
}
