using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDAL.DAL
{
    //class pcbdaqinTblEntiyt
    //{
    //}

    public partial class pcbdaqinTblEntiyt
    {
        public int DAQINID { get; set; }
        public string PCBIPAddress { get; set; }
        public int ParamPIN { get; set; }
        public Nullable<int> ParamValue { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<int> CreatedBy { get; set; }
    }


}
