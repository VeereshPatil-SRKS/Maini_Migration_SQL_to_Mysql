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
    
    public partial class tblToolAndSocketDetail
    {
        public int socketId { get; set; }
        public string toolNumber { get; set; }
        public string socketNo { get; set; }
        public Nullable<int> machineId { get; set; }
        public Nullable<int> standardToolLife { get; set; }
        public Nullable<int> actaulToolLife { get; set; }
        public Nullable<System.DateTime> toolInsertedDateTime { get; set; }
        public Nullable<System.DateTime> toolRemovedDateTime { get; set; }
        public Nullable<System.DateTime> createdOn { get; set; }
        public Nullable<int> createdBy { get; set; }
        public Nullable<System.DateTime> modifiedOn { get; set; }
        public Nullable<int> modifiedBy { get; set; }
        public Nullable<int> isDeleted { get; set; }
        public string qrcode { get; set; }
    }
}
