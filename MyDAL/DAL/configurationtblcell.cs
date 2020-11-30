using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDAL.DAL
{
    using System;
    using System.Collections.Generic;

    public partial class configurationtblcell
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public configurationtblcell()
        {
            //this.configuration_tblmultipleworkorder = new HashSet<configuration_tblmultipleworkorder>();
            //this.configuration_tbloeedashboardvariables = new HashSet<configuration_tbloeedashboardvariables>();
            //this.configuration_tbloeedashboardvariablestoday = new HashSet<configuration_tbloeedashboardvariablestoday>();
            //this.configuration_tblpartmodule = new HashSet<configuration_tblpartmodule>();
            //this.configuration_tblpmchecklist = new HashSet<configuration_tblpmchecklist>();
            //this.configuration_tblpmcheckpoint = new HashSet<configuration_tblpmcheckpoint>();
            //this.configuration_tblprimitivemaintainancescheduling = new HashSet<configuration_tblprimitivemaintainancescheduling>();
            //this.configuration_tblrejectreason = new HashSet<configuration_tblrejectreason>();
            //this.configuration_tblshiftplanner = new HashSet<configuration_tblshiftplanner>();
            //this.configuration_tblusers = new HashSet<configuration_tblusers>();
            //this.configurationtbl_autoreportsetting = new HashSet<configurationtbl_autoreportsetting>();
            //this.configurationtblandondispdets = new HashSet<configurationtblandondispdet>();
            //this.configurationtblandonimagetextscheduleddisplays = new HashSet<configurationtblandonimagetextscheduleddisplay>();
            //this.configurationtblbottelnecks = new HashSet<configurationtblbottelneck>();
            //this.configurationtblcellparts = new HashSet<configurationtblcellpart>();
            //this.configurationtbloeedetails = new HashSet<configurationtbloeedetail>();
            this.configurationtblmachinedetails = new HashSet<configurationtblmachinedetail>();
            //this.configurationtblandondisplayrotates = new HashSet<configurationtblandondisplayrotate>();
            //this.configurationtbloeedashboardfinalvariables = new HashSet<configurationtbloeedashboardfinalvariable>();
            //this.configurationtblemailescalations = new HashSet<configurationtblemailescalation>();
        }

        public int CellID { get; set; }
        public string CellName { get; set; }
        public string CellDesc { get; set; }
        public Nullable<int> PlantID { get; set; }
        public int ShopID { get; set; }
        public int IsDeleted { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public string CelldisplayName { get; set; }
        public Nullable<int> NoOfModel { get; set; }
        public int DashboardOrdering { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<configuration_tblmultipleworkorder> configuration_tblmultipleworkorder { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<configuration_tbloeedashboardvariables> configuration_tbloeedashboardvariables { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<configuration_tbloeedashboardvariablestoday> configuration_tbloeedashboardvariablestoday { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<configuration_tblpartmodule> configuration_tblpartmodule { get; set; }
        public virtual configuration_tblplant configuration_tblplant { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<configuration_tblpmchecklist> configuration_tblpmchecklist { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<configuration_tblpmcheckpoint> configuration_tblpmcheckpoint { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<configuration_tblprimitivemaintainancescheduling> configuration_tblprimitivemaintainancescheduling { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<configuration_tblrejectreason> configuration_tblrejectreason { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<configuration_tblshiftplanner> configuration_tblshiftplanner { get; set; }
        public virtual configuration_tblshop configuration_tblshop { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<configuration_tblusers> configuration_tblusers { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<configurationtbl_autoreportsetting> configurationtbl_autoreportsetting { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<configurationtblandondispdet> configurationtblandondispdets { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<configurationtblandonimagetextscheduleddisplay> configurationtblandonimagetextscheduleddisplays { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<configurationtblbottelneck> configurationtblbottelnecks { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<configurationtblcellpart> configurationtblcellparts { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<configurationtbloeedetail> configurationtbloeedetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<configurationtblmachinedetail> configurationtblmachinedetails { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<configurationtblandondisplayrotate> configurationtblandondisplayrotates { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<configurationtbloeedashboardfinalvariable> configurationtbloeedashboardfinalvariables { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<configurationtblemailescalation> configurationtblemailescalations { get; set; }
    }
}
