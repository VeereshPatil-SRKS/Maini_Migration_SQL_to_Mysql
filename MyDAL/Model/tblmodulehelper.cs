//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyDAL.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblmodulehelper
    {
        public int ID { get; set; }
        public string ModuleID { get; set; }
        public Nullable<int> RoleID { get; set; }
        public bool IsAll { get; set; }
        public bool IsAdded { get; set; }
        public bool IsEdited { get; set; }
        public bool IsRemoved { get; set; }
        public bool IsReadonly { get; set; }
        public bool IsHidden { get; set; }
        public short IsDeleted { get; set; }
    }
}
