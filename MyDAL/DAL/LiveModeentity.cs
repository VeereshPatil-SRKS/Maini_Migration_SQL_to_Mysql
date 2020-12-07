using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDAL.DAL
{
    //class LiveModeentity
    //{
    //}


    public partial class LiveModeentity
    {
        public int ModeID { get; set; }
        public int MachineID { get; set; }
        public string MacMode { get; set; }
        public System.DateTime InsertedOn { get; set; }
        public int InsertedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public System.DateTime CorrectedDate { get; set; }
        public int IsDeleted { get; set; }
        public Nullable<System.DateTime> StartTime { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public string ColorCode { get; set; }
        public int IsCompleted { get; set; }
        public Nullable<int> DurationInSec { get; set; }
        public Nullable<int> LossCodeID { get; set; }
        public Nullable<int> BreakdownID { get; set; }
        public string ModeType { get; set; }
        public int ModeTypeEnd { get; set; }
        public int StartIdle { get; set; }
        public Nullable<System.DateTime> LossCodeEnteredTime { get; set; }
        public string LossCodeEnteredBy { get; set; }
        public int IsInserted { get; set; }
        public Nullable<int> TotalPartsCount { get; set; }
        public Nullable<int> CuttingDuration { get; set; }
        public int IsShiftEnd { get; set; }
        public Nullable<int> breakDownCodeID { get; set; }
        public string shift { get; set; }

       
    }



}
