//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinalKist.Models.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class fine
    {
        public int id { get; set; }
        public string staffid { get; set; }
        public string issueid { get; set; }
        public string descripttion { get; set; }
        public Nullable<decimal> amount { get; set; }
    
        public virtual issue issue { get; set; }
        public virtual Staff Staff { get; set; }
    }
}
