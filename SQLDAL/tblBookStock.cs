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
    
    public partial class tblBookStock
    {
        public long bookStockId { get; set; }
        public string bookStockName { get; set; }
        public string bookStockDesc { get; set; }
        public string toolSapCode { get; set; }
        public string plantCode { get; set; }
        public Nullable<long> plantId { get; set; }
        public string sapLoaction { get; set; }
        public Nullable<long> quantity { get; set; }
        public string sapBatch { get; set; }
        public Nullable<bool> isDeleted { get; set; }
        public Nullable<bool> isActive { get; set; }
        public Nullable<System.DateTime> createdOn { get; set; }
        public Nullable<long> createdby { get; set; }
        public Nullable<System.DateTime> modifiedOn { get; set; }
        public Nullable<long> modifiedBy { get; set; }
    }
}
