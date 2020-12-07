using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDAL.DAL
{
    //class logintrackerdetailsE
    //{
    //}

    public partial class logintrackerdetailsE
    {
        public int loginTrackerDetailsId { get; set; }
        public Nullable<int> machineId { get; set; }
        public Nullable<int> operatorId { get; set; }
        public Nullable<int> currentFGPart { get; set; }
        public string currentTicketRaisedId { get; set; }
        public Nullable<System.DateTime> loginDateTime { get; set; }
        public Nullable<System.DateTime> logoutDateTime { get; set; }
        public bool isLoggedIn { get; set; }
        public Nullable<System.DateTime> insertedOn { get; set; }
        public Nullable<bool> isDeleted { get; set; }
        public string shift { get; set; }
        public string correctedDate { get; set; }
    }


}
