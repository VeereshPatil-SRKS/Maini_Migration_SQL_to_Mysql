using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDAL.DAL
{
    //class tblstoppageE
    //{
    //}
    public partial class tblstoppageE
    {
        public int stoppagesId { get; set; }
        public Nullable<int> categoryId { get; set; }
        public Nullable<int> alramNo { get; set; }
        public string alramDesc { get; set; }
        public Nullable<int> sourceId { get; set; }
        public Nullable<System.DateTime> createdOn { get; set; }
        public Nullable<int> createdBy { get; set; }
        public Nullable<int> modifiedBy { get; set; }
        public Nullable<System.DateTime> modifiedOn { get; set; }
        public Nullable<int> isDeleted { get; set; }
    }



}
