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
    
    public partial class tbl_CycleTimeAnalysis
    {
        public int CTAID { get; set; }
        public string PartNum { get; set; }
        public Nullable<int> MachineID { get; set; }
        public string CorrectedDate { get; set; }
        public Nullable<int> PartsCount { get; set; }
        public Nullable<decimal> Std_CycleTime { get; set; }
        public string Std_CycleTimeUnit { get; set; }
        public Nullable<decimal> AvgLoadTimeinMinutes { get; set; }
        public Nullable<decimal> OperatingTime { get; set; }
        public string OperatingTimeUnit { get; set; }
        public Nullable<decimal> AvgOperatingTime { get; set; }
        public string AvgOperatingTimeUnit { get; set; }
        public Nullable<decimal> Std_LoadTime { get; set; }
        public string Std_LoadTimeUnit { get; set; }
        public Nullable<decimal> TotalLoadTime { get; set; }
        public string TotalLoadTimeUnit { get; set; }
        public Nullable<decimal> LossTime { get; set; }
        public string LossTimeUnit { get; set; }
        public Nullable<int> IsDeleted { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
    }
}
