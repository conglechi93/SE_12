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
    
    public partial class Salary
    {
        public string ID_Salary { get; set; }
        public string ID_Account { get; set; }
        public string Month { get; set; }
        public string Salary1 { get; set; }
    
        public virtual Account Account { get; set; }
    }
}
