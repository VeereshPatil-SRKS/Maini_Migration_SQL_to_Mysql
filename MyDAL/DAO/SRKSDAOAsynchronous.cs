using Dapper;
using MyDAL.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDAL.DAO
{
    public class SRKSDAOAsynchronous : ConnectionFactory
    {
        IConnectionFactory _connectionFactory;
        public SRKSDAOAsynchronous()
        {

        }

        public SRKSDAOAsynchronous(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public async Task<List<configurationtblmachinedetail>> GetMachineDetails()
        {
            List<configurationtblmachinedetail> machinelist = new List<configurationtblmachinedetail>();
            try
            {
                string qry = "SELECT IPAddress,MachineType,MachineID,IsParameters,CurrentControlAxis,MachineLockBit, MachineSetupBit, MachineMaintBit, MachineToolLifeBit, MachineUnlockBit, MachineIdleBit, MachineIdleMin, EnableLockLogic From  " + ConnectionFactory.DBConfig + "." + "configurationtblmachinedetails WHERE IsDeleted = 0 and MachineModelType = 1 order by MachineID";
                machinelist = await Task.FromResult<List<configurationtblmachinedetail>>(_connectionFactory.GetConnectionConfig.QueryAsync<configurationtblmachinedetail>(qry).Result.ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return machinelist;
        }

        public async Task<int> InsertParameterDetails(string cuttingtime, string operatingtime, string powertime, double partcount, int parttotal, int mcid, int shift, string CorrectedDate, string InsertedOn)
        {
            int res = 0;
            try
            {
                string query = "INSERT INTO  liveparameters_master(CuttingTime,OperatingTime,InsertedOn, PowerOnTime, PartsCount, PartsTotal,MachineID, Shift, CorrectedDate) VALUES('" + cuttingtime + "','" + operatingtime + "','" + InsertedOn + "','" + powertime + "','" + partcount + "','" + parttotal + "','" + mcid + "','" + shift + "','" + CorrectedDate + "')";
                var re = await Task.FromResult<int>(_connectionFactory.GetConnectionLive.ExecuteAsync(query).Result);
                res = Convert.ToInt32(res);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return res;
        }
        public async Task<int> InsertOperationLogDetails(string OpMsg, string OpDate, string opTime, string OpDateTime, string opReason, int mcid)
        {
            int res = 0;
            try
            {
                string query = "INSERT INTO  configurationoperationlog(OpMsg,OpDate,OpTime,OpDateTime,OpReason,MachineID) VALUES(' " + OpMsg + "','" + OpDate + "','" + opTime + "','" + OpDateTime + "','" + opReason + "'," + mcid + ")";
                res = await Task.FromResult<int>(_connectionFactory.GetConnectionConfig.ExecuteAsync(query).Result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return res;
        }
       
        public async Task<int> InserttbllivemodeDetails(string MacMode, int MacID, int InsertedBy, string InsertedOn, string correctedDate, string StartTimeNext, string ColoCode, string ModeType)
        {
            int res = 0;
            try
            {
                string query = "INSERT INTO livetbllivemode (MacMode,MachineID,InsertedBy,InsertedOn,CorrectedDate,StartTime,ColorCode,ModeType) VALUES('" + MacMode + "'," + MacID + ",'" + InsertedBy + ",'" + InsertedOn + ",'" + correctedDate + "','" + StartTimeNext + "','" + ColoCode + "','" + ModeType + "')";
                res = await Task.FromResult<int>(_connectionFactory.GetConnectionLive.ExecuteAsync(query).Result);
                //res = _connectionFactory.GetConnection.ExecuteAsync(query).Result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return res;
        }

        public async Task<int> UpdatetbllivemodeDetails(DateTime NowDateCalc, int durationinsec, int ModeID)
        {
            int res = 0;
            try
            {
                //Reopository<live_tblmode> lista = new Reopository<live_tblmode>();
                string query = "UPDATE livetbllivemode SET EndTime = '" + NowDateCalc.ToString("yyyy-MM-dd HH:mm:ss") + "', IsCompleted = 1, ModeTypeEnd = 1, DurationInSec = " + durationinsec + " Where ModeID = " + ModeID + "";
                var re = await Task.FromResult<int>(_connectionFactory.GetConnectionLive.ExecuteAsync(query).Result);
                res = Convert.ToInt32(res);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return res;
        }

        public async Task<int> UpdatetbllivemodeDetails(DateTime nowdate, int durationinsec, int StartIDLE, int ModeID)
        {
            int res = 0;
            try
            {

                string query = "UPDATE livetbllivemode SET EndTime = '" + nowdate.ToString("yyyy-MM-dd HH:mm:ss") + "', IsCompleted = 1, DurationInSec = " + durationinsec + ", ModeTypeEnd = 1, StartIdle = " + StartIDLE + " Where ModeID = " + ModeID + "";
                var re = await Task.FromResult<int>(_connectionFactory.GetConnectionLive.ExecuteAsync(query).Result);
                res = Convert.ToInt32(res);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return res;
        }

        public async Task<int> UpdatetbllivemodeDetails(int StartIDLE, int ModeID)
        {
            int res = 0;
            try
            {

                string query = "UPDATE livetbllivemode SET StartIdle = " + StartIDLE + " Where ModeID = " + ModeID + "";
                var re = await Task.FromResult<int>(_connectionFactory.GetConnectionLive.ExecuteAsync(query).Result);
                res = Convert.ToInt32(res);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return res;
        }

        public async Task<int> InserttbllivemodeDetails(string MacMode, int MacID, int InsertedBy, string InsertedOn, string correctedDate, string StartTimeNext, string ColoCode, int LossCodeID, string ModeType)
        {
            int res = 0;
            try
            {
                //Reopository<live_tblmode> lista = new Reopository<live_tblmode>();
                string query = "INSERT INTO livetbllivemode (MacMode,MachineID,InsertedBy,InsertedOn,CorrectedDate,StartTime,ColorCode, LossCodeID, ModeType) VALUES('" + MacMode + "'," + MacID + ",'" + InsertedBy + "'," + InsertedOn + "','" + "','" + correctedDate + "','" + StartTimeNext + "','" + ColoCode + "'," + Convert.ToInt32(LossCodeID) + ",'" + ModeType + "'";
                var re = await Task.FromResult<int>(_connectionFactory.GetConnectionLive.ExecuteAsync(query).Result);
                res = Convert.ToInt32(res);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return res;
        }

        public async Task<int> UpdatetbllivemodeDetails1(DateTime nowdate, int MacID, int durationinsec, int ModeID)
        {
            int res = 0;
            try
            {
                //Reopository<live_tblmode> lista = new Reopository<live_tblmode>();
                string query = "UPDATE livetbllivemode SET EndTime = '" + nowdate.ToString("yyyy-MM-dd HH:mm:ss") + "', IsCompleted = 1, DurationInSec = " + durationinsec + ", ModeTypeEnd = 1, StartIdle = 0 Where ModeID = " + ModeID + "";
                var re = await Task.FromResult<int>(_connectionFactory.GetConnectionLive.ExecuteAsync(query).Result);
                res = Convert.ToInt32(res);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return res;
        }

        public async Task<int> InserttbllivemodeDetails(string MacMode, int MacID, int InsertedBy, DateTime InsertedOn, DateTime correctedDate, DateTime StartTime, string ColorCode, string ModeType, DateTime nowdate)
        {
            int res = 0;
            try
            {
                //Reopository<live_tblmode> lista = new Reopository<live_tblmode>();
                string query = "INSERT INTO livetbllivemode (MacMode,MachineID,InsertedBy,InsertedOn,CorrectedDate,StartTime,ColorCode, ModeType) VALUES('," + MacMode + "','" + MacID + "','" + InsertedBy + "','" + InsertedOn + "','" + correctedDate.ToString("yyyy-MM-dd") + "','" + nowdate.ToString("yyyy-MM-dd HH:mm:ss") + "','" + ColorCode + "','" + MacMode + "'";
                var re = await Task.FromResult<int>(_connectionFactory.GetConnectionLive.ExecuteAsync(query).Result);
                res = Convert.ToInt32(res);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return res;
        }


        public async Task<int> UpdatetbllivemodeDetails1(int ModeID)
        {
            int res = 0;
            try
            {
                //Reopository<live_tblmode> lista = new Reopository<live_tblmode>();
                string query = "UPDATE livetbllivemode SET StartIdle = 1 Where ModeID = " + ModeID + "";
                var re = await Task.FromResult<int>(_connectionFactory.GetConnectionLive.ExecuteAsync(query).Result);
                res = Convert.ToInt32(res);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return res;
        }

        public async Task<int> InsertOperationLogDetails4(string OpMsg, DateTime OpDate, TimeSpan OpTime, DateTime OpDateTime, string OpReason, int MachineID, int ConnectionRet, int ConnectionRetErr, int MacID)
        {
            int res = 0;
            try
            {
                //Reopository<operationlog> lista = new Reopository<operationlog>();
                string query = "INSERT INTO  configurationoperationlog(OpMsg,OpDate,OpTime,OpDateTime,OpReason,MachineID) VALUES('" + OpMsg + ConnectionRet + " ErrorNo " + ConnectionRetErr + "','" + OpDate + "','" + OpTime + "','" + OpDateTime + "','" + OpReason + "'," + MacID + ")";
                var re = await Task.FromResult<int>(_connectionFactory.GetConnectionConfig.ExecuteAsync(query).Result);
                res = Convert.ToInt32(res);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return res;
        }

        public async Task<List<configurationtblmachinedetail>> GetMachineDetails(int machineid)
        {
            //Reopository<configuration_tblmachinedetails> lista = new Reopository<configuration_tblmachinedetails>();
            List<configurationtblmachinedetail> det = new List<configurationtblmachinedetail>();
            try
            {
                string query = "SELECT MachineDisplayName FROM  configurationtblmachinedetail WHERE MachineID = " + machineid + ";";
                det = await Task.FromResult<List<configurationtblmachinedetail>>(_connectionFactory.GetConnectionConfig.QueryAsync<configurationtblmachinedetail>(query).Result.ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return det;
        }

        public async Task<List<configurationtblmachinedetail>> GetMachineDetails1(int machineid)
        {
            //Reopository<configuration_tblmachinedetails> lista = new Reopository<configuration_tblmachinedetails>();
            List<configurationtblmachinedetail> det = new List<configurationtblmachinedetail>();
            try
            {
                string query = "SELECT ProgramNum,ProgDBit From  configurationtblmachinedetail WHERE IsDeleted = 0 AND MachineID = " + machineid + " order by MachineID";
                det = await Task.FromResult<List<configurationtblmachinedetail>>(_connectionFactory.GetConnectionConfig.QueryAsync<configurationtblmachinedetail>(query).Result.ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return det;
        }

        public async Task<int> UpdateMessageHistoryDetails(int machineid)
        {
            int res = 0;
            try
            {
                //Reopository<alarm_history_master> lista = new Reopository<alarm_history_master>();
                string query = "Update  message_livehistory_master SET IsProgLock = 1 WHERE MachineID = " + machineid + " ";
                var re = await Task.FromResult<int>(_connectionFactory.GetConnectionLive.ExecuteAsync(query).Result);
                res = Convert.ToInt32(res);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return res;
        }

        public async Task<int> InsertAxisDetails1(int machineid, string AxisNo, string AbsPos, string RelPos, string MacPos, string DisPos, DateTime StartTime, int IsDeleted, DateTime InsertedOn)
        {
            int res = 0;
            try
            {
                //Reopository<tbl_axisdetails1> lista = new Reopository<tbl_axisdetails1>();
                string query = "INSERT INTO tbl_liveaxisdetails1(MachineID,Axis,AbsPos,RelPos,MacPos,DistPos,StartTime,IsDeleted,InsertedOn)" + //
                            "VALUES('" + machineid + "','" + AxisNo + "','" + AbsPos + "'," + RelPos + ",'" + MacPos + "','" + DisPos + "','" + StartTime + "','" + IsDeleted + InsertedOn + "')";
                var re = await Task.FromResult<int>(_connectionFactory.GetConnectionLive.ExecuteAsync(query).Result);
                res = Convert.ToInt32(res);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return res;
        }

        public async Task<int> InsertAxisDetails2(int machineid, decimal FeedRate, string SpiLoadMain, decimal SpindleSpeed, DateTime StartTime, int IsDeleted, DateTime InsertedOn)
        {
            int res = 0;
            try
            {
                //Reopository<tbl_axisdetails2> lista = new Reopository<tbl_axisdetails2>();
                string query = "INSERT INTO  tbl_liveaxisdetails2(MachineID,FeedRate,SpindleLoad,SpindleSpeed,StartTime,IsDeleted,InsertedOn)" + //
                            "VALUES('" + machineid + "','" + FeedRate + "','" + SpiLoadMain.ToString() + "'," + SpindleSpeed + ",'" + StartTime + "','" + IsDeleted + "','" + InsertedOn + "')";
                var re = await Task.FromResult<int>(_connectionFactory.GetConnectionLive.ExecuteAsync(query).Result);
                res = Convert.ToInt32(res);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return res;
        }

        public async Task<int> InsertServoDetails(int machineid, string AxisName, string ServLoadMain, string ServCurPerMain, string ServcurrAmpMain, DateTime StartDateTime, int IsDeleted, DateTime InsertedOn, int InsertedBy)
        {
            int res = 0;
            try
            {
                //Reopository<tbl_servodetails> lista = new Reopository<tbl_servodetails>();
                string query = "INSERT INTO  tbl_liveservodetails(MachineID,ServoAxis,ServoLoadMeter,LoadCurrent,LoadCurrentAmp,StartDateTime,IsDeleted,InsertedOn,InsertedBy)" + //
                                        "VALUES('" + machineid + "','" + AxisName + "','" + ServLoadMain + "','" + ServCurPerMain + "','" + ServcurrAmpMain + "','" + StartDateTime + "','" + IsDeleted + "','" + InsertedOn + "','" + InsertedBy + ")";
                var re = await Task.FromResult<int>(_connectionFactory.GetConnectionLive.ExecuteAsync(query).Result);
                res = Convert.ToInt32(res);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return res;
        }

        public async Task<int> InsertServoDetails1(int machineid, string AxisName2, string ServLoadMain2, string ServCurPerMain2, string ServcurrAmpMain2, DateTime StartDateTime, int IsDeleted, DateTime InsertedOn, int InsertedBy)
        {
            int res = 0;
            try
            {
                //Reopository<tbl_servodetails> lista = new Reopository<tbl_servodetails>();
                string query = "INSERT INTO  tbl_liveservodetails(MachineID,ServoAxis,ServoLoadMeter,LoadCurrent,LoadCurrentAmp,StartDateTime,IsDeleted,InsertedOn,InsertedBy)" + //
                                        "VALUES('" + machineid + "','" + AxisName2 + "','" + ServLoadMain2 + "','" + ServCurPerMain2 + "','" + ServcurrAmpMain2 + "','" + StartDateTime + "','" + IsDeleted + "','" + InsertedOn + "','" + InsertedBy + "')";
                var re = await Task.FromResult<int>(_connectionFactory.GetConnectionLive.ExecuteAsync(query).Result);
                res = Convert.ToInt32(res);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return res;
        }

        public async Task<int> InsertServoDetails2(int machineid, string AxisName3, string ServLoadMain3, string ServCurPerMain3, string ServcurrAmpMain3, DateTime StartDateTime, int IsDeleted, DateTime InsertedOn, int InsertedBy)
        {
            int res = 0;
            try
            {
                //Reopository<tbl_servodetails> lista = new Reopository<tbl_servodetails>();
                string query = "INSERT INTO  tbl_liveservodetails(MachineID,ServoAxis,ServoLoadMeter,LoadCurrent,LoadCurrentAmp,StartDateTime,IsDeleted,InsertedOn,InsertedBy)" + //
                                        "VALUES('" + machineid + "','" + AxisName3 + "','" + ServLoadMain3 + "','" + ServCurPerMain3 + "','" + ServcurrAmpMain3 + "','" + StartDateTime + "','" + IsDeleted + "','" + InsertedOn + "','" + InsertedBy + "')";
                var re = await Task.FromResult<int>(_connectionFactory.GetConnectionLive.ExecuteAsync(query).Result);
                res = Convert.ToInt32(res);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return res;
        }

        public async Task<int> InsertServoDetails3(int machineid, string AxisName4, string ServLoadMain4, string ServCurPerMain4, string ServcurrAmpMain4, DateTime StartDateTime, int IsDeleted, DateTime InsertedOn, int InsertedBy)
        {
            int res = 0;
            try
            {
                //Reopository<tbl_servodetails> lista = new Reopository<tbl_servodetails>();
                string query = "INSERT INTO  tbl_liveservodetails(MachineID,ServoAxis,ServoLoadMeter,LoadCurrent,LoadCurrentAmp,StartDateTime,IsDeleted,InsertedOn,InsertedBy)" + //
                                        "VALUES('" + machineid + "','" + AxisName4 + "','" + ServLoadMain4 + "','" + ServCurPerMain4 + "','" + ServcurrAmpMain4 + "','" + StartDateTime + "','" + IsDeleted + "','" + InsertedOn + "','" + InsertedBy + "')";
                var re = await Task.FromResult<int>(_connectionFactory.GetConnectionLive.ExecuteAsync(query).Result);
                res = Convert.ToInt32(res);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return res;
        }


        public async Task<int> DeleteModeDetails(int ModeID)
        {
            int res = 0;
            try
            {
                string query = "DELETE FROM livetbllivemode where ModeID = " + ModeID + "";
                res = await Task.FromResult<int>(_connectionFactory.GetConnectionLive.ExecuteAsync(query).Result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return res;
        }

    }
}
