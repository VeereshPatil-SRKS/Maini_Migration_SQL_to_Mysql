using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDAL.DAL
{
    //class ChildFgPartNo
    //{
    //}

    public partial class ChildFgPartNo
    {
        public int childFgpartId { get; set; }
        public string childFgPartNo { get; set; }
        public string childPartNoDesc { get; set; }
        public Nullable<int> plantId { get; set; }
        public string fgPartNo { get; set; }
        public Nullable<int> isDeleted { get; set; }
        public Nullable<System.DateTime> createdOn { get; set; }
        public Nullable<int> createdBy { get; set; }
        public Nullable<System.DateTime> modifiedOn { get; set; }
        public Nullable<int> modifiedBy { get; set; }
        public string fgPartDesc { get; set; }
    }


}
