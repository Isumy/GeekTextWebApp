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
    
    public partial class CreditCard
    {
        public string CCNumber { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CVV { get; set; }
        public System.DateTime ExpDate { get; set; }
    
        public virtual User User { get; set; }
    }
}