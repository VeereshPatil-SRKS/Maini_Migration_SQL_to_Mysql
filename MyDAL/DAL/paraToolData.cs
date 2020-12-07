using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDAL.DAL
{
    //class paraToolData
    //{
    //}

    public partial class paraToolData
    {
        public int parameterToolDataId { get; set; }
        public Nullable<int> machineId { get; set; }
        public Nullable<System.DateTime> parameterToolDataCapturedDate { get; set; }
        public string toolGroupName { get; set; }
        public string toolNumber { get; set; }
        public Nullable<int> capacity { get; set; }
        public Nullable<int> partsproduced { get; set; }
        public Nullable<System.DateTime> createdOn { get; set; }
        public Nullable<bool> isDeleted { get; set; }
        public Nullable<System.DateTime> correctedDate { get; set; }
    }



}
