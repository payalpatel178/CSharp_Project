//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BloodBankWPFApplication
{
    using System;
    using System.Collections.Generic;
    
    public partial class DonorDetail
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string bloodGroup { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        public int addressId { get; set; }
        public string phoneNo { get; set; }
        public string email { get; set; }
    
        public virtual Address Address { get; set; }
    }
}