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
    
    public partial class tblescalationlog
    {
        public int ELID { get; set; }
        public Nullable<int> EscalationID { get; set; }
        public Nullable<int> LossCodeID { get; set; }
        public int IsIdle { get; set; }
        public Nullable<System.DateTime> EscalationSentOn { get; set; }
        public string CorrectedDate { get; set; }
        public int IsDeleted { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<int> WCID { get; set; }
    
        public virtual tbllossescode tbllossescode { get; set; }
    }
}
