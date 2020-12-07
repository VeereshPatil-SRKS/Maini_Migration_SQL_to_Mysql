using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDAL.DAL
{
    //class ParameterMasterSensorData
    //{
    //}

    public partial class ParameterMasterSensorData
    {
        public int parameterSensorDataId { get; set; }
        public Nullable<int> machineId { get; set; }
        public Nullable<System.DateTime> sensorDataCapturedTime { get; set; }
        public Nullable<bool> isDeleted { get; set; }
        public Nullable<System.DateTime> createdOn { get; set; }
        public Nullable<System.DateTime> correctedDate { get; set; }
    }



}
