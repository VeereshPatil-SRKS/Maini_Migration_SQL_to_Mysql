using Dapper;
using MyDAL.DAL;
using MyDAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using System.Configuration;
using MySql.Data.MySqlClient;


using MyDAL.DAO;

namespace MyDAL.DAO
{
    public class SRKSDAO                  /* ConnectionFactory*/
    {
        IConnectionFactory _connectionFactory;
        public SRKSDAO()
        {

        }

        public SRKSDAO(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        
        public List<configuration_tblplant> getplant()
        {
            

            List<configuration_tblplant> plantList = new List<configuration_tblplant>();
            try
            {

                

                string qry = "SELECT * From  " + ConnectionFactory.DBCon + "." + "tblplant WHERE IsDeleted = 0";
                plantList = _connectionFactory.GetConnection.QueryAsync<configuration_tblplant>(qry).Result.ToList();

               


                //string qry = "SELECT Project1.LossID, Project1.MessageCodeID, Project1.StartDateTime, Project1.EndDateTime, Project1.EntryTime, Project1.CorrectedDate, Project1.MachineID, Project1.Shift, Project1.MessageDesc, Project1.MessageCode, Project1.IsUpdate, Project1.DoneWithRow, Project1.IsStart, Project1.IsScreen, Project1.ForRefresh, Project1.LossCodeID, Project1.LossCode, Project1.LossCodeDesc, Project1.MessageType, Project1.LossCodesLevel, Project1.LossCodesLevel1ID, Project1.LossCodesLevel2ID, Project1.ContributeTo, Project1.IsDeleted, Project1.CreatedOn, Project1.CreatedBy, Project1.ModifiedOn, Project1.ModifiedBy, Project1.EndCode, Project1.DeletedDate FROM(SELECT Extent1.LossID, Extent1.MessageCodeID, Extent1.StartDateTime, Extent1.EndDateTime, Extent1.EntryTime, Extent1.CorrectedDate, Extent1.MachineID, Extent1.Shift, Extent1.MessageDesc, Extent1.MessageCode, Extent1.IsUpdate, Extent1.DoneWithRow, Extent1.IsStart, Extent1.IsScreen, Extent1.ForRefresh, Extent2.LossCodeID, Extent2.LossCode, Extent2.LossCodeDesc, Extent2.MessageType, Extent2.LossCodesLevel, Extent2.LossCodesLevel1ID, Extent2.LossCodesLevel2ID, Extent2.ContributeTo, Extent2.IsDeleted, Extent2.CreatedOn, Extent2.CreatedBy, Extent2.ModifiedOn, Extent2.ModifiedBy, Extent2.EndCode, Extent2.DeletedDate FROM " + databaseName + ".[tbllivelossofentry] AS Extent1 INNER JOIN " + databaseName + ".[tbllossescodes] AS Extent2 ON Extent1.MessageCodeID = Extent2.LossCodeID WHERE(Extent1.MachineID =" + MachineID + "AND Extent1.CorrectedDate ='" + CorrectedDate + "'AND Extent1.DoneWithRow = 1)) AS Project1 ORDER BY Project1.StartDateTime DESC";
             //   return plantList.GetList(qry, _connectionFactory.GetConnection);



                //machinelist = await Task.FromResult<List<configurationtblmachinedetail>>(_connectionFactory.GetConnectionConfig.QueryAsync<configurationtblmachinedetail>(qry).Result.ToList());


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return plantList;
        }
        public List<IOTGatewayEntity> getIOTGate()
        {


            List<IOTGatewayEntity> plantList = new List<IOTGatewayEntity>();
            try
            {

                string qry = "SELECT * From  " + ConnectionFactory.DBCon + "." + "`unitworkccs.iotgatwaypacketsdata`";
                plantList = _connectionFactory.GetConnection.QueryAsync<IOTGatewayEntity>(qry).Result.ToList();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return plantList;
        }

        public List<ParameterMasterSensorData> getParameterMasterSensorData()
        {


            List<ParameterMasterSensorData> plantList = new List<ParameterMasterSensorData>();
            try
            {

                string qry = "SELECT * From  " + ConnectionFactory.DBCon + "." + "`unitworkccs.parameter_sendor_data`";
                plantList = _connectionFactory.GetConnection.QueryAsync<ParameterMasterSensorData>(qry).Result.ToList();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return plantList;
        }

        public List<paraToolData> getParameterTool()
        {


            List<paraToolData> plantList = new List<paraToolData>();
            try
            {

                string qry = "SELECT * From  " + ConnectionFactory.DBCon + "." + "`unitworkccs.parameter_tool_data`";
                plantList = _connectionFactory.GetConnection.QueryAsync<paraToolData>(qry).Result.ToList();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return plantList;
        }

        public List<parameterMasterEntity> getParameterMaster()
        {


            List<parameterMasterEntity> plantList = new List<parameterMasterEntity>();
            try
            {

                string qry = "SELECT * From  " + ConnectionFactory.DBCon + "." + "`unitworkccs.parameters_master`";
                plantList = _connectionFactory.GetConnection.QueryAsync<parameterMasterEntity>(qry).Result.ToList();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return plantList;
        }


        public List<pcbdaqinTblEntiyt> getpcbdaqin_tbl()
        {


            List<pcbdaqinTblEntiyt> plantList = new List<pcbdaqinTblEntiyt>();
            try
            {

                string qry = "SELECT * From  " + ConnectionFactory.DBCon + "." + "`unitworkccs.pcbdaqin_tbl`";
                plantList = _connectionFactory.GetConnection.QueryAsync<pcbdaqinTblEntiyt>(qry).Result.ToList();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return plantList;
        }


        public List<Axisdetails1Entity> getAxisdetails1()
        {


            List<Axisdetails1Entity> plantList = new List<Axisdetails1Entity>();
            try
            {

                string qry = "SELECT * From  " + ConnectionFactory.DBCon + "." + "`unitworkccs.tbl_axisdetails1`";
                plantList = _connectionFactory.GetConnection.QueryAsync<Axisdetails1Entity>(qry).Result.ToList();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return plantList;
        }

        public List<Adixdetails2Entity> getAxisdetails2()
        {


            List<Adixdetails2Entity> plantList = new List<Adixdetails2Entity>();
            try
            {

                string qry = "SELECT * From  " + ConnectionFactory.DBCon + "." + "`unitworkccs.tbl_axisdetails2`";
                plantList = _connectionFactory.GetConnection.QueryAsync<Adixdetails2Entity>(qry).Result.ToList();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return plantList;
        }


        public List<partsAndCuuting> gettblpartscountandcutting()
        {


            List<partsAndCuuting> plantList = new List<partsAndCuuting>();
            try
            {

                string qry = "SELECT * From  " + ConnectionFactory.DBCon + "." + "`unitworkccs.tblpartscountandcutting`";
                plantList = _connectionFactory.GetConnection.QueryAsync<partsAndCuuting>(qry).Result.ToList();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return plantList;
        }

        public List<LiveModeentity> gettblLiveMode()
        {


            List<LiveModeentity> plantList = new List<LiveModeentity>();
            try
            {

                string qry = "SELECT * From  " + ConnectionFactory.DBCon + "." + "`unitworkccs.tbllivemode`";
                plantList = _connectionFactory.GetConnection.QueryAsync<LiveModeentity>(qry).Result.ToList();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return plantList;
        }


        public List<fgpartentity> gettfgpartCellAllow()
        {


            List<fgpartentity> plantList = new List<fgpartentity>();
            try
            {

                string qry = "SELECT * From  " + ConnectionFactory.DBCon + "." + "`unitworkccs.tblfgandcellallocation`";
                plantList = _connectionFactory.GetConnection.QueryAsync<fgpartentity>(qry).Result.ToList();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return plantList;
        }

        public List<defectcodemsasteentity> getDefectCodemaster()
        {


            List<defectcodemsasteentity> plantList = new List<defectcodemsasteentity>();
            try
            {

                string qry = "SELECT * From  " + ConnectionFactory.DBCon + "." + "`unitworkccs.tbldefectcodemaster`";
                plantList = _connectionFactory.GetConnection.QueryAsync<defectcodemsasteentity>(qry).Result.ToList();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return plantList;
        }


        public List<ChildFgPartNo> gettblChildFgPartNo()
        {


            List<ChildFgPartNo> plantList = new List<ChildFgPartNo>();
            try
            {

                string qry = "SELECT * From  " + ConnectionFactory.DBCon + "." + "`unitworkccs.tblChildFgPartNo`";
                plantList = _connectionFactory.GetConnection.QueryAsync<ChildFgPartNo>(qry).Result.ToList();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return plantList;
        }


        public List<utilreportE> gettbl_UtilReport()
        {


            List<utilreportE> plantList = new List<utilreportE>();
            try
            {

                string qry = "SELECT * From  " + ConnectionFactory.DBCon + "." + "`unitworkccs.tbl_utilreport`";
                plantList = _connectionFactory.GetConnection.QueryAsync<utilreportE>(qry).Result.ToList();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return plantList;
        }



        public List<tblbreakdowncodesE> gettbl_tblbreakdowncodes()
        {


            List<tblbreakdowncodesE> plantList = new List<tblbreakdowncodesE>();
            try
            {

                string qry = "SELECT * From  " + ConnectionFactory.DBCon + "." + "`unitworkccs.tblbreakdowncodes`";
                plantList = _connectionFactory.GetConnection.QueryAsync<tblbreakdowncodesE>(qry).Result.ToList();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return plantList;
        }

        public List<tblpriorityalarmsE> gettbl_tblpriorityalarms()
        {


            List<tblpriorityalarmsE> plantList = new List<tblpriorityalarmsE>();
            try
            {

                string qry = "SELECT * From  " + ConnectionFactory.DBCon + "." + "`unitworkccs.tblpriorityalarms`";
                plantList = _connectionFactory.GetConnection.QueryAsync<tblpriorityalarmsE>(qry).Result.ToList();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return plantList;
        }


        public List<alarm_history_masterE> getalarm_history_master()
        {


            List<alarm_history_masterE> plantList = new List<alarm_history_masterE>();
            try
            {

                string qry = "SELECT * From  " + ConnectionFactory.DBCon + "." + "`unitworkccs.alarm_history_master`";
                plantList = _connectionFactory.GetConnection.QueryAsync<alarm_history_masterE>(qry).Result.ToList();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return plantList;
        }

        public List<tblfgpartnodetE> gettblfgpartnodet()
        {


            List<tblfgpartnodetE> plantList = new List<tblfgpartnodetE>();
            try
            {

                string qry = "SELECT * From  " + ConnectionFactory.DBCon + "." + "`unitworkccs.tblfgpartnodet`";
                plantList = _connectionFactory.GetConnection.QueryAsync<tblfgpartnodetE>(qry).Result.ToList();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return plantList;
        }
        public List<tbl_prodmanmachineE> gettbl_prodmanmachine()
        {


            List<tbl_prodmanmachineE> plantList = new List<tbl_prodmanmachineE>();
            try
            {

                string qry = "SELECT * From  " + ConnectionFactory.DBCon + "." + "`unitworkccs.tbl_prodmanmachine`";
                plantList = _connectionFactory.GetConnection.QueryAsync<tbl_prodmanmachineE>(qry).Result.ToList();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return plantList;
        }


        public List<tblrejectiondetailsE> gettbl_tblrejectiondetails()
        {


            List<tblrejectiondetailsE> plantList = new List<tblrejectiondetailsE>();
            try
            {

                string qry = "SELECT * From  " + ConnectionFactory.DBCon + "." + "`unitworkccs.tblrejectiondetails`";
                plantList = _connectionFactory.GetConnection.QueryAsync<tblrejectiondetailsE>(qry).Result.ToList();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return plantList;
        }



        public List<configuration_tblprimitivemaintainE_> gettbl_configuration_tblprimitive()
        {


            List<configuration_tblprimitivemaintainE_> plantList = new List<configuration_tblprimitivemaintainE_>();
            try
            {

                string qry = "SELECT * From  " + ConnectionFactory.DBCon + "." + "`unitworkccs.configuration_tblprimitivemaintainancescheduling`";
                plantList = _connectionFactory.GetConnection.QueryAsync<configuration_tblprimitivemaintainE_>(qry).Result.ToList();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return plantList;
        }


        public List<tblsmsdetailsE> gettbl_tblSmsDetails()
        {


            List<tblsmsdetailsE> plantList = new List<tblsmsdetailsE>();
            try
            {

                string qry = "SELECT * From  " + ConnectionFactory.DBCon + "." + "`unitworkccs.tblsmsdetails`";
                plantList = _connectionFactory.GetConnection.QueryAsync<tblsmsdetailsE>(qry).Result.ToList();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return plantList;
        }


        public List<operationlogE> gettbl_operationlog()
        {


            List<operationlogE> plantList = new List<operationlogE>();
            try
            {

                string qry = "SELECT * From  " + ConnectionFactory.DBCon + "." + "`unitworkccs.operationlog`";
                plantList = _connectionFactory.GetConnection.QueryAsync<operationlogE>(qry).Result.ToList();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return plantList;
        }


        public List<tblstoppageE> gettbl_tblstoppage()
        {


            List<tblstoppageE> plantList = new List<tblstoppageE>();
            try
            {

                string qry = "SELECT * From  " + ConnectionFactory.DBCon + "." + "`unitworkccs.tblstoppage`";
                plantList = _connectionFactory.GetConnection.QueryAsync<tblstoppageE>(qry).Result.ToList();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return plantList;
        }

        public List<tblproductwisedefectcodesE> gettbl_tblproductwisedefectcodes()
        {


            List<tblproductwisedefectcodesE> plantList = new List<tblproductwisedefectcodesE>();
            try
            {

                string qry = "SELECT * From  " + ConnectionFactory.DBCon + "." + "`unitworkccs.tblproductwisedefectcodes`";
                plantList = _connectionFactory.GetConnection.QueryAsync<tblproductwisedefectcodesE>(qry).Result.ToList();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return plantList;
        }

        public List<tblmachinedetailsE> gettbl_tblmachinedetails()
        {


            List<tblmachinedetailsE> plantList = new List<tblmachinedetailsE>();
            try
            {

                string qry = "SELECT * From  " + ConnectionFactory.DBCon + "." + "`unitworkccs.tblmachinedetails`";
                plantList = _connectionFactory.GetConnection.QueryAsync<tblmachinedetailsE>(qry).Result.ToList();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return plantList;
        }


        public List<logintrackerdetailsE> gettbl_logintrackerdetails()
        {


            List<logintrackerdetailsE> plantList = new List<logintrackerdetailsE>();
            try
            {

                string qry = "SELECT * From  " + ConnectionFactory.DBCon + "." + "`unitworkccs.logintrackerdetails`";
                plantList = _connectionFactory.GetConnection.QueryAsync<logintrackerdetailsE>(qry).Result.ToList();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return plantList;
        }


        public List<tblpartsE> gettbl_tblparts()
        {


            List<tblpartsE> plantList = new List<tblpartsE>();
            try
            {

                string qry = "SELECT * From  " + ConnectionFactory.DBCon + "." + "`unitworkccs.tblparts`";
                plantList = _connectionFactory.GetConnection.QueryAsync<tblpartsE>(qry).Result.ToList();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return plantList;
        }













        public Task<int> insert_ddlMysqlPlant(List<MyDAL.Model.tblplant> datalist)
        {
            int res = 0;
            List<configuration_tblplant> ddllist = new List<configuration_tblplant>();
            foreach (var row in datalist)
            {
                configuration_tblplant dlist = new configuration_tblplant();
                dlist.PlantID = row.PlantID;
                dlist.PlantName = row.PlantName;
                dlist.PlantDesc = row.PlantDesc;
                dlist.CreatedOn = row.CreatedOn;
                dlist.CreatedBy = row.CreatedBy;

                dlist.IsDeleted = row.IsDeleted;

                ddllist.Add(dlist);

            }
            try
            {
                ConnectionFactory _connectionFactory = new ConnectionFactory();
                string query = "INSERT INTO [unitworksccs].[tblplant](plantId,PlantName,PlantDesc,IsDeleted, CreatedOn, CreatedBy) " +
                    "VALUES(@PlantID,@PlantName,@PlantDesc,@CreatedOn,@CreatedBy)";
                using (var con = _connectionFactory.GetConnection)
                {
                    res = con.Execute(query, ddllist, commandTimeout: 600);
                    con.Close();
                }
            }
            catch (Exception ex)
            {

            }
            return Task.FromResult<int>(res);
        }

        public Task<int> insert_ddlMysqlPlant22(List<tblplant> datalist)
        {
            int res = 0;
            List<configuration_tblplant> ddllist = new List<configuration_tblplant>();
            foreach (var row in datalist)
            {
                configuration_tblplant dlist = new configuration_tblplant();
                dlist.PlantID = row.PlantID;
                dlist.PlantName = row.PlantName;
                dlist.PlantDesc = row.PlantDesc;
                dlist.CreatedOn = row.CreatedOn;
                dlist.CreatedBy = row.CreatedBy;

                dlist.IsDeleted = row.IsDeleted;

                ddllist.Add(dlist);

            }
            try
            {
                ConnectionFactory _connectionFactory = new ConnectionFactory();
                string query = "INSERT INTO [unitworksccs].[tblplant](plantId,PlantName,PlantDesc,IsDeleted, CreatedOn, CreatedBy) " +
                    "VALUES(@PlantID,@PlantName,@PlantDesc,@CreatedOn,@CreatedBy)";
                using (var con = _connectionFactory.GetConnection)
                {
                    res = con.Execute(query, ddllist, commandTimeout: 600);
                    con.Close();
                }
            }
            catch (Exception ex)
            {

            }
            return Task.FromResult<int>(res);
        }

        public Task<int> insert_ddlMysqlPlantMysql(List<configuration_tblplant> datalist)
        {
            int res = 0;
            //List<configuration_tblplant> ddllist = new List<configuration_tblplant>();
            //foreach (var row in datalist)
            //{
            //    configuration_tblplant dlist = new configuration_tblplant();
            //    dlist.PlantID = row.PlantID;
            //    dlist.PlantName = row.PlantName;
            //    dlist.PlantDesc = row.PlantDesc;
            //    dlist.CreatedOn = row.CreatedOn;
            //    dlist.CreatedBy = row.CreatedBy;

            //    dlist.IsDeleted = row.IsDeleted;

            //    ddllist.Add(dlist);

            //}
            try
            {
                ConnectionFactory _connectionFactory = new ConnectionFactory();

                //  string query = "INSERT INTO [unitworksccs].[tblplant](plantId,PlantName,PlantDesc,IsDeleted, CreatedOn, CreatedBy) " +"VALUES(@PlantID,@PlantName,@PlantDesc,@CreatedOn,@CreatedBy)";
                  string query = "INSERT INTO tblplant(plantId,PlantName,PlantDesc,IsDeleted, CreatedOn, CreatedBy) VALUES(@PlantID,@PlantName,@PlantDesc,0,@CreatedOn,@CreatedBy)";
                using (var con = _connectionFactory.GetConnection)
                {
                    res = con.Execute(query, datalist, commandTimeout: 600);
                    con.Close();
                }
            }
            catch (Exception ex)
            {

            }
            return Task.FromResult<int>(res);
        }



        public Task<int> insert_IOTgate(List<IOTGatewayEntity> datalist)
        {
            int res = 0;
            //List<configuration_tblplant> ddllist = new List<configuration_tblplant>();
            //foreach (var row in datalist)
            //{
            //    configuration_tblplant dlist = new configuration_tblplant();
            //    dlist.PlantID = row.PlantID;
            //    dlist.PlantName = row.PlantName;
            //    dlist.PlantDesc = row.PlantDesc;
            //    dlist.CreatedOn = row.CreatedOn;
            //    dlist.CreatedBy = row.CreatedBy;

            //    dlist.IsDeleted = row.IsDeleted;

            //    ddllist.Add(dlist);

            //}
            try
            {
                ConnectionFactory _connectionFactory = new ConnectionFactory();

                //  string query = "INSERT INTO [unitworksccs].[tblplant](plantId,PlantName,PlantDesc,IsDeleted, CreatedOn, CreatedBy) " +"VALUES(@PlantID,@PlantName,@PlantDesc,@CreatedOn,@CreatedBy)";
                string query = "INSERT INTO `unitworkccs.iotgatwaypacketsdata`(GatewayMsgID, SOF, SiteId, UnitId, PacketType, Time, Date, IPAddres, ProductSerialNo, SWversion, NumOfNodeDetected, NumOfNodeActive, NodeId, NodeCommunication, NodePayLoadLength, NodeDataPayLoad, EOF, IOTGateWayMsg, CorrectedDate, TypeOfDevice, DevicePayLoadLength, AlaramInput1_16, AlaramInput2_17, AlaramInput3_18, AlaramInput4_19, AlaramInput5_20, AlaramInput6_22, AlaramInput7_23, AlaramInput8_24, Reserved, RelayFeedbak1Status, RelayFeedbak2Status, RelayFeedbak3Status, RelayFeedbak4Status, CreatedOn) VALUES( @GatewayMsgID,@SOF,@SiteId,@UnitId,@PacketType,@Time,@Date,@IPAddres,@ProductSerialNo,@SWversion,@NumOfNodeDetected,@NumOfNodeActive,@NodeId,@NodeCommunication,@NodePayLoadLength,@NodeDataPayLoad,@EOF,@IOTGateWayMsg,@CorrectedDate,@TypeOfDevice,@DevicePayLoadLength,@AlaramInput1_16,@AlaramInput2_17,@AlaramInput3_18,@AlaramInput4_19,@AlaramInput5_20,@AlaramInput6_22,@AlaramInput7_23,@AlaramInput8_24,@Reserved,@RelayFeedbak1Status,@RelayFeedbak2Status,@RelayFeedbak3Status,@RelayFeedbak4Status,@CreatedOn)";
                using (var con = _connectionFactory.GetConnection)
                {
                    res = con.Execute(query, datalist, commandTimeout: 600);
                    con.Close();
                }
            }
            catch (Exception ex)
            {

            }
            return Task.FromResult<int>(res);
        }



        public Task<int> insert_paraSensorData(List<ParameterMasterSensorData> datalist)
        {
            int res = 0;
           
            try
            {
                ConnectionFactory _connectionFactory = new ConnectionFactory();

                //  string query = "INSERT INTO [unitworksccs].[tblplant](plantId,PlantName,PlantDesc,IsDeleted, CreatedOn, CreatedBy) " +"VALUES(@PlantID,@PlantName,@PlantDesc,@CreatedOn,@CreatedBy)";
                
                string query = "INSERT INTO `unitworkccs.parameter_sendor_data`(parameterSensorDataId,machineId,sensorDataCapturedTime,isDeleted,createdOn,correctedDate) VALUES(  @parameterSensorDataId,@machineId,@sensorDataCapturedTime,@isDeleted,@createdOn,@correctedDate)";
               
               // string query = "INSERT INTO `unitworkccs.parameter_tool_data`(parameterToolDataId,machineId,parameterToolDataCapturedDate,toolGroupName,toolNumber,capacity,partsproduced,createdOn,isDeleted,correctedDate) VALUES( parameterToolDataId,@machineId,@parameterToolDataCapturedDate,@toolGroupName,@toolNumber,@capacity,@partsproduced,@createdOn,@isDeleted,@correctedDate)";



                using (var con = _connectionFactory.GetConnection)
                {
                    res = con.Execute(query, datalist, commandTimeout: 600);
                    con.Close();
                }
            }
            catch (Exception ex)
            {

            }
            return Task.FromResult<int>(res);
        }



        public Task<int> insert_paraTooldata(List<paraToolData> datalist)
        {
            int res = 0;

            try
            {
                ConnectionFactory _connectionFactory = new ConnectionFactory();

                //  string query = "INSERT INTO [unitworksccs].[tblplant](plantId,PlantName,PlantDesc,IsDeleted, CreatedOn, CreatedBy) " +"VALUES(@PlantID,@PlantName,@PlantDesc,@CreatedOn,@CreatedBy)";

                //string query = "INSERT INTO `unitworkccs.parameter_sendor_data`(parameterSensorDataId,machineId,sensorDataCapturedTime,isDeleted,createdOn,correctedDate) VALUES(  @parameterSensorDataId,@machineId,@sensorDataCapturedTime,@isDeleted,@createdOn,@correctedDate)";

                string query = "INSERT INTO `unitworkccs.parameter_tool_data`(parameterToolDataId,machineId,parameterToolDataCapturedDate,toolGroupName,toolNumber,capacity,partsproduced,createdOn,isDeleted,correctedDate) VALUES( @parameterToolDataId,@machineId,@parameterToolDataCapturedDate,@toolGroupName,@toolNumber,@capacity,@partsproduced,@createdOn,@isDeleted,@correctedDate)";



                using (var con = _connectionFactory.GetConnection)
                {
                    res = con.Execute(query, datalist, commandTimeout: 600);
                    con.Close();
                }
            }
            catch (Exception ex)
            {

            }
            return Task.FromResult<int>(res);
        }

        public Task<int> insert_paraMaster(List<parameterMasterEntity> datalist)
        {
            int res = 0;

            try
            {
                ConnectionFactory _connectionFactory = new ConnectionFactory();

                //  string query = "INSERT INTO [unitworksccs].[tblplant](plantId,PlantName,PlantDesc,IsDeleted, CreatedOn, CreatedBy) " +"VALUES(@PlantID,@PlantName,@PlantDesc,@CreatedOn,@CreatedBy)";

                //string query = "INSERT INTO `unitworkccs.parameter_sendor_data`(parameterSensorDataId,machineId,sensorDataCapturedTime,isDeleted,createdOn,correctedDate) VALUES(  @parameterSensorDataId,@machineId,@sensorDataCapturedTime,@isDeleted,@createdOn,@correctedDate)";

                string query = "INSERT INTO `unitworkccs.parameters_master`(ParameterID,SetupTime,OperatingTime,PowerOnTime,PartsCount,InsertedOn,MachineID,Shift,CorrectedDate,AutoCutTime,Total_CutTime,PartsTotal,CuttingTime,AutoMode) VALUES( @ParameterID,@SetupTime,@OperatingTime,@PowerOnTime,@PartsCount,@InsertedOn,@MachineID,@Shift,@CorrectedDate,@AutoCutTime,@Total_CutTime,@PartsTotal,@CuttingTime,@AutoMode)";



                using (var con = _connectionFactory.GetConnection)
                {
                    res = con.Execute(query, datalist, commandTimeout: 600);
                    con.Close();
                }
            }
            catch (Exception ex)
            {

            }
            return Task.FromResult<int>(res);
        }

        public Task<int> insert_ppcbdaqin(List<pcbdaqinTblEntiyt> datalist)
        {
            int res = 0;

            try
            {
                ConnectionFactory _connectionFactory = new ConnectionFactory();

                //  string query = "INSERT INTO [unitworksccs].[tblplant](plantId,PlantName,PlantDesc,IsDeleted, CreatedOn, CreatedBy) " +"VALUES(@PlantID,@PlantName,@PlantDesc,@CreatedOn,@CreatedBy)";

                //string query = "INSERT INTO `unitworkccs.parameter_sendor_data`(parameterSensorDataId,machineId,sensorDataCapturedTime,isDeleted,createdOn,correctedDate) VALUES(  @parameterSensorDataId,@machineId,@sensorDataCapturedTime,@isDeleted,@createdOn,@correctedDate)";

                string query = "INSERT INTO `unitworkccs.pcbdaqin_tbl`( DAQINID,PCBIPAddress,ParamPIN,ParamValue,CreatedOn,CreatedBy) VALUES(@DAQINID,@PCBIPAddress,@ParamPIN,@ParamValue,@CreatedOn,@CreatedBy)";



                using (var con = _connectionFactory.GetConnection)
                {
                    res = con.Execute(query, datalist, commandTimeout: 600);
                    con.Close();
                }
            }
            catch (Exception ex)
            {

            }
            return Task.FromResult<int>(res);
        }

        public Task<int> insert_axisdetails1(List<Axisdetails1Entity> datalist)
        {
            int res = 0;

            try
            {
                ConnectionFactory _connectionFactory = new ConnectionFactory();

                //  string query = "INSERT INTO [unitworksccs].[tblplant](plantId,PlantName,PlantDesc,IsDeleted, CreatedOn, CreatedBy) " +"VALUES(@PlantID,@PlantName,@PlantDesc,@CreatedOn,@CreatedBy)";

                //string query = "INSERT INTO `unitworkccs.parameter_sendor_data`(parameterSensorDataId,machineId,sensorDataCapturedTime,isDeleted,createdOn,correctedDate) VALUES(  @parameterSensorDataId,@machineId,@sensorDataCapturedTime,@isDeleted,@createdOn,@correctedDate)";

                string query = "INSERT INTO `unitworkccs.tbl_axisdetails1`( ADID,MachineID,Axis,AbsPos,RelPos,MacPos,DistPos,StartTime,EndTime,IsDeleted,InsertedOn ) VALUES(@ADID,@MachineID,@Axis,@AbsPos,@RelPos,@MacPos,@DistPos,@StartTime,@EndTime,@IsDeleted,@InsertedOn)";



                using (var con = _connectionFactory.GetConnection)
                {
                    res = con.Execute(query, datalist, commandTimeout: 600);
                    con.Close();
                }
            }
            catch (Exception ex)
            {

            }
            return Task.FromResult<int>(res);
        }


        public Task<int> insert_axisdetails2(List<Adixdetails2Entity> datalist)
        {
            int res = 0;

            try
            {
                ConnectionFactory _connectionFactory = new ConnectionFactory();

                //  string query = "INSERT INTO [unitworksccs].[tblplant](plantId,PlantName,PlantDesc,IsDeleted, CreatedOn, CreatedBy) " +"VALUES(@PlantID,@PlantName,@PlantDesc,@CreatedOn,@CreatedBy)";

                //string query = "INSERT INTO `unitworkccs.parameter_sendor_data`(parameterSensorDataId,machineId,sensorDataCapturedTime,isDeleted,createdOn,correctedDate) VALUES(  @parameterSensorDataId,@machineId,@sensorDataCapturedTime,@isDeleted,@createdOn,@correctedDate)";

                string query = "INSERT INTO `unitworkccs.tbl_axisdetails2`( AD2ID,MachineID,StartTime,EndTime,FeedRate,SpindleLoad,SpindleSpeed,IsDeleted,InsertedOn,FeedRatePercentage) VALUES(@AD2ID,@MachineID,@StartTime,@EndTime,@FeedRate,@SpindleLoad,@SpindleSpeed,@IsDeleted,@InsertedOn,@FeedRatePercentage)";



                using (var con = _connectionFactory.GetConnection)
                {
                    res = con.Execute(query, datalist, commandTimeout: 600);
                    con.Close();
                }
            }
            catch (Exception ex)
            {

            }
            return Task.FromResult<int>(res);
        }

        public Task<int> insert_tblpartscountandcutting(List<partsAndCuuting> datalist)
        {
            int res = 0;

            try
            {
                ConnectionFactory _connectionFactory = new ConnectionFactory();

                //  string query = "INSERT INTO [unitworksccs].[tblplant](plantId,PlantName,PlantDesc,IsDeleted, CreatedOn, CreatedBy) " +"VALUES(@PlantID,@PlantName,@PlantDesc,@CreatedOn,@CreatedBy)";

                //string query = "INSERT INTO `unitworkccs.parameter_sendor_data`(parameterSensorDataId,machineId,sensorDataCapturedTime,isDeleted,createdOn,correctedDate) VALUES(  @parameterSensorDataId,@machineId,@sensorDataCapturedTime,@isDeleted,@createdOn,@correctedDate)";

                string query = "INSERT INTO `unitworkccs.tblpartscountandcutting`( pcid,MachineID,PartCount,CuttingTime,TargetQuantity,StartTime,EndTime,Isdeleted,CreatedOn,CorrectedDate,CreatedBy,ModifiedOn,ModifiedBy,PartsPerCyscleEnteredTime,WoPartCount,ShiftName,CuttingTimeInSec,woTargetQty,rejectionQty,reworkQty,actualQty,dryRunQty,OkQty) VALUES(@pcid,@MachineID,@PartCount,@CuttingTime,@TargetQuantity,@StartTime,@EndTime,@Isdeleted,@CreatedOn,@CorrectedDate,@CreatedBy,@ModifiedOn,@ModifiedBy,@PartsPerCyscleEnteredTime,@WoPartCount,@ShiftName,@CuttingTimeInSec,@woTargetQty,@rejectionQty,@reworkQty,@actualQty,@dryRunQty,@OkQty)";



                using (var con = _connectionFactory.GetConnection)
                {
                    res = con.Execute(query, datalist, commandTimeout: 600);
                    con.Close();
                }
            }
            catch (Exception ex)
            {

            }
            return Task.FromResult<int>(res);
        }


        public Task<int> insert_livemode(List<LiveModeentity> datalist)
        {
            int res = 0;

            try
            {
                ConnectionFactory _connectionFactory = new ConnectionFactory();

                //  string query = "INSERT INTO [unitworksccs].[tblplant](plantId,PlantName,PlantDesc,IsDeleted, CreatedOn, CreatedBy) " +"VALUES(@PlantID,@PlantName,@PlantDesc,@CreatedOn,@CreatedBy)";

                //string query = "INSERT INTO `unitworkccs.parameter_sendor_data`(parameterSensorDataId,machineId,sensorDataCapturedTime,isDeleted,createdOn,correctedDate) VALUES(  @parameterSensorDataId,@machineId,@sensorDataCapturedTime,@isDeleted,@createdOn,@correctedDate)";

                string query = "INSERT INTO `unitworkccs.tbllivemode`(  ModeID,MachineID,MacMode,InsertedOn,InsertedBy,ModifiedOn,ModifiedBy,CorrectedDate,IsDeleted,StartTime,EndTime,ColorCode,IsCompleted,DurationInSec,LossCodeID,BreakdownID,ModeType,ModeTypeEnd,StartIdle,LossCodeEnteredTime,LossCodeEnteredBy,IsInserted,TotalPartsCount,CuttingDuration,IsShiftEnd,breakDownCodeID,shift) VALUES(@ModeID,@MachineID,@MacMode,@InsertedOn,@InsertedBy,@ModifiedOn,@ModifiedBy,@CorrectedDate,@IsDeleted,@StartTime,@EndTime,@ColorCode,@IsCompleted,@DurationInSec,@LossCodeID,@BreakdownID,@ModeType,@ModeTypeEnd,@StartIdle,@LossCodeEnteredTime,@LossCodeEnteredBy,@IsInserted,@TotalPartsCount,@CuttingDuration,@IsShiftEnd,@breakDownCodeID,@shift)";



                using (var con = _connectionFactory.GetConnection)
                {
                    res = con.Execute(query, datalist, commandTimeout: 600);
                    con.Close();
                }
            }
            catch (Exception ex)
            {

            }
            return Task.FromResult<int>(res);
        }

        public Task<int> insert_tblfgandcellallocation(List<fgpartentity> datalist)
        {
            int res = 0;

            try
            {
                ConnectionFactory _connectionFactory = new ConnectionFactory();

                //  string query = "INSERT INTO [unitworksccs].[tblplant](plantId,PlantName,PlantDesc,IsDeleted, CreatedOn, CreatedBy) " +"VALUES(@PlantID,@PlantName,@PlantDesc,@CreatedOn,@CreatedBy)";

                //string query = "INSERT INTO `unitworkccs.parameter_sendor_data`(parameterSensorDataId,machineId,sensorDataCapturedTime,isDeleted,createdOn,correctedDate) VALUES(  @parameterSensorDataId,@machineId,@sensorDataCapturedTime,@isDeleted,@createdOn,@correctedDate)";

                string query = "INSERT INTO `unitworkccs.tblfgandcellallocation`(  fgAndCellAllocationId,plantId,partNo,cellFinalId,subCellFinalId,isDeleted,createdOn,createdBy,modifiedOn,modifiedBy,partName,dmcCodeStatus) VALUES(@fgAndCellAllocationId,@plantId,@partNo,@cellFinalId,@subCellFinalId,@isDeleted,@createdOn,@createdBy,@modifiedOn,@modifiedBy,@partName,@dmcCodeStatus)";



                using (var con = _connectionFactory.GetConnection)
                {
                    res = con.Execute(query, datalist, commandTimeout: 600);
                    con.Close();
                }
            }
            catch (Exception ex)
            {

            }
            return Task.FromResult<int>(res);
        }




        public Task<int> insert_tblDefectCode(List<defectcodemsasteentity> datalist)
        {
            int res = 0;

            try
            {
                ConnectionFactory _connectionFactory = new ConnectionFactory();

                //  string query = "INSERT INTO [unitworksccs].[tblplant](plantId,PlantName,PlantDesc,IsDeleted, CreatedOn, CreatedBy) " +"VALUES(@PlantID,@PlantName,@PlantDesc,@CreatedOn,@CreatedBy)";

                //string query = "INSERT INTO `unitworkccs.parameter_sendor_data`(parameterSensorDataId,machineId,sensorDataCapturedTime,isDeleted,createdOn,correctedDate) VALUES(  @parameterSensorDataId,@machineId,@sensorDataCapturedTime,@isDeleted,@createdOn,@correctedDate)";

                string query = "INSERT INTO `unitworkccs.tbldefectcodemaster`(  defectCodeId,defectCodeName,defectCodeDesc,isDeleted,createdOn,createdBy,modifiedOn,modifiedBy) VALUES( @defectCodeId,@defectCodeName,@defectCodeDesc,@isDeleted,@createdOn,@createdBy,@modifiedOn,@modifiedBy)";



                using (var con = _connectionFactory.GetConnection)
                {
                    res = con.Execute(query, datalist, commandTimeout: 600);
                    con.Close();
                }
            }
            catch (Exception ex)
            {

            }
            return Task.FromResult<int>(res);
        }


        public Task<int> insert_tblchildfgpartno(List<ChildFgPartNo> datalist)
        {
            int res = 0;

            try
            {
                ConnectionFactory _connectionFactory = new ConnectionFactory();

                //  string query = "INSERT INTO [unitworksccs].[tblplant](plantId,PlantName,PlantDesc,IsDeleted, CreatedOn, CreatedBy) " +"VALUES(@PlantID,@PlantName,@PlantDesc,@CreatedOn,@CreatedBy)";

                //string query = "INSERT INTO `unitworkccs.parameter_sendor_data`(parameterSensorDataId,machineId,sensorDataCapturedTime,isDeleted,createdOn,correctedDate) VALUES(  @parameterSensorDataId,@machineId,@sensorDataCapturedTime,@isDeleted,@createdOn,@correctedDate)";

                string query = "INSERT INTO `unitworkccs.tblchildfgpartno`(childFgpartId,childFgPartNo,childPartNoDesc,plantId,fgPartNo,isDeleted,createdOn,createdBy,modifiedOn,modifiedBy,fgPartDesc) VALUES(@childFgpartId,@childFgPartNo,@childPartNoDesc,@plantId,@fgPartNo,@isDeleted,@createdOn,@createdBy,@modifiedOn,@modifiedBy,@fgPartDesc)";



                using (var con = _connectionFactory.GetConnection)
                {
                    res = con.Execute(query, datalist, commandTimeout: 600);
                    con.Close();
                }
            }
            catch (Exception ex)
            {

            }
            return Task.FromResult<int>(res);
        }


        public Task<int> insert_tbl_utilreport(List<utilreportE> datalist)
        {
            int res = 0;

            try
            {
                ConnectionFactory _connectionFactory = new ConnectionFactory();

                //  string query = "INSERT INTO [unitworksccs].[tblplant](plantId,PlantName,PlantDesc,IsDeleted, CreatedOn, CreatedBy) " +"VALUES(@PlantID,@PlantName,@PlantDesc,@CreatedOn,@CreatedBy)";

                //string query = "INSERT INTO `unitworkccs.parameter_sendor_data`(parameterSensorDataId,machineId,sensorDataCapturedTime,isDeleted,createdOn,correctedDate) VALUES(  @parameterSensorDataId,@machineId,@sensorDataCapturedTime,@isDeleted,@createdOn,@correctedDate)";

                string query = "INSERT INTO `unitworkccs.tbl_utilreport`(UtilReportID,MachineID,CorrectedDate,TotalTime,OperatingTime,SetupTime,MinorLossTime,LossTime,BDTime,PowerOffTime,UtilPercent,InsertedOn,SetupMinorTime) VALUES(@UtilReportID,@MachineID,@CorrectedDate,@TotalTime,@OperatingTime,@SetupTime,@MinorLossTime,@LossTime,@BDTime,@PowerOffTime,@UtilPercent,@InsertedOn,@SetupMinorTime)";



                using (var con = _connectionFactory.GetConnection)
                {
                    res = con.Execute(query, datalist, commandTimeout: 600);
                    con.Close();
                }
            }
            catch (Exception ex)
            {

            }
            return Task.FromResult<int>(res);
        }


        public Task<int> insert_tbl_tblbreakdowncodes(List<tblbreakdowncodesE> datalist)
        {
            int res = 0;

            try
            {
                ConnectionFactory _connectionFactory = new ConnectionFactory();

                //  string query = "INSERT INTO [unitworksccs].[tblplant](plantId,PlantName,PlantDesc,IsDeleted, CreatedOn, CreatedBy) " +"VALUES(@PlantID,@PlantName,@PlantDesc,@CreatedOn,@CreatedBy)";

                //string query = "INSERT INTO `unitworkccs.parameter_sendor_data`(parameterSensorDataId,machineId,sensorDataCapturedTime,isDeleted,createdOn,correctedDate) VALUES(  @parameterSensorDataId,@machineId,@sensorDataCapturedTime,@isDeleted,@createdOn,@correctedDate)";

                string query = "INSERT INTO `unitworkccs.tblbreakdowncodes`(BreakdownID,BreakdownCode,BreakdownDesc,MessageType,BreakdownLevel,BreakdownLevel1ID,BreakdownLevel2ID,ContributeTo,IsDeleted,CreatedOn,CreatedBy,ModifiedOn,ModifiedBy,EndCode,DeletedDate,ServerTabCheck,ServerTabFlagSync,TargetPercent) VALUES( @BreakdownID,@BreakdownCode,@BreakdownDesc,@MessageType,@BreakdownLevel,@BreakdownLevel1ID,@BreakdownLevel2ID,@ContributeTo,@IsDeleted,@CreatedOn,@CreatedBy,@ModifiedOn,@ModifiedBy,@EndCode,@DeletedDate,@ServerTabCheck,@ServerTabFlagSync,@TargetPercent)";



                using (var con = _connectionFactory.GetConnection)
                {
                    res = con.Execute(query, datalist, commandTimeout: 600);
                    con.Close();
                }
            }
            catch (Exception ex)
            {

            }
            return Task.FromResult<int>(res);
        }



        public Task<int> insert_tblpriorityalarms(List<tblpriorityalarmsE> datalist)
        {
            int res = 0;

            try
            {
                ConnectionFactory _connectionFactory = new ConnectionFactory();

                //  string query = "INSERT INTO [unitworksccs].[tblplant](plantId,PlantName,PlantDesc,IsDeleted, CreatedOn, CreatedBy) " +"VALUES(@PlantID,@PlantName,@PlantDesc,@CreatedOn,@CreatedBy)";

                //string query = "INSERT INTO `unitworkccs.parameter_sendor_data`(parameterSensorDataId,machineId,sensorDataCapturedTime,isDeleted,createdOn,correctedDate) VALUES(  @parameterSensorDataId,@machineId,@sensorDataCapturedTime,@isDeleted,@createdOn,@correctedDate)";

                string query = "INSERT INTO `unitworkccs.tblpriorityalarms`( AlarmID,AlarmNumber,AlarmDesc,AxisNo,AlarmGroup,PriorityNumber,IsDeleted,CreatedOn,CreatedBy,ModifiedOn,ModifiedBy,MachineID,CorrectedDate,isMailSent) VALUES(@AlarmID,@AlarmNumber,@AlarmDesc,@AxisNo,@AlarmGroup,@PriorityNumber,@IsDeleted,@CreatedOn,@CreatedBy,@ModifiedOn,@ModifiedBy,@MachineID,@CorrectedDate,@isMailSent)";



                using (var con = _connectionFactory.GetConnection)
                {
                    res = con.Execute(query, datalist, commandTimeout: 600);
                    con.Close();
                }
            }
            catch (Exception ex)
            {

            }
            return Task.FromResult<int>(res);
        }



        public Task<int> insert_alarm_history_master(List<alarm_history_masterE> datalist)
        {
            int res = 0;

            try
            {
                ConnectionFactory _connectionFactory = new ConnectionFactory();

                //  string query = "INSERT INTO [unitworksccs].[tblplant](plantId,PlantName,PlantDesc,IsDeleted, CreatedOn, CreatedBy) " +"VALUES(@PlantID,@PlantName,@PlantDesc,@CreatedOn,@CreatedBy)";

                //string query = "INSERT INTO `unitworkccs.parameter_sendor_data`(parameterSensorDataId,machineId,sensorDataCapturedTime,isDeleted,createdOn,correctedDate) VALUES(  @parameterSensorDataId,@machineId,@sensorDataCapturedTime,@isDeleted,@createdOn,@correctedDate)";

                string query = "INSERT INTO `unitworkccs.alarm_history_master`( AlarmID,AlarmMessage,AlarmDateTime,InsertedOn,MachineID,Shift,CorrectedDate,ErrorNum,Status,DetailCode1,DetailCode2,DetailCode3,InterferedPart,SystemHead,AlarmNo,Axis_No,Axis_Num,Abs_Pos,AlarmDate,AlarmTime) VALUES(@AlarmID,@AlarmMessage,@AlarmDateTime,@InsertedOn,@MachineID,@Shift,@CorrectedDate,@ErrorNum,@Status,@DetailCode1,@DetailCode2,@DetailCode3,@InterferedPart,@SystemHead,@AlarmNo,@Axis_No,@Axis_Num,@Abs_Pos,@AlarmDate,@AlarmTime)";



                using (var con = _connectionFactory.GetConnection)
                {
                    res = con.Execute(query, datalist, commandTimeout: 600);
                    con.Close();
                }
            }
            catch (Exception ex)
            {

            }
            return Task.FromResult<int>(res);
        }


        public Task<int> insert_tblfgpartnodet(List<tblfgpartnodetE> datalist)
        {
            int res = 0;

            try
            {
                ConnectionFactory _connectionFactory = new ConnectionFactory();

                //  string query = "INSERT INTO [unitworksccs].[tblplant](plantId,PlantName,PlantDesc,IsDeleted, CreatedOn, CreatedBy) " +"VALUES(@PlantID,@PlantName,@PlantDesc,@CreatedOn,@CreatedBy)";

                //string query = "INSERT INTO `unitworkccs.parameter_sendor_data`(parameterSensorDataId,machineId,sensorDataCapturedTime,isDeleted,createdOn,correctedDate) VALUES(  @parameterSensorDataId,@machineId,@sensorDataCapturedTime,@isDeleted,@createdOn,@correctedDate)";

                string query = "INSERT INTO `unitworkccs.tblfgpartnodet`(fgPartId,partId,partCountMethod,operationNo,workOrderNo,noOfPartsPerCycle,isClosed,isDeleted,startDate,closedDate,operatorId,machineId,correctedDate,shift,createdOn,createdBy,modifiedOn,modifiedBy,planLinkageId,actaulValue,targetQty,availibility,performance,quality,oee,fgPartNo,idealCycleTime,unit,scheduledQty,plannedStartTime,plannedEndTime,routingId,partName,workOrderCompletedQty) VALUES(@fgPartId,@partId,@partCountMethod,@operationNo,@workOrderNo,@noOfPartsPerCycle,@isClosed,@isDeleted,@startDate,@closedDate,@operatorId,@machineId,@correctedDate,@shift,@createdOn,@createdBy,@modifiedOn,@modifiedBy,@planLinkageId,@actaulValue,@targetQty,@availibility,@performance,@quality,@oee,@fgPartNo,@idealCycleTime,@unit,@scheduledQty,@plannedStartTime,@plannedEndTime,@routingId,@partName,@workOrderCompletedQty)";



                using (var con = _connectionFactory.GetConnection)
                {
                    res = con.Execute(query, datalist, commandTimeout: 600);
                    con.Close();
                }
            }
            catch (Exception ex)
            {

            }
            return Task.FromResult<int>(res);
        }


        public Task<int> insert_tbl_prodmanmachine(List<tbl_prodmanmachineE> datalist)
        {
            int res = 0;

            try
            {
                ConnectionFactory _connectionFactory = new ConnectionFactory();

                //  string query = "INSERT INTO [unitworksccs].[tblplant](plantId,PlantName,PlantDesc,IsDeleted, CreatedOn, CreatedBy) " +"VALUES(@PlantID,@PlantName,@PlantDesc,@CreatedOn,@CreatedBy)";

                //string query = "INSERT INTO `unitworkccs.parameter_sendor_data`(parameterSensorDataId,machineId,sensorDataCapturedTime,isDeleted,createdOn,correctedDate) VALUES(  @parameterSensorDataId,@machineId,@sensorDataCapturedTime,@isDeleted,@createdOn,@correctedDate)";

                string query = "INSERT INTO `unitworkccs.tbl_prodmanmachine`(ProdManMachineID,MachineID,CorrectedDate,WOID,UtilPercent,TotalLoss,TotalSetup,TotalMinorLoss,TotalOperatingTime,InsertedOn,TotalSetupMinorLoss,TotalPowerLoss,PerformancePerCent,QualityPercent,PerfromaceFactor) VALUES(@ProdManMachineID,@MachineID,@CorrectedDate,@WOID,@UtilPercent,@TotalLoss,@TotalSetup,@TotalMinorLoss,@TotalOperatingTime,@InsertedOn,@TotalSetupMinorLoss,@TotalPowerLoss,@PerformancePerCent,@QualityPercent,@PerfromaceFactor)";



                using (var con = _connectionFactory.GetConnection)
                {
                    res = con.Execute(query, datalist, commandTimeout: 600);
                    con.Close();
                }
            }
            catch (Exception ex)
            {

            }
            return Task.FromResult<int>(res);
        }



        public Task<int> insert_tblRejectionDetails(List<tblrejectiondetailsE> datalist)
        {
            int res = 0;

            try
            {
                ConnectionFactory _connectionFactory = new ConnectionFactory();

                //  string query = "INSERT INTO [unitworksccs].[tblplant](plantId,PlantName,PlantDesc,IsDeleted, CreatedOn, CreatedBy) " +"VALUES(@PlantID,@PlantName,@PlantDesc,@CreatedOn,@CreatedBy)";

                //string query = "INSERT INTO `unitworkccs.parameter_sendor_data`(parameterSensorDataId,machineId,sensorDataCapturedTime,isDeleted,createdOn,correctedDate) VALUES(  @parameterSensorDataId,@machineId,@sensorDataCapturedTime,@isDeleted,@createdOn,@correctedDate)";

                string query = "INSERT INTO `unitworkccs.tblrejectiondetails`(rejectionId,fgPartId,defectCodeId,defectQty,machineId,operatorId,isDeleted,createdOn,createdBy,modifiedOn,modifiedBy,correctedDate,shift,qrCodeNo,isDirLineInsp,isDirQualityHead,dmcCodeStatus,ReasonForRejection) VALUES(@rejectionId,@fgPartId,@defectCodeId,@defectQty,@machineId,@operatorId,@isDeleted,@createdOn,@createdBy,@modifiedOn,@modifiedBy,@correctedDate,@shift,@qrCodeNo,@isDirLineInsp,@isDirQualityHead,@dmcCodeStatus,@ReasonForRejection)";



                using (var con = _connectionFactory.GetConnection)
                {
                    res = con.Execute(query, datalist, commandTimeout: 600);
                    con.Close();
                }
            }
            catch (Exception ex)
            {

            }
            return Task.FromResult<int>(res);
        }



        public Task<int> insert_configuration_tblprimitivem(List<configuration_tblprimitivemaintainE_> datalist)
        {
            int res = 0;

            try
            {
                ConnectionFactory _connectionFactory = new ConnectionFactory();

                //  string query = "INSERT INTO [unitworksccs].[tblplant](plantId,PlantName,PlantDesc,IsDeleted, CreatedOn, CreatedBy) " +"VALUES(@PlantID,@PlantName,@PlantDesc,@CreatedOn,@CreatedBy)";

                //string query = "INSERT INTO `unitworkccs.parameter_sendor_data`(parameterSensorDataId,machineId,sensorDataCapturedTime,isDeleted,createdOn,correctedDate) VALUES(  @parameterSensorDataId,@machineId,@sensorDataCapturedTime,@isDeleted,@createdOn,@correctedDate)";

                 string query = "INSERT INTO `unitworkccs.configuration_tblprimitivemaintainancescheduling`(pmid,MachineID,MachineName,Month,Week,IsDeleted,CreatedOn,CreatedBy,ModifiedOn,ModifiedBy,CellName,CellID,PlantID,ShopID,plantName,shopname,MonthID,WeekID) VALUES(@pmid,@MachineID,@MachineName,@Month,@Week,@IsDeleted,@CreatedOn,@CreatedBy,@ModifiedOn,@ModifiedBy,@CellName,@CellID,@PlantID,@ShopID,@plantName,@shopname,@MonthID,@WeekID)";

                //string query = "INSERT INTO `unitworkccs.configuration_`(pmid,MachineID,MachineName,Month,Week,IsDeleted,CreatedOn,CreatedBy,ModifiedOn,ModifiedBy,CellName,CellID,PlantID,ShopID,plantName,shopname,MonthID,WeekID) VALUES(@pmid,@MachineID,@MachineName,@Month,@Week,@IsDeleted,@CreatedOn,@CreatedBy,@ModifiedOn,@ModifiedBy,@CellName,@CellID,@PlantID,@ShopID,@plantName,@shopname,@MonthID,@WeekID)";

                using (var con = _connectionFactory.GetConnection)
                {
                    res = con.Execute(query, datalist, commandTimeout: 600);
                    con.Close();
                }
            }
            catch (Exception ex)
            {

            }
            return Task.FromResult<int>(res);
        }


        public Task<int> insert_tblsmsdetails(List<tblsmsdetailsE> datalist)
        {
            int res = 0;

            try
            {
                ConnectionFactory _connectionFactory = new ConnectionFactory();

                //  string query = "INSERT INTO [unitworksccs].[tblplant](plantId,PlantName,PlantDesc,IsDeleted, CreatedOn, CreatedBy) " +"VALUES(@PlantID,@PlantName,@PlantDesc,@CreatedOn,@CreatedBy)";

                //string query = "INSERT INTO `unitworkccs.parameter_sendor_data`(parameterSensorDataId,machineId,sensorDataCapturedTime,isDeleted,createdOn,correctedDate) VALUES(  @parameterSensorDataId,@machineId,@sensorDataCapturedTime,@isDeleted,@createdOn,@correctedDate)";

                string query = "INSERT INTO `unitworkccs.tblsmsdetails`(smsId,machineId,contactNo,ticketId,createdOn,createdBy,modifiedOn,modifiedBy,isDeleted,responseId,idleResponseId,idleSms,shift,message,correctedDate,cellId,subCellId,categoryId,smsPriority,timeToBeTriggered,employeeName,opNo) VALUES(@smsId,@machineId,@contactNo,@ticketId,@createdOn,@createdBy,@modifiedOn,@modifiedBy,@isDeleted,@responseId,@idleResponseId,@idleSms,@shift,@message,@correctedDate,@cellId,@subCellId,@categoryId,@smsPriority,@timeToBeTriggered,@employeeName,@opNo)";

                //string query = "INSERT INTO `unitworkccs.configuration_`(pmid,MachineID,MachineName,Month,Week,IsDeleted,CreatedOn,CreatedBy,ModifiedOn,ModifiedBy,CellName,CellID,PlantID,ShopID,plantName,shopname,MonthID,WeekID) VALUES(@pmid,@MachineID,@MachineName,@Month,@Week,@IsDeleted,@CreatedOn,@CreatedBy,@ModifiedOn,@ModifiedBy,@CellName,@CellID,@PlantID,@ShopID,@plantName,@shopname,@MonthID,@WeekID)";

                using (var con = _connectionFactory.GetConnection)
                {
                    res = con.Execute(query, datalist, commandTimeout: 600);
                    con.Close();
                }
            }
            catch (Exception ex)
            {

            }
            return Task.FromResult<int>(res);
        }


        public Task<int> insert_operationlog(List<operationlogE> datalist)
        {
            int res = 0;

            try
            {
                ConnectionFactory _connectionFactory = new ConnectionFactory();

                //  string query = "INSERT INTO [unitworksccs].[tblplant](plantId,PlantName,PlantDesc,IsDeleted, CreatedOn, CreatedBy) " +"VALUES(@PlantID,@PlantName,@PlantDesc,@CreatedOn,@CreatedBy)";

                //string query = "INSERT INTO `unitworkccs.parameter_sendor_data`(parameterSensorDataId,machineId,sensorDataCapturedTime,isDeleted,createdOn,correctedDate) VALUES(  @parameterSensorDataId,@machineId,@sensorDataCapturedTime,@isDeleted,@createdOn,@correctedDate)";

                string query = "INSERT INTO `unitworkccs.operationlog`( idoperationlog,OpMsg,OpDate,OpTime,OpDateTime,OpReason,MachineID) VALUES( @idoperationlog,@OpMsg,@OpDate,@OpTime,@OpDateTime,@OpReason,@MachineID)";

                //string query = "INSERT INTO `unitworkccs.configuration_`(pmid,MachineID,MachineName,Month,Week,IsDeleted,CreatedOn,CreatedBy,ModifiedOn,ModifiedBy,CellName,CellID,PlantID,ShopID,plantName,shopname,MonthID,WeekID) VALUES(@pmid,@MachineID,@MachineName,@Month,@Week,@IsDeleted,@CreatedOn,@CreatedBy,@ModifiedOn,@ModifiedBy,@CellName,@CellID,@PlantID,@ShopID,@plantName,@shopname,@MonthID,@WeekID)";

                using (var con = _connectionFactory.GetConnection)
                {
                    res = con.Execute(query, datalist, commandTimeout: 600);
                    con.Close();
                }
            }
            catch (Exception ex)
            {

            }
            return Task.FromResult<int>(res);
        }


        public Task<int> insert_tblstoppage(List<tblstoppageE> datalist)
        {
            int res = 0;

            try
            {
                ConnectionFactory _connectionFactory = new ConnectionFactory();

                //  string query = "INSERT INTO [unitworksccs].[tblplant](plantId,PlantName,PlantDesc,IsDeleted, CreatedOn, CreatedBy) " +"VALUES(@PlantID,@PlantName,@PlantDesc,@CreatedOn,@CreatedBy)";

                //string query = "INSERT INTO `unitworkccs.parameter_sendor_data`(parameterSensorDataId,machineId,sensorDataCapturedTime,isDeleted,createdOn,correctedDate) VALUES(  @parameterSensorDataId,@machineId,@sensorDataCapturedTime,@isDeleted,@createdOn,@correctedDate)";

                string query = "INSERT INTO `unitworkccs.tblstoppage`( stoppagesId,categoryId,alramNo,alramDesc,sourceId,createdOn,createdBy,modifiedBy,modifiedOn,isDeleted) VALUES( @stoppagesId,@categoryId,@alramNo,@alramDesc,@sourceId,@createdOn,@createdBy,@modifiedBy,@modifiedOn,@isDeleted)";

                //string query = "INSERT INTO `unitworkccs.configuration_`(pmid,MachineID,MachineName,Month,Week,IsDeleted,CreatedOn,CreatedBy,ModifiedOn,ModifiedBy,CellName,CellID,PlantID,ShopID,plantName,shopname,MonthID,WeekID) VALUES(@pmid,@MachineID,@MachineName,@Month,@Week,@IsDeleted,@CreatedOn,@CreatedBy,@ModifiedOn,@ModifiedBy,@CellName,@CellID,@PlantID,@ShopID,@plantName,@shopname,@MonthID,@WeekID)";

                using (var con = _connectionFactory.GetConnection)
                {
                    res = con.Execute(query, datalist, commandTimeout: 600);
                    con.Close();
                }
            }
            catch (Exception ex)
            {

            }
            return Task.FromResult<int>(res);
        }



        public Task<int> insert_tblproductwisedefectcodese(List<tblproductwisedefectcodesE> datalist)
        {
            int res = 0;

            try
            {
                ConnectionFactory _connectionFactory = new ConnectionFactory();

                //  string query = "INSERT INTO [unitworksccs].[tblplant](plantId,PlantName,PlantDesc,IsDeleted, CreatedOn, CreatedBy) " +"VALUES(@PlantID,@PlantName,@PlantDesc,@CreatedOn,@CreatedBy)";

                //string query = "INSERT INTO `unitworkccs.parameter_sendor_data`(parameterSensorDataId,machineId,sensorDataCapturedTime,isDeleted,createdOn,correctedDate) VALUES(  @parameterSensorDataId,@machineId,@sensorDataCapturedTime,@isDeleted,@createdOn,@correctedDate)";

                string query = "INSERT INTO `unitworkccs.tblproductwisedefectcodes`(productWiseDefectCodeId,trim,plantId,partNo,defectCodeId,isDeleted,createdOn,createdBy,modifiedOn,modifiedBy,partName) VALUES( @productWiseDefectCodeId,@trim,@plantId,@partNo,@defectCodeId,@isDeleted,@createdOn,@createdBy,@modifiedOn,@modifiedBy,@partName)";

                //string query = "INSERT INTO `unitworkccs.configuration_`(pmid,MachineID,MachineName,Month,Week,IsDeleted,CreatedOn,CreatedBy,ModifiedOn,ModifiedBy,CellName,CellID,PlantID,ShopID,plantName,shopname,MonthID,WeekID) VALUES(@pmid,@MachineID,@MachineName,@Month,@Week,@IsDeleted,@CreatedOn,@CreatedBy,@ModifiedOn,@ModifiedBy,@CellName,@CellID,@PlantID,@ShopID,@plantName,@shopname,@MonthID,@WeekID)";

                using (var con = _connectionFactory.GetConnection)
                {
                    res = con.Execute(query, datalist, commandTimeout: 600);
                    con.Close();
                }
            }
            catch (Exception ex)
            {

            }
            return Task.FromResult<int>(res);
        }

        public Task<int> inserttblmachinedetails(List<tblmachinedetailsE> datalist)
        {
            int res = 0;

            try
            {
                ConnectionFactory _connectionFactory = new ConnectionFactory();

                //  string query = "INSERT INTO [unitworksccs].[tblplant](plantId,PlantName,PlantDesc,IsDeleted, CreatedOn, CreatedBy) " +"VALUES(@PlantID,@PlantName,@PlantDesc,@CreatedOn,@CreatedBy)";

                //string query = "INSERT INTO `unitworkccs.parameter_sendor_data`(parameterSensorDataId,machineId,sensorDataCapturedTime,isDeleted,createdOn,correctedDate) VALUES(  @parameterSensorDataId,@machineId,@sensorDataCapturedTime,@isDeleted,@createdOn,@correctedDate)";

                string query = "INSERT INTO `unitworkccs.tblmachinedetails`(MachineID,InsertedOn,InsertedBy,ModifiedOn,ModifiedBy,IsDeleted,PlantID,ShopID,CellID,MachineName,MachineDescription,MachineDisplayName,CellOrderNo,IPAddress,MachineType,ControllerType,MachineModel,MachineMake,ModelType,IsParameters,ShopNo,IsPCB,IsLevel,IsNormalWC,ManualWCID,NoOfAxis,MacType,CurrentControlAxis,ProgramNum,ProgDBit,MachineModelType,MacConnName,SpindleAxis,TabIPAddress,MachineLockBit,MachineSetupBit,MachineMaintBit,MachineToolLifeBit,MachineUnlockBit,MachineIdleBit,MachineIdleMin,EnableLockLogic,ServerTabFlagSync,ServerTabCheck,DeletedDate,EnableToolLife,IsBottelNeck,IsFirstMachine,IsLastMachine,OperationNumber,IsShiftWise,LossFlag,TransmissionFrequency,LoggerType,MachinePort,NumOfAxis,ToolGroupNum,NumberOfCurrent,NumberOfTemperature,NumberOfPresure,NumberOfLevel,CreatedOn,IsWimerasys,IOTGatewayIP,NodeID,IsDLVersion,machinePockets,noOfPartsPerCycle,Category,MachineCategoryId,MMMGroup,dedicatedOrShared,primaryOrSecondary,machineSpec,chuckOrRodSize,noOfToolStation,tallStockAvailId,noOfAxisId,tableSize,palletId) VALUES( @MachineID,@InsertedOn,@InsertedBy,@ModifiedOn,@ModifiedBy,@IsDeleted,@PlantID,@ShopID,@CellID,@MachineName,@MachineDescription,@MachineDisplayName,@CellOrderNo,@IPAddress,@MachineType,@ControllerType,@MachineModel,@MachineMake,@ModelType,@IsParameters,@ShopNo,@IsPCB,@IsLevel,@IsNormalWC,@ManualWCID,@NoOfAxis,@MacType,@CurrentControlAxis,@ProgramNum,@ProgDBit,@MachineModelType,@MacConnName,@SpindleAxis,@TabIPAddress,@MachineLockBit,@MachineSetupBit,@MachineMaintBit,@MachineToolLifeBit,@MachineUnlockBit,@MachineIdleBit,@MachineIdleMin,@EnableLockLogic,@ServerTabFlagSync,@ServerTabCheck,@DeletedDate,@EnableToolLife,@IsBottelNeck,@IsFirstMachine,@IsLastMachine,@OperationNumber,@IsShiftWise,@LossFlag,@TransmissionFrequency,@LoggerType,@MachinePort,@NumOfAxis,@ToolGroupNum,@NumberOfCurrent,@NumberOfTemperature,@NumberOfPresure,@NumberOfLevel,@CreatedOn,@IsWimerasys,@IOTGatewayIP,@NodeID,@IsDLVersion,@machinePockets,@noOfPartsPerCycle,@Category,@MachineCategoryId,@MMMGroup,@dedicatedOrShared,@primaryOrSecondary,@machineSpec,@chuckOrRodSize,@noOfToolStation,@tallStockAvailId,@noOfAxisId,@tableSize,@palletId)";

                //string query = "INSERT INTO `unitworkccs.configuration_`(pmid,MachineID,MachineName,Month,Week,IsDeleted,CreatedOn,CreatedBy,ModifiedOn,ModifiedBy,CellName,CellID,PlantID,ShopID,plantName,shopname,MonthID,WeekID) VALUES(@pmid,@MachineID,@MachineName,@Month,@Week,@IsDeleted,@CreatedOn,@CreatedBy,@ModifiedOn,@ModifiedBy,@CellName,@CellID,@PlantID,@ShopID,@plantName,@shopname,@MonthID,@WeekID)";

                using (var con = _connectionFactory.GetConnection)
                {
                    res = con.Execute(query, datalist, commandTimeout: 600);
                    con.Close();
                }
            }
            catch (Exception ex)
            {

            }
            return Task.FromResult<int>(res);
        }

        public Task<int> insertlogintrackerdetails(List<logintrackerdetailsE> datalist)
        {
            int res = 0;

            try
            {
                ConnectionFactory _connectionFactory = new ConnectionFactory();

                //  string query = "INSERT INTO [unitworksccs].[tblplant](plantId,PlantName,PlantDesc,IsDeleted, CreatedOn, CreatedBy) " +"VALUES(@PlantID,@PlantName,@PlantDesc,@CreatedOn,@CreatedBy)";

                //string query = "INSERT INTO `unitworkccs.parameter_sendor_data`(parameterSensorDataId,machineId,sensorDataCapturedTime,isDeleted,createdOn,correctedDate) VALUES(  @parameterSensorDataId,@machineId,@sensorDataCapturedTime,@isDeleted,@createdOn,@correctedDate)";

                string query = "INSERT INTO `unitworkccs.logintrackerdetails`(loginTrackerDetailsId,machineId,operatorId,currentFGPart,currentTicketRaisedId,loginDateTime,logoutDateTime,isLoggedIn,insertedOn,isDeleted,shift,correctedDate) VALUES( @loginTrackerDetailsId,@machineId,@operatorId,@currentFGPart,@currentTicketRaisedId,@loginDateTime,@logoutDateTime,@isLoggedIn,@insertedOn,@isDeleted,@shift,@correctedDate)";

                //string query = "INSERT INTO `unitworkccs.configuration_`(pmid,MachineID,MachineName,Month,Week,IsDeleted,CreatedOn,CreatedBy,ModifiedOn,ModifiedBy,CellName,CellID,PlantID,ShopID,plantName,shopname,MonthID,WeekID) VALUES(@pmid,@MachineID,@MachineName,@Month,@Week,@IsDeleted,@CreatedOn,@CreatedBy,@ModifiedOn,@ModifiedBy,@CellName,@CellID,@PlantID,@ShopID,@plantName,@shopname,@MonthID,@WeekID)";

                using (var con = _connectionFactory.GetConnection)
                {
                    res = con.Execute(query, datalist, commandTimeout: 600);
                    con.Close();
                }
            }
            catch (Exception ex)
            {

            }
            return Task.FromResult<int>(res);
        }

        public Task<int> inserttblparts(List<tblpartsE> datalist)
        {
            int res = 0;

            try
            {
                ConnectionFactory _connectionFactory = new ConnectionFactory();

                //  string query = "INSERT INTO [unitworksccs].[tblplant](plantId,PlantName,PlantDesc,IsDeleted, CreatedOn, CreatedBy) " +"VALUES(@PlantID,@PlantName,@PlantDesc,@CreatedOn,@CreatedBy)";

                //string query = "INSERT INTO `unitworkccs.parameter_sendor_data`(parameterSensorDataId,machineId,sensorDataCapturedTime,isDeleted,createdOn,correctedDate) VALUES(  @parameterSensorDataId,@machineId,@sensorDataCapturedTime,@isDeleted,@createdOn,@correctedDate)";

                string query = "INSERT INTO `unitworkccs.tblparts`(PartID,FGCode,OperationNo,PartName,IdealCycleTime,PartsPerCycle,UnitDesc,IsDeleted,CreatedOn,CreatedBy,ModifiedOn,ModifiedBy,DrawingNo,DeletedDate,Std_Load_UnloadTime,Std_SetupTime,MachineID,StdMinorLoss,StdLoadingTime,StdUnLoadingTime,PartNo,PartDesc,targetPerHr,planLinkageId,targetPerShift,routingId,resourceId,plantId,priority) VALUES( @PartID,@FGCode,@OperationNo,@PartName,@IdealCycleTime,@PartsPerCycle,@UnitDesc,@IsDeleted,@CreatedOn,@CreatedBy,@ModifiedOn,@ModifiedBy,@DrawingNo,@DeletedDate,@Std_Load_UnloadTime,@Std_SetupTime,@MachineID,@StdMinorLoss,@StdLoadingTime,@StdUnLoadingTime,@PartNo,@PartDesc,@targetPerHr,@planLinkageId,@targetPerShift,@routingId,@resourceId,@plantId,@priority)";

                //string query = "INSERT INTO `unitworkccs.configuration_`(pmid,MachineID,MachineName,Month,Week,IsDeleted,CreatedOn,CreatedBy,ModifiedOn,ModifiedBy,CellName,CellID,PlantID,ShopID,plantName,shopname,MonthID,WeekID) VALUES(@pmid,@MachineID,@MachineName,@Month,@Week,@IsDeleted,@CreatedOn,@CreatedBy,@ModifiedOn,@ModifiedBy,@CellName,@CellID,@PlantID,@ShopID,@plantName,@shopname,@MonthID,@WeekID)";

                using (var con = _connectionFactory.GetConnection)
                {
                    res = con.Execute(query, datalist, commandTimeout: 600);
                    con.Close();
                }
            }
            catch (Exception ex)
            {

            }
            return Task.FromResult<int>(res);
        }





        //public Task<int> insert_ddlistsql(List<MyDAL.Model.tblddl> datalist)
        //{
        //    int res = 0;
        //    List<MySQLDAL.DAL.ddl> ddllist = new List<DAL.ddl>();
        //    foreach (var row in datalist)
        //    {
        //        MySQLDAL.DAL.ddl dlist = new DAL.ddl();
        //        dlist.DDLID = row.DDLID;
        //        dlist.WorkCenter = row.WorkCenter;
        //        dlist.WorkOrder = row.WorkOrder;
        //        dlist.OperationNo = row.OperationNo;
        //        dlist.OperationDesc = row.OperationDesc;
        //        dlist.MaterialDesc = row.MaterialDesc;
        //        dlist.PartName = row.PartName;
        //        dlist.TargetQty = row.TargetQty;
        //        dlist.Type = row.Type;
        //        dlist.Project = row.Project;
        //        dlist.MADDate = row.MADDate;
        //        dlist.MADDateInd = row.MADDateInd;
        //        dlist.PreOpnEndDate = row.PreOpnEndDate;
        //        dlist.DaysAgeing = row.DaysAgeing;
        //        dlist.OperationsOnHold = row.OperationsOnHold;
        //        dlist.ReasonForHold = row.ReasonForHold;
        //        dlist.DueDate = row.DueDate;
        //        dlist.FlagRushInd = row.FlagRushInd;
        //        dlist.SplitWO = row.SplitWO;
        //        dlist.IsCompleted = row.IsCompleted;
        //        dlist.IsDeleted = row.IsDeleted;
        //        dlist.DeliveredQty = row.DeliveredQty;
        //        dlist.ScrapQty = row.ScrapQty;
        //        dlist.InsertedOn = row.InsertedOn;
        //        dlist.CorrectedDate = row.CorrectedDate;


        //        ddllist.Add(dlist);

        //    }
        //    try
        //    {
        //        ConnectionFactory _connectionFactory = new ConnectionFactory();
        //        string query = "INSERT INTO [i_facility_tsal].[dbo].[tblddl](DDLID,WorkCenter,WorkOrder,OperationNo,OperationDesc,MaterialDesc,PartName,TargetQty,Type,Project,MADDate,MADDateInd,PreOpnEndDate,DaysAgeing,OperationsOnHold,ReasonForHold,DueDate,FlagRushInd,SplitWO,IsCompleted,IsDeleted,DeliveredQty,ScrapQty,InsertedOn,CorrectedDate) VALUES(@DDLID,@WorkCenter,@WorkOrder,@OperationNo,@OperationDesc,@MaterialDesc,@PartName,@TargetQty,@Type,@Project,@MADDate,@MADDateInd,@PreOpnEndDate,@DaysAgeing,@OperationsOnHold,@ReasonForHold,@DueDate,@FlagRushInd,@SplitWO,@IsCompleted,@IsDeleted,@DeliveredQty,@ScrapQty,@InsertedOn,@CorrectedDate)";
        //        using (var con = _connectionFactory.GetConnection)
        //        {
        //            res = con.Execute(query, ddllist, commandTimeout: 600);
        //            con.Close();
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    return Task.FromResult<int>(res);
        //}

        public int insertPlnatinMYsql1(string PlantName, string PlantDesc, int IsDeleted, DateTime CreatedOn, int CreatedBy, string PlantDisplayName)
        {
            int res = 0;
            try
            {
                string dateee = CreatedOn.ToString("yyyy-MM-dd HH:mm:ss");
                string query = "INSERT INTO  tblplant(PlantName,PlantDesc,IsDeleted, CreatedOn, CreatedBy, PlantDisplayName) VALUES('" + PlantName + "','" + PlantDesc + "','" + IsDeleted + "','" + dateee + "','" + CreatedBy + "','" + PlantDisplayName + "')";
                res = _connectionFactory.GetConnection.ExecuteAsync(query).Result;

                // var re = await Task.FromResult<int>(_connectionFactory.GetConnectionLive.ExecuteAsync(query).Result);
                // res = Convert.ToInt32(res);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return res;
        }

        public int insertPlnatinMYsql2(string PlantName, string PlantDesc, int IsDeleted, DateTime CreatedOn, int CreatedBy, string PlantDisplayName, int plantId)
        {
            int res = 0;
            try
            {
                string dateee = CreatedOn.ToString("yyyy-MM-dd HH:mm:ss");
                string query = "INSERT INTO  tblplant(PlantName,PlantDesc,IsDeleted, CreatedOn, CreatedBy, PlantDisplayName,plantId) VALUES('" + PlantName + "','" + PlantDesc + "','" + IsDeleted + "','" + dateee + "','" + CreatedBy + "','" + PlantDisplayName + "',"+ plantId + ")";
                res = _connectionFactory.GetConnection.ExecuteAsync(query).Result;

                // var re = await Task.FromResult<int>(_connectionFactory.GetConnectionLive.ExecuteAsync(query).Result);
                // res = Convert.ToInt32(res);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return res;
        }


        public List<configurationtblmachinedetail> GetMachineDetails()
        {
            List<configurationtblmachinedetail> machinelist = new List<configurationtblmachinedetail>();
            try
            {
                string qry = "SELECT IPAddress,MachineType,MachineID,IsParameters,CurrentControlAxis,MachineLockBit, MachineSetupBit, MachineMaintBit, MachineToolLifeBit, MachineUnlockBit, MachineIdleBit, MachineIdleMin, EnableLockLogic From  " + ConnectionFactory.DBConfig + "." + "configurationtblmachinedetails WHERE IsDeleted = 0 and MachineModelType = 1 order by MachineID";
                machinelist = _connectionFactory.GetConnectionConfig.QueryAsync<configurationtblmachinedetail>(qry).Result.ToList();

                //machinelist = await Task.FromResult<List<configurationtblmachinedetail>>(_connectionFactory.GetConnectionConfig.QueryAsync<configurationtblmachinedetail>(qry).Result.ToList());


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return machinelist;
        }

        public int insertPlnatinMYsql(string PlantName, string PlantDesc, int IsDeleted, string CreatedOn, int CreatedBy, string PlantDisplayName, string PlantCode, string PlantLocation,string ModifiedOn,int ModifiedBy)
        {
            int res = 0;
            try
            {

                string query = "INSERT INTO  tblplant(PlantName,PlantDesc,IsDeleted, CreatedOn, CreatedBy, PlantDisplayName,PlantCode, PlantLocation,ModifiedOn,ModifiedBy) VALUES('" + PlantName + "','" + PlantDesc + "','" + IsDeleted + "','" + CreatedOn + "','" + CreatedBy + "','" + PlantDisplayName + "','" + PlantCode + "','" + PlantLocation + "','" + ModifiedOn + "','"+ ModifiedBy + "')";
                res = _connectionFactory.GetConnection.ExecuteAsync(query).Result;

                // var re = await Task.FromResult<int>(_connectionFactory.GetConnectionLive.ExecuteAsync(query).Result);
                // res = Convert.ToInt32(res);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return res;
        }

        //public int InsertOperationLogDetails(string OpMsg,DateTime OpDate,TimeSpan opTime, DateTime OpDateTime, string opReason, int mcid)
        //{
        //    int res = 0;
        //    try
        //    {   
        //        string query = "INSERT INTO  configurationoperationlog(OpMsg,OpDate,OpTime,OpDateTime,OpReason,MachineID) VALUES(' " + OpMsg + "','" + OpDate + "','" + opTime + "','" + OpDateTime + "','"+opReason+"'," + mcid + "'";
        //        res = _connectionFactory.GetConnection.ExecuteAsync(query).Result;
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    return res;
        //}

        public int InsertOperationLogDetails(string OpMsg, string OpDate, string opTime, string OpDateTime, string opReason, int mcid)
        {
            int res = 0;
            try
            {
                string query = "INSERT INTO  configurationoperationlog(OpMsg,OpDate,OpTime,OpDateTime,OpReason,MachineID) VALUES(' " + OpMsg + "','" + OpDate + "','" + opTime + "','" + OpDateTime + "','" + opReason + "'," + mcid + ")";
                res = _connectionFactory.GetConnectionConfig.ExecuteAsync(query).Result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return res;
        }



        public int InserttbllivemodeDetails(string MacMode, int MacID, int InsertedBy, DateTime InsertedOn, DateTime correctedDate, string StartTimeNext, string ColoCode, string ModeType)
        {
            int res = 0;
            try
            {
                string query = "INSERT INTO livetbllivemode (MacMode,MachineID,InsertedBy,InsertedOn,CorrectedDate,StartTime,ColorCode,ModeType) VALUES('" + MacMode + "'," + MacID + "','" + InsertedBy + "','" + InsertedOn + "''" + ",1,'" + correctedDate.ToString("yyyy-MM-dd") + "','" + StartTimeNext + "','" + ColoCode + "','" + ModeType + "')";
                res = _connectionFactory.GetConnection.ExecuteAsync(query).Result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return res;
        }

       

        public int UpdatetbllivemodeDetails(DateTime NowDateCalc, int durationinsec, int ModeID)
        {
            int res = 0;
            try
            {
                //Reopository<live_tblmode> lista = new Reopository<live_tblmode>();
                string query = "UPDATE livetbllivemode SET EndTime = '" + NowDateCalc.ToString("yyyy-MM-dd HH:mm:ss") + "', IsCompleted = 1, ModeTypeEnd = 1, DurationInSec = " + durationinsec + " Where ModeID = " + ModeID + "";
                res = _connectionFactory.GetConnection.ExecuteAsync(query).Result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return res;
        }

        public int InserttbllivemodeDetails(string MacMode, int MacID, int InsertedBy, DateTime InsertedOn, DateTime correctedDate, DateTime StartTimeNext, string ColoCode, int LossCodeID, string ModeType)
        {
            int res = 0;
            try
            {
                //Reopository<live_tblmode> lista = new Reopository<live_tblmode>();
                string query = "INSERT INTO livetbllivemode (MacMode,MachineID,InsertedBy,InsertedOn,CorrectedDate,StartTime,ColorCode, LossCodeID, ModeType) VALUES('" + MacMode + "'," + MacID + ",'" + InsertedBy + "'," + InsertedOn + "','" + "','" + correctedDate.ToString("yyyy-MM-dd") + "','" + StartTimeNext + "','" + ColoCode + "'," + Convert.ToInt32(LossCodeID) + ",'" + ModeType + "'";
                res = _connectionFactory.GetConnection.ExecuteAsync(query).Result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return res;
        }

        public int UpdatetbllivemodeDetails1(DateTime nowdate, int MacID, int durationinsec, int ModeID)
        {
            int res = 0;
            try
            {
                //Reopository<live_tblmode> lista = new Reopository<live_tblmode>();
                string query = "UPDATE livetbllivemode SET EndTime = '" + nowdate.ToString("yyyy-MM-dd HH:mm:ss") + "', IsCompleted = 1, DurationInSec = " + durationinsec + ", ModeTypeEnd = 1, StartIdle = 0 Where ModeID = " + ModeID + "";
                res = _connectionFactory.GetConnection.ExecuteAsync(query).Result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return res;
        }

        public int InserttbllivemodeDetails(string MacMode, int MacID, int InsertedBy, DateTime InsertedOn, DateTime correctedDate, DateTime StartTime, string ColorCode, string ModeType, DateTime nowdate)
        {
            int res = 0;
            try
            {
                //Reopository<live_tblmode> lista = new Reopository<live_tblmode>();
                string query = "INSERT INTO livetbllivemode (MacMode,MachineID,InsertedBy,InsertedOn,CorrectedDate,StartTime,ColorCode, ModeType) VALUES('," + MacMode + "','" + MacID + "','" + InsertedBy + "','" + InsertedOn + "','" + correctedDate.ToString("yyyy-MM-dd") + "','" + nowdate.ToString("yyyy-MM-dd HH:mm:ss") + "','" + ColorCode + "','" + MacMode + "'";
                res = _connectionFactory.GetConnection.ExecuteAsync(query).Result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return res;
        }


        public int UpdatetbllivemodeDetails1(int ModeID)
        {
            int res = 0;
            try
            {
                //Reopository<live_tblmode> lista = new Reopository<live_tblmode>();
                string query = "UPDATE livetbllivemode SET StartIdle = 1 Where ModeID = " + ModeID + "";
                res = _connectionFactory.GetConnection.ExecuteAsync(query).Result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return res;
        }

        public int InsertOperationLogDetails4(string OpMsg, DateTime OpDate, TimeSpan OpTime, DateTime OpDateTime, string OpReason, int MachineID, int ConnectionRet, int ConnectionRetErr, int MacID)
        {
            int res = 0;
            try
            {
                //Reopository<operationlog> lista = new Reopository<operationlog>();
                string query = "INSERT INTO  configurationoperationlog(OpMsg,OpDate,OpTime,OpDateTime,OpReason,MachineID) VALUES('" + OpMsg + ConnectionRet + " ErrorNo " + ConnectionRetErr + "','" + OpDate + "','" + OpTime + "','" + OpDateTime + "','" + OpReason + "'," + MacID + ")";
                res = _connectionFactory.GetConnection.ExecuteAsync(query).Result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return res;
        }

        public List<configurationtblmachinedetail> GetMachineDetails(int machineid)
        {
            //Reopository<configuration_tblmachinedetails> lista = new Reopository<configuration_tblmachinedetails>();
            List<configurationtblmachinedetail> det = new List<configurationtblmachinedetail>();
            try
            {
                string query = "SELECT MachineDisplayName FROM  tblmachinedetails WHERE MachineID = " + machineid + ";";
                det = _connectionFactory.GetConnectionConfig.QueryAsync<configurationtblmachinedetail>(query).Result.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return det;
        }

        public List<configurationtblmachinedetail> MachineDetails1(int machineid)
        {
            //Reopository<configuration_tblmachinedetails> lista = new Reopository<configuration_tblmachinedetails>();
            List<configurationtblmachinedetail> det = new List<configurationtblmachinedetail>();
            try
            {
                string query = "SELECT ProgramNum,ProgDBit From  tblmachinedetails WHERE IsDeleted = 0 AND MachineID = " + machineid + " order by MachineID";
                det = _connectionFactory.GetConnectionConfig.QueryAsync<configurationtblmachinedetail>(query).Result.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return det;
        }

        public int InsertAxisDetails1(int machineid, string AxisNo, string AbsPos, string RelPos, string MacPos, string DisPos, DateTime StartTime, int IsDeleted, DateTime InsertedOn)
        {
            int res = 0;
            try
            {
                //Reopository<tbl_axisdetails1> lista = new Reopository<tbl_axisdetails1>();
                string query = "INSERT INTO tbl_liveaxisdetails1(MachineID,Axis,AbsPos,RelPos,MacPos,DistPos,StartTime,IsDeleted,InsertedOn)" + //
                            "VALUES('" + machineid + "','" + AxisNo + "','" + AbsPos + "'," + RelPos + ",'" + MacPos + "','" + DisPos + "','" + StartTime + "','" + IsDeleted + InsertedOn + "')";
                res = _connectionFactory.GetConnectionLive.ExecuteAsync(query).Result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return res;
        }

        public int InsertAxisDetails2(int machineid, decimal FeedRate, string SpiLoadMain, decimal SpindleSpeed, DateTime StartTime, int IsDeleted, DateTime InsertedOn)
        {
            int res = 0;
            try
            {
                //Reopository<tbl_axisdetails2> lista = new Reopository<tbl_axisdetails2>();
                string query = "INSERT INTO  tbl_liveaxisdetails2(MachineID,FeedRate,SpindleLoad,SpindleSpeed,StartTime,IsDeleted,InsertedOn)" + //
                            "VALUES('" + machineid + "','" + FeedRate + "','" + SpiLoadMain.ToString() + "'," + SpindleSpeed + ",'" + StartTime + "','" + IsDeleted + "','" + InsertedOn + "')";
                res = _connectionFactory.GetConnection.ExecuteAsync(query).Result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return res;
        }

        public int InsertServoDetails(int machineid, string AxisName, string ServLoadMain, string ServCurPerMain, string ServcurrAmpMain, DateTime StartDateTime, int IsDeleted, DateTime InsertedOn, int InsertedBy)
        {
            int res = 0;
            try
            {
                //Reopository<tbl_servodetails> lista = new Reopository<tbl_servodetails>();
                string query = "INSERT INTO  tbl_liveservodetails(MachineID,ServoAxis,ServoLoadMeter,LoadCurrent,LoadCurrentAmp,StartDateTime,IsDeleted,InsertedOn,InsertedBy)" + //
                                        "VALUES('" + machineid + "','" + AxisName + "','" + ServLoadMain + "','" + ServCurPerMain + "','" + ServcurrAmpMain + "','" + StartDateTime + "','" + IsDeleted + "','" + InsertedOn + "','" + InsertedBy + ")";
                res = _connectionFactory.GetConnectionLive.ExecuteAsync(query).Result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return res;
        }

        public int InsertServoDetails1(int machineid, string AxisName2, string ServLoadMain2, string ServCurPerMain2, string ServcurrAmpMain2, DateTime StartDateTime, int IsDeleted, DateTime InsertedOn, int InsertedBy)
        {
            int res = 0;
            try
            {
                //Reopository<tbl_servodetails> lista = new Reopository<tbl_servodetails>();
                string query = "INSERT INTO  tbl_liveservodetails(MachineID,ServoAxis,ServoLoadMeter,LoadCurrent,LoadCurrentAmp,StartDateTime,IsDeleted,InsertedOn,InsertedBy)" + //
                                        "VALUES('" + machineid + "','" + AxisName2 + "','" + ServLoadMain2 + "','" + ServCurPerMain2 + "','" + ServcurrAmpMain2 + "','" + StartDateTime + "','" + IsDeleted + "','" + InsertedOn + "','" + InsertedBy + "')";
                res = _connectionFactory.GetConnectionLive.ExecuteAsync(query).Result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return res;
        }

        public int InsertServoDetails2(int machineid, string AxisName3, string ServLoadMain3, string ServCurPerMain3, string ServcurrAmpMain3, DateTime StartDateTime, int IsDeleted, DateTime InsertedOn, int InsertedBy)
        {
            int res = 0;
            try
            {
                //Reopository<tbl_servodetails> lista = new Reopository<tbl_servodetails>();
                string query = "INSERT INTO  tbl_liveservodetails(MachineID,ServoAxis,ServoLoadMeter,LoadCurrent,LoadCurrentAmp,StartDateTime,IsDeleted,InsertedOn,InsertedBy)" + //
                                        "VALUES('" + machineid + "','" + AxisName3 + "','" + ServLoadMain3 + "','" + ServCurPerMain3 + "','" + ServcurrAmpMain3 + "','" + StartDateTime + "','" + IsDeleted + "','" + InsertedOn + "','" + InsertedBy + "')";
                res = _connectionFactory.GetConnectionLive.ExecuteAsync(query).Result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return res;
        }

        public int InsertServoDetails3(int machineid, string AxisName4, string ServLoadMain4, string ServCurPerMain4, string ServcurrAmpMain4, DateTime StartDateTime, int IsDeleted, DateTime InsertedOn, int InsertedBy)
        {
            int res = 0;
            try
            {
                //Reopository<tbl_servodetails> lista = new Reopository<tbl_servodetails>();
                string query = "INSERT INTO  tbl_liveservodetails(MachineID,ServoAxis,ServoLoadMeter,LoadCurrent,LoadCurrentAmp,StartDateTime,IsDeleted,InsertedOn,InsertedBy)" + //
                                        "VALUES('" + machineid + "','" + AxisName4 + "','" + ServLoadMain4 + "','" + ServCurPerMain4 + "','" + ServcurrAmpMain4 + "','" + StartDateTime + "','" + IsDeleted + "','" + InsertedOn + "','" + InsertedBy + "')";
                res = _connectionFactory.GetConnectionLive.ExecuteAsync(query).Result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return res;
        }


    }
}

















//string mainconn = ConfigurationManager.ConnectionStrings["MySqlConnection11"].ConnectionString;
//MySqlConnection mysql = new MySqlConnection(mainconn);

//string query1 = "SELECT * From   tblplant WHERE IsDeleted = 0";


//MySqlCommand cmd = new MySqlCommand(query1);
//cmd.Connection = mysql;

//mysql.Open();
//MySqlDataReader dr = cmd.ExecuteReader();

//while (dr.Read())
//{
//    plantList.Add(new configuration_tblplant
//    {
//        PlantName = dr["PlantName"].ToString()

//    }); 


//}