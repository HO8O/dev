//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wam.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Developer
    {
        public Developer()
        {
            this.Applications = new HashSet<Application>();
            this.Followings = new HashSet<Following>();
            this.Followings1 = new HashSet<Following>();
        }
    
        public int Id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    
        public virtual ICollection<Application> Applications { get; set; }
        public virtual ICollection<Following> Followings { get; set; }
        public virtual ICollection<Following> Followings1 { get; set; }
    }
}