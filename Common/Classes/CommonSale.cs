using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Classes
{
    public class CommonSale
    {
        public Guid SaleId { get; set; }
        public Guid BuyerId { get; set; }
        public Guid SellerId { get; set; }
        public DateTime Date { get; set; }
        public int Type { get; set; }
        public string InvoiceId { get; set; }
        public List<CommonSoldItem> SoldItems { get; set; }

        public double TotalPrice
        {
            get
            {
                double totalPrice = 0;
                foreach (var item in SoldItems)
                {

                    totalPrice += (double) (item.Quantity * item.Price);
                }
                return totalPrice;


            }
        }

        public string BuyerCompanyName { get; set; }

        public string InvoiceNumber
        {
            get
            {
                if (String.IsNullOrEmpty(InvoiceId))
                {
                    return "";
                }
                return InvoiceId.PadLeft(20, '0');
            }
        }
    }

}
