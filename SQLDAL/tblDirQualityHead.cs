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
    
    public partial class tblDirQualityHead
    {
        public int dirQhId { get; set; }
        public string partDescription { get; set; }
        public string workOrderNumber { get; set; }
        public Nullable<int> operatorId { get; set; }
        public string employeeNo { get; set; }
        public string reworkOrReject { get; set; }
        public string openTracker { get; set; }
        public string trackerNo { get; set; }
        public string routeCause { get; set; }
        public string responsibility { get; set; }
        public Nullable<System.DateTime> targetDate { get; set; }
        public Nullable<System.DateTime> completedOn { get; set; }
        public string remarks { get; set; }
        public string shift { get; set; }
        public string action { get; set; }
        public Nullable<int> isDeleted { get; set; }
        public Nullable<System.DateTime> createdOn { get; set; }
        public Nullable<int> createdBy { get; set; }
        public Nullable<System.DateTime> modifiedOn { get; set; }
        public Nullable<int> modifiedBy { get; set; }
        public Nullable<int> machineId { get; set; }
    }
}
