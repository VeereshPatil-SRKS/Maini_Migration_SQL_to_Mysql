using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySQLDAL;
using MyDAL;
using MyDAL.Model;
using System.IO;
using MyDAL.DAO;
using SQLDAL;
using MyDAL.DAL;

//using System.Data.MySqlClient;

namespace migration
{
    public partial class Form1 : Form
    {
        public int MysqlCount = 0;
        public int sqlCount = 0;
        public Form1()
        {
            
            InitializeComponent();
            try

            {
                SQL_to_Mysql().Wait();  
            }
            catch (Exception e)
            {

            }
        }


        // IOTGATEWAY

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// 
        //public async Task<int> SQL_to_Mysql()
        //{
        //    IntoFile("SQL_to_Mysql");
        //    int resultsu = 0;


        //    #region   My sql Connection
        //    //mysql data
        //    MyDAL.ConnectionFactory con = new MyDAL.ConnectionFactory();
        //    MyDAL.IConnectionFactory _iconne;

        //    SRKSDAO srksMysql = new SRKSDAO();
        //    _iconne = new MyDAL.ConnectionFactory();
        //    srksMysql = new SRKSDAO(_iconne);



        //    //IOTGateWay
        //    var MysqlData = srksMysql.getIOTGate();
        //    int countList = MysqlData.Count();





        //    #endregion



        //    #region M S SQL connection

        //    //sql data

        //    SQLDAL.ConnectionFactory conSql = new SQLDAL.ConnectionFactory();
        //    SQLDAL.IConnectionFactory _iconneSQL;

        //    SQLDAO plantDAO = new SQLDAO();

        //    _iconneSQL = new SQLDAL.ConnectionFactory();
        //    plantDAO = new SQLDAO(_iconneSQL);


        //    var plantSql = plantDAO.GetIotgate();  //Get SQL
        //    sqlCount = plantSql.Count;

        //    #endregion

        //    IntoFile("Sql list count" + plantSql.Count);

        //    var ddlids = MysqlData.Select(m => m.GatewayMsgID).ToList();  //my sql tbl IDs 
        //    IntoFile("sql IDs Count" + ddlids.Count);


        //    var det = plantSql.Where(m => !ddlids.Contains(m.GatewayMsgID)).ToList();
        //    var res7 = det.ToList();
        //    IntoFile("Start_ddl Except SQL data:" + res7.Count);
        //    if (res7.Count > 0)
        //    {

        //        List<IOTGatewayEntity> mysqlPlant = new List<IOTGatewayEntity>();


        //        foreach (var row in res7)
        //        {
        //            IOTGatewayEntity dlist = new IOTGatewayEntity();
        //            dlist.GatewayMsgID = row.GatewayMsgID;
        //            dlist.SOF = row.SOF;
        //            dlist.SiteId = row.SiteId;
        //            dlist.UnitId = row.UnitId;
        //            dlist.PacketType = row.PacketType;

        //            dlist.Time = row.Time;
        //            dlist.Date = row.Date;
        //            dlist.IPAddres = row.IPAddres;
        //            dlist.ProductSerialNo = row.ProductSerialNo;
        //            dlist.SWversion = row.SWversion;

        //            dlist.NumOfNodeDetected = row.NumOfNodeDetected;
        //            dlist.NumOfNodeActive = row.NumOfNodeActive;
        //            dlist.NodeId = row.NodeId;
        //            dlist.NodeCommunication = row.NodeCommunication;
        //            dlist.NodePayLoadLength = row.NodePayLoadLength;

        //            dlist.NodeDataPayLoad = row.NodeDataPayLoad;
        //            dlist.EOF = row.EOF;
        //            dlist.IOTGateWayMsg = row.IOTGateWayMsg;
        //            dlist.CorrectedDate = row.CorrectedDate;
        //            dlist.TypeOfDevice = row.TypeOfDevice;

        //            dlist.DevicePayLoadLength = row.DevicePayLoadLength;
        //            dlist.AlaramInput1_16 = row.AlaramInput1_16;
        //            dlist.AlaramInput2_17 = row.AlaramInput2_17;
        //            dlist.CorrectedDate = row.CorrectedDate;
        //            dlist.TypeOfDevice = row.TypeOfDevice;


        //            dlist.DevicePayLoadLength = row.DevicePayLoadLength;
        //            dlist.AlaramInput1_16 = row.AlaramInput1_16;
        //            dlist.AlaramInput2_17 = row.AlaramInput2_17;
        //            dlist.AlaramInput3_18 = row.AlaramInput3_18;
        //            dlist.AlaramInput4_19 = row.AlaramInput4_19;
        //            dlist.AlaramInput5_20 = row.AlaramInput5_20;
        //            dlist.AlaramInput6_22 = row.AlaramInput6_22;
        //            dlist.AlaramInput7_23 = row.AlaramInput7_23;
        //            dlist.AlaramInput8_24 = row.AlaramInput8_24;
        //            dlist.Reserved = row.Reserved;

        //            dlist.RelayFeedbak1Status = row.RelayFeedbak1Status;
        //            dlist.RelayFeedbak2Status = row.RelayFeedbak2Status;
        //            dlist.RelayFeedbak3Status = row.RelayFeedbak3Status;
        //            dlist.RelayFeedbak4Status = row.RelayFeedbak4Status;


        //            dlist.CreatedOn = row.CreatedOn;

        //            dlist.Time = row.Time;

        //            mysqlPlant.Add(dlist);

        //        }


        //        // resultsu = await srksMysql.insert_ddlMysqlPlantMysql(mysqlPlant);


        //        resultsu = await srksMysql.insert_IOTgate(mysqlPlant);


        //        //  resultsu = await plantDAO.insert_ddlMysqlPlantSQl(res7); 

        //        IntoFile("inserted Successfully");


        //    }
        //    return resultsu;
        //}

        ///

        // ParameterMaster Sensor data
        ///

        public async Task<int> SQL_to_Mysql()
        {
            IntoFile("SQL_to_Mysql");
            int resultsu = 0;


            #region   My sql Connection
            //mysql data
            MyDAL.ConnectionFactory con = new MyDAL.ConnectionFactory();
            MyDAL.IConnectionFactory _iconne;

            SRKSDAO srksMysql = new SRKSDAO();
            _iconne = new MyDAL.ConnectionFactory();
            srksMysql = new SRKSDAO(_iconne);



            //Parameter MasterSensor Data
            var MysqlData = srksMysql.getParameterMasterSensorData();
            int countList = MysqlData.Count();


            #endregion


            #region M S SQL connection

            //sql data

            SQLDAL.ConnectionFactory conSql = new SQLDAL.ConnectionFactory();
            SQLDAL.IConnectionFactory _iconneSQL;

            SQLDAO plantDAO = new SQLDAO();

            _iconneSQL = new SQLDAL.ConnectionFactory();
            plantDAO = new SQLDAO(_iconneSQL);

            var plantSql = plantDAO.GetsqlParameterSensorData();
            sqlCount = plantSql.Count;

            #endregion

            IntoFile("Sql list count" + plantSql.Count);

            var ddlids = MysqlData.Select(m => m.parameterSensorDataId).ToList();  //my sql tbl IDs 
            IntoFile("sql IDs Count" + ddlids.Count);


            var det = plantSql.Where(m => !ddlids.Contains(m.parameterSensorDataId)).ToList();
            var res7 = det.ToList();
            IntoFile("Start_ddl Except SQL data:" + res7.Count);
            if (res7.Count > 0)
            {


                List<ParameterMasterSensorData> mysqlPlant = new List<ParameterMasterSensorData>();


                foreach (var row in res7)
                {



                    ParameterMasterSensorData dlist = new ParameterMasterSensorData();
                    dlist.parameterSensorDataId = row.parameterSensorDataId;
                    dlist.machineId = row.machineId;
                    dlist.sensorDataCapturedTime = row.sensorDataCapturedTime;
                    dlist.isDeleted = row.isDeleted;
                    dlist.createdOn = row.createdOn;

                    dlist.correctedDate = row.correctedDate;


                    mysqlPlant.Add(dlist);

                }



                resultsu = await srksMysql.insert_paraSensorData(mysqlPlant);



                //  resultsu = await plantDAO.insert_ddlMysqlPlantSQl(res7); 

                IntoFile("inserted Successfully");


            }
            return resultsu;
        }

        ///



        ///
        //para tool
        ///

        //public async Task<int> SQL_to_Mysql()
        //{
        //    IntoFile("SQL_to_Mysql");
        //    int resultsu = 0;


        //    #region   My sql Connection
        //    //mysql data
        //    MyDAL.ConnectionFactory con = new MyDAL.ConnectionFactory();
        //    MyDAL.IConnectionFactory _iconne;

        //    SRKSDAO srksMysql = new SRKSDAO();
        //    _iconne = new MyDAL.ConnectionFactory();
        //    srksMysql = new SRKSDAO(_iconne);

        //     var MysqlData = srksMysql.getParameterTool();
        //     int countList = MysqlData.Count();

        //   // var MysqlData = srksMysql.getParameterMaster();
        //   // int countList = MysqlData.Count();



        //    #endregion


        //    #region M S SQL connection

        //    //sql data

        //    SQLDAL.ConnectionFactory conSql = new SQLDAL.ConnectionFactory();
        //    SQLDAL.IConnectionFactory _iconneSQL;

        //    SQLDAO plantDAO = new SQLDAO();

        //    _iconneSQL = new SQLDAL.ConnectionFactory();
        //    plantDAO = new SQLDAO(_iconneSQL);

        //    //var plantSql = plantDAO.GetPlantDetails();  //Get SQL
        //    // sqlCount = plantSql.Count;

        //    // var plantSql = plantDAO.GetsqlParameterSensorData();
        //    // sqlCount = plantSql.Count;


        //     var plantSql = plantDAO.GetsqlParameterTool();
        //    sqlCount = plantSql.Count;

        //   // var plantSql = plantDAO.GetsqlParameterMaster();
        //   // sqlCount = plantSql.Count;

        //    #endregion

        //    IntoFile("Sql list count" + plantSql.Count);

        //    var ddlids = MysqlData.Select(m => m.parameterToolDataId).ToList();  //my sql tbl IDs 
        //    IntoFile("sql IDs Count" + ddlids.Count);


        //    var det = plantSql.Where(m => !ddlids.Contains(m.parameterToolDataId)).ToList();
        //    var res7 = det.ToList();
        //    IntoFile("Start_ddl Except SQL data:" + res7.Count);
        //    if (res7.Count > 0)
        //    {
        //        //  resultsu = await srksMysql.insertPlnatinMYsql(res7);


        //        // resultsu = await srksMysql.insert_ddlMysqlPlant(res7);


        //        List<paraToolData> mysqlPlant = new List<paraToolData>();


        //        foreach (var row in res7)
        //        {



        //            paraToolData dlist = new paraToolData();

        //            dlist.parameterToolDataId = row.parameterToolDataId;
        //            dlist.machineId = row.machineId;
        //            dlist.parameterToolDataCapturedDate = row.parameterToolDataCapturedDate;
        //            dlist.toolGroupName = row.toolGroupName;
        //            dlist.toolNumber = row.toolNumber;

        //            dlist.capacity = row.capacity;
        //            dlist.partsproduced = row.partsproduced;
        //            dlist.createdOn = row.createdOn;
        //            dlist.isDeleted = row.isDeleted;
        //            dlist.correctedDate = row.correctedDate;

        //            dlist.correctedDate = row.correctedDate;


        //            mysqlPlant.Add(dlist);

        //        }


        //        // resultsu = await srksMysql.insert_ddlMysqlPlantMysql(mysqlPlant);


        //        //resultsu = await srksMysql.insert_IOTgate(mysqlPlant);

        //        // resultsu = await srksMysql.insert_paraSensorData(mysqlPlant);

        //        resultsu = await srksMysql.insert_paraTooldata(mysqlPlant);

        //        //  resultsu = await srksMysql.insert_paraMaster(mysqlPlant);
        //        //  resultsu = await plantDAO.insert_ddlMysqlPlantSQl(res7); 

        //        IntoFile("inserted Successfully");


        //    }
        //    return resultsu;
        //}




        ///
        //para master
        ///
        //public async Task<int> SQL_to_Mysql()
        //{
        //    IntoFile("SQL_to_Mysql");
        //    int resultsu = 0;


        //    #region   My sql Connection
        //    //mysql data
        //    MyDAL.ConnectionFactory con = new MyDAL.ConnectionFactory();
        //    MyDAL.IConnectionFactory _iconne;

        //    SRKSDAO srksMysql = new SRKSDAO();
        //    _iconne = new MyDAL.ConnectionFactory();
        //    srksMysql = new SRKSDAO(_iconne);




        //    var MysqlData = srksMysql.getParameterMaster();
        //     int countList = MysqlData.Count();



        //    #endregion


        //    #region M S SQL connection

        //    //sql data

        //    SQLDAL.ConnectionFactory conSql = new SQLDAL.ConnectionFactory();
        //    SQLDAL.IConnectionFactory _iconneSQL;

        //    SQLDAO plantDAO = new SQLDAO();

        //    _iconneSQL = new SQLDAL.ConnectionFactory();
        //    plantDAO = new SQLDAO(_iconneSQL);



        //   // var plantSql = plantDAO.GetsqlParameterTool();
        //   // sqlCount = plantSql.Count;

        //     var plantSql = plantDAO.GetsqlParameterMaster();
        //     sqlCount = plantSql.Count;

        //    #endregion

        //    IntoFile("Sql list count" + plantSql.Count);

        //    var ddlids = MysqlData.Select(m => m.ParameterID).ToList();  //my sql tbl IDs 
        //    IntoFile("sql IDs Count" + ddlids.Count);


        //    var det = plantSql.Where(m => !ddlids.Contains(m.ParameterID)).ToList();
        //    var res7 = det.ToList();
        //    IntoFile("Start_ddl Except SQL data:" + res7.Count);
        //    if (res7.Count > 0)
        //    {

        //        List<parameterMasterEntity> mysqlPlant = new List<parameterMasterEntity>();


        //        foreach (var row in res7)
        //        {


        //            parameterMasterEntity dlist = new parameterMasterEntity();

        //            dlist.ParameterID = row.ParameterID;
        //            dlist.SetupTime = row.SetupTime;
        //            dlist.OperatingTime = row.OperatingTime;
        //            dlist.PowerOnTime = row.PowerOnTime;
        //            dlist.PartsCount = row.PartsCount;

        //            dlist.InsertedOn = row.InsertedOn;
        //            dlist.MachineID = row.MachineID;
        //            dlist.Shift = row.Shift;
        //            dlist.CorrectedDate = row.CorrectedDate;
        //            dlist.AutoCutTime = row.AutoCutTime;

        //            dlist.Total_CutTime = row.Total_CutTime;
        //            dlist.PartsTotal = row.PartsTotal;
        //            dlist.CuttingTime = row.CuttingTime;
        //            dlist.AutoMode = row.AutoMode;



        //            mysqlPlant.Add(dlist);

        //        }



        //         resultsu = await srksMysql.insert_paraMaster(mysqlPlant);


        //        IntoFile("inserted Successfully");


        //    }
        //    return resultsu;
        //}






        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// 





        //public async Task<int> SQL_to_Mysql()
        //{
        //    IntoFile("SQL_to_Mysql");
        //    int resultsu = 0;


        //    #region   My sql Connection
        //    //mysql data
        //    MyDAL.ConnectionFactory con = new MyDAL.ConnectionFactory();
        //    MyDAL.IConnectionFactory _iconne;

        //    SRKSDAO srksMysql = new SRKSDAO();
        //    _iconne = new MyDAL.ConnectionFactory();
        //    srksMysql = new SRKSDAO(_iconne);



        //    var MysqlData = srksMysql.getpcbdaqin_tbl();
        //    int countList = MysqlData.Count();


        //    #endregion


        //    #region M S SQL connection

        //    //sql data

        //    SQLDAL.ConnectionFactory conSql = new SQLDAL.ConnectionFactory();
        //    SQLDAL.IConnectionFactory _iconneSQL;

        //    SQLDAO plantDAO = new SQLDAO();

        //    _iconneSQL = new SQLDAL.ConnectionFactory();
        //    plantDAO = new SQLDAO(_iconneSQL);


        //    var plantSql = plantDAO.Getsqlpcbdaqin_tbl();
        //    sqlCount = plantSql.Count;



        //    #endregion

        //    IntoFile("Sql list count" + plantSql.Count);

        //    var ddlids = MysqlData.Select(m => m.DAQINID).ToList();  //my sql tbl IDs 

        //    IntoFile("sql IDs Count" + ddlids.Count);


        //    var det = plantSql.Where(m => !ddlids.Contains(m.DAQINID)).ToList();
        //    var res7 = det.ToList();

        //    IntoFile("Start_ddl Except SQL data:" + res7.Count);

        //    if (res7.Count > 0)
        //    {

        //        List<pcbdaqinTblEntiyt> mysqlPlant = new List<pcbdaqinTblEntiyt>();


        //        foreach (var row in res7)
        //        {

        //            pcbdaqinTblEntiyt dlist = new pcbdaqinTblEntiyt();

        //            dlist.DAQINID = row.DAQINID;
        //            dlist.PCBIPAddress = row.PCBIPAddress;
        //            dlist.ParamPIN = row.ParamPIN;
        //            dlist.ParamValue = row.ParamValue;
        //            dlist.CreatedOn = row.CreatedOn;

        //            dlist.CreatedBy = row.CreatedBy;

        //            mysqlPlant.Add(dlist);


        //        }



        //        resultsu = await srksMysql.insert_ppcbdaqin(mysqlPlant);

        //        IntoFile("inserted Successfully");


        //    }
        //    return resultsu;
        //}

        ///
        //pcbdaqin_tbl
        ///

        //public async Task<int> SQL_to_Mysql()
        //{
        //    IntoFile("SQL_to_Mysql");
        //    int resultsu = 0;


        //    #region   My sql Connection
        //    //mysql data
        //    MyDAL.ConnectionFactory con = new MyDAL.ConnectionFactory();
        //    MyDAL.IConnectionFactory _iconne;

        //    SRKSDAO srksMysql = new SRKSDAO();
        //    _iconne = new MyDAL.ConnectionFactory();
        //    srksMysql = new SRKSDAO(_iconne);



        //    var MysqlData = srksMysql.getpcbdaqin_tbl();
        //    int countList = MysqlData.Count();


        //    #endregion


        //    #region M S SQL connection

        //    //sql data

        //    SQLDAL.ConnectionFactory conSql = new SQLDAL.ConnectionFactory();
        //    SQLDAL.IConnectionFactory _iconneSQL;

        //    SQLDAO plantDAO = new SQLDAO();

        //    _iconneSQL = new SQLDAL.ConnectionFactory();
        //    plantDAO = new SQLDAO(_iconneSQL);


        //    var plantSql = plantDAO.Getsqlpcbdaqin_tbl();
        //    sqlCount = plantSql.Count;



        //    #endregion

        //    IntoFile("Sql list count" + plantSql.Count);

        //    var ddlids = MysqlData.Select(m => m.DAQINID).ToList();  //my sql tbl IDs 

        //    IntoFile("sql IDs Count" + ddlids.Count);


        //    var det = plantSql.Where(m => !ddlids.Contains(m.DAQINID)).ToList();
        //    var res7 = det.ToList();

        //    IntoFile("Start_ddl Except SQL data:" + res7.Count);

        //    if (res7.Count > 0)
        //    {

        //        List<pcbdaqinTblEntiyt> mysqlPlant = new List<pcbdaqinTblEntiyt>();


        //        foreach (var row in res7)
        //        {

        //            pcbdaqinTblEntiyt dlist = new pcbdaqinTblEntiyt();

        //            dlist.DAQINID = row.DAQINID;
        //            dlist.PCBIPAddress = row.PCBIPAddress;
        //            dlist.ParamPIN = row.ParamPIN;
        //            dlist.ParamValue = row.ParamValue;
        //            dlist.CreatedOn = row.CreatedOn;

        //            dlist.CreatedBy = row.CreatedBy;

        //            mysqlPlant.Add(dlist);


        //        }



        //        resultsu = await srksMysql.insert_ppcbdaqin(mysqlPlant);

        //        IntoFile("inserted Successfully");


        //    }
        //    return resultsu;
        //}


        ///
        //axis1 tbl
        ///
        //public async Task<int> SQL_to_Mysql()
        //{
        //    IntoFile("SQL_to_Mysql");
        //    int resultsu = 0;


        //    #region   My sql Connection
        //    //mysql data
        //    MyDAL.ConnectionFactory con = new MyDAL.ConnectionFactory();
        //    MyDAL.IConnectionFactory _iconne;

        //    SRKSDAO srksMysql = new SRKSDAO();
        //    _iconne = new MyDAL.ConnectionFactory();
        //    srksMysql = new SRKSDAO(_iconne);



        //    var MysqlData = srksMysql.getAxisdetails1();
        //    int countList = MysqlData.Count();


        //    #endregion


        //    #region M S SQL connection

        //    //sql data

        //    SQLDAL.ConnectionFactory conSql = new SQLDAL.ConnectionFactory();
        //    SQLDAL.IConnectionFactory _iconneSQL;

        //    SQLDAO plantDAO = new SQLDAO();

        //    _iconneSQL = new SQLDAL.ConnectionFactory();
        //    plantDAO = new SQLDAO(_iconneSQL);


        //    var plantSql = plantDAO.GetsqlAxisdetails1();
        //    sqlCount = plantSql.Count;



        //    #endregion

        //    IntoFile("Sql list count" + plantSql.Count);

        //    var ddlids = MysqlData.Select(m => m.ADID).ToList();  //my sql tbl IDs 

        //    IntoFile("sql IDs Count" + ddlids.Count);


        //    var det = plantSql.Where(m => !ddlids.Contains(m.ADID)).ToList();
        //    var res7 = det.ToList();

        //    IntoFile("Start_ddl Except SQL data:" + res7.Count);

        //    if (res7.Count > 0)
        //    {

        //        List<Axisdetails1Entity> mysqlPlant = new List<Axisdetails1Entity>();


        //        foreach (var row in res7)
        //        {
        //           // ADID,MachineID,Axis,AbsPos,RelPos,MacPos,DistPos,StartTime,EndTime,IsDeleted,InsertedOn
        //                                Axisdetails1Entity dlist = new Axisdetails1Entity();

        //            dlist.ADID = row.ADID;
        //            dlist.MachineID = row.MachineID;
        //            dlist.Axis = row.Axis;
        //            dlist.AbsPos = row.AbsPos;
        //            dlist.RelPos = row.RelPos;

        //            dlist.MacPos = row.MacPos;


        //            dlist.DistPos = row.DistPos;
        //            dlist.StartTime = row.StartTime;
        //            dlist.EndTime = row.EndTime;
        //            dlist.IsDeleted = row.IsDeleted;
        //            dlist.InsertedOn = row.InsertedOn;


        //            mysqlPlant.Add(dlist);


        //        }



        //        resultsu = await srksMysql.insert_axisdetails1(mysqlPlant);

        //        IntoFile("inserted Successfully");


        //    }
        //    return resultsu;
        //}



        /// <summary>
        /// axis2 tbl
        /// </summary>
        /// <param name="axis2 tbl"></param>
        /// 
        //public async Task<int> SQL_to_Mysql()
        //{
        //    IntoFile("SQL_to_Mysql");
        //    int resultsu = 0;


        //    #region   My sql Connection
        //    //mysql data
        //    MyDAL.ConnectionFactory con = new MyDAL.ConnectionFactory();
        //    MyDAL.IConnectionFactory _iconne;

        //    SRKSDAO srksMysql = new SRKSDAO();
        //    _iconne = new MyDAL.ConnectionFactory();
        //    srksMysql = new SRKSDAO(_iconne);



        //    var MysqlData = srksMysql.getAxisdetails2();
        //    int countList = MysqlData.Count();


        //    #endregion


        //    #region M S SQL connection

        //    //sql data

        //    SQLDAL.ConnectionFactory conSql = new SQLDAL.ConnectionFactory();
        //    SQLDAL.IConnectionFactory _iconneSQL;

        //    SQLDAO plantDAO = new SQLDAO();

        //    _iconneSQL = new SQLDAL.ConnectionFactory();
        //    plantDAO = new SQLDAO(_iconneSQL);


        //    var plantSql = plantDAO.GetsqlAxisdetails2();
        //    sqlCount = plantSql.Count;



        //    #endregion

        //    IntoFile("Sql list count" + plantSql.Count);

        //    var ddlids = MysqlData.Select(m => m.AD2ID).ToList();  //my sql tbl IDs 

        //    IntoFile("sql IDs Count" + ddlids.Count);


        //    var det = plantSql.Where(m => !ddlids.Contains(m.AD2ID)).ToList();
        //    var res7 = det.ToList();

        //    IntoFile("Start_ddl Except SQL data:" + res7.Count);

        //    if (res7.Count > 0)
        //    {

        //        List<Adixdetails2Entity> mysqlPlant = new List<Adixdetails2Entity>();


        //        foreach (var row in res7)
        //        {
        //            // ADID,MachineID,Axis,AbsPos,RelPos,MacPos,DistPos,StartTime,EndTime,IsDeleted,InsertedOn
        //            Adixdetails2Entity dlist = new Adixdetails2Entity();


        //           // AD2ID,MachineID,StartTime,EndTime,FeedRate,SpindleLoad,SpindleSpeed,IsDeleted,InsertedOn,FeedRatePercentage


        //            dlist.AD2ID = row.AD2ID;
        //            dlist.MachineID = row.MachineID;
        //            dlist.StartTime = row.StartTime;
        //            dlist.EndTime = row.EndTime;
        //            dlist.FeedRate = row.FeedRate;

        //            dlist.SpindleLoad = row.SpindleLoad;


        //            dlist.SpindleSpeed = row.SpindleSpeed;
        //            dlist.IsDeleted = row.IsDeleted;
        //            dlist.InsertedOn = row.InsertedOn;
        //            dlist.FeedRatePercentage = row.FeedRatePercentage;



        //            mysqlPlant.Add(dlist);


        //        }



        //        resultsu = await srksMysql.insert_axisdetails2(mysqlPlant);

        //        IntoFile("inserted Successfully");


        //    }
        //    return resultsu;
        //}



        /// <summary>
        ///
        /// </summary>
        /// <param name="parts and cutting"></param>
        /// 
        //public async Task<int> SQL_to_Mysql()
        //{
        //    IntoFile("SQL_to_Mysql");
        //    int resultsu = 0;


        //    #region   My sql Connection
        //    //mysql data
        //    MyDAL.ConnectionFactory con = new MyDAL.ConnectionFactory();
        //    MyDAL.IConnectionFactory _iconne;

        //    SRKSDAO srksMysql = new SRKSDAO();
        //    _iconne = new MyDAL.ConnectionFactory();
        //    srksMysql = new SRKSDAO(_iconne);



        //    var MysqlData = srksMysql.gettblpartscountandcutting();
        //    int countList = MysqlData.Count();


        //    #endregion


        //    #region M S SQL connection

        //    //sql data

        //    SQLDAL.ConnectionFactory conSql = new SQLDAL.ConnectionFactory();
        //    SQLDAL.IConnectionFactory _iconneSQL;

        //    SQLDAO plantDAO = new SQLDAO();

        //    _iconneSQL = new SQLDAL.ConnectionFactory();
        //    plantDAO = new SQLDAO(_iconneSQL);


        //    var plantSql = plantDAO.Getsqltblpartscountandcutting();
        //    sqlCount = plantSql.Count;



        //    #endregion

        //    IntoFile("Sql list count" + plantSql.Count);

        //    var ddlids = MysqlData.Select(m => m.pcid).ToList();  //my sql tbl IDs 

        //    IntoFile("sql IDs Count" + ddlids.Count);


        //    var det = plantSql.Where(m => !ddlids.Contains(m.pcid)).ToList();
        //    var res7 = det.ToList();

        //    IntoFile("Start_ddl Except SQL data:" + res7.Count);

        //    if (res7.Count > 0)
        //    {

        //        List<partsAndCuuting> mysqlPlant = new List<partsAndCuuting>();


        //        foreach (var row in res7)
        //        {

        //            partsAndCuuting dlist = new partsAndCuuting();


        //            dlist.pcid = row.pcid;
        //            dlist.MachineID = row.MachineID;
        //            dlist.PartCount = row.PartCount;
        //            dlist.CuttingTime = row.CuttingTime;
        //            dlist.TargetQuantity = row.TargetQuantity;

        //            dlist.StartTime = row.StartTime;


        //            dlist.EndTime = row.EndTime;
        //            dlist.Isdeleted = row.Isdeleted;
        //            dlist.CreatedOn = row.CreatedOn;
        //            dlist.CorrectedDate = row.CorrectedDate;

        //            dlist.CreatedBy = row.CreatedBy;
        //            dlist.ModifiedOn = row.ModifiedOn;
        //            dlist.ModifiedBy = row.ModifiedBy;
        //            dlist.PartsPerCyscleEnteredTime = row.PartsPerCyscleEnteredTime;
        //            dlist.WoPartCount = row.WoPartCount;

        //            dlist.ShiftName = row.ShiftName;


        //            dlist.CuttingTimeInSec = row.CuttingTimeInSec;
        //            dlist.woTargetQty = row.woTargetQty;
        //            dlist.rejectionQty = row.rejectionQty;
        //            dlist.reworkQty = row.reworkQty;


        //            dlist.actualQty = row.actualQty;
        //            dlist.dryRunQty = row.dryRunQty;
        //            dlist.OkQty = row.OkQty;



        //            mysqlPlant.Add(dlist);


        //        }



        //        resultsu = await srksMysql.insert_tblpartscountandcutting(mysqlPlant);

        //        IntoFile("inserted Successfully");


        //    }
        //    return resultsu;
        //}


        /// <summary>
        ///
        /// </summary>
        /// <param name="livemode"></param>
        /// 

        //        public async Task<int> SQL_to_Mysql()
        //        {
        //            IntoFile("SQL_to_Mysql");
        //            int resultsu = 0;


        //            #region   My sql Connection
        //            //mysql data
        //            MyDAL.ConnectionFactory con = new MyDAL.ConnectionFactory();
        //            MyDAL.IConnectionFactory _iconne;

        //            SRKSDAO srksMysql = new SRKSDAO();
        //            _iconne = new MyDAL.ConnectionFactory();
        //            srksMysql = new SRKSDAO(_iconne);



        //            var MysqlData = srksMysql.gettblLiveMode();
        //            int countList = MysqlData.Count();


        //            #endregion


        //            #region M S SQL connection

        //            //sql data

        //            SQLDAL.ConnectionFactory conSql = new SQLDAL.ConnectionFactory();
        //            SQLDAL.IConnectionFactory _iconneSQL;

        //            SQLDAO plantDAO = new SQLDAO();

        //            _iconneSQL = new SQLDAL.ConnectionFactory();
        //            plantDAO = new SQLDAO(_iconneSQL);


        //            var plantSql = plantDAO.GetsqlliveMode();
        //            sqlCount = plantSql.Count;



        //            #endregion

        //            IntoFile("Sql list count" + plantSql.Count);

        //            var ddlids = MysqlData.Select(m => m.ModeID).ToList();  //my sql tbl IDs 

        //            IntoFile("sql IDs Count" + ddlids.Count);


        //            var det = plantSql.Where(m => !ddlids.Contains(m.ModeID)).ToList();
        //            var res7 = det.ToList();

        //            IntoFile("Start_ddl Except SQL data:" + res7.Count);

        //            if (res7.Count > 0)
        //            {

        //                List<LiveModeentity> mysqlPlant = new List<LiveModeentity>();


        //                foreach (var row in res7)
        //                {

        //                    LiveModeentity dlist = new LiveModeentity();


        //                    dlist.ModeID = row.ModeID;
        //                    dlist.MachineID = row.MachineID;
        //                    dlist.MacMode = row.MacMode;
        //                    dlist.InsertedOn = row.InsertedOn;
        //                    dlist.InsertedBy = row.InsertedBy;

        //                    dlist.ModifiedOn = row.ModifiedOn;


        //                    dlist.ModifiedBy = row.ModifiedBy;
        //                    dlist.CorrectedDate = row.CorrectedDate;
        //                    dlist.IsDeleted = row.IsDeleted;
        //                    dlist.StartTime = row.StartTime;

        //                    dlist.EndTime = row.EndTime;
        //                    dlist.ColorCode = row.ColorCode;
        //                    dlist.IsCompleted = row.IsCompleted;
        //                    dlist.DurationInSec = row.DurationInSec;
        //                    dlist.LossCodeID = row.LossCodeID;

        //                    dlist.BreakdownID = row.BreakdownID;


        //                    dlist.ModeType = row.ModeType;
        //                    dlist.ModeTypeEnd = row.ModeTypeEnd;
        //                    dlist.StartIdle = row.StartIdle;
        //                    dlist.LossCodeEnteredTime = row.LossCodeEnteredTime;


        //                    dlist.LossCodeEnteredBy = row.LossCodeEnteredBy;
        //                    dlist.IsInserted = row.IsInserted;
        //                    dlist.TotalPartsCount = row.TotalPartsCount;


        //                    dlist.CuttingDuration = row.CuttingDuration;
        //                    dlist.CuttingDuration = row.CuttingDuration;
        //                    dlist.IsShiftEnd = row.IsShiftEnd;
        //                    dlist.breakDownCodeID = row.breakDownCodeID;


        //                    dlist.shift = row.shift;
        //;


        //                    mysqlPlant.Add(dlist);


        //                }



        //                resultsu = await srksMysql.insert_livemode(mysqlPlant);

        //                IntoFile("inserted Successfully");


        //            }
        //            return resultsu;
        //        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="tblFgAndCellAllocation"></param>
        /// 


        //public async Task<int> SQL_to_Mysql()
        //{
        //    IntoFile("SQL_to_Mysql");
        //    int resultsu = 0;


        //    #region   My sql Connection
        //    //mysql data
        //    MyDAL.ConnectionFactory con = new MyDAL.ConnectionFactory();
        //    MyDAL.IConnectionFactory _iconne;

        //    SRKSDAO srksMysql = new SRKSDAO();
        //    _iconne = new MyDAL.ConnectionFactory();
        //    srksMysql = new SRKSDAO(_iconne);



        //    var MysqlData = srksMysql.gettfgpartCellAllow();
        //    int countList = MysqlData.Count();


        //    #endregion


        //    #region M S SQL connection

        //    //sql data

        //    SQLDAL.ConnectionFactory conSql = new SQLDAL.ConnectionFactory();
        //    SQLDAL.IConnectionFactory _iconneSQL;

        //    SQLDAO plantDAO = new SQLDAO();

        //    _iconneSQL = new SQLDAL.ConnectionFactory();
        //    plantDAO = new SQLDAO(_iconneSQL);


        //    var plantSql = plantDAO.GetsqlFgpartCellAllow();
        //    sqlCount = plantSql.Count;



        //    #endregion

        //    IntoFile("Sql list count" + plantSql.Count);

        //    var ddlids = MysqlData.Select(m => m.fgAndCellAllocationId).ToList();  //my sql tbl IDs 

        //    IntoFile("sql IDs Count" + ddlids.Count);


        //    var det = plantSql.Where(m => !ddlids.Contains(m.fgAndCellAllocationId)).ToList();
        //    var res7 = det.ToList();

        //    IntoFile("Start_ddl Except SQL data:" + res7.Count);

        //    if (res7.Count > 0)
        //    {

        //        List<fgpartentity> mysqlPlant = new List<fgpartentity>();


        //        foreach (var row in res7)
        //        {

        //            fgpartentity dlist = new fgpartentity();

        //            //fgAndCellAllocationId,plantId,partNo,cellFinalId,subCellFinalId,isDeleted,createdOn,createdBy,modifiedOn,modifiedBy,partName,dmcCodeStatus

        //            dlist.fgAndCellAllocationId = row.fgAndCellAllocationId;
        //            dlist.plantId = row.plantId;
        //            dlist.partNo = row.partNo;
        //            dlist.cellFinalId = row.cellFinalId;
        //            dlist.subCellFinalId = row.subCellFinalId;

        //            dlist.isDeleted = row.isDeleted;


        //            dlist.createdOn = row.createdOn;
        //            dlist.createdBy = row.createdBy;
        //            dlist.modifiedOn = row.modifiedOn;
        //            dlist.modifiedBy = row.modifiedBy;

        //            dlist.partName = row.partName;
        //            dlist.dmcCodeStatus = row.dmcCodeStatus;






        //            mysqlPlant.Add(dlist);


        //        }



        //        resultsu = await srksMysql.insert_tblfgandcellallocation(mysqlPlant);

        //        IntoFile("inserted Successfully");


        //    }
        //    return resultsu;
        //}


        /// <summary>
        ///
        /// </summary>
        /// <param name="defect code master"></param>
        /// 
        //public async Task<int> SQL_to_Mysql()
        // {
        //     IntoFile("SQL_to_Mysql");
        //     int resultsu = 0;


        //     #region   My sql Connection
        //     //mysql data
        //     MyDAL.ConnectionFactory con = new MyDAL.ConnectionFactory();
        //     MyDAL.IConnectionFactory _iconne;

        //     SRKSDAO srksMysql = new SRKSDAO();
        //     _iconne = new MyDAL.ConnectionFactory();
        //     srksMysql = new SRKSDAO(_iconne);



        //     var MysqlData = srksMysql.getDefectCodemaster();
        //     int countList = MysqlData.Count();


        //     #endregion


        //     #region M S SQL connection

        //     //sql data

        //     SQLDAL.ConnectionFactory conSql = new SQLDAL.ConnectionFactory();
        //     SQLDAL.IConnectionFactory _iconneSQL;

        //     SQLDAO plantDAO = new SQLDAO();

        //     _iconneSQL = new SQLDAL.ConnectionFactory();
        //     plantDAO = new SQLDAO(_iconneSQL);


        //     var plantSql = plantDAO.GetsqlDefectcodemaster();
        //     sqlCount = plantSql.Count;



        //     #endregion

        //     IntoFile("Sql list count" + plantSql.Count);

        //     var ddlids = MysqlData.Select(m => m.defectCodeId).ToList();  //my sql tbl IDs 

        //     IntoFile("sql IDs Count" + ddlids.Count);


        //     var det = plantSql.Where(m => !ddlids.Contains(m.defectCodeId)).ToList();
        //     var res7 = det.ToList();

        //     IntoFile("Start_ddl Except SQL data:" + res7.Count);

        //     if (res7.Count > 0)
        //     {

        //         List<defectcodemsasteentity> mysqlPlant = new List<defectcodemsasteentity>();


        //         foreach (var row in res7)
        //         {

        //             defectcodemsasteentity dlist = new defectcodemsasteentity();

        //            // defectCodeId,defectCodeName,defectCodeDesc,isDeleted,createdOn,createdBy,modifiedOn,modifiedBy

        //             dlist.defectCodeId = row.defectCodeId;
        //             dlist.defectCodeName = row.defectCodeName;
        //             dlist.defectCodeDesc = row.defectCodeDesc;
        //             dlist.isDeleted = row.isDeleted;
        //             dlist.createdOn = row.createdOn;

        //             dlist.createdBy = row.createdBy;


        //             dlist.modifiedOn = row.modifiedOn;
        //             dlist.modifiedBy = row.modifiedBy;







        //             mysqlPlant.Add(dlist);


        //         }



        //         resultsu = await srksMysql.insert_tblDefectCode(mysqlPlant);

        //         IntoFile("inserted Successfully");


        //     }
        //     return resultsu;
        // }


        /// <summary>
        ///
        /// </summary>
        /// <param name="tblChildFgPartNo"></param>
        /// 
        //public async Task<int> SQL_to_Mysql()
        //  {
        //      IntoFile("SQL_to_Mysql");
        //      int resultsu = 0;


        //      #region   My sql Connection
        //      //mysql data
        //      MyDAL.ConnectionFactory con = new MyDAL.ConnectionFactory();
        //      MyDAL.IConnectionFactory _iconne;

        //      SRKSDAO srksMysql = new SRKSDAO();
        //      _iconne = new MyDAL.ConnectionFactory();
        //      srksMysql = new SRKSDAO(_iconne);



        //      var MysqlData = srksMysql.gettblChildFgPartNo();
        //      int countList = MysqlData.Count();


        //      #endregion


        //      #region M S SQL connection

        //      //sql data

        //      SQLDAL.ConnectionFactory conSql = new SQLDAL.ConnectionFactory();
        //      SQLDAL.IConnectionFactory _iconneSQL;

        //      SQLDAO plantDAO = new SQLDAO();

        //      _iconneSQL = new SQLDAL.ConnectionFactory();
        //      plantDAO = new SQLDAO(_iconneSQL);


        //      var plantSql = plantDAO.GetsqltblChildFgPartNo();
        //      sqlCount = plantSql.Count;



        //      #endregion

        //      IntoFile("Sql list count" + plantSql.Count);

        //      var ddlids = MysqlData.Select(m => m.childFgpartId).ToList();  //my sql tbl IDs 

        //      IntoFile("sql IDs Count" + ddlids.Count);


        //      var det = plantSql.Where(m => !ddlids.Contains(m.childFgpartId)).ToList();
        //      var res7 = det.ToList();

        //      IntoFile("Start_ddl Except SQL data:" + res7.Count);

        //      if (res7.Count > 0)
        //      {

        //          List<ChildFgPartNo> mysqlPlant = new List<ChildFgPartNo>();


        //          foreach (var row in res7)
        //          {

        //              ChildFgPartNo dlist = new ChildFgPartNo();

        //            //  childFgpartId,childFgPartNo,childPartNoDesc,plantId,fgPartNo,isDeleted,createdOn,createdBy,modifiedOn,modifiedBy,fgPartDesc

        //              dlist.childFgpartId = row.childFgpartId;
        //              dlist.childFgPartNo = row.childFgPartNo;
        //              dlist.childPartNoDesc = row.childPartNoDesc;
        //              dlist.plantId = row.plantId;
        //              dlist.fgPartNo = row.fgPartNo;

        //              dlist.isDeleted = row.isDeleted;


        //              dlist.createdOn = row.createdOn;
        //              dlist.createdBy = row.createdBy;


        //              dlist.modifiedOn = row.modifiedOn;
        //              dlist.modifiedBy = row.modifiedBy;
        //              dlist.fgPartDesc = row.fgPartDesc;





        //              mysqlPlant.Add(dlist);


        //          }



        //          resultsu = await srksMysql.insert_tblchildfgpartno(mysqlPlant);

        //          IntoFile("inserted Successfully");


        //      }
        //      return resultsu;
        //  }


        /// <summary>
        ///
        /// </summary>
        /// <param name="tbl_UtilReport"></param>
        /// 
        //public async Task<int> SQL_to_Mysql()
        // {
        //     IntoFile("SQL_to_Mysql");
        //     int resultsu = 0;


        //     #region   My sql Connection
        //     //mysql data
        //     MyDAL.ConnectionFactory con = new MyDAL.ConnectionFactory();
        //     MyDAL.IConnectionFactory _iconne;

        //     SRKSDAO srksMysql = new SRKSDAO();
        //     _iconne = new MyDAL.ConnectionFactory();
        //     srksMysql = new SRKSDAO(_iconne);



        //     var MysqlData = srksMysql.gettbl_UtilReport();
        //     int countList = MysqlData.Count();


        //     #endregion


        //     #region M S SQL connection

        //     //sql data

        //     SQLDAL.ConnectionFactory conSql = new SQLDAL.ConnectionFactory();
        //     SQLDAL.IConnectionFactory _iconneSQL;

        //     SQLDAO plantDAO = new SQLDAO();

        //     _iconneSQL = new SQLDAL.ConnectionFactory();
        //     plantDAO = new SQLDAO(_iconneSQL);


        //     var plantSql = plantDAO.Getsqltbl_UtilReport();
        //     sqlCount = plantSql.Count;



        //     #endregion

        //     IntoFile("Sql list count" + plantSql.Count);

        //     var ddlids = MysqlData.Select(m => m.UtilReportID).ToList();  //my sql tbl IDs 

        //     IntoFile("sql IDs Count" + ddlids.Count);


        //     var det = plantSql.Where(m => !ddlids.Contains(m.UtilReportID)).ToList();
        //     var res7 = det.ToList();

        //     IntoFile("Start_ddl Except SQL data:" + res7.Count);

        //     if (res7.Count > 0)
        //     {

        //         List<utilreportE> mysqlPlant = new List<utilreportE>();


        //         foreach (var row in res7)
        //         {

        //             utilreportE dlist = new utilreportE();

        //            // UtilReportID,MachineID,CorrectedDate,TotalTime,OperatingTime,SetupTime,MinorLossTime,LossTime,BDTime,PowerOffTime,UtilPercent,InsertedOn,SetupMinorTime

        //             dlist.UtilReportID = row.UtilReportID;
        //             dlist.MachineID = row.MachineID;
        //             dlist.CorrectedDate = row.CorrectedDate;
        //             dlist.TotalTime = row.TotalTime;
        //             dlist.OperatingTime = row.OperatingTime;

        //             dlist.SetupTime = row.SetupTime;


        //             dlist.MinorLossTime = row.MinorLossTime;
        //             dlist.LossTime = row.LossTime;


        //             dlist.BDTime = row.BDTime;
        //             dlist.PowerOffTime = row.PowerOffTime;
        //             dlist.UtilPercent = row.UtilPercent;

        //             dlist.InsertedOn = row.InsertedOn;
        //             dlist.SetupMinorTime = row.SetupMinorTime;



        //             mysqlPlant.Add(dlist);


        //         }



        //         resultsu = await srksMysql.insert_tbl_utilreport(mysqlPlant);

        //         IntoFile("inserted Successfully");


        //     }
        //     return resultsu;
        // }


        /// <summary>
        ///
        /// </summary>
        /// <param name="[tblBreakdowncodes]"></param>
        /// 
        //public async Task<int> SQL_to_Mysql()
        //  {
        //      IntoFile("SQL_to_Mysql");
        //      int resultsu = 0;


        //      #region   My sql Connection
        //      //mysql data
        //      MyDAL.ConnectionFactory con = new MyDAL.ConnectionFactory();
        //      MyDAL.IConnectionFactory _iconne;

        //      SRKSDAO srksMysql = new SRKSDAO();
        //      _iconne = new MyDAL.ConnectionFactory();
        //      srksMysql = new SRKSDAO(_iconne);



        //      var MysqlData = srksMysql.gettbl_tblbreakdowncodes();
        //      int countList = MysqlData.Count();


        //      #endregion


        //      #region M S SQL connection

        //      //sql data

        //      SQLDAL.ConnectionFactory conSql = new SQLDAL.ConnectionFactory();
        //      SQLDAL.IConnectionFactory _iconneSQL;

        //      SQLDAO plantDAO = new SQLDAO();

        //      _iconneSQL = new SQLDAL.ConnectionFactory();
        //      plantDAO = new SQLDAO(_iconneSQL);


        //      var plantSql = plantDAO.GetsqltbltblBreakdowncodes();
        //      sqlCount = plantSql.Count;



        //      #endregion

        //      IntoFile("Sql list count" + plantSql.Count);

        //      var ddlids = MysqlData.Select(m => m.BreakdownID).ToList();  //my sql tbl IDs 

        //      IntoFile("sql IDs Count" + ddlids.Count);


        //      var det = plantSql.Where(m => !ddlids.Contains(m.BreakdownID)).ToList();
        //      var res7 = det.ToList();

        //      IntoFile("Start_ddl Except SQL data:" + res7.Count);

        //      if (res7.Count > 0)
        //      {

        //          List<tblbreakdowncodesE> mysqlPlant = new List<tblbreakdowncodesE>();


        //          foreach (var row in res7)
        //          {

        //              tblbreakdowncodesE dlist = new tblbreakdowncodesE();


        //              dlist.BreakdownID = row.BreakdownID;
        //              dlist.BreakdownCode = row.BreakdownCode;
        //              dlist.BreakdownDesc = row.BreakdownDesc;
        //              dlist.MessageType = row.MessageType;
        //              dlist.BreakdownLevel = row.BreakdownLevel;

        //              dlist.BreakdownLevel1ID = row.BreakdownLevel1ID;


        //              dlist.BreakdownLevel2ID = row.BreakdownLevel2ID;
        //              dlist.ContributeTo = row.ContributeTo;


        //              dlist.IsDeleted = row.IsDeleted;
        //              dlist.CreatedOn = row.CreatedOn;
        //              dlist.CreatedBy = row.CreatedBy;

        //              dlist.ModifiedOn = row.ModifiedOn;
        //              dlist.ModifiedBy = row.ModifiedBy;


        //              dlist.EndCode = row.EndCode;
        //              dlist.DeletedDate = row.DeletedDate;
        //              dlist.ServerTabCheck = row.ServerTabCheck;

        //              dlist.ServerTabFlagSync = row.ServerTabFlagSync;
        //              dlist.TargetPercent = row.TargetPercent;



        //              mysqlPlant.Add(dlist);


        //          }



        //          resultsu = await srksMysql.insert_tbl_tblbreakdowncodes(mysqlPlant);

        //          IntoFile("inserted Successfully");


        //      }
        //      return resultsu;
        //  }





        /// <summary>
        ///
        /// </summary>
        /// <param name="[tblpriorityalarms]"></param>
        /// 
        //public async Task<int> SQL_to_Mysql()
        //  {
        //      IntoFile("SQL_to_Mysql");
        //      int resultsu = 0;


        //      #region   My sql Connection
        //      //mysql data
        //      MyDAL.ConnectionFactory con = new MyDAL.ConnectionFactory();
        //      MyDAL.IConnectionFactory _iconne;

        //      SRKSDAO srksMysql = new SRKSDAO();
        //      _iconne = new MyDAL.ConnectionFactory();
        //      srksMysql = new SRKSDAO(_iconne);



        //      var MysqlData = srksMysql.gettbl_tblpriorityalarms();
        //      int countList = MysqlData.Count();


        //      #endregion


        //      #region M S SQL connection

        //      //sql data

        //      SQLDAL.ConnectionFactory conSql = new SQLDAL.ConnectionFactory();
        //      SQLDAL.IConnectionFactory _iconneSQL;

        //      SQLDAO plantDAO = new SQLDAO();

        //      _iconneSQL = new SQLDAL.ConnectionFactory();
        //      plantDAO = new SQLDAO(_iconneSQL);


        //      var plantSql = plantDAO.Getsqltblpriorityalarms();
        //      sqlCount = plantSql.Count;



        //      #endregion

        //      IntoFile("Sql list count" + plantSql.Count);

        //      var ddlids = MysqlData.Select(m => m.AlarmID).ToList();  //my sql tbl IDs 

        //      IntoFile("sql IDs Count" + ddlids.Count);


        //      var det = plantSql.Where(m => !ddlids.Contains(m.AlarmID)).ToList();
        //      var res7 = det.ToList();

        //      IntoFile("Start_ddl Except SQL data:" + res7.Count);

        //      if (res7.Count > 0)
        //      {

        //          List<tblpriorityalarmsE> mysqlPlant = new List<tblpriorityalarmsE>();


        //          foreach (var row in res7)
        //          {

        //              tblpriorityalarmsE dlist = new tblpriorityalarmsE();

        //              dlist.AlarmID = row.AlarmID;
        //              dlist.AlarmNumber = row.AlarmNumber;
        //              dlist.AlarmDesc = row.AlarmDesc;
        //              dlist.AxisNo = row.AxisNo;
        //              dlist.AlarmGroup = row.AlarmGroup;

        //              dlist.PriorityNumber = row.PriorityNumber;


        //              dlist.IsDeleted = row.IsDeleted;
        //              dlist.CreatedOn = row.CreatedOn;


        //              dlist.CreatedBy = row.CreatedBy;
        //              dlist.ModifiedOn = row.ModifiedOn;
        //              dlist.ModifiedBy = row.ModifiedBy;

        //              dlist.MachineID = row.MachineID;
        //              dlist.CorrectedDate = row.CorrectedDate;


        //              dlist.isMailSent = row.isMailSent;




        //              mysqlPlant.Add(dlist);


        //          }



        //          resultsu = await srksMysql.insert_tblpriorityalarms(mysqlPlant);

        //          IntoFile("inserted Successfully");


        //      }
        //      return resultsu;
        //  }





        /// <summary>
        ///
        /// </summary>
        /// <param name="[alarm_history_master]"></param>
        /// 
        //public async Task<int> SQL_to_Mysql()
        //  {
        //      IntoFile("SQL_to_Mysql");
        //      int resultsu = 0;


        //      #region   My sql Connection
        //      //mysql data
        //      MyDAL.ConnectionFactory con = new MyDAL.ConnectionFactory();
        //      MyDAL.IConnectionFactory _iconne;

        //      SRKSDAO srksMysql = new SRKSDAO();
        //      _iconne = new MyDAL.ConnectionFactory();
        //      srksMysql = new SRKSDAO(_iconne);



        //      var MysqlData = srksMysql.getalarm_history_master();
        //      int countList = MysqlData.Count();


        //      #endregion


        //      #region M S SQL connection

        //      //sql data

        //      SQLDAL.ConnectionFactory conSql = new SQLDAL.ConnectionFactory();
        //      SQLDAL.IConnectionFactory _iconneSQL;

        //      SQLDAO plantDAO = new SQLDAO();

        //      _iconneSQL = new SQLDAL.ConnectionFactory();
        //      plantDAO = new SQLDAO(_iconneSQL);


        //      var plantSql = plantDAO.Getsqlalarm_history_maste();
        //      sqlCount = plantSql.Count;



        //      #endregion

        //      IntoFile("Sql list count" + plantSql.Count);

        //      var ddlids = MysqlData.Select(m => m.AlarmID).ToList();  //my sql tbl IDs 

        //      IntoFile("sql IDs Count" + ddlids.Count);


        //      var det = plantSql.Where(m => !ddlids.Contains(m.AlarmID)).ToList();
        //      var res7 = det.ToList();

        //      IntoFile("Start_ddl Except SQL data:" + res7.Count);

        //      if (res7.Count > 0)
        //      {

        //          List<alarm_history_masterE> mysqlPlant = new List<alarm_history_masterE>();


        //          foreach (var row in res7)
        //          {

        //              alarm_history_masterE dlist = new alarm_history_masterE();




        //              dlist.AlarmID = row.AlarmID;
        //              dlist.AlarmMessage = row.AlarmMessage;
        //              dlist.AlarmDateTime = row.AlarmDateTime;
        //              dlist.InsertedOn = row.InsertedOn;
        //              dlist.MachineID = row.MachineID;

        //              dlist.Shift = row.Shift;


        //              dlist.CorrectedDate = row.CorrectedDate;
        //              dlist.ErrorNum = row.ErrorNum;


        //              dlist.Status = row.Status;
        //              dlist.DetailCode1 = row.DetailCode1;
        //              dlist.DetailCode2 = row.DetailCode2;

        //              dlist.DetailCode3 = row.DetailCode3;
        //              dlist.InterferedPart = row.InterferedPart;



        //              dlist.SystemHead = row.SystemHead;
        //              dlist.AlarmNo = row.AlarmNo;
        //              dlist.Axis_No = row.Axis_No;
        //              dlist.Axis_Num = row.Axis_Num;
        //              dlist.Abs_Pos = row.Abs_Pos;
        //              dlist.AlarmDate = row.AlarmDate;

        //              dlist.AlarmTime = row.AlarmTime;



        //              mysqlPlant.Add(dlist);


        //          }



        //          resultsu = await srksMysql.insert_alarm_history_master(mysqlPlant);

        //          IntoFile("inserted Successfully");


        //      }
        //      return resultsu;
        //  }



        /// <summary>
        ///
        /// </summary>
        /// <param name="[tblfgpartnodet]"></param>
        /// 
        //public async Task<int> SQL_to_Mysql()
        //  {
        //      IntoFile("SQL_to_Mysql");
        //      int resultsu = 0;


        //      #region   My sql Connection
        //      //mysql data
        //      MyDAL.ConnectionFactory con = new MyDAL.ConnectionFactory();
        //      MyDAL.IConnectionFactory _iconne;

        //      SRKSDAO srksMysql = new SRKSDAO();
        //      _iconne = new MyDAL.ConnectionFactory();
        //      srksMysql = new SRKSDAO(_iconne);



        //      var MysqlData = srksMysql.gettblfgpartnodet();
        //      int countList = MysqlData.Count();


        //      #endregion


        //      #region M S SQL connection

        //      //sql data

        //      SQLDAL.ConnectionFactory conSql = new SQLDAL.ConnectionFactory();
        //      SQLDAL.IConnectionFactory _iconneSQL;

        //      SQLDAO plantDAO = new SQLDAO();

        //      _iconneSQL = new SQLDAL.ConnectionFactory();
        //      plantDAO = new SQLDAO(_iconneSQL);


        //      var plantSql = plantDAO.Getsqltblfgpartnodet();
        //      sqlCount = plantSql.Count;



        //      #endregion

        //      IntoFile("Sql list count" + plantSql.Count);

        //      var ddlids = MysqlData.Select(m => m.fgPartId).ToList();  //my sql tbl IDs 

        //      IntoFile("sql IDs Count" + ddlids.Count);


        //      var det = plantSql.Where(m => !ddlids.Contains(m.fgPartId)).ToList();
        //      var res7 = det.ToList();

        //      IntoFile("Start_ddl Except SQL data:" + res7.Count);

        //      if (res7.Count > 0)
        //      {

        //          List<tblfgpartnodetE> mysqlPlant = new List<tblfgpartnodetE>();


        //          foreach (var row in res7)
        //          {

        //              tblfgpartnodetE dlist = new tblfgpartnodetE();




        //              dlist.fgPartId = row.fgPartId;
        //              dlist.partId = row.partId;
        //              dlist.partCountMethod = row.partCountMethod;
        //              dlist.operationNo = row.operationNo;
        //              dlist.workOrderNo = row.workOrderNo;

        //              dlist.noOfPartsPerCycle = row.noOfPartsPerCycle;


        //              dlist.isClosed = row.isClosed;
        //              dlist.isDeleted = row.isDeleted;


        //              dlist.startDate = row.startDate;
        //              dlist.closedDate = row.closedDate;
        //              dlist.operatorId = row.operatorId;

        //              dlist.machineId = row.machineId;
        //              dlist.correctedDate = row.correctedDate;


        //              dlist.shift = row.shift;
        //              dlist.createdOn = row.createdOn;
        //              dlist.createdBy = row.createdBy;
        //              dlist.modifiedOn = row.modifiedOn;
        //              dlist.modifiedBy = row.modifiedBy;
        //              dlist.planLinkageId = row.planLinkageId;

        //              dlist.actaulValue = row.actaulValue;


        //              dlist.targetQty = row.targetQty;
        //              dlist.availibility = row.availibility;
        //              dlist.performance = row.performance;
        //              dlist.performance = row.performance;
        //              dlist.quality = row.quality;

        //              dlist.oee = row.oee;


        //              dlist.fgPartNo = row.fgPartNo;
        //              dlist.idealCycleTime = row.idealCycleTime;



        //              dlist.unit = row.unit;
        //              dlist.scheduledQty = row.scheduledQty;
        //              dlist.plannedStartTime = row.plannedStartTime;

        //              dlist.plannedEndTime = row.plannedEndTime;
        //              dlist.routingId = row.routingId;



        //              dlist.partName = row.partName;
        //              dlist.workOrderCompletedQty = row.workOrderCompletedQty;



        //              mysqlPlant.Add(dlist);


        //          }



        //          resultsu = await srksMysql.insert_tblfgpartnodet(mysqlPlant);

        //          IntoFile("inserted Successfully");


        //      }
        //      return resultsu;
        //  }



        /// <summary>
        ///
        /// </summary>
        /// <param name="[tbl_prodmanmachine]"></param>
        /// 
        //public async Task<int> SQL_to_Mysql()
        //  {
        //      IntoFile("SQL_to_Mysql");
        //      int resultsu = 0;


        //      #region   My sql Connection
        //      //mysql data
        //      MyDAL.ConnectionFactory con = new MyDAL.ConnectionFactory();
        //      MyDAL.IConnectionFactory _iconne;

        //      SRKSDAO srksMysql = new SRKSDAO();
        //      _iconne = new MyDAL.ConnectionFactory();
        //      srksMysql = new SRKSDAO(_iconne);



        //      var MysqlData = srksMysql.gettbl_prodmanmachine();
        //      int countList = MysqlData.Count();


        //      #endregion


        //      #region M S SQL connection

        //      //sql data

        //      SQLDAL.ConnectionFactory conSql = new SQLDAL.ConnectionFactory();
        //      SQLDAL.IConnectionFactory _iconneSQL;

        //      SQLDAO plantDAO = new SQLDAO();

        //      _iconneSQL = new SQLDAL.ConnectionFactory();
        //      plantDAO = new SQLDAO(_iconneSQL);


        //      var plantSql = plantDAO.Getsqltbl_prodmanmachine();
        //      sqlCount = plantSql.Count;



        //      #endregion

        //      IntoFile("Sql list count" + plantSql.Count);

        //      var ddlids = MysqlData.Select(m => m.ProdManMachineID).ToList();  //my sql tbl IDs 

        //      IntoFile("sql IDs Count" + ddlids.Count);


        //      var det = plantSql.Where(m => !ddlids.Contains(m.ProdManMachineID)).ToList();
        //      var res7 = det.ToList();

        //      IntoFile("Start_ddl Except SQL data:" + res7.Count);

        //      if (res7.Count > 0)
        //      {

        //          List<tbl_prodmanmachineE> mysqlPlant = new List<tbl_prodmanmachineE>();


        //          foreach (var row in res7)
        //          {

        //              tbl_prodmanmachineE dlist = new tbl_prodmanmachineE();


        //              dlist.ProdManMachineID = row.ProdManMachineID;
        //              dlist.MachineID = row.MachineID;
        //              dlist.CorrectedDate = row.CorrectedDate;
        //              dlist.WOID = row.WOID;
        //              dlist.UtilPercent = row.UtilPercent;

        //              dlist.TotalLoss = row.TotalLoss;


        //              dlist.TotalSetup = row.TotalSetup;
        //              dlist.TotalMinorLoss = row.TotalMinorLoss;


        //              dlist.TotalOperatingTime = row.TotalOperatingTime;

        //              dlist.InsertedOn = row.InsertedOn;

        //              dlist.TotalSetupMinorLoss = row.TotalSetupMinorLoss;
        //              dlist.TotalPowerLoss = row.TotalPowerLoss;


        //              dlist.PerformancePerCent = row.PerformancePerCent;
        //              dlist.QualityPercent = row.QualityPercent;
        //              dlist.PerfromaceFactor = row.PerfromaceFactor;





        //              mysqlPlant.Add(dlist);


        //          }



        //          resultsu = await srksMysql.insert_tbl_prodmanmachine(mysqlPlant);

        //          IntoFile("inserted Successfully");


        //      }
        //      return resultsu;
        //  }

        /// <summary>
        ///
        /// </summary>
        /// <param name="[tblrejectiondetails]"></param>
        /// 
        //public async Task<int> SQL_to_Mysql()
        // {
        //     IntoFile("SQL_to_Mysql");
        //     int resultsu = 0;


        //     #region   My sql Connection
        //     //mysql data
        //     MyDAL.ConnectionFactory con = new MyDAL.ConnectionFactory();
        //     MyDAL.IConnectionFactory _iconne;

        //     SRKSDAO srksMysql = new SRKSDAO();
        //     _iconne = new MyDAL.ConnectionFactory();
        //     srksMysql = new SRKSDAO(_iconne);



        //     var MysqlData = srksMysql.gettbl_tblrejectiondetails();
        //     int countList = MysqlData.Count();


        //     #endregion


        //     #region M S SQL connection

        //     //sql data

        //     SQLDAL.ConnectionFactory conSql = new SQLDAL.ConnectionFactory();
        //     SQLDAL.IConnectionFactory _iconneSQL;

        //     SQLDAO plantDAO = new SQLDAO();

        //     _iconneSQL = new SQLDAL.ConnectionFactory();
        //     plantDAO = new SQLDAO(_iconneSQL);


        //     var plantSql = plantDAO.GetsqltblRejectionDetails();
        //     sqlCount = plantSql.Count;



        //     #endregion

        //     IntoFile("Sql list count" + plantSql.Count);

        //     var ddlids = MysqlData.Select(m => m.rejectionId).ToList();  //my sql tbl IDs 

        //     IntoFile("sql IDs Count" + ddlids.Count);


        //     var det = plantSql.Where(m => !ddlids.Contains(m.rejectionId)).ToList();
        //     var res7 = det.ToList();

        //     IntoFile("Start_ddl Except SQL data:" + res7.Count);

        //     if (res7.Count > 0)
        //     {

        //         List<tblrejectiondetailsE> mysqlPlant = new List<tblrejectiondetailsE>();


        //         foreach (var row in res7)
        //         {

        //             tblrejectiondetailsE dlist = new tblrejectiondetailsE();

        //                 dlist.rejectionId = row.rejectionId;
        //             dlist.fgPartId = row.fgPartId;
        //             dlist.defectCodeId = row.defectCodeId;
        //             dlist.defectQty = row.defectQty;
        //             dlist.machineId = row.machineId;

        //             dlist.operatorId = row.operatorId;


        //             dlist.isDeleted = row.isDeleted;
        //             dlist.createdOn = row.createdOn;


        //             dlist.createdBy = row.createdBy;



        //             dlist.modifiedOn = row.modifiedOn;
        //             dlist.modifiedBy = row.modifiedBy;


        //             dlist.correctedDate = row.correctedDate;
        //             dlist.shift = row.shift;
        //             dlist.qrCodeNo = row.qrCodeNo;



        //             dlist.isDirLineInsp = row.isDirLineInsp;
        //             dlist.isDirQualityHead = row.isDirQualityHead;


        //             dlist.dmcCodeStatus = row.dmcCodeStatus;
        //             dlist.ReasonForRejection = row.ReasonForRejection;





        //             mysqlPlant.Add(dlist);


        //         }



        //         resultsu = await srksMysql.insert_tblRejectionDetails(mysqlPlant);

        //         IntoFile("inserted Successfully");


        //     }
        //     return resultsu;
        // }


        /// <summary>
        ///
        /// </summary>
        /// <param name="[unitworkccs.configuration_tblprimitivemaintainancescheduling`]"></param>
        /// 
        //public async Task<int> SQL_to_Mysql()
        // {
        //     IntoFile("SQL_to_Mysql");
        //     int resultsu = 0;


        //     #region   My sql Connection
        //     //mysql data
        //     MyDAL.ConnectionFactory con = new MyDAL.ConnectionFactory();
        //     MyDAL.IConnectionFactory _iconne;

        //     SRKSDAO srksMysql = new SRKSDAO();
        //     _iconne = new MyDAL.ConnectionFactory();
        //     srksMysql = new SRKSDAO(_iconne);



        //     var MysqlData = srksMysql.gettbl_configuration_tblprimitive();
        //     int countList = MysqlData.Count();


        //     #endregion


        //     #region M S SQL connection

        //     //sql data

        //     SQLDAL.ConnectionFactory conSql = new SQLDAL.ConnectionFactory();
        //     SQLDAL.IConnectionFactory _iconneSQL;

        //     SQLDAO plantDAO = new SQLDAO();

        //     _iconneSQL = new SQLDAL.ConnectionFactory();
        //     plantDAO = new SQLDAO(_iconneSQL);


        //     var plantSql = plantDAO.Getsqlconfiguration_tblprimitivemaintainancescheduling();
        //     sqlCount = plantSql.Count;



        //     #endregion

        //     IntoFile("Sql list count" + plantSql.Count);

        //     var ddlids = MysqlData.Select(m => m.pmid).ToList();  //my sql tbl IDs 

        //     IntoFile("sql IDs Count" + ddlids.Count);


        //     var det = plantSql.Where(m => !ddlids.Contains(m.pmid)).ToList();
        //     var res7 = det.ToList();

        //     IntoFile("Start_ddl Except SQL data:" + res7.Count);

        //     if (res7.Count > 0)
        //     {

        //         List<configuration_tblprimitivemaintainE_> mysqlPlant = new List<configuration_tblprimitivemaintainE_>();


        //         foreach (var row in res7)
        //         {

        //             configuration_tblprimitivemaintainE_ dlist = new configuration_tblprimitivemaintainE_();


        //             dlist.pmid = row.pmid;
        //             dlist.MachineID = row.MachineID;
        //             dlist.MachineName = row.MachineName;
        //             dlist.Month = row.Month;
        //             dlist.Week = row.Week;

        //             dlist.IsDeleted = row.IsDeleted;


        //             dlist.CreatedOn = row.CreatedOn;
        //             dlist.CreatedBy = row.CreatedBy;


        //             dlist.ModifiedOn = row.ModifiedOn;



        //             dlist.ModifiedBy = row.ModifiedBy;
        //             dlist.CellName = row.CellName;


        //             dlist.CellID = row.CellID;
        //             dlist.PlantID = row.PlantID;
        //             dlist.ShopID = row.ShopID;



        //             dlist.plantName = row.plantName;
        //             dlist.shopname = row.shopname;


        //             dlist.MonthID = row.MonthID;
        //             dlist.WeekID = row.WeekID;





        //             mysqlPlant.Add(dlist);


        //         }



        //         resultsu = await srksMysql.insert_configuration_tblprimitivem(mysqlPlant);

        //         IntoFile("inserted Successfully");


        //     }
        //     return resultsu;
        // }


        /// <summary>
        ///
        /// </summary>
        /// <param name="[unitworkccs.tblsmsdetails`]"></param>
        /// 
        //public async Task<int> SQL_to_Mysql()
        //  {
        //      IntoFile("SQL_to_Mysql");
        //      int resultsu = 0;


        //      #region   My sql Connection
        //      //mysql data
        //      MyDAL.ConnectionFactory con = new MyDAL.ConnectionFactory();
        //      MyDAL.IConnectionFactory _iconne;

        //      SRKSDAO srksMysql = new SRKSDAO();
        //      _iconne = new MyDAL.ConnectionFactory();
        //      srksMysql = new SRKSDAO(_iconne);



        //      var MysqlData = srksMysql.gettbl_tblSmsDetails();
        //      int countList = MysqlData.Count();


        //      #endregion


        //      #region M S SQL connection

        //      //sql data

        //      SQLDAL.ConnectionFactory conSql = new SQLDAL.ConnectionFactory();
        //      SQLDAL.IConnectionFactory _iconneSQL;

        //      SQLDAO plantDAO = new SQLDAO();

        //      _iconneSQL = new SQLDAL.ConnectionFactory();
        //      plantDAO = new SQLDAO(_iconneSQL);


        //      var plantSql = plantDAO.GetsqltblSmsDetails();
        //      sqlCount = plantSql.Count;



        //      #endregion

        //      IntoFile("Sql list count" + plantSql.Count);

        //      var ddlids = MysqlData.Select(m => m.smsId).ToList();  //my sql tbl IDs 

        //      IntoFile("sql IDs Count" + ddlids.Count);


        //      var det = plantSql.Where(m => !ddlids.Contains(m.smsId)).ToList();
        //      var res7 = det.ToList();

        //      IntoFile("Start_ddl Except SQL data:" + res7.Count);

        //      if (res7.Count > 0)
        //      {

        //          List<tblsmsdetailsE> mysqlPlant = new List<tblsmsdetailsE>();


        //          foreach (var row in res7)
        //          {

        //              tblsmsdetailsE dlist = new tblsmsdetailsE();

        //                  dlist.smsId = row.smsId;
        //              dlist.machineId = row.machineId;
        //              dlist.contactNo = row.contactNo;
        //              dlist.ticketId = row.ticketId;
        //              dlist.createdOn = row.createdOn;

        //              dlist.createdBy = row.createdBy;


        //              dlist.modifiedOn = row.modifiedOn;
        //              dlist.modifiedBy = row.modifiedBy;


        //              dlist.isDeleted = row.isDeleted;



        //              dlist.responseId = row.responseId;
        //              dlist.idleResponseId = row.idleResponseId;


        //              dlist.idleSms = row.idleSms;
        //              dlist.shift = row.shift;
        //              dlist.message = row.message;



        //              dlist.correctedDate = row.correctedDate;
        //              dlist.cellId = row.cellId;


        //              dlist.subCellId = row.subCellId;
        //              dlist.categoryId = row.categoryId;


        //              dlist.smsPriority = row.smsPriority;
        //              dlist.timeToBeTriggered = row.timeToBeTriggered;


        //              dlist.employeeName = row.employeeName;
        //              dlist.opNo = row.opNo;





        //              mysqlPlant.Add(dlist);


        //          }



        //          resultsu = await srksMysql.insert_tblsmsdetails(mysqlPlant);

        //          IntoFile("inserted Successfully");


        //      }
        //      return resultsu;
        //  }

        /// <summary>
        ///
        /// </summary>
        /// <param name="[unitworkccs.tblsmsdetails`]"></param>
        /// 


        //public async Task<int> SQL_to_Mysql()
        //  {
        //      IntoFile("SQL_to_Mysql");
        //      int resultsu = 0;


        //      #region   My sql Connection
        //      //mysql data
        //      MyDAL.ConnectionFactory con = new MyDAL.ConnectionFactory();
        //      MyDAL.IConnectionFactory _iconne;

        //      SRKSDAO srksMysql = new SRKSDAO();
        //      _iconne = new MyDAL.ConnectionFactory();
        //      srksMysql = new SRKSDAO(_iconne);



        //      var MysqlData = srksMysql.gettbl_operationlog();
        //      int countList = MysqlData.Count();


        //      #endregion


        //      #region M S SQL connection

        //      //sql data

        //      SQLDAL.ConnectionFactory conSql = new SQLDAL.ConnectionFactory();
        //      SQLDAL.IConnectionFactory _iconneSQL;

        //      SQLDAO plantDAO = new SQLDAO();

        //      _iconneSQL = new SQLDAL.ConnectionFactory();
        //      plantDAO = new SQLDAO(_iconneSQL);


        //      var plantSql = plantDAO.Getsqloperationlog();
        //      sqlCount = plantSql.Count;



        //      #endregion

        //      IntoFile("Sql list count" + plantSql.Count);

        //      var ddlids = MysqlData.Select(m => m.idoperationlog).ToList();  //my sql tbl IDs 

        //      IntoFile("sql IDs Count" + ddlids.Count);


        //      var det = plantSql.Where(m => !ddlids.Contains(m.idoperationlog)).ToList();
        //      var res7 = det.ToList();

        //      IntoFile("Start_ddl Except SQL data:" + res7.Count);

        //      if (res7.Count > 0)
        //      {

        //          List<operationlogE> mysqlPlant = new List<operationlogE>();


        //          foreach (var row in res7)
        //          {

        //              operationlogE dlist = new operationlogE();

        //             // idoperationlog,OpMsg,OpDate,OpTime,OpDateTime,OpReason,MachineID

        //              dlist.idoperationlog = row.idoperationlog;
        //              dlist.OpMsg = row.OpMsg;
        //              dlist.OpDate = row.OpDate;
        //              dlist.OpTime = row.OpTime;
        //              dlist.OpDateTime = row.OpDateTime;

        //              dlist.OpReason = row.OpReason;


        //              dlist.MachineID = row.MachineID;




        //              mysqlPlant.Add(dlist);


        //          }



        //          resultsu = await srksMysql.insert_operationlog(mysqlPlant);

        //          IntoFile("inserted Successfully");


        //      }
        //      return resultsu;
        //  }


        /// <summary>
        ///
        /// </summary>
        /// <param name="[unitworkccs.tblstoppage`]"></param>
        /// 


        //public async Task<int> SQL_to_Mysql()
        //  {
        //      IntoFile("SQL_to_Mysql");
        //      int resultsu = 0;


        //      #region   My sql Connection
        //      //mysql data
        //      MyDAL.ConnectionFactory con = new MyDAL.ConnectionFactory();
        //      MyDAL.IConnectionFactory _iconne;

        //      SRKSDAO srksMysql = new SRKSDAO();
        //      _iconne = new MyDAL.ConnectionFactory();
        //      srksMysql = new SRKSDAO(_iconne);



        //      var MysqlData = srksMysql.gettbl_tblstoppage();
        //      int countList = MysqlData.Count();


        //      #endregion


        //      #region M S SQL connection

        //      //sql data

        //      SQLDAL.ConnectionFactory conSql = new SQLDAL.ConnectionFactory();
        //      SQLDAL.IConnectionFactory _iconneSQL;

        //      SQLDAO plantDAO = new SQLDAO();

        //      _iconneSQL = new SQLDAL.ConnectionFactory();
        //      plantDAO = new SQLDAO(_iconneSQL);


        //      var plantSql = plantDAO.GetsqltblStoppage();
        //      sqlCount = plantSql.Count;



        //      #endregion

        //      IntoFile("Sql list count" + plantSql.Count);

        //      var ddlids = MysqlData.Select(m => m.stoppagesId).ToList();  //my sql tbl IDs 

        //      IntoFile("sql IDs Count" + ddlids.Count);


        //      var det = plantSql.Where(m => !ddlids.Contains(m.stoppagesId)).ToList();
        //      var res7 = det.ToList();

        //      IntoFile("Start_ddl Except SQL data:" + res7.Count);

        //      if (res7.Count > 0)
        //      {

        //          List<tblstoppageE> mysqlPlant = new List<tblstoppageE>();


        //          foreach (var row in res7)
        //          {

        //              tblstoppageE dlist = new tblstoppageE();

        //            //  stoppagesId,categoryId,alramNo,alramDesc,sourceId,createdOn,createdBy,modifiedBy,modifiedOn,isDeleted

        //              dlist.stoppagesId = row.stoppagesId;
        //              dlist.categoryId = row.categoryId;
        //              dlist.alramNo = row.alramNo;
        //              dlist.alramDesc = row.alramDesc;
        //              dlist.sourceId = row.sourceId;

        //              dlist.createdOn = row.createdOn;


        //              dlist.createdBy = row.createdBy;

        //              dlist.modifiedBy = row.modifiedBy;
        //              dlist.modifiedOn = row.modifiedOn;
        //              dlist.isDeleted = row.isDeleted;




        //              mysqlPlant.Add(dlist);


        //          }



        //          resultsu = await srksMysql.insert_tblstoppage(mysqlPlant);

        //          IntoFile("inserted Successfully");


        //      }
        //      return resultsu;
        //  }




        /// <summary>
        ///
        /// </summary>
        /// <param name="[tblproductwisedefectcodes`]"></param>
        /// 

        //public async Task<int> SQL_to_Mysql()
        //  {
        //      IntoFile("SQL_to_Mysql");
        //      int resultsu = 0;


        //      #region   My sql Connection
        //      //mysql data
        //      MyDAL.ConnectionFactory con = new MyDAL.ConnectionFactory();
        //      MyDAL.IConnectionFactory _iconne;

        //      SRKSDAO srksMysql = new SRKSDAO();
        //      _iconne = new MyDAL.ConnectionFactory();
        //      srksMysql = new SRKSDAO(_iconne);



        //      var MysqlData = srksMysql.gettbl_tblproductwisedefectcodes();
        //      int countList = MysqlData.Count();


        //      #endregion


        //      #region M S SQL connection

        //      //sql data

        //      SQLDAL.ConnectionFactory conSql = new SQLDAL.ConnectionFactory();
        //      SQLDAL.IConnectionFactory _iconneSQL;

        //      SQLDAO plantDAO = new SQLDAO();

        //      _iconneSQL = new SQLDAL.ConnectionFactory();
        //      plantDAO = new SQLDAO(_iconneSQL);


        //      var plantSql = plantDAO.GetsqltblProductWiseDefectCode();
        //      sqlCount = plantSql.Count;



        //      #endregion

        //      IntoFile("Sql list count" + plantSql.Count);

        //      var ddlids = MysqlData.Select(m => m.productWiseDefectCodeId).ToList();  //my sql tbl IDs 

        //      IntoFile("sql IDs Count" + ddlids.Count);


        //      var det = plantSql.Where(m => !ddlids.Contains(m.productWiseDefectCodeId)).ToList();
        //      var res7 = det.ToList();

        //      IntoFile("Start_ddl Except SQL data:" + res7.Count);

        //      if (res7.Count > 0)
        //      {

        //          List<tblproductwisedefectcodesE> mysqlPlant = new List<tblproductwisedefectcodesE>();


        //          foreach (var row in res7)
        //          {

        //              tblproductwisedefectcodesE dlist = new tblproductwisedefectcodesE();

        //            //  productWiseDefectCodeId,trim,plantId,partNo,defectCodeId,isDeleted,createdOn,createdBy,modifiedOn,modifiedBy,partName

        //              dlist.productWiseDefectCodeId = row.productWiseDefectCodeId;
        //              dlist.trim = row.trim;
        //              dlist.plantId = row.plantId;
        //              dlist.partNo = row.partNo;
        //              dlist.defectCodeId = row.defectCodeId;

        //              dlist.isDeleted = row.isDeleted;


        //              dlist.createdOn = row.createdOn;

        //              dlist.createdBy = row.createdBy;
        //              dlist.modifiedOn = row.modifiedOn;
        //              dlist.modifiedBy = row.modifiedBy;


        //              dlist.partName = row.partName;

        //              mysqlPlant.Add(dlist);


        //          }



        //          resultsu = await srksMysql.insert_tblproductwisedefectcodese(mysqlPlant);

        //          IntoFile("inserted Successfully");


        //      }
        //      return resultsu;
        //  }


        /// <summary>
        ///
        /// </summary>
        /// <param name="[tblmachinedetails`]"></param>
        /// 
        //      public async Task<int> SQL_to_Mysql()
        //        {
        //            IntoFile("SQL_to_Mysql");
        //            int resultsu = 0;


        //            #region   My sql Connection
        //            //mysql data
        //            MyDAL.ConnectionFactory con = new MyDAL.ConnectionFactory();
        //            MyDAL.IConnectionFactory _iconne;

        //            SRKSDAO srksMysql = new SRKSDAO();
        //            _iconne = new MyDAL.ConnectionFactory();
        //            srksMysql = new SRKSDAO(_iconne);



        //            var MysqlData = srksMysql.gettbl_tblmachinedetails();
        //            int countList = MysqlData.Count();


        //            #endregion


        //            #region M S SQL connection

        //            //sql data

        //            SQLDAL.ConnectionFactory conSql = new SQLDAL.ConnectionFactory();
        //            SQLDAL.IConnectionFactory _iconneSQL;

        //            SQLDAO plantDAO = new SQLDAO();

        //            _iconneSQL = new SQLDAL.ConnectionFactory();
        //            plantDAO = new SQLDAO(_iconneSQL);


        //            var plantSql = plantDAO.Getsqltblmachinedetails();
        //            sqlCount = plantSql.Count;



        //            #endregion

        //            IntoFile("Sql list count" + plantSql.Count);

        //            var ddlids = MysqlData.Select(m => m.MachineID).ToList();  //my sql tbl IDs 

        //            IntoFile("sql IDs Count" + ddlids.Count);


        //            var det = plantSql.Where(m => !ddlids.Contains(m.MachineID)).ToList();
        //            var res7 = det.ToList();

        //            IntoFile("Start_ddl Except SQL data:" + res7.Count);

        //            if (res7.Count > 0)
        //            {

        //                List<tblmachinedetailsE> mysqlPlant = new List<tblmachinedetailsE>();


        //                foreach (var row in res7)
        //                {

        //                    tblmachinedetailsE dlist = new tblmachinedetailsE();

        //                    //  productWiseDefectCodeId,trim,plantId,partNo,defectCodeId,isDeleted,createdOn,createdBy,modifiedOn,modifiedBy,partName




        // //MachineID,InsertedOn,InsertedBy,ModifiedOn,ModifiedBy,IsDeleted,PlantID,ShopID,CellID,MachineName,MachineDescription,



        //                    dlist.MachineID = row.MachineID;
        //                    dlist.InsertedOn = row.InsertedOn;
        //                    dlist.InsertedBy = row.InsertedBy;
        //                    dlist.ModifiedOn = row.ModifiedOn;
        //                    dlist.ModifiedBy = row.ModifiedBy;

        //                    dlist.IsDeleted = row.IsDeleted;


        //                    dlist.PlantID = row.PlantID;

        //                    dlist.ShopID = row.ShopID;
        //                    dlist.CellID = row.CellID;
        //                    dlist.MachineName = row.MachineName;


        //                    dlist.MachineDescription = row.MachineDescription;
        //                    dlist.MachineDisplayName = row.MachineDisplayName;
        //                    dlist.CellOrderNo = row.CellOrderNo;
        //                    dlist.IPAddress = row.IPAddress;
        //                    dlist.MachineType = row.MachineType;

        //                    dlist.ControllerType = row.ControllerType;


        //                    dlist.MachineModel = row.MachineModel;

        //                    dlist.MachineMake = row.MachineMake;
        //                    dlist.ModelType = row.ModelType;
        //                    dlist.IsParameters = row.IsParameters;




        //                 //   MachineDisplayName,CellOrderNo,IPAddress,MachineType,ControllerType,MachineModel,MachineMake,ModelType,IsParameters,





        //                    dlist.ShopNo = row.ShopNo;
        //                    dlist.IsPCB = row.IsPCB;
        //                    dlist.IsLevel = row.IsLevel;
        //                    dlist.IsNormalWC = row.IsNormalWC;
        //                    dlist.ManualWCID = row.ManualWCID;

        //                    dlist.NoOfAxis = row.NoOfAxis;


        //                    dlist.MacType = row.MacType;

        //                    dlist.CurrentControlAxis = row.CurrentControlAxis;
        //                    dlist.ProgramNum = row.ProgramNum;
        //                    dlist.ProgDBit = row.ProgDBit;


        //                    dlist.MachineModelType = row.MachineModelType;

        //                 //   ShopNo,IsPCB,IsLevel,IsNormalWC,ManualWCID,NoOfAxis,MacType,CurrentControlAxis,ProgramNum,ProgDBit,MachineModelType,



        //                    dlist.MacConnName = row.MacConnName;
        //                    dlist.SpindleAxis = row.SpindleAxis;
        //                    dlist.TabIPAddress = row.TabIPAddress;
        //                    dlist.MachineLockBit = row.MachineLockBit;
        //                    dlist.MachineSetupBit = row.MachineSetupBit;

        //                    dlist.MachineMaintBit = row.MachineMaintBit;


        //                    dlist.MachineToolLifeBit = row.MachineToolLifeBit;

        //                    dlist.MachineUnlockBit = row.MachineUnlockBit;



        //// MacConnName,SpindleAxis,TabIPAddress,MachineLockBit,MachineSetupBit,MachineMaintBit,MachineToolLifeBit,MachineUnlockBit,



        //                    dlist.MachineIdleBit = row.MachineIdleBit;
        //                    dlist.MachineIdleMin = row.MachineIdleMin;
        //                    dlist.EnableLockLogic = row.EnableLockLogic;
        //                    dlist.ServerTabFlagSync = row.ServerTabFlagSync;
        //                    dlist.ServerTabCheck = row.ServerTabCheck;

        //                    dlist.DeletedDate = row.DeletedDate;


        //                    dlist.EnableToolLife = row.EnableToolLife;

        //                    dlist.IsBottelNeck = row.IsBottelNeck;


        //// MachineIdleBit,MachineIdleMin,EnableLockLogic,ServerTabFlagSync,ServerTabCheck,DeletedDate,EnableToolLife,IsBottelNeck,





        //                    dlist.IsFirstMachine = row.IsFirstMachine;
        //                    dlist.IsLastMachine = row.IsLastMachine;
        //                    dlist.OperationNumber = row.OperationNumber;
        //                    dlist.IsShiftWise = row.IsShiftWise;
        //                    dlist.LossFlag = row.LossFlag;

        //                    dlist.TransmissionFrequency = row.TransmissionFrequency;


        //                    dlist.LoggerType = row.LoggerType;

        //                    dlist.MachinePort = row.MachinePort;
        //                    dlist.NumOfAxis = row.NumOfAxis;


        //// IsFirstMachine,IsLastMachine,OperationNumber,IsShiftWise,LossFlag,TransmissionFrequency,LoggerType,MachinePort,NumOfAxis,





        //                    dlist.ToolGroupNum = row.ToolGroupNum;
        //                    dlist.NumberOfCurrent = row.NumberOfCurrent;
        //                    dlist.NumberOfTemperature = row.NumberOfTemperature;
        //                    dlist.NumberOfPresure = row.NumberOfPresure;
        //                    dlist.NumberOfLevel = row.NumberOfLevel;

        //                    dlist.CreatedOn = row.CreatedOn;


        //                    dlist.IsWimerasys = row.IsWimerasys;

        //                    dlist.IOTGatewayIP = row.IOTGatewayIP;



        // //ToolGroupNum,NumberOfCurrent,NumberOfTemperature,NumberOfPresure,NumberOfLevel,CreatedOn,IsWimerasys,IOTGatewayIP,




        //                    dlist.NodeID = row.NodeID;
        //                    dlist.IsDLVersion = row.IsDLVersion;
        //                    dlist.machinePockets = row.machinePockets;
        //                    dlist.noOfPartsPerCycle = row.noOfPartsPerCycle;
        //                    dlist.Category = row.Category;

        //                    dlist.MachineCategoryId = row.MachineCategoryId;


        //                    dlist.MMMGroup = row.MMMGroup;

        //                    dlist.dedicatedOrShared = row.dedicatedOrShared;


        //// NodeID,IsDLVersion,machinePockets,noOfPartsPerCycle,Category,MachineCategoryId,MMMGroup,dedicatedOrShared,


        //                    dlist.primaryOrSecondary = row.primaryOrSecondary;
        //                    dlist.machineSpec = row.machineSpec;
        //                    dlist.chuckOrRodSize = row.chuckOrRodSize;
        //                    dlist.noOfToolStation = row.noOfToolStation;
        //                    dlist.tallStockAvailId = row.tallStockAvailId;

        //                    dlist.noOfAxisId = row.noOfAxisId;


        //                    dlist.tableSize = row.tableSize;

        //                    dlist.palletId = row.palletId;


        ////primaryOrSecondary,machineSpec,chuckOrRodSize,noOfToolStation,tallStockAvailId,noOfAxisId,tableSize,palletId







        //                    mysqlPlant.Add(dlist);


        //                }



        //                resultsu = await srksMysql.inserttblmachinedetails(mysqlPlant);

        //                IntoFile("inserted Successfully");


        //            }
        //            return resultsu;
        //        }


        /// <summary>
        ///
        /// </summary>
        /// <param name="[logintrackerdetails`]"></param>
        /// 
        //public async Task<int> SQL_to_Mysql()
        //  {
        //      IntoFile("SQL_to_Mysql");
        //      int resultsu = 0;


        //      #region   My sql Connection
        //      //mysql data
        //      MyDAL.ConnectionFactory con = new MyDAL.ConnectionFactory();
        //      MyDAL.IConnectionFactory _iconne;

        //      SRKSDAO srksMysql = new SRKSDAO();
        //      _iconne = new MyDAL.ConnectionFactory();
        //      srksMysql = new SRKSDAO(_iconne);



        //      var MysqlData = srksMysql.gettbl_logintrackerdetails();
        //      int countList = MysqlData.Count();


        //      #endregion


        //      #region M S SQL connection

        //      //sql data

        //      SQLDAL.ConnectionFactory conSql = new SQLDAL.ConnectionFactory();
        //      SQLDAL.IConnectionFactory _iconneSQL;

        //      SQLDAO plantDAO = new SQLDAO();

        //      _iconneSQL = new SQLDAL.ConnectionFactory();
        //      plantDAO = new SQLDAO(_iconneSQL);


        //      var plantSql = plantDAO.Getsqllogintrackerdetails();
        //      sqlCount = plantSql.Count;



        //      #endregion

        //      IntoFile("Sql list count" + plantSql.Count);

        //      var ddlids = MysqlData.Select(m => m.loginTrackerDetailsId).ToList();  //my sql tbl IDs 

        //      IntoFile("sql IDs Count" + ddlids.Count);


        //      var det = plantSql.Where(m => !ddlids.Contains(m.loginTrackerDetailsId)).ToList();
        //      var res7 = det.ToList();

        //      IntoFile("Start_ddl Except SQL data:" + res7.Count);

        //      if (res7.Count > 0)
        //      {

        //          List<logintrackerdetailsE> mysqlPlant = new List<logintrackerdetailsE>();


        //          foreach (var row in res7)
        //          {

        //              logintrackerdetailsE dlist = new logintrackerdetailsE();



        //              dlist.loginTrackerDetailsId = row.loginTrackerDetailsId;
        //              dlist.machineId = row.machineId;
        //              dlist.operatorId = row.operatorId;
        //              dlist.currentFGPart = row.currentFGPart;
        //              dlist.currentTicketRaisedId = row.currentTicketRaisedId;

        //              dlist.loginDateTime = row.loginDateTime;


        //              dlist.logoutDateTime = row.logoutDateTime;

        //              dlist.isLoggedIn = row.isLoggedIn;
        //              dlist.insertedOn = row.insertedOn;
        //              dlist.isDeleted = row.isDeleted;


        //              dlist.shift = row.shift;
        //              dlist.correctedDate = row.correctedDate;








        //              mysqlPlant.Add(dlist);


        //          }



        //          resultsu = await srksMysql.insertlogintrackerdetails(mysqlPlant);

        //          IntoFile("inserted Successfully");


        //      }
        //      return resultsu;
        //  }


        /// <summary>
        ///
        /// </summary>
        /// <param name="[tblparts`]"></param>
        /// 
        //public async Task<int> SQL_to_Mysql()
        //{
        //    IntoFile("SQL_to_Mysql");
        //    int resultsu = 0;


        //    #region   My sql Connection
        //    //mysql data
        //    MyDAL.ConnectionFactory con = new MyDAL.ConnectionFactory();
        //    MyDAL.IConnectionFactory _iconne;

        //    SRKSDAO srksMysql = new SRKSDAO();
        //    _iconne = new MyDAL.ConnectionFactory();
        //    srksMysql = new SRKSDAO(_iconne);



        //    var MysqlData = srksMysql.gettbl_tblparts();
        //    int countList = MysqlData.Count();


        //    #endregion


        //    #region M S SQL connection

        //    //sql data

        //    SQLDAL.ConnectionFactory conSql = new SQLDAL.ConnectionFactory();
        //    SQLDAL.IConnectionFactory _iconneSQL;

        //    SQLDAO plantDAO = new SQLDAO();

        //    _iconneSQL = new SQLDAL.ConnectionFactory();
        //    plantDAO = new SQLDAO(_iconneSQL);


        //    var plantSql = plantDAO.Getsqltblparts();
        //    sqlCount = plantSql.Count;



        //    #endregion

        //    IntoFile("Sql list count" + plantSql.Count);

        //    var ddlids = MysqlData.Select(m => m.PartID).ToList();  //my sql tbl IDs 

        //    IntoFile("sql IDs Count" + ddlids.Count);


        //    var det = plantSql.Where(m => !ddlids.Contains(m.PartID)).ToList();
        //    var res7 = det.ToList();

        //    IntoFile("Start_ddl Except SQL data:" + res7.Count);

        //    if (res7.Count > 0)
        //    {

        //        List<tblpartsE> mysqlPlant = new List<tblpartsE>();


        //        foreach (var row in res7)
        //        {

        //            tblpartsE dlist = new tblpartsE();




        //            dlist.PartID = row.PartID;
        //            dlist.FGCode = row.FGCode;
        //            dlist.OperationNo = row.OperationNo;
        //            dlist.PartName = row.PartName;
        //            dlist.IdealCycleTime = row.IdealCycleTime;

        //            dlist.PartsPerCycle = row.PartsPerCycle;


        //            dlist.UnitDesc = row.UnitDesc;

        //            dlist.IsDeleted = row.IsDeleted;
        //            dlist.CreatedOn = row.CreatedOn;
        //            dlist.CreatedBy = row.CreatedBy;


        //            dlist.ModifiedOn = row.ModifiedOn;
        //            dlist.ModifiedBy = row.ModifiedBy;


        //            dlist.DrawingNo = row.DrawingNo;
        //            dlist.DeletedDate = row.DeletedDate;
        //            dlist.Std_Load_UnloadTime = row.Std_Load_UnloadTime;
        //            dlist.Std_SetupTime = row.Std_SetupTime;
        //            dlist.MachineID = row.MachineID;

        //            dlist.StdMinorLoss = row.StdMinorLoss;


        //            dlist.StdLoadingTime = row.StdLoadingTime;

        //            dlist.StdUnLoadingTime = row.StdUnLoadingTime;
        //            dlist.PartNo = row.PartNo;
        //            dlist.PartDesc = row.PartDesc;


        //            dlist.targetPerHr = row.targetPerHr;
        //            dlist.planLinkageId = row.planLinkageId;

        //            dlist.targetPerShift = row.targetPerShift;

        //            dlist.routingId = row.routingId;

        //            dlist.resourceId = row.resourceId;
        //            dlist.plantId = row.plantId;
        //            dlist.priority = row.priority;


        //            mysqlPlant.Add(dlist);


        //        }



        //        resultsu = await srksMysql.inserttblparts(mysqlPlant);

        //        IntoFile("inserted Successfully");


        //    }
        //    return resultsu;
        //}















        public void IntoFile(string Msg)
        {
            string path1 = AppDomain.CurrentDomain.BaseDirectory;
            string appPath = Application.StartupPath + @"\TataDDLLogFile.txt";
            using (StreamWriter writer = new StreamWriter(appPath, true)) //true => Append Text
            {
                writer.WriteLine(System.DateTime.Now + ":  " + Msg);
            }
        }


    }

}


///

//public async Task<int> SQL_to_Mysql()
//{
//    IntoFile("SQL_to_Mysql");
//    int resultsu = 0;


//    #region   My sql Connection
//    //mysql data
//    MyDAL.ConnectionFactory con = new MyDAL.ConnectionFactory();
//    MyDAL.IConnectionFactory _iconne;

//    SRKSDAO srksMysql = new SRKSDAO();
//    _iconne = new MyDAL.ConnectionFactory();
//    srksMysql = new SRKSDAO(_iconne);


//    //plant

//    // var MysqlData = srksMysql.getplant();   //2,3
//    // int countList = MysqlData.Count();


//    //IOTGateWay
//    //var MysqlData = srksMysql.getIOTGate();   
//    //int countList = MysqlData.Count();

//    //Parameter MasterSensor Data
//    // var MysqlData = srksMysql.getParameterMasterSensorData();
//    // int countList = MysqlData.Count();


//    var MysqlData = srksMysql.getParameterTool();
//    int countList = MysqlData.Count();

//    //var MysqlData = srksMysql.getParameterMaster();
//    // int countList = MysqlData.Count();



//    #endregion


//    #region M S SQL connection

//    //sql data

//    SQLDAL.ConnectionFactory conSql = new SQLDAL.ConnectionFactory();
//    SQLDAL.IConnectionFactory _iconneSQL;

//    SQLDAO plantDAO = new SQLDAO();

//    _iconneSQL = new SQLDAL.ConnectionFactory();
//    plantDAO = new SQLDAO(_iconneSQL);

//    //var plantSql = plantDAO.GetPlantDetails();  //Get SQL
//    // sqlCount = plantSql.Count;

//    //  var plantSql = plantDAO.GetsqlParameterSensorData();
//    // sqlCount = plantSql.Count;


//    var plantSql = plantDAO.GetsqlParameterTool();
//    sqlCount = plantSql.Count;

//    //  var plantSql = plantDAO.GetsqlParameterMaster();
//    //  sqlCount = plantSql.Count;

//    #endregion

//    IntoFile("Sql list count" + plantSql.Count);

//    var ddlids = MysqlData.Select(m => m.parameterToolDataId).ToList();  //my sql tbl IDs 
//    IntoFile("sql IDs Count" + ddlids.Count);


//    var det = plantSql.Where(m => !ddlids.Contains(m.parameterToolDataId)).ToList();
//    var res7 = det.ToList();
//    IntoFile("Start_ddl Except SQL data:" + res7.Count);
//    if (res7.Count > 0)
//    {
//        //  resultsu = await srksMysql.insertPlnatinMYsql(res7);


//        // resultsu = await srksMysql.insert_ddlMysqlPlant(res7);


//        //  List<parameterMasterEntity> mysqlPlant = new  List<parameterMasterEntity>();

//        List<paraToolData> mysqlPlant = new List<paraToolData>();


//        foreach (var row in res7)
//        {




//            paraToolData dlist = new paraToolData();

//            dlist.parameterToolDataId = row.parameterToolDataId;
//            dlist.machineId = row.machineId;
//            dlist.parameterToolDataCapturedDate = row.parameterToolDataCapturedDate;
//            dlist.toolGroupName = row.toolGroupName;
//            dlist.toolNumber = row.toolNumber;

//            dlist.capacity = row.capacity;
//            dlist.partsproduced = row.partsproduced;
//            dlist.createdOn = row.createdOn;
//            dlist.isDeleted = row.isDeleted;
//            dlist.correctedDate = row.correctedDate;

//            dlist.correctedDate = row.correctedDate;



//            mysqlPlant.Add(dlist);








//            //parameterMasterEntity dlist = new parameterMasterEntity();

//            //dlist.ParameterID = row.ParameterID;
//            //dlist.SetupTime = row.SetupTime;
//            //dlist.OperatingTime = row.OperatingTime;
//            //dlist.PowerOnTime = row.PowerOnTime;
//            //dlist.PartsCount = row.PartsCount;

//            //dlist.InsertedOn = row.InsertedOn;
//            //dlist.MachineID = row.MachineID;
//            //dlist.Shift = row.Shift;
//            //dlist.CorrectedDate = row.CorrectedDate;
//            //dlist.AutoCutTime = row.AutoCutTime;

//            //dlist.Total_CutTime = row.Total_CutTime;
//            //dlist.PartsTotal = row.PartsTotal;
//            //dlist.CuttingTime = row.CuttingTime;
//            //dlist.AutoMode = row.AutoMode;



//            //mysqlPlant.Add(dlist);

//        }


//        // resultsu = await srksMysql.insert_ddlMysqlPlantMysql(mysqlPlant);


//        //resultsu = await srksMysql.insert_IOTgate(mysqlPlant);

//        // resultsu = await srksMysql.insert_paraSensorData(mysqlPlant);

//        resultsu = await srksMysql.insert_paraTooldata(mysqlPlant);

//        // resultsu = await srksMysql.insert_paraMaster(mysqlPlant);


//        //  resultsu = await srksMysql.insert_paraMaster(mysqlPlant);
//        //  resultsu = await plantDAO.insert_ddlMysqlPlantSQl(res7); 

//        IntoFile("inserted Successfully");


//    }
//    return resultsu;
//}
///

///para tool

//public async Task<int> SQL_to_Mysql()
//{
//    IntoFile("SQL_to_Mysql");
//    int resultsu = 0;


//    #region   My sql Connection
//    //mysql data
//    MyDAL.ConnectionFactory con = new MyDAL.ConnectionFactory();
//    MyDAL.IConnectionFactory _iconne;

//    SRKSDAO srksMysql = new SRKSDAO();
//    _iconne = new MyDAL.ConnectionFactory();
//    srksMysql = new SRKSDAO(_iconne);


//    //plant

//    // var MysqlData = srksMysql.getplant();   //2,3
//    // int countList = MysqlData.Count();


//    //IOTGateWay
//    //var MysqlData = srksMysql.getIOTGate();   
//    //int countList = MysqlData.Count();

//    //Parameter MasterSensor Data
//    // var MysqlData = srksMysql.getParameterMasterSensorData();
//    // int countList = MysqlData.Count();


//    // var MysqlData = srksMysql.getParameterTool();
//    // int countList = MysqlData.Count();

//    var MysqlData = srksMysql.getParameterMaster();
//    int countList = MysqlData.Count();



//    #endregion


//    #region M S SQL connection

//    //sql data

//    SQLDAL.ConnectionFactory conSql = new SQLDAL.ConnectionFactory();
//    SQLDAL.IConnectionFactory _iconneSQL;

//    SQLDAO plantDAO = new SQLDAO();

//    _iconneSQL = new SQLDAL.ConnectionFactory();
//    plantDAO = new SQLDAO(_iconneSQL);

//    //var plantSql = plantDAO.GetPlantDetails();  //Get SQL
//    // sqlCount = plantSql.Count;

//    // var plantSql = plantDAO.GetsqlParameterSensorData();
//    // sqlCount = plantSql.Count;


//    // var plantSql = plantDAO.GetsqlParameterTool();
//    //sqlCount = plantSql.Count;

//    var plantSql = plantDAO.GetsqlParameterMaster();
//    sqlCount = plantSql.Count;

//    #endregion

//    IntoFile("Sql list count" + plantSql.Count);

//    var ddlids = MysqlData.Select(m => m.parameterToolDataId).ToList();  //my sql tbl IDs 
//    IntoFile("sql IDs Count" + ddlids.Count);


//    var det = plantSql.Where(m => !ddlids.Contains(m.parameterToolDataId)).ToList();
//    var res7 = det.ToList();
//    IntoFile("Start_ddl Except SQL data:" + res7.Count);
//    if (res7.Count > 0)
//    {
//        //  resultsu = await srksMysql.insertPlnatinMYsql(res7);


//        // resultsu = await srksMysql.insert_ddlMysqlPlant(res7);


//        List<paraToolData> mysqlPlant = new List<paraToolData>();


//        foreach (var row in res7)
//        {



//            paraToolData dlist = new paraToolData();

//            dlist.parameterToolDataId = row.parameterToolDataId;
//            dlist.machineId = row.machineId;
//            dlist.parameterToolDataCapturedDate = row.parameterToolDataCapturedDate;
//            dlist.toolGroupName = row.toolGroupName;
//            dlist.toolNumber = row.toolNumber;

//            dlist.capacity = row.capacity;
//            dlist.partsproduced = row.partsproduced;
//            dlist.createdOn = row.createdOn;
//            dlist.isDeleted = row.isDeleted;
//            dlist.correctedDate = row.correctedDate;

//            dlist.correctedDate = row.correctedDate;


//            mysqlPlant.Add(dlist);

//        }


//        // resultsu = await srksMysql.insert_ddlMysqlPlantMysql(mysqlPlant);


//        //resultsu = await srksMysql.insert_IOTgate(mysqlPlant);

//        // resultsu = await srksMysql.insert_paraSensorData(mysqlPlant);

//        resultsu = await srksMysql.insert_paraTooldata(mysqlPlant);

//        //  resultsu = await srksMysql.insert_paraMaster(mysqlPlant);
//        //  resultsu = await plantDAO.insert_ddlMysqlPlantSQl(res7); 

//        IntoFile("inserted Successfully");


//    }
//    return resultsu;
//}

///


///
//ParameterMaster Sensor data
//public async Task<int> SQL_to_Mysql()
//{
//    IntoFile("SQL_to_Mysql");
//    int resultsu = 0;


//    #region   My sql Connection
//    //mysql data
//    MyDAL.ConnectionFactory con = new MyDAL.ConnectionFactory();
//    MyDAL.IConnectionFactory _iconne;

//    SRKSDAO srksMysql = new SRKSDAO();
//    _iconne = new MyDAL.ConnectionFactory();
//    srksMysql = new SRKSDAO(_iconne);


//    //plant

//    // var MysqlData = srksMysql.getplant();   //2,3
//    // int countList = MysqlData.Count();


//    //IOTGateWay
//    //var MysqlData = srksMysql.getIOTGate();   
//    //int countList = MysqlData.Count();

//    //Parameter MasterSensor Data
//    var MysqlData = srksMysql.getParameterMasterSensorData();
//    int countList = MysqlData.Count();


//    #endregion


//    #region M S SQL connection

//    //sql data

//    SQLDAL.ConnectionFactory conSql = new SQLDAL.ConnectionFactory();
//    SQLDAL.IConnectionFactory _iconneSQL;

//    SQLDAO plantDAO = new SQLDAO();

//    _iconneSQL = new SQLDAL.ConnectionFactory();
//    plantDAO = new SQLDAO(_iconneSQL);

//    //var plantSql = plantDAO.GetPlantDetails();  //Get SQL
//    // sqlCount = plantSql.Count;

//    var plantSql = plantDAO.GetsqlParameterSensorData();
//    sqlCount = plantSql.Count;

//    #endregion

//    IntoFile("Sql list count" + plantSql.Count);

//    var ddlids = MysqlData.Select(m => m.parameterSensorDataId).ToList();  //my sql tbl IDs 
//    IntoFile("sql IDs Count" + ddlids.Count);


//    var det = plantSql.Where(m => !ddlids.Contains(m.parameterSensorDataId)).ToList();
//    var res7 = det.ToList();
//    IntoFile("Start_ddl Except SQL data:" + res7.Count);
//    if (res7.Count > 0)
//    {
//        //  resultsu = await srksMysql.insertPlnatinMYsql(res7);


//        // resultsu = await srksMysql.insert_ddlMysqlPlant(res7);


//        List<ParameterMasterSensorData> mysqlPlant = new List<ParameterMasterSensorData>();


//        foreach (var row in res7)
//        {



//            ParameterMasterSensorData dlist = new ParameterMasterSensorData();
//            dlist.parameterSensorDataId = row.parameterSensorDataId;
//            dlist.machineId = row.machineId;
//            dlist.sensorDataCapturedTime = row.sensorDataCapturedTime;
//            dlist.isDeleted = row.isDeleted;
//            dlist.createdOn = row.createdOn;

//            dlist.correctedDate = row.correctedDate;


//            mysqlPlant.Add(dlist);

//        }


//        // resultsu = await srksMysql.insert_ddlMysqlPlantMysql(mysqlPlant);


//        //resultsu = await srksMysql.insert_IOTgate(mysqlPlant);

//        resultsu = await srksMysql.insert_paraSensorData(mysqlPlant);



//        //  resultsu = await plantDAO.insert_ddlMysqlPlantSQl(res7); 

//        IntoFile("inserted Successfully");


//    }
//    return resultsu;
//}

///

//IOTGATEWAY

//public async Task<int> SQL_to_Mysql()
//{
//    IntoFile("SQL_to_Mysql");
//    int resultsu = 0;


//    #region   My sql Connection
//    //mysql data
//    MyDAL.ConnectionFactory con = new MyDAL.ConnectionFactory();
//    MyDAL.IConnectionFactory _iconne;

//    SRKSDAO srksMysql = new SRKSDAO();
//    _iconne = new MyDAL.ConnectionFactory();
//    srksMysql = new SRKSDAO(_iconne);


//    //plant

//    // var MysqlData = srksMysql.getplant();   //2,3
//    // int countList = MysqlData.Count();


//    //IOTGateWay
//    var MysqlData = srksMysql.getIOTGate();
//    int countList = MysqlData.Count();





//    #endregion



//    #region M S SQL connection

//    //sql data

//    SQLDAL.ConnectionFactory conSql = new SQLDAL.ConnectionFactory();
//    SQLDAL.IConnectionFactory _iconneSQL;

//    SQLDAO plantDAO = new SQLDAO();

//    _iconneSQL = new SQLDAL.ConnectionFactory();
//    plantDAO = new SQLDAO(_iconneSQL);

//    //var plantSql = plantDAO.GetPlantDetails();  //Get SQL
//    // sqlCount = plantSql.Count;

//    var plantSql = plantDAO.GetIotgate();  //Get SQL
//    sqlCount = plantSql.Count;

//    #endregion

//    IntoFile("Sql list count" + plantSql.Count);

//    var ddlids = MysqlData.Select(m => m.GatewayMsgID).ToList();  //my sql tbl IDs 
//    IntoFile("sql IDs Count" + ddlids.Count);


//    var det = plantSql.Where(m => !ddlids.Contains(m.GatewayMsgID)).ToList();
//    var res7 = det.ToList();
//    IntoFile("Start_ddl Except SQL data:" + res7.Count);
//    if (res7.Count > 0)
//    {
//        //  resultsu = await srksMysql.insertPlnatinMYsql(res7);


//        // resultsu = await srksMysql.insert_ddlMysqlPlant(res7);


//        List<IOTGatewayEntity> mysqlPlant = new List<IOTGatewayEntity>();


//        foreach (var row in res7)
//        {
//            IOTGatewayEntity dlist = new IOTGatewayEntity();
//            dlist.GatewayMsgID = row.GatewayMsgID;
//            dlist.SOF = row.SOF;
//            dlist.SiteId = row.SiteId;
//            dlist.UnitId = row.UnitId;
//            dlist.PacketType = row.PacketType;

//            dlist.Time = row.Time;
//            dlist.Date = row.Date;
//            dlist.IPAddres = row.IPAddres;
//            dlist.ProductSerialNo = row.ProductSerialNo;
//            dlist.SWversion = row.SWversion;

//            dlist.NumOfNodeDetected = row.NumOfNodeDetected;
//            dlist.NumOfNodeActive = row.NumOfNodeActive;
//            dlist.NodeId = row.NodeId;
//            dlist.NodeCommunication = row.NodeCommunication;
//            dlist.NodePayLoadLength = row.NodePayLoadLength;

//            dlist.NodeDataPayLoad = row.NodeDataPayLoad;
//            dlist.EOF = row.EOF;
//            dlist.IOTGateWayMsg = row.IOTGateWayMsg;
//            dlist.CorrectedDate = row.CorrectedDate;
//            dlist.TypeOfDevice = row.TypeOfDevice;

//            dlist.DevicePayLoadLength = row.DevicePayLoadLength;
//            dlist.AlaramInput1_16 = row.AlaramInput1_16;
//            dlist.AlaramInput2_17 = row.AlaramInput2_17;
//            dlist.CorrectedDate = row.CorrectedDate;
//            dlist.TypeOfDevice = row.TypeOfDevice;


//            dlist.DevicePayLoadLength = row.DevicePayLoadLength;
//            dlist.AlaramInput1_16 = row.AlaramInput1_16;
//            dlist.AlaramInput2_17 = row.AlaramInput2_17;
//            dlist.AlaramInput3_18 = row.AlaramInput3_18;
//            dlist.AlaramInput4_19 = row.AlaramInput4_19;
//            dlist.AlaramInput5_20 = row.AlaramInput5_20;
//            dlist.AlaramInput6_22 = row.AlaramInput6_22;
//            dlist.AlaramInput7_23 = row.AlaramInput7_23;
//            dlist.AlaramInput8_24 = row.AlaramInput8_24;
//            dlist.Reserved = row.Reserved;

//            dlist.RelayFeedbak1Status = row.RelayFeedbak1Status;
//            dlist.RelayFeedbak2Status = row.RelayFeedbak2Status;
//            dlist.RelayFeedbak3Status = row.RelayFeedbak3Status;
//            dlist.RelayFeedbak4Status = row.RelayFeedbak4Status;


//            dlist.CreatedOn = row.CreatedOn;









//            dlist.Time = row.Time;

//            mysqlPlant.Add(dlist);

//        }


//        // resultsu = await srksMysql.insert_ddlMysqlPlantMysql(mysqlPlant);


//        resultsu = await srksMysql.insert_IOTgate(mysqlPlant);


//        //  resultsu = await plantDAO.insert_ddlMysqlPlantSQl(res7); 

//        IntoFile("inserted Successfully");


//    }
//    return resultsu;
//}




















//  delete_ddl();


// Update_ddl();

//Timer MyTimer = new Timer();
////MyTimer1.Interval = (60 * 1000 * 5); //5 min       
//MyTimer.Interval = (60 * 1000 * 10); //10 min
//MyTimer.Enabled = true;
//MyTimer.Tick += new EventHandler(MyTimer_Tick);
//MyTimer.Start();

//Timer MyTimer1 = new Timer();
////MyTimer1.Interval = (60 * 1000 * 5); //5 min       
//MyTimer1.Interval = (10*1000*60); //2 min
//MyTimer1.Enabled = true;
//MyTimer1.Tick += new EventHandler(MyTimer_Tick1);
//MyTimer1.Start();

//Timer MyTimer2 = new Timer();
////MyTimer1.Interval = (60 * 1000 * 5); //5 min       
//MyTimer1.Interval = (60 * 1000); //1 min
//MyTimer1.Enabled = true;
//MyTimer1.Tick += new EventHandler(MyTimer_Tick2);
//MyTimer1.Start();

//var livelossMysql1 = obddlmysql.ddllistmysql1(); // MYSQL
//IntoFile("Mysql list count" + ddllistSQL.Count);
//MysqlCount = livelossMysql1.Count;





//SQLDAO objddlsql = new SQLDAO();
//var ddllistSQL = objddlsql.ddllistsql();  //Get SQL
//sqlCount = ddllistSQL.Count;

//IntoFile("Sql list count" + ddllistSQL.Count);

//var ddlids = ddllistSQL.Select(m => m.DDLID).ToList();  //SQL IDs 
//IntoFile("sql IDs Count" + ddlids.Count);

//MYSQLDAO obddlmysql = new MYSQLDAO();


//foreach (var rr in res7)
//{

//   // srksMysql.insertPlnatinMYsql1(rr.PlantName,rr.PlantDesc,rr.IsDeleted,rr.CreatedOn,rr.CreatedBy,rr.PlantDisplayName);

//    srksMysql.insertPlnatinMYsql2(rr.PlantName, rr.PlantDesc, rr.IsDeleted, rr.CreatedOn, rr.CreatedBy, rr.PlantDisplayName, rr.PlantID);



//    IntoFile("inserted Successfully");

//}










//public async Task<int> delete_ddl()
//{
//    IntoFile("delete_ddl");
//    int resultsu = 0;                                                  //get sql n mysql data lists
//    SQLDAO objddlsql = new SQLDAO();
//    var ddllistSQL = objddlsql.ddllistsql();
//    IntoFile("Sql list count" + ddllistSQL.Count);
//    MYSQLDAO obddlmysql = new MYSQLDAO();
//                                                                     //get primarykey ID list from sql database

//    var livelossMysql = obddlmysql.ddllistmysql1();

//    var ddlids = livelossMysql.Select(m => m.DDLID).ToList();
//    IntoFile("Mysql IDs Count" + livelossMysql.Count);
//    //deleting the records which is not present in Mysql
//    List<MySQLDAL.tblddl> res7 = ddllistSQL.Where(m => !ddlids.Contains(m.DDLID)).ToList();  // Mysql.where(sql ids needs compare)
//    IntoFile("sql records which is not in mysql" + res7.Count);
//    if (res7.Count > 0)
//    {
//        resultsu = await objddlsql.delete_ddlistsql(res7);
//        IntoFile("delete Successfully");
//    }
//    return resultsu;
//}

//public async Task<int> Update_ddl()
//{
//    IntoFile("Update_ddl");
//    int resultsu = 0;
//    SQLDAO objddlsql = new SQLDAO();
//    var ddllistSQL = objddlsql.ddllistsql1();
//    IntoFile("Sql iscompleted 0 list" + ddllistSQL.Count);
//    MYSQLDAO obddlmysql = new MYSQLDAO();
//    List<int> livelossMysql = obddlmysql.ddllistmysql2().Select(m => m.DDLID).ToList();
//    IntoFile("Mysql iscompleted 1 list" + livelossMysql.Count);

//    List<int> ddlidlist = ddllistSQL.Where(m => livelossMysql.Contains(m.DDLID)).Select(m=>m.DDLID).ToList();
//    IntoFile("sql records which is not in mysql" + ddlidlist.Count);
//    //deleting the records which is not present in Mysql
//    if (ddlidlist.Count > 0)
//    {
//        resultsu = await objddlsql.Update_ddlistsql(ddlidlist);
//        IntoFile("Update Successfully");
//    }
//    return resultsu;
//}





///////////////////////////////////////////////////





//private void Form1_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
//{
//    // if not restarting the uncomment the line of code which is now commented
//    //System.Diagnostics.Process.Start(Application.StartupPath);
//    Application.Restart();
//}
//private void MyTimer_Tick(object sender, EventArgs e)
//{
//    try
//    {
//        //pageloadhistory();
//        LossLoad2();
//    }
//    catch (Exception ex)
//    {
//        MessageBox.Show(ex.ToString());
//    }
//}

//private void MyTimer_Tick1(object sender, EventArgs e)
//{
//    try
//    {
//        //pageloadhistory();
//        LossLoad();
//    }
//    catch (Exception ex)
//    {
//        MessageBox.Show(ex.ToString());
//    }
//}

//private void MyTimer_Tick2(object sender, EventArgs e)
//{
//    try
//    {
//        //pageloadhistory();
//        LossLoad1();
//    }
//    catch (Exception ex)
//    {
//        MessageBox.Show(ex.ToString());
//    }
//}
//private async void LossLoad2()
//{
//    delete_ddl();
//}

//private async void LossLoad()
//{
//     start_ddl().Wait();
//}

//private async void LossLoad1()
//{
//      await Update_ddl();
//    //await delete_ddl();
//}








//////////////////////////////////////////////////
///

//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using MySQLDAL;
//using MyDAL;
//using MyDAL.Model;
//using System.IO;
////using System.Data.MySqlClient;

//namespace migration
//{
//    public partial class Form1 : Form
//    {
//        public int MysqlCount = 0;
//        public int sqlCount = 0;
//        public Form1()
//        {

//            InitializeComponent();
//            try

//            {
//                delete_ddl();
//                start_ddl().Wait();
//                Update_ddl();

//                Timer MyTimer = new Timer();
//                //MyTimer1.Interval = (60 * 1000 * 5); //5 min       
//                MyTimer.Interval = (60 * 1000 * 10); //10 min
//                MyTimer.Enabled = true;
//                MyTimer.Tick += new EventHandler(MyTimer_Tick);
//                MyTimer.Start();

//                Timer MyTimer1 = new Timer();
//                //MyTimer1.Interval = (60 * 1000 * 5); //5 min       
//                MyTimer1.Interval = (10 * 1000 * 60); //2 min
//                MyTimer1.Enabled = true;
//                MyTimer1.Tick += new EventHandler(MyTimer_Tick1);
//                MyTimer1.Start();

//                Timer MyTimer2 = new Timer();
//                //MyTimer1.Interval = (60 * 1000 * 5); //5 min       
//                MyTimer1.Interval = (60 * 1000); //1 min
//                MyTimer1.Enabled = true;
//                MyTimer1.Tick += new EventHandler(MyTimer_Tick2);
//                MyTimer1.Start();
//            }
//            catch (Exception e)
//            {

//            }
//        }

//        //private void Form1_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
//        //{
//        //    // if not restarting the uncomment the line of code which is now commented
//        //    //System.Diagnostics.Process.Start(Application.StartupPath);
//        //    Application.Restart();
//        //}
//        private void MyTimer_Tick(object sender, EventArgs e)
//        {
//            try
//            {
//                //pageloadhistory();
//                LossLoad2();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.ToString());
//            }
//        }

//        private void MyTimer_Tick1(object sender, EventArgs e)
//        {
//            try
//            {
//                //pageloadhistory();
//                LossLoad();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.ToString());
//            }
//        }

//        private void MyTimer_Tick2(object sender, EventArgs e)
//        {
//            try
//            {
//                //pageloadhistory();
//                LossLoad1();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.ToString());
//            }
//        }
//        private async void LossLoad2()
//        {
//            delete_ddl();
//        }

//        private async void LossLoad()
//        {
//            start_ddl().Wait();
//        }

//        private async void LossLoad1()
//        {
//            await Update_ddl();
//            //await delete_ddl();
//        }

//        public async Task<int> start_ddl()
//        {
//            IntoFile("Start_ddl");
//            int resultsu = 0;
//            SQLDAO objddlsql = new SQLDAO();
//            var ddllistSQL = objddlsql.ddllistsql();  //Get SQL
//            sqlCount = ddllistSQL.Count;
//            IntoFile("Sql list count" + ddllistSQL.Count);
//            var ddlids = ddllistSQL.Select(m => m.DDLID).ToList();  //SQL IDs 
//            IntoFile("sql IDs Count" + ddlids.Count);
//            MYSQLDAO obddlmysql = new MYSQLDAO();

//            var livelossMysql1 = obddlmysql.ddllistmysql1(); // MYSQL
//            IntoFile("Mysql list count" + ddllistSQL.Count);
//            MysqlCount = livelossMysql1.Count;

//            var det = livelossMysql1.Where(m => !ddlids.Contains(m.DDLID)).ToList();
//            var res7 = det.ToList();
//            IntoFile("Start_ddl Except SQL data:" + res7.Count);
//            if (res7.Count > 0)
//            {
//  resultsu = await objddlsql.insert_ddlistsql(res7);
//                IntoFile("inserted Successfully");
//            }
//            return resultsu;
//        }

//        public async Task<int> delete_ddl()
//        {
//            IntoFile("delete_ddl");
//            int resultsu = 0;                                                  //get sql n mysql data lists
//            SQLDAO objddlsql = new SQLDAO();
//            var ddllistSQL = objddlsql.ddllistsql();
//            IntoFile("Sql list count" + ddllistSQL.Count);
//            MYSQLDAO obddlmysql = new MYSQLDAO();
//            //get primarykey ID list from sql database

//            var livelossMysql = obddlmysql.ddllistmysql1();

//            var ddlids = livelossMysql.Select(m => m.DDLID).ToList();
//            IntoFile("Mysql IDs Count" + livelossMysql.Count);
//            //deleting the records which is not present in Mysql
//            List<MySQLDAL.tblddl> res7 = ddllistSQL.Where(m => !ddlids.Contains(m.DDLID)).ToList();  // Mysql.where(sql ids needs compare)
//            IntoFile("sql records which is not in mysql" + res7.Count);
//            if (res7.Count > 0)
//            {
//                resultsu = await objddlsql.delete_ddlistsql(res7);
//                IntoFile("delete Successfully");
//            }
//            return resultsu;
//        }

//        public async Task<int> Update_ddl()
//        {
//            IntoFile("Update_ddl");
//            int resultsu = 0;
//            SQLDAO objddlsql = new SQLDAO();
//            var ddllistSQL = objddlsql.ddllistsql1();
//            IntoFile("Sql iscompleted 0 list" + ddllistSQL.Count);
//            MYSQLDAO obddlmysql = new MYSQLDAO();
//            List<int> livelossMysql = obddlmysql.ddllistmysql2().Select(m => m.DDLID).ToList();
//            IntoFile("Mysql iscompleted 1 list" + livelossMysql.Count);

//            List<int> ddlidlist = ddllistSQL.Where(m => livelossMysql.Contains(m.DDLID)).Select(m => m.DDLID).ToList();
//            IntoFile("sql records which is not in mysql" + ddlidlist.Count);
//            //deleting the records which is not present in Mysql
//            if (ddlidlist.Count > 0)
//            {
//                resultsu = await objddlsql.Update_ddlistsql(ddlidlist);
//                IntoFile("Update Successfully");
//            }
//            return resultsu;
//        }
//        public void IntoFile(string Msg)
//        {
//            string path1 = AppDomain.CurrentDomain.BaseDirectory;
//            string appPath = Application.StartupPath + @"\TataDDLLogFile.txt";
//            using (StreamWriter writer = new StreamWriter(appPath, true)) //true => Append Text
//            {
//                writer.WriteLine(System.DateTime.Now + ":  " + Msg);
//            }
//        }


//    }

//}
