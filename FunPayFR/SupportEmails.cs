//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FunPayFR
{
    using System;
    using System.Collections.Generic;
    
    public partial class SupportEmails
    {
        public int EmailID { get; set; }
        public Nullable<int> SupportID { get; set; }
        public string Email { get; set; }
    
        public virtual SupportTeam SupportTeam { get; set; }
    }
}
