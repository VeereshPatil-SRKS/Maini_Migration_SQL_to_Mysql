using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDAL.DAL
{
    //class utilreportE
    //{
    //}
    public partial class utilreportE
    {
        public int UtilReportID { get; set; }
        public int MachineID { get; set; }
        public System.DateTime CorrectedDate { get; set; }
        public decimal TotalTime { get; set; }
        public decimal OperatingTime { get; set; }
        public decimal SetupTime { get; set; }
        public decimal MinorLossTime { get; set; }
        public decimal LossTime { get; set; }
        public decimal BDTime { get; set; }
        public decimal PowerOffTime { get; set; }
        public decimal UtilPercent { get; set; }
        public System.DateTime InsertedOn { get; set; }
        public decimal SetupMinorTime { get; set; }
    }

}
