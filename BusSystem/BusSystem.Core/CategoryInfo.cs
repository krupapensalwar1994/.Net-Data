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
    
    public partial class CategoryInfo
    {
        public CategoryInfo()
        {
            this.BusInfoes = new HashSet<BusInfo>();
            this.FareInfoes = new HashSet<FareInfo>();
        }
    
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    
        public virtual ICollection<BusInfo> BusInfoes { get; set; }
        public virtual ICollection<FareInfo> FareInfoes { get; set; }
    }
}
