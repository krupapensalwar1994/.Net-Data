//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusSystem.Core
{
    using System;
    using System.Collections.Generic;
    
    public partial class FareInfo
    {
        public int FareInfoId { get; set; }
        public int CategoryId { get; set; }
        public int Age { get; set; }
        public Nullable<double> Fare { get; set; }
    
        public virtual CategoryInfo CategoryInfo { get; set; }
    }
}
