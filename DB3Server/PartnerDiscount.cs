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
    
    public partial class PartnerDiscount
    {
        public int RowID { get; set; }
        public int PartnerType { get; set; }
        public decimal Discount { get; set; }
        public Nullable<decimal> RangeFrom { get; set; }
        public Nullable<decimal> RangeTo { get; set; }
        public string TypeName { get; set; }
    }
}
