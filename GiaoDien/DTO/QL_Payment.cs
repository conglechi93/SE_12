//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GiaoDien.DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class QL_Payment
    {
        public string ID_Oder { get; set; }
        public string ID_Account { get; set; }
        public Nullable<int> Proceeds { get; set; }
        public Nullable<System.DateTime> Payment_Time { get; set; }
    
        public virtual Order Order { get; set; }
    }
}
