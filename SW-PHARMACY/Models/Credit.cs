//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SW_PHARMACY.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Credit
    {
        public int Credit_id { get; set; }
        public string Credit_Holder_Name { get; set; }
        public Nullable<System.DateTime> Credit_Expire { get; set; }
        public Nullable<int> Postal_Code { get; set; }
        public Nullable<int> CVV_Number { get; set; }
        public Nullable<int> User_Id { get; set; }
    
        public virtual User User { get; set; }
    }
}
