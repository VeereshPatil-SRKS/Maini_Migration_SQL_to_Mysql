using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDAL.DAL
{
    //class parameterMasterEntity
    //{
    //}


    public partial class parameterMasterEntity
    {
        public int ParameterID { get; set; }
        public string SetupTime { get; set; }
        public string OperatingTime { get; set; }
        public string PowerOnTime { get; set; }
        public Nullable<double> PartsCount { get; set; }
        public Nullable<System.DateTime> InsertedOn { get; set; }
        public Nullable<int> MachineID { get; set; }
        public Nullable<int> Shift { get; set; }
        public Nullable<System.DateTime> CorrectedDate { get; set; }
        public string AutoCutTime { get; set; }
        public string Total_CutTime { get; set; }
        public Nullable<int> PartsTotal { get; set; }
        public string CuttingTime { get; set; }
        public int AutoMode { get; set; }
    }



}
