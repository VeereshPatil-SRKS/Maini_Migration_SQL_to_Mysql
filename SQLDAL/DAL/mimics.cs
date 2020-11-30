using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQLDAL.DAL
{
    using System;
    using System.Collections.Generic;

    class mimics
    {
        public int mid { get; set; }
        public string MachineOnTime { get; set; }
        public string OperatingTime { get; set; }
        public string SetupTime { get; set; }
        public string IdleTime { get; set; }
        public string MachineOffTime { get; set; }
        public string BreakdownTime { get; set; }
        public int MachineID { get; set; }
        public string Shift { get; set; }
        public string CorrectedDate { get; set; }

    }
}
