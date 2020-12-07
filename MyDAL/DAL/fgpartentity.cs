using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDAL.DAL
{
    //class fgpartentity
    //{
    //}

    public partial class fgpartentity
    {
        public int fgAndCellAllocationId { get; set; }
        public Nullable<int> plantId { get; set; }
        public string partNo { get; set; }
        public Nullable<int> cellFinalId { get; set; }
        public Nullable<int> subCellFinalId { get; set; }
        public Nullable<int> isDeleted { get; set; }
        public Nullable<System.DateTime> createdOn { get; set; }
        public Nullable<int> createdBy { get; set; }
        public Nullable<System.DateTime> modifiedOn { get; set; }
        public Nullable<int> modifiedBy { get; set; }
        public string partName { get; set; }
        public string dmcCodeStatus { get; set; }
    }


}
