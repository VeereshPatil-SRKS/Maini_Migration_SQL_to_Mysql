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