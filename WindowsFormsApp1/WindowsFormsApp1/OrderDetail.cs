//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderDetail
    {
        public string OrderDetailID { get; set; }
        public string ProductID { get; set; }
        public int Quantity { get; set; }
        public int Totalorderdetailprice { get; set; }
        public int Unitprice { get; set; }
    
        public virtual Product Product { get; set; }
    }
}
