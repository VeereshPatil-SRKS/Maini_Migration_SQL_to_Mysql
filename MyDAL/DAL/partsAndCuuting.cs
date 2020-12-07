using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDAL.DAL
{
    //class partsAndCuuting
    //{
    //}


    public partial class partsAndCuuting
    {
        public int pcid { get; set; }
        public int MachineID { get; set; }
        public int PartCount { get; set; }
        public int CuttingTime { get; set; }
        public int TargetQuantity { get; set; }
        public System.DateTime StartTime { get; set; }
        public System.DateTime EndTime { get; set; }
        public int Isdeleted { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<System.DateTime> CorrectedDate { get; set; }
        public int CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> PartsPerCyscleEnteredTime { get; set; }
        public int WoPartCount { get; set; }
        public string ShiftName { get; set; }
        public Nullable<int> CuttingTimeInSec { get; set; }
        public int woTargetQty { get; set; }
        public Nullable<int> rejectionQty { get; set; }
        public Nullable<int> reworkQty { get; set; }
        public Nullable<int> actualQty { get; set; }
        public Nullable<int> IsInserted { get; set; }
        public Nullable<int> OkQty { get; set; }
    }


}
