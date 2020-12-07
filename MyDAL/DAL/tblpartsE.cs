using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDAL.DAL
{
    //class tblpartsE
    //{
    //}

    public partial class tblpartsE
    {
        public int PartID { get; set; }
        public string FGCode { get; set; }
        public string OperationNo { get; set; }
        public string PartName { get; set; }
        public decimal IdealCycleTime { get; set; }
        public Nullable<int> PartsPerCycle { get; set; }
        public int UnitDesc { get; set; }
        public int IsDeleted { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public string DrawingNo { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
        public Nullable<decimal> Std_Load_UnloadTime { get; set; }
        public Nullable<decimal> Std_SetupTime { get; set; }
        public Nullable<int> MachineID { get; set; }
        public string StdMinorLoss { get; set; }
        public Nullable<decimal> StdLoadingTime { get; set; }
        public Nullable<decimal> StdUnLoadingTime { get; set; }
        public string PartNo { get; set; }
        public string PartDesc { get; set; }
        public Nullable<int> targetPerHr { get; set; }
        public Nullable<int> planLinkageId { get; set; }
        public Nullable<int> targetPerShift { get; set; }
        public string routingId { get; set; }
        public string resourceId { get; set; }
        public Nullable<int> plantId { get; set; }
        public Nullable<int> priority { get; set; }

       
    }


}
