using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDAL.DAL
{
    //class IOTGatewayEntity
    //{
    //}

    public partial class IOTGatewayEntity
    {
        public int GatewayMsgID { get; set; }
        public string SOF { get; set; }
        public string SiteId { get; set; }
        public string UnitId { get; set; }
        public string PacketType { get; set; }
        public string Time { get; set; }
        public string Date { get; set; }
        public string IPAddres { get; set; }
        public string ProductSerialNo { get; set; }
        public string SWversion { get; set; }
        public string NumOfNodeDetected { get; set; }
        public string NumOfNodeActive { get; set; }
        public string NodeId { get; set; }
        public string NodeCommunication { get; set; }
        public string NodePayLoadLength { get; set; }
        public string NodeDataPayLoad { get; set; }
        public string EOF { get; set; }
        public string IOTGateWayMsg { get; set; }
        public string CorrectedDate { get; set; }
        public string TypeOfDevice { get; set; }
        public string DevicePayLoadLength { get; set; }
        public Nullable<int> AlaramInput1_16 { get; set; }
        public Nullable<int> AlaramInput2_17 { get; set; }
        public Nullable<int> AlaramInput3_18 { get; set; }
        public Nullable<int> AlaramInput4_19 { get; set; }
        public Nullable<int> AlaramInput5_20 { get; set; }
        public Nullable<int> AlaramInput6_22 { get; set; }
        public Nullable<int> AlaramInput7_23 { get; set; }
        public Nullable<int> AlaramInput8_24 { get; set; }
        public string Reserved { get; set; }
        public string RelayFeedbak1Status { get; set; }
        public string RelayFeedbak2Status { get; set; }
        public string RelayFeedbak3Status { get; set; }
        public string RelayFeedbak4Status { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
    }




}
