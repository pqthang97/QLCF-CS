//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLCF
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderInfo
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public Nullable<int> Cost { get; set; }
        public Nullable<int> Count { get; set; }
        public Nullable<int> Total { get; set; }
    
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
