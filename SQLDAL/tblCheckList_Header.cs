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
    
    public partial class tblCheckList_Header
    {
        public int HeaderId { get; set; }
        public Nullable<int> PlantId { get; set; }
        public string PlantName { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public string CategoryName { get; set; }
        public Nullable<int> MakeId { get; set; }
        public string MakeName { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public int RevNo { get; set; }
        public Nullable<System.DateTime> LastRevDate { get; set; }
        public string CheckListNo { get; set; }
        public Nullable<int> PreparedBy { get; set; }
        public Nullable<System.DateTime> PreparedByDate { get; set; }
        public Nullable<int> ApprovedBy { get; set; }
        public Nullable<System.DateTime> ApprovedByDate { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<int> IsDeleted { get; set; }
        public Nullable<int> IsPrepared { get; set; }
        public Nullable<int> IsApproved { get; set; }
        public Nullable<int> IsEditApproved { get; set; }
    }
}
