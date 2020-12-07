using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDAL.DAL
{
    //class tblrejectiondetailsE
    //{
    //}



    public partial class tblrejectiondetailsE
    {
        public int rejectionId { get; set; }
        public Nullable<int> fgPartId { get; set; }
        public Nullable<int> defectCodeId { get; set; }
        public Nullable<int> defectQty { get; set; }
        public Nullable<int> machineId { get; set; }
        public Nullable<int> operatorId { get; set; }
        public Nullable<int> isDeleted { get; set; }
        public Nullable<System.DateTime> createdOn { get; set; }
        public Nullable<int> createdBy { get; set; }
        public Nullable<System.DateTime> modifiedOn { get; set; }
        public Nullable<int> modifiedBy { get; set; }
        public string correctedDate { get; set; }
        public string shift { get; set; }
        public string qrCodeNo { get; set; }
        public Nullable<int> isDirLineInsp { get; set; }
        public Nullable<int> isDirQualityHead { get; set; }
        public string dmcCodeStatus { get; set; }
        public string ReasonForRejection { get; set; }
    }
}
