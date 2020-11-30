using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDAL.DAL
{
    using System;
    using System.Collections.Generic;

    public partial class configuration_tblshop
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public configuration_tblshop()
        {
            //    this.configuration_tblmultipleworkorder = new HashSet<configuration_tblmultipleworkorder>();
            //    this.configuration_tbloeedashboardvariables = new HashSet<configuration_tbloeedashboardvariables>();
            //    this.configuration_tbloeedashboardvariablestoday = new HashSet<configuration_tbloeedashboardvariablestoday>();
            //    this.configuration_tblpmchecklist = new HashSet<configuration_tblpmchecklist>();
            //    this.configuration_tblpmcheckpoint = new HashSet<configuration_tblpmcheckpoint>();
            //    this.configuration_tblprimitivemaintainancescheduling = new HashSet<configuration_tblprimitivemaintainancescheduling>();
            //    this.configuration_tblshiftplanner = new HashSet<configuration_tblshiftplanner>();
            //    this.configurationtbloeedashboardfinalvariables = new HashSet<configurationtbloeedashboardfinalvariable>();
            //    this.configurationtblandondispdets = new HashSet<configurationtblandondispdet>();
            //    this.configurationtblandonimagetextscheduleddisplays = new HashSet<configurationtblandonimagetextscheduleddisplay>();
            this.configurationtblmachinedetails = new HashSet<configurationtblmachinedetail>();
            //this.configurationtbl_autoreportsetting = new HashSet<configurationtbl_autoreportsetting>();
            //this.configurationtblemailescalations = new HashSet<configurationtblemailescalation>();
            //this.configurationtblbottelnecks = new HashSet<configurationtblbottelneck>();
            this.configurationtblcells = new HashSet<configurationtblcell>();
        }

        public int ShopID { get; set; }
        public string ShopName { get; set; }
        public string ShopDesc { get; set; }
        public string Shopdisplayname { get; set; }
        public int PlantID { get; set; }
        public int IsDeleted { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<int> NoOfMachines { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<configuration_tblmultipleworkorder> configuration_tblmultipleworkorder { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<configuration_tbloeedashboardvariables> configuration_tbloeedashboardvariables { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<configuration_tbloeedashboardvariablestoday> configuration_tbloeedashboardvariablestoday { get; set; }
        public virtual configuration_tblplant configuration_tblplant { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<configuration_tblpmchecklist> configuration_tblpmchecklist { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<configuration_tblpmcheckpoint> configuration_tblpmcheckpoint { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<configuration_tblprimitivemaintainancescheduling> configuration_tblprimitivemaintainancescheduling { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<configuration_tblshiftplanner> configuration_tblshiftplanner { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<configurationtbloeedashboardfinalvariable> configurationtbloeedashboardfinalvariables { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<configurationtblandondispdet> configurationtblandondispdets { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<configurationtblandonimagetextscheduleddisplay> configurationtblandonimagetextscheduleddisplays { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<configurationtblmachinedetail> configurationtblmachinedetails { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<configurationtbl_autoreportsetting> configurationtbl_autoreportsetting { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<configurationtblemailescalation> configurationtblemailescalations { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<configurationtblbottelneck> configurationtblbottelnecks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<configurationtblcell> configurationtblcells { get; set; }
    }
}
