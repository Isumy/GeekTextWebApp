//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GeekBooks
{
    using System;
    using System.Collections.Generic;
    
    public partial class ShoppingCart
    {
        public string Username { get; set; }
        public string ISBN { get; set; }
        public decimal PriceEach { get; set; }
        public decimal Quantity { get; set; }
    
        public virtual Book Book { get; set; }
        public virtual User User { get; set; }
    }
}
