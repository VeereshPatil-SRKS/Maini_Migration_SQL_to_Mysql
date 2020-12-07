using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDAL.DAL
{
    //class Adixdetails2Entity
    //{
    //}

    public partial class Adixdetails2Entity
    {
        public int AD2ID { get; set; }
        public Nullable<int> MachineID { get; set; }
        public Nullable<System.DateTime> StartTime { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public Nullable<decimal> FeedRate { get; set; }
        public Nullable<decimal> SpindleLoad { get; set; }
        public Nullable<decimal> SpindleSpeed { get; set; }
        public int IsDeleted { get; set; }
        public Nullable<System.DateTime> InsertedOn { get; set; }
        public Nullable<decimal> FeedRatePercentage { get; set; }
    }

}
