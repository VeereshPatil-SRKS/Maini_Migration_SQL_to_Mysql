//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SQLDAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblWorkCenter
    {
        public long workCenterId { get; set; }
        public string workCenterName { get; set; }
        public string workCenterDescription { get; set; }
        public string plantCode { get; set; }
        public Nullable<long> plantId { get; set; }
        public string woCode { get; set; }
        public string costCenter { get; set; }
        public Nullable<bool> isDeleted { get; set; }
        public Nullable<bool> isActive { get; set; }
        public Nullable<System.DateTime> createdOn { get; set; }
        public Nullable<long> createdBy { get; set; }
        public Nullable<System.DateTime> modifiedOn { get; set; }
        public Nullable<long> modifiedBy { get; set; }
    }
}
