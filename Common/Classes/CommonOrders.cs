using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Classes
{
    class CommonOrders
    {
        public Guid PurcasedId { get; set; }
        public Guid BuyerId { get; set; }
        public Guid SellerId { get; set; }
        public DateTime Date { get; set; }
        public String InvoiceId { get; set; }
        public String WareHouseReceipt { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public Guid PurcaseId { get; set; }
        public Guid ItemId { get; set; }
        public List<CommonContract> Contract { get; set; }
        public List<CommonItem> Item { get; set; }

    }
}
