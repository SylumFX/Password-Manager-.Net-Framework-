//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Password_Manager.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Passwords
    {
        public int ID { get; set; }
        public int User_ID { get; set; }
        public string Website { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Type { get; set; }
        public string Note { get; set; }
        public System.DateTime Created { get; set; }
        public Nullable<System.DateTime> Deleted { get; set; }
        public bool isDeleted { get; set; }
        public bool isFavorite { get; set; }
    
        public virtual User User { get; set; }
    }
}
