//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DayTide.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Moderator
    {
        public string ModeratorId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public double Salary { get; set; }
        public string Picture { get; set; }
    
        public virtual User User { get; set; }
    }
}
