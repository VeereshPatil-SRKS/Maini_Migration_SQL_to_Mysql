using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDAL.DAL
{
    //class tblfgpartnodetE
    //{
    //}

    public partial class tblfgpartnodetE
    {
       
        public int fgPartId { get; set; }
        public Nullable<int> partId { get; set; }
        public string partCountMethod { get; set; }
        public Nullable<int> operationNo { get; set; }
        public string workOrderNo { get; set; }
        public string noOfPartsPerCycle { get; set; }
        public Nullable<int> isClosed { get; set; }
        public Nullable<int> isDeleted { get; set; }
        public Nullable<System.DateTime> startDate { get; set; }
        public Nullable<System.DateTime> closedDate { get; set; }
        public Nullable<int> operatorId { get; set; }
        public Nullable<int> machineId { get; set; }
        public string correctedDate { get; set; }
        public string shift { get; set; }
        public Nullable<System.DateTime> createdOn { get; set; }
        public Nullable<int> createdBy { get; set; }
        public Nullable<System.DateTime> modifiedOn { get; set; }
        public string modifiedBy { get; set; }
        public Nullable<int> planLinkageId { get; set; }
        public Nullable<int> actaulValue { get; set; }
        public Nullable<int> targetQty { get; set; }
        public Nullable<double> availibility { get; set; }
        public Nullable<double> performance { get; set; }
        public Nullable<double> quality { get; set; }
        public Nullable<double> oee { get; set; }
        public string fgPartNo { get; set; }
        public Nullable<decimal> idealCycleTime { get; set; }
        public string unit { get; set; }
        public Nullable<int> scheduledQty { get; set; }
        public Nullable<System.DateTime> plannedStartTime { get; set; }
        public Nullable<System.DateTime> plannedEndTime { get; set; }
        public string routingId { get; set; }
        public string partName { get; set; }
        public Nullable<int> workOrderCompletedQty { get; set; }

       
    }


}
