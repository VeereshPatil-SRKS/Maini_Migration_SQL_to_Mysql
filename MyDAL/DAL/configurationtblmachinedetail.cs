using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDAL.DAL
{
    public partial class configurationtblmachinedetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public configurationtblmachinedetail()
        {
            //this.configuration_tblgenericworkentry = new HashSet<configuration_tblgenericworkentry>();
            //this.configuration_tblmachineaxisdetails = new HashSet<configuration_tblmachineaxisdetails>();
            //this.configuration_tblmode2018 = new HashSet<configuration_tblmode2018>();
            //this.configuration_tblmultipleworkorder = new HashSet<configuration_tblmultipleworkorder>();
            //this.configuration_tblncprogramtransfermain = new HashSet<configuration_tblncprogramtransfermain>();
            //this.configuration_tbloperatordashboard = new HashSet<configuration_tbloperatordashboard>();
            //this.configuration_tbloperatorheader = new HashSet<configuration_tbloperatorheader>();
            //this.configuration_tblpartlearningreport = new HashSet<configuration_tblpartlearningreport>();
            //this.configuration_tblpresenttool = new HashSet<configuration_tblpresenttool>();
            //this.configuration_tblprimitivemaintainancescheduling = new HashSet<configuration_tblprimitivemaintainancescheduling>();
            //this.configuration_tblprogramtransferhistory = new HashSet<configuration_tblprogramtransferhistory>();
            //this.configuration_tblrejectreason = new HashSet<configuration_tblrejectreason>();
            //this.configuration_tblsetupmaint = new HashSet<configuration_tblsetupmaint>();
            //this.configuration_tblshiftdetails_machinewise = new HashSet<configuration_tblshiftdetails_machinewise>();
            //this.configuration_tblshiftplanner = new HashSet<configuration_tblshiftplanner>();
            //this.configuration_tbltoolcounter = new HashSet<configuration_tbltoolcounter>();
            //this.configuration_tbltoollifeoperator = new HashSet<configuration_tbltoollifeoperator>();
            //this.configuration_tblusers = new HashSet<configuration_tblusers>();
            //this.configuration_tblworeport = new HashSet<configuration_tblworeport>();
            //this.configurationpcb_details = new HashSet<configurationpcb_details>();
            //this.configurationpcb_parameters = new HashSet<configurationpcb_parameters>();
            //this.configurationpcbdps_master = new HashSet<configurationpcbdps_master>();
            //this.configurationtbl_autoreportsetting = new HashSet<configurationtbl_autoreportsetting>();
            //this.configurationtbl_deletedprogdet = new HashSet<configurationtbl_deletedprogdet>();
            //this.configurationtbl_prodmanmachine = new HashSet<configurationtbl_prodmanmachine>();
            //this.configurationtbl_prodorderlosses = new HashSet<configurationtbl_prodorderlosses>();
            //this.configurationtbl_savencprogver = new HashSet<configurationtbl_savencprogver>();
            //this.configurationtblatccounters = new HashSet<configurationtblatccounter>();
            //this.configurationtblemailescalations = new HashSet<configurationtblemailescalation>();
            //this.configurationtblmachinesensors = new HashSet<configurationtblmachinesensor>();
            //this.configurationtbloeedetails = new HashSet<configurationtbloeedetail>();
            //this.configurationtblbottelnecks = new HashSet<configurationtblbottelneck>();
            //this.configuration_program_master = new HashSet<configuration_program_master>();
        }

        public int MachineID { get; set; }
        public string InsertedOn { get; set; }
        public int InsertedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<int> IsDeleted { get; set; }
        public Nullable<int> PlantID { get; set; }
        public Nullable<int> ShopID { get; set; }
        public Nullable<int> CellID { get; set; }
        public string MachineName { get; set; }
        public string MachineDescription { get; set; }
        public string MachineDisplayName { get; set; }
        public Nullable<int> CellOrderNo { get; set; }
        public string IPAddress { get; set; }
        public Nullable<int> MachineType { get; set; }
        public string ControllerType { get; set; }
        public string MachineModel { get; set; }
        public string MachineMake { get; set; }
        public string ModelType { get; set; }
        public Nullable<int> IsParameters { get; set; }
        public string ShopNo { get; set; }
        public Nullable<int> IsPCB { get; set; }
        public Nullable<int> IsLevel { get; set; }
        public Nullable<int> IsNormalWC { get; set; }
        public Nullable<int> ManualWCID { get; set; }
        public Nullable<int> NoOfAxis { get; set; }
        public string MacType { get; set; }
        public Nullable<int> CurrentControlAxis { get; set; }
        public string ProgramNum { get; set; }
        public string ProgDBit { get; set; }
        public int MachineModelType { get; set; }
        public string MacConnName { get; set; }
        public string SpindleAxis { get; set; }
        public string TabIPAddress { get; set; }
        public Nullable<int> MachineLockBit { get; set; }
        public Nullable<int> MachineSetupBit { get; set; }
        public Nullable<int> MachineMaintBit { get; set; }
        public Nullable<int> MachineToolLifeBit { get; set; }
        public Nullable<int> MachineUnlockBit { get; set; }
        public Nullable<int> MachineIdleBit { get; set; }
        public Nullable<int> MachineIdleMin { get; set; }
        public int EnableLockLogic { get; set; }
        public int ServerTabFlagSync { get; set; }
        public int ServerTabCheck { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
        public bool EnableToolLife { get; set; }
        public Nullable<int> AssetCode { get; set; }
        public Nullable<int> OperationNumber { get; set; }
        public Nullable<int> IsBottelNeck { get; set; }
        public Nullable<int> IsFirstMachine { get; set; }
        public Nullable<int> IsLastMachine { get; set; }
        public string BottomneckMachine { get; set; }
        public Nullable<decimal> PlannedCycleTimeInSec { get; set; }
        public Nullable<decimal> StdLoadingTime { get; set; }
        public Nullable<decimal> StdUnLoadingTime { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<configuration_tblgenericworkentry> configuration_tblgenericworkentry { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<configuration_tblmachineaxisdetails> configuration_tblmachineaxisdetails { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<configuration_tblmode2018> configuration_tblmode2018 { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<configuration_tblmultipleworkorder> configuration_tblmultipleworkorder { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<configuration_tblncprogramtransfermain> configuration_tblncprogramtransfermain { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<configuration_tbloperatordashboard> configuration_tbloperatordashboard { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<configuration_tbloperatorheader> configuration_tbloperatorheader { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<configuration_tblpartlearningreport> configuration_tblpartlearningreport { get; set; }
        //public virtual configuration_tblplant configuration_tblplant { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<configuration_tblpresenttool> configuration_tblpresenttool { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<configuration_tblprimitivemaintainancescheduling> configuration_tblprimitivemaintainancescheduling { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<configuration_tblprogramtransferhistory> configuration_tblprogramtransferhistory { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<configuration_tblrejectreason> configuration_tblrejectreason { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<configuration_tblsetupmaint> configuration_tblsetupmaint { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<configuration_tblshiftdetails_machinewise> configuration_tblshiftdetails_machinewise { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<configuration_tblshiftplanner> configuration_tblshiftplanner { get; set; }
        //public virtual configuration_tblshop configuration_tblshop { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<configuration_tbltoolcounter> configuration_tbltoolcounter { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<configuration_tbltoollifeoperator> configuration_tbltoollifeoperator { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<configuration_tblusers> configuration_tblusers { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<configuration_tblworeport> configuration_tblworeport { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<configurationpcb_details> configurationpcb_details { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<configurationpcb_parameters> configurationpcb_parameters { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<configurationpcbdps_master> configurationpcbdps_master { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<configurationtbl_autoreportsetting> configurationtbl_autoreportsetting { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<configurationtbl_deletedprogdet> configurationtbl_deletedprogdet { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<configurationtbl_prodmanmachine> configurationtbl_prodmanmachine { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<configurationtbl_prodorderlosses> configurationtbl_prodorderlosses { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<configurationtbl_savencprogver> configurationtbl_savencprogver { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<configurationtblatccounter> configurationtblatccounters { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<configurationtblemailescalation> configurationtblemailescalations { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<configurationtblmachinesensor> configurationtblmachinesensors { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<configurationtbloeedetail> configurationtbloeedetails { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<configurationtblbottelneck> configurationtblbottelnecks { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<configuration_program_master> configuration_program_master { get; set; }
        //public virtual configurationtblcell configurationtblcell { get; set; }
    }
}
