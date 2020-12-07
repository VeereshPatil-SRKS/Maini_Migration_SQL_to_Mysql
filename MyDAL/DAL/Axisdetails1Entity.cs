using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDAL.DAL
{
    //class Axisdetails1Entity
    //{
    //}

    public partial class Axisdetails1Entity
    {
        public int ADID { get; set; }
        public int MachineID { get; set; }
        public string Axis { get; set; }
        public Nullable<decimal> AbsPos { get; set; }
        public Nullable<decimal> RelPos { get; set; }
        public Nullable<decimal> MacPos { get; set; }
        public Nullable<decimal> DistPos { get; set; }
        public Nullable<System.DateTime> StartTime { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public Nullable<int> IsDeleted { get; set; }
        public Nullable<System.DateTime> InsertedOn { get; set; }
    }



}
