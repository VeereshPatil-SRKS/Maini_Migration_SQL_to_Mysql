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
    
    public partial class tbl_genericfilepath
    {
        public int FilePathID { get; set; }
        public string CompleteFilePath { get; set; }
        public string FilePathDesc { get; set; }
        public string FilePathDet { get; set; }
        public Nullable<int> IsDeleted { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<int> TypeofFilePath { get; set; }
    }
}
