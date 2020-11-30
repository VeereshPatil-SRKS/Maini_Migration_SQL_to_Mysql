using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQLDAL.DAL
{

    using System;
    using System.Collections.Generic;
    class pcbdetails
    {
        public int PCBID { get; set; }
        public Nullable<int> PCBNo { get; set; }
        public string PCBIPAddress { get; set; }
        public string PCBMACAddress { get; set; }
        public Nullable<int> MachineID { get; set; }
        public int IsDeleted { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<int> ModifiedBy { get; set; }

    }
}
