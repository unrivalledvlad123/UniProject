//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DB3Server
{
    using System;
    using System.Collections.Generic;
    
    public partial class Invoice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Invoice()
        {
            this.Sales = new HashSet<Sale>();
        }
    
        public System.Guid OwnerId { get; set; }
        public System.Guid PartnerId { get; set; }
        public System.Guid SaleId { get; set; }
        public System.Guid InvoiceId { get; set; }
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
        public Nullable<decimal> DiscountPercent { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
