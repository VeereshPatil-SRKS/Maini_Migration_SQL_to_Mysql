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
    
    public partial class tbl_autoreporttime
    {
        public tbl_autoreporttime()
        {
            this.tbl_autoreportsetting = new HashSet<tbl_autoreportsetting>();
        }
    
        public int AutoReportTimeID { get; set; }
        public string AutoReportTime { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<int> IsDeleted { get; set; }
    
        public virtual ICollection<tbl_autoreportsetting> tbl_autoreportsetting { get; set; }
    }
}
