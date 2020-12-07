using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDAL.DAL
{
    //class tblbreakdowncodesE
    //{
    //}


    public partial class tblbreakdowncodesE
    {
       
        public int BreakdownID { get; set; }
        public string BreakdownCode { get; set; }
        public string BreakdownDesc { get; set; }
        public string MessageType { get; set; }
        public int BreakdownLevel { get; set; }
        public Nullable<int> BreakdownLevel1ID { get; set; }
        public Nullable<int> BreakdownLevel2ID { get; set; }
        public string ContributeTo { get; set; }
        public int IsDeleted { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<int> EndCode { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
        public int ServerTabCheck { get; set; }
        public int ServerTabFlagSync { get; set; }
        public decimal TargetPercent { get; set; }

       
    }



}
