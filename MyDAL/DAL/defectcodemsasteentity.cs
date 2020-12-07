using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDAL.DAL
{
    //class defectcodemsasteentity
    //{
    //}

    public partial class defectcodemsasteentity
    {
        public int defectCodeId { get; set; }
        public string defectCodeName { get; set; }
        public string defectCodeDesc { get; set; }
        public Nullable<int> isDeleted { get; set; }
        public Nullable<System.DateTime> createdOn { get; set; }
        public Nullable<int> createdBy { get; set; }
        public Nullable<System.DateTime> modifiedOn { get; set; }
        public Nullable<int> modifiedBy { get; set; }
    }



}
