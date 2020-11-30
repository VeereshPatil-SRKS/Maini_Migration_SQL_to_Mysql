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
    
    public partial class tblBreakDownTickect
    {
        public int id { get; set; }
        public Nullable<int> machineId { get; set; }
        public Nullable<int> reasonId { get; set; }
        public string operatorId { get; set; }
        public Nullable<int> mntOpId { get; set; }
        public Nullable<int> prodOpId { get; set; }
        public Nullable<System.DateTime> bdTktDateTime { get; set; }
        public Nullable<bool> mntStatus { get; set; }
        public string mntRrejectReason { get; set; }
        public Nullable<System.DateTime> mntAcp_RejDateTime { get; set; }
        public string mntRemarks { get; set; }
        public Nullable<System.DateTime> tktClosingTime { get; set; }
        public Nullable<int> mntClosureOpId { get; set; }
        public Nullable<System.DateTime> prodAcp_RejDateTime { get; set; }
        public Nullable<bool> prodStatus { get; set; }
        public string prodRemarks { get; set; }
        public Nullable<int> isDeleted { get; set; }
        public Nullable<System.DateTime> createdOn { get; set; }
        public string createdBy { get; set; }
        public Nullable<int> woId { get; set; }
        public Nullable<System.DateTime> correctedDate { get; set; }
        public Nullable<int> AcceptFlage { get; set; }
        public Nullable<int> MaintFlage { get; set; }
        public Nullable<int> MaintFinished { get; set; }
        public Nullable<int> ProdFinished { get; set; }
        public Nullable<int> maintRejId { get; set; }
        public Nullable<int> prodRejId { get; set; }
    
        public virtual tblBreakdowncode tblBreakdowncode { get; set; }
        public virtual tblworkorderentry tblworkorderentry { get; set; }
    }
}
