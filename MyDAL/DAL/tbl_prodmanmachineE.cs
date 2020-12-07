using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDAL.DAL
{
    //class tbl_prodmanmachineE
    //{
    //}

    public partial class tbl_prodmanmachineE
    {
        public int ProdManMachineID { get; set; }
        public int MachineID { get; set; }
        public System.DateTime CorrectedDate { get; set; }
        public int WOID { get; set; }
        public Nullable<decimal> UtilPercent { get; set; }
        public decimal TotalLoss { get; set; }
        public decimal TotalSetup { get; set; }
        public decimal TotalMinorLoss { get; set; }
        public decimal TotalOperatingTime { get; set; }
        public System.DateTime InsertedOn { get; set; }
        public decimal TotalSetupMinorLoss { get; set; }
        public decimal TotalPowerLoss { get; set; }
        public decimal PerformancePerCent { get; set; }
        public decimal QualityPercent { get; set; }
        public int PerfromaceFactor { get; set; }

        
    }


}
