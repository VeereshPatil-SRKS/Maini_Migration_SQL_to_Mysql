using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLDAL.DAL
{
    class pcbdps_master
    {
        public int PcbDpsMasterID { get; set; }
        public Nullable<int> Pin17 { get; set; }
        public Nullable<int> Pin18 { get; set; }
        public Nullable<int> Pin19 { get; set; }
        public Nullable<int> Pin20 { get; set; }
        public Nullable<int> Pin22 { get; set; }
        public Nullable<int> Pin23 { get; set; }
        public Nullable<int> Pin24 { get; set; }
        public Nullable<int> Pin25 { get; set; }
        public Nullable<int> Pin26 { get; set; }
        public Nullable<int> MachineID { get; set; }
        public string ColorValue { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<int> IsDeleted { get; set; }

    }
}
