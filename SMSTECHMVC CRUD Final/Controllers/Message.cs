//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SMSTECHMVC_CRUD_Final.Controllers
{
    using System;
    using System.Collections.Generic;
    
    public partial class Message
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public Nullable<int> SenderID { get; set; }
        public Nullable<int> RecipientID { get; set; }
        public Nullable<int> StudentID { get; set; }
        public Nullable<bool> Status { get; set; }
    }
}
