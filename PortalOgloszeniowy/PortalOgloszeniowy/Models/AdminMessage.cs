//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PortalOgloszeniowy.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AdminMessage
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Message { get; set; }
        public bool IsActive { get; set; }
    
        public virtual AspNetUsers AspNetUsers { get; set; }
    }
}
