﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDAL.DAL
{
    //class tblsmsdetailsE
    //{
    //}
    public partial class tblsmsdetailsE
    {
        public int smsId { get; set; }
        public Nullable<int> machineId { get; set; }
        public string contactNo { get; set; }
        public Nullable<int> ticketId { get; set; }
        public Nullable<System.DateTime> createdOn { get; set; }
        public Nullable<int> createdBy { get; set; }
        public Nullable<System.DateTime> modifiedOn { get; set; }
        public Nullable<int> modifiedBy { get; set; }
        public Nullable<int> isDeleted { get; set; }
        public string responseId { get; set; }
        public string idleResponseId { get; set; }
        public Nullable<int> idleSms { get; set; }
        public string shift { get; set; }
        public string message { get; set; }
        public string correctedDate { get; set; }
        public string cellId { get; set; }
        public string subCellId { get; set; }
        public string categoryId { get; set; }
        public string smsPriority { get; set; }
        public Nullable<int> timeToBeTriggered { get; set; }
        public string employeeName { get; set; }
        public Nullable<int> opNo { get; set; }
    }


}
