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
    
    public partial class FormElementChoice
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string value { get; set; }
        public string defaultValue { get; set; }
        public string dataType { get; set; }
        public Nullable<int> formElementId { get; set; }
        public string label { get; set; }
        public string placeholder { get; set; }
        public Nullable<int> order { get; set; }
    
        public virtual FormElement FormElement { get; set; }
    }
}
