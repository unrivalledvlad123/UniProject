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
    
    public partial class User
    {
        public System.Guid UserId { get; set; }
        public System.Guid OwnerId { get; set; }
        public int Role { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string AssignedTo { get; set; }
        public Nullable<System.DateTime> RegisteredAt { get; set; }
    
        public virtual Owner Owner { get; set; }
    }
}
