using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDAL.DAL
{
    //class configuration_tblprimitivemaintainE_
    //{
    //}

    public partial class configuration_tblprimitivemaintainE_
    {
        public int pmid { get; set; }
        public int MachineID { get; set; }
        public string MachineName { get; set; }
        public Nullable<int> Month { get; set; }
        public Nullable<int> Week { get; set; }
        public Nullable<int> IsDeleted { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public string CellName { get; set; }
        public int CellID { get; set; }
        public Nullable<int> PlantID { get; set; }
        public Nullable<int> ShopID { get; set; }
        public string plantName { get; set; }
        public string shopname { get; set; }
        public int MonthID { get; set; }
        public int WeekID { get; set; }

      
    }



}
