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
    
    public partial class Review
    {
        public string ISBN { get; set; }
        public string Username { get; set; }
        public decimal Rating { get; set; }
        public string Comment { get; set; }
        public System.DateTime DatePosted { get; set; }
           
        public virtual Book Book { get; set; }
        public virtual User User { get; set; }

        public bool BoolValue { get { return Anonymous == 1; } set { Anonymous = value ? 1 : 0; } }
        public int Anonymous { get; set; }

    }
}
