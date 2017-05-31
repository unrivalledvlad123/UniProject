using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Classes
{
  public  class CommonInvoice
    {
        public Guid OwnerId { get; set; }
        public Guid PartnerId { get; set; }
        public Guid SaleId { get; set; }
        public Guid InvoiceId { get; set; }
        public int InvoiceNumber { get; set; }
        public string BuyerCompanyName { get; set; }
        public string BuyerAddress { get; set; }
        public string BuyerVATNumber { get; set; }
        public string BuyerBulstat { get; set; }
        public string OwnerCompanyName { get; set; }
        public string OwnerAddress { get; set; }
        public string OwnerVATNumber { get; set; }
        public string OwnerBulstat { get; set; }
        public string OwnerBank { get; set; }
        public string OwnerIBAN { get; set; }
        public string OwnerSwiftCode { get; set; }
        public string BuyerMol { get; set; }
        public string OwnerMol { get; set; }
        public List<CommonSoldItem> SoldItems { get; set; }
        public decimal DiscountPercent { get; set; }
    }
}
