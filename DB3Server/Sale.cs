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
    
    public partial class Sale
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sale()
        {
            this.Salesmappings = new HashSet<Salesmapping>();
        }
    
        public int Id { get; set; }
        public int Company_id { get; set; }
        public System.DateTime Date { get; set; }
        public Nullable<int> Contract_id { get; set; }
        public int Type { get; set; }
        public int Reciept_id { get; set; }
        public Nullable<int> Invoice_id { get; set; }
    
        public virtual Company Company { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Salesmapping> Salesmappings { get; set; }
    }
}