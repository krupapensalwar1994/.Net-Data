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
    
    public partial class BusSchedule
    {
        public BusSchedule()
        {
            this.Bookings = new HashSet<Booking>();
        }
    
        public int Id { get; set; }
        public System.DateTime DepartureDate { get; set; }
        public Nullable<System.DateTime> ReturnDate { get; set; }
        public System.TimeSpan DepartureTime { get; set; }
        public System.TimeSpan ArrivalTime { get; set; }
        public System.TimeSpan Duration { get; set; }
        public int BusId { get; set; }
        public int RouteId { get; set; }
    
        public virtual ICollection<Booking> Bookings { get; set; }
        public virtual BusInfo BusInfo { get; set; }
        public virtual RouteInfo RouteInfo { get; set; }
    }
}
