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
    
    public partial class Reviews
    {
        public int ReviewID { get; set; }
        public Nullable<int> SellerID { get; set; }
        public string ReviewText { get; set; }
    
        public virtual Sellers Sellers { get; set; }
    }
}
