//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Banking.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transaction
    {
        public int TransactionId { get; set; }
        public System.DateTime PostedOn { get; set; }
        public decimal Amount { get; set; }
        public string Notes { get; set; }
        public Nullable<int> SourceNo { get; set; }
        public Nullable<int> TargetNo { get; set; }
    
        public virtual Account AccountSource { get; set; }
        public virtual Account AccountTarget { get; set; }
    }
}
