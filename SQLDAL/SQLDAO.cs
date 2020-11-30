using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDAL;
using MySQLDAL.DAL;
using SQLDAL;
using MyDAL.DAL;

namespace SQLDAL
{
    public class SQLDAO
    {

        IConnectionFactory _connectionFactory;
        public SQLDAO()
        {

        }

        public SQLDAO(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }



        public List<tblplant> GetPlantDetails()
        {
            //string item = "";

           List< tblplant> Plant = new List<tblplant>();
            SQLDAL.Reopository<tblplant> lista = new SQLDAL.Reopository<tblplant>();
            try
            {
                string query = "SELECT *  from unitworkccs.tblplant WHERE isdeleted =0";
                Plant = lista.GetList(query, _connectionFactory.GetConnection);
               
            }
            catch (Exception ex)
            {
              //  IntoFile(ex.ToString());
                // MessageBox.Show(ex.ToString());
            }
            return Plant;
        }



        public Task<int> insert_ddlMysqlPlantSQl(List<tblplant> datalist)
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
                string query = "INSERT INTO [unitworksccs].[unitworkccs].[tblddl](plantId,PlantName,PlantDesc,IsDeleted, CreatedOn, CreatedBy) " +
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
        //            res = con.Execute(query, ddllist,commandTimeout: 600);
        //             con.Close();
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    return Task.FromResult<int>(res);
        //}











        private string GetCorrectedDate()
        {
            using (unitworksccsEntities db = new unitworksccsEntities())
            {
                string correctedDateformat = "";
                try
                {
                    DateTime correctedDate = DateTime.Now;
                    var daytimings = db.tbldaytimings.Where(m => m.IsDeleted == 0).FirstOrDefault();
                    if (daytimings != null)
                    {
                        DateTime Start = Convert.ToDateTime(correctedDate.ToString("yyyy-MM-dd") + " " + daytimings.StartTime);
                        if (Start <= DateTime.Now)
                        {
                            correctedDate = DateTime.Now.Date;
                        }
                        else
                        {
                            correctedDate = DateTime.Now.AddDays(-1).Date;
                        }
                    }
                     correctedDateformat = correctedDate.ToString("yyyy-MM-dd");
                }
                catch(Exception ex)
                {

                }
                // DateTime date = correctedDate.Date;
                return correctedDateformat;
            }
        }



        /*   public List<tbllivemodedb> getLiveModeSQL()
           {
               var modelist = new List<tbllivemodedb>();
               using (i_facility_tsalEntities db = new i_facility_tsalEntities())
               {
                   string correcteddate = GetCorrectedDate();
                   //DateTime newdate = Convert.ToDateTime(correcteddate);


                   modelist = db.tbllivemodedbs.Where(m=>m.CorrectedDate==correcteddate).OrderBy(m => m.ModeID).ToList();
               }
               return modelist;
           }

           public Task<int> PCBDAQ_multipeldatainsert(List<MyDAL.Model.tbllivemodedb> datalist)
           {
               int res = 0;
               List<SQLDAL.DAL.livemodedb> listmodes = new List<SQLDAL.DAL.livemodedb>();
               foreach (var row in datalist)
               {
                   SQLDAL.DAL.livemodedb mrow = new DAL.livemodedb();
                   mrow.ModeID = row.ModeID;
                   mrow.MachineID = row.MachineID;
                   mrow.Mode = row.Mode;
                   mrow.InsertedOn = row.InsertedOn;
                   mrow.InsertedBy = row.InsertedBy;
                   mrow.CorrectedDate = row.CorrectedDate;
                   mrow.StartTime = row.StartTime;
                   mrow.EndTime = row.EndTime;
                   mrow.ColorCode = row.ColorCode;
                   mrow.IsCompleted = row.IsCompleted;
                   mrow.DurationInSec = row.DurationInSec;
                   listmodes.Add(mrow);
               }
               try
               {
                   ConnectionFactory _connectionFactory = new ConnectionFactory();
                   string query = "INSERT INTO [i_facility_tsal].[dbo].[tbllivemodedb](ModeID,MachineID,Mode, InsertedOn,InsertedBy, CorrectedDate,StartTime,EndTime,ColorCode,IsCompleted,DurationInSec) VALUES(@ModeID,@MachineID,@Mode,@InsertedOn,@InsertedBy,@CorrectedDate,@StartTime,@EndTime,@ColorCode,@IsCompleted,@DurationInSec)";
                   using (var con = _connectionFactory.GetConnection)
                   {
                       res = _connectionFactory.GetConnection.Execute(query, listmodes);//( commandTimeout: 60);
                       con.Close();
                   }
               }
               catch (Exception ex)
               {

               }
               return Task.FromResult<int>(res);
           }
           public List<tblmode> getModeSQL()
           {
               var modelist = new List<tblmode>();
               using (i_facility_tsalEntities db = new i_facility_tsalEntities())
               {
                   string correcteddate = GetCorrectedDate();
                   //DateTime newdate = Convert.ToDateTime(correcteddate);


                   int modeid = 2580548;

                   modelist = db.tblmodes.Where(m=>m.ModeID> modeid &&m.CorrectedDate==correcteddate).OrderBy(m => m.ModeID).ToList();
               }
               return modelist;
           }

          /* public List<tblmode> PRevgetModeSQL()
           {
               var modelist = new List<tblmode>();
               using (i_facility_tsalEntities db = new i_facility_tsalEntities())
               {
                   string correcteddate = GetCorrectedDate();
                   //DateTime newdate = Convert.ToDateTime(correcteddate);



                   modelist = db.tblmodes.Where(m=>m.CorrectedDate==correcteddate).OrderByDescending(m => m.ModeID).Take(5).ToList();
               }
               return modelist;
           }

           public Task<int> PCBDAQ__mode(List<MyDAL.Model.tblmode> datalist)
           {
               int res = 0;
               List<SQLDAL.DAL.mode> listmodes = new List<SQLDAL.DAL.mode>();
               foreach (var row in datalist)
               {
                   SQLDAL.DAL.mode mrow = new DAL.mode();
                   mrow.ModeID = row.ModeID;
                   mrow.MachineID = row.MachineID;
                   mrow.Mode = row.Mode;
                   mrow.InsertedOn = row.InsertedOn;
                   mrow.InsertedBy = row.InsertedBy;
                   mrow.CorrectedDate = row.CorrectedDate;
                   mrow.StartTime = row.StartTime;
                   mrow.EndTime = row.EndTime;
                   mrow.ColorCode = row.ColorCode;
                   mrow.IsCompleted = row.IsCompleted;
                   mrow.DurationInSec = row.DurationInSec;
                   mrow.ModeMonth = row.ModeMonth;
                   mrow.ModeQuarter = row.ModeQuarter;
                   mrow.ModeWeekNumber = row.ModeWeekNumber;
                   mrow.ModeYear = row.ModeYear;

                   listmodes.Add(mrow);
               }
               try
               {
                   ConnectionFactory _connectionFactory = new ConnectionFactory();
                   string query = "INSERT INTO [i_facility_tsal].[dbo].[tblmode](ModeID,MachineID,Mode, InsertedOn,InsertedBy,ModifiedOn,ModifiedBy, CorrectedDate,IsDeleted,StartTime,EndTime,ColorCode,IsCompleted,DurationInSec,ModeMonth,ModeYear,ModeWeekNumber,ModeQuarter) VALUES(@ModeID,@MachineID,@Mode,@InsertedOn,@InsertedBy,@ModifiedOn,@ModifiedBy,@CorrectedDate,@IsDeleted,@StartTime,@EndTime,@ColorCode,@IsCompleted,@DurationInSec,@ModeMonth,@ModeYear,@ModeWeekNumber,@ModeQuarter)";

                   using (var con = _connectionFactory.GetConnection)
                   {
                       res = _connectionFactory.GetConnection.Execute(query,listmodes); //(commandTimeout: 60);
                       con.Close();
                   }
               }
               catch (Exception ex)
               {

               }
               return Task.FromResult<int>(res);
           }
           public List<tbllivehmiscreen> screensql()
           {
               var hmiilist = new List<tbllivehmiscreen>();
               using (i_facility_tsalEntities db = new i_facility_tsalEntities())
               {
                   string correcteddate = GetCorrectedDate();
                   //DateTime newdate = Convert.ToDateTime(correcteddate);

                   hmiilist = db.tbllivehmiscreens.Where(m=>m.CorrectedDate==correcteddate).OrderBy(m => m.HMIID).ToList();
               }
               return hmiilist;
           }
           public Task<int> insert_screen(List<MyDAL.Model.tbllivehmiscreen> datalist)
           {
               int res = 0;
               List<SQLDAL.DAL.livehmiscreen> listhmi = new List<DAL.livehmiscreen>();
               foreach (var row in datalist)
               {
                   SQLDAL.DAL.livehmiscreen listrow = new DAL.livehmiscreen();
                   listrow.HMIID = row.HMIID;
                   listrow.MachineID = row.MachineID;
                   listrow.OperationNo = row.OperationNo;
                   listrow.Shift = row.Shift;
                   listrow.Date = row.Date;
                   listrow.Time = row.Time;
                   listrow.Project = row.Project;
                   listrow.PartNo = row.PartNo;
                   listrow.OperationNo = row.OperationNo;
                   listrow.Rej_Qty = row.Rej_Qty;
                   listrow.Work_Order_No = row.Work_Order_No;
                   listrow.Target_Qty = row.Target_Qty;
                   listrow.Delivered_Qty = row.Delivered_Qty;
                   listrow.Status = row.Status;
                   listrow.CorrectedDate = row.CorrectedDate;
                   listrow.Prod_FAI = row.Prod_FAI;
                   listrow.isUpdate = row.isUpdate;
                   listrow.DoneWithRow = row.DoneWithRow;
                   listrow.isWorkInProgress = row.isWorkInProgress;
                   listrow.isWorkOrder = row.isWorkOrder;
                   listrow.OperatorDet = row.OperatorDet;
                   listrow.PEStartTime = row.PEStartTime;
                   listrow.ProcessQty = row.ProcessQty;
                   listrow.DDLWokrCentre = row.DDLWokrCentre;
                   listrow.IsMultiWO = row.IsMultiWO;
                   listrow.IsHold = row.IsHold;
                   listrow.SplitWO = row.SplitWO;
                   listrow.batchNo = row.batchNo;


                   listhmi.Add(listrow);
               }
               //try
               //{
               //    ConnectionFactory _connectionFactory = new ConnectionFactory();
               //    string query = "INSERT INTO [i_facility_tsal].[dbo].[tbllivehmiscreen](HMIID,MachineID,OperatiorID, Shift,Date,Time,Project PartNo,OperationNo,Rej_Qty,Work_Order_No,Target_Qty,Delivered_Qty,Status,CorrectedDate,Prod_FAI,isUpdate,DoneWithRow,isWorkInProgress,isWorkOrder,OperatorDet,PEStartTime,ProcessQty,DDLWokrCentre,IsMultiWO,IsHold,SplitWO,batchNo) VALUES(@HMIID,@MachineID,@OperatiorID, @Shift,@Date,@Time,@Project,@ PartNo,@OperationNo,@Rej_Qty,@Work_Order_No,@Target_Qty,@Delivered_Qty,@Status,@CorrectedDate,@Prod_FAI,@isUpdate,@DoneWithRow,@isWorkInProgress,@isWorkOrder,@OperatorDet,@PEStartTime,@ProcessQty,@DDLWokrCentre,@IsMultiWO,@IsHold,@SplitWO,@batchNo)";
               //    /*  ConnectionFactory _connectionFactory = new ConnectionFactory();
               //      string query = "INSERT INTO [i_facility_tsal].[dbo].[tblmode](ModeID,MachineID,Mode, InsertedOn,InsertedBy,ModifiedOn,ModifiedBy CorrectedDate,IsDeleted,StartTime,EndTime,ColorCode,IsCompleted,DurationInSec,ModeMonth,ModeYear,ModeWeekNumber,ModeQuarter) VALUES(@ModeID,@MachineID,@Mode, @InsertedOn,@InsertedBy,@ModifiedOn,@ModifiedBy @CorrectedDate,@IsDeleted,@StartTime,@EndTime,@ColorCode,@IsCompleted,@DurationInSec,@ModeMonth,@ModeYear,@ModeWeekNumber,@ModeQuarter)";*/
        //    using (var con = _connectionFactory.GetConnection)
        //    {
        //        res = _connectionFactory.GetConnection.Execute(query, listhmi); //commandTimeout: 60);
        //        con.Close();
        //    }

        //}


        /*   try
            {
                ConnectionFactory _connectionFactory = new ConnectionFactory();
                string query = "INSERT INTO [i_facility_tsal].[dbo].[tbllivehmiscreen](HMIID,MachineID,OperatiorID, Shift,Date,Time,Project, PartNo,OperationNo,Rej_Qty,Work_Order_No,Target_Qty,Delivered_Qty,Status,CorrectedDate,Prod_FAI,isUpdate,DoneWithRow,isWorkInProgress,isWorkOrder,OperatorDet,PEStartTime,ProcessQty,DDLWokrCentre,IsMultiWO,IsHold,SplitWO,batchNo) VALUES(@HMIID,@MachineID,@OperatiorID,@Shift,@Date,@Time,@Project,@PartNo,@OperationNo,@Rej_Qty,@Work_Order_No,@Target_Qty,@Delivered_Qty,@Status,@CorrectedDate,@Prod_FAI,@isUpdate,@DoneWithRow,@isWorkInProgress,@isWorkOrder,@OperatorDet,@PEStartTime,@ProcessQty,@DDLWokrCentre,@IsMultiWO,@IsHold,@SplitWO,@batchNo)";
               
                using (var con = _connectionFactory.GetConnection)
                {
                    res = _connectionFactory.GetConnection.Execute(query, listhmi); //commandTimeout: 60);
                    con.Close();
                }
            }
            catch (Exception ex)
            {

            }
            return Task.FromResult<int>(res);
        }
   

        public List<tbllivelossofentry> lossofentrysql()
        {
            var lossentrylist = new List<tbllivelossofentry>();
            using (i_facility_tsalEntities db = new i_facility_tsalEntities())
            {
                string correcteddate = GetCorrectedDate();
                //DateTime newdate = Convert.ToDateTime(correcteddate);


                lossentrylist = db.tbllivelossofentries.Where(m=>m.CorrectedDate==correcteddate).OrderBy(m => m.LossID).ToList();
            }
            return lossentrylist;

        }
        public Task<int> insert_livelossofentry(List<MyDAL.Model.tbllivelossofentry> datalist)
        {
            int res = 0;
            List<SQLDAL.DAL.livelossofentry> livelossofentlist = new List<DAL.livelossofentry>();
            foreach (var row in datalist)
            {
                SQLDAL.DAL.livelossofentry listrow1 = new DAL.livelossofentry();
                listrow1.LossID = row.LossID;
                listrow1.MessageCodeID = row.MessageCodeID;
                listrow1.StartDateTime = row.StartDateTime;
                listrow1.EndDateTime = row.EndDateTime;
                listrow1.EntryTime = row.EntryTime;
                listrow1.CorrectedDate = row.CorrectedDate;
                listrow1.MachineID = row.MachineID;
                listrow1.Shift = row.Shift;
                listrow1.MessageDesc = row.MessageDesc;
                listrow1.MessageCode = row.MessageCode;
                listrow1.IsUpdate = row.IsUpdate;
                listrow1.DoneWithRow = row.DoneWithRow;
                listrow1.IsStart = row.IsStart;
                listrow1.IsScreen = row.IsScreen;
                listrow1.ForRefresh = row.ForRefresh;

                livelossofentlist.Add(listrow1);

            }
            try
            {
                ConnectionFactory _connectionFactory = new ConnectionFactory();
                string query = "INSERT INTO [i_facility_tsal].[dbo].[tbllivelossofentry](LossID,MessageCodeID,StartDateTime,EndDateTime,EntryTime,CorrectedDate,MachineID,Shift,MessageDesc,MessageCode,IsUpdate,DoneWithRow,IsStart,IsScreen,ForRefresh) VALUES(@LossID,@MessageCodeID,@StartDateTime,@EndDateTime,@EntryTime,@CorrectedDate,@MachineID,@Shift,@MessageDesc,@MessageCode,@IsUpdate,@DoneWithRow,@IsStart,@IsScreen,@ForRefresh)";

                using (var con = _connectionFactory.GetConnection)
                {
                    res = _connectionFactory.GetConnection.Execute(query, livelossofentlist); //(commandTimeout: 60);
                    con.Close();
                }
            }

            catch (Exception ex)
            {

            }
            return Task.FromResult<int>(res);

        }

        public List<tbllivemultiwoselection> livemultiwoselctionlistsql()
        {
            var livemultiwolist = new List<tbllivemultiwoselection>();
            using (i_facility_tsalEntities db = new i_facility_tsalEntities())
            {
                string correcteddate = GetCorrectedDate();
               DateTime newdate = Convert.ToDateTime(correcteddate);

                livemultiwolist = db.tbllivemultiwoselections.Where(m=>m.CreatedOn==newdate).OrderBy(m => m.MultiWOID).ToList();
            }
            return livemultiwolist;
        }
        public Task<int> insert_livemultiwoselection(List<MyDAL.Model.tbllivemultiwoselection> datalist)
        {
            int res = 0;
            List<SQLDAL.DAL.livemultiwoselection> livewolist = new List<DAL.livemultiwoselection>();
            foreach (var row in datalist)
            {
                SQLDAL.DAL.livemultiwoselection livelistwo = new DAL.livemultiwoselection();
                livelistwo.MultiWOID = row.MultiWOID;
                livelistwo.WorkOrder = row.WorkOrder;
                livelistwo.PartNo = row.PartNo;
                livelistwo.OperationNo = row.OperationNo;
                livelistwo.TargetQty = row.TargetQty;
                livelistwo.DeliveredQty = row.DeliveredQty;
                livelistwo.HMIID = row.HMIID;
                livelistwo.CreatedOn = row.CreatedOn;
                livelistwo.IsCompleted = row.IsCompleted;
                livelistwo.ProcessQty = row.ProcessQty;
                livelistwo.DDLWorkCentre = row.DDLWorkCentre;
                livelistwo.IsSubmit = row.IsSubmit;
                livelistwo.ScrapQty = row.ScrapQty;
                livelistwo.SplitWO = row.SplitWO;

                livewolist.Add(livelistwo);
            }

            try
            {
                ConnectionFactory _connectionFactory = new ConnectionFactory();
                string query = "INSERT INTO [i_facility_tsal].[dbo].[tbllivemultiwoselection](MultiWOID ,WorkOrder,PartNo,OperationNo,TargetQty,DeliveredQty,HMIID,CreatedOn,IsCompleted ,ProcessQty,DDLWorkCentre ,IsSubmit,ScrapQty,SplitWO) VALUES(@MultiWOID ,@WorkOrder,@PartNo,@OperationNo,@TargetQty,@DeliveredQty,@HMIID,@CreatedOn,@IsCompleted,@ProcessQty,@DDLWorkCentre ,@IsSubmit,@ScrapQty,@SplitWO)";
                
                using (var con = _connectionFactory.GetConnection)
                {
                    res = _connectionFactory.GetConnection.Execute(query, livewolist);//( commandTimeout: 60);
                    con.Close();
                }
            }
            catch (Exception ex)
            {

            }
            return Task.FromResult<int>(res);
        }

        public List<tbl_multiwoselection> multiwoselctionlistsql()
        {
            var multiwolist = new List<tbl_multiwoselection>();
            using (i_facility_tsalEntities db = new i_facility_tsalEntities())
            {
                string correcteddate = GetCorrectedDate();
                DateTime newdate = Convert.ToDateTime(correcteddate);


                multiwolist = db.tbl_multiwoselection.Where(m=>m.CreatedOn==newdate).OrderBy(m => m.MultiWOID).ToList();
            }
            return multiwolist;
        }

        public Task<int> insert_multiwoselection(List<MyDAL.Model.tbl_multiwoselection> datalist)
        {
            int res = 0;
            List<SQLDAL.DAL.multiwoselection> livewolist = new List<DAL.multiwoselection>();
            foreach (var row in datalist)
            {
                SQLDAL.DAL.multiwoselection listwo = new DAL.multiwoselection();
                listwo.MultiWOID = row.MultiWOID;
                listwo.WorkOrder = row.WorkOrder;
                listwo.PartNo = row.PartNo;
                listwo.OperationNo = row.OperationNo;
                listwo.TargetQty = row.TargetQty;
                listwo.DeliveredQty = row.DeliveredQty;
                listwo.HMIID = row.HMIID;
                listwo.CreatedOn = row.CreatedOn;
                listwo.IsCompleted = row.IsCompleted;
                listwo.ProcessQty = row.ProcessQty;
                listwo.DDLWorkCentre = row.DDLWorkCentre;
                listwo.IsSubmit = row.IsSubmit;
                listwo.ScrapQty = row.ScrapQty;
                listwo.SplitWO = row.SplitWO;

                livewolist.Add(listwo);

            }
            try
            {
                ConnectionFactory _connectionFactory = new ConnectionFactory();
                string query = "INSERT INTO[i_facility_tsal].[dbo].[tbl_multiwoselection](MultiWOID ,WorkOrder,PartNo,OperationNo,TargetQty,DeliveredQty,HMIID,CreatedOn,IsCompleted ,ProcessQty,DDLWorkCentre ,IsSubmit,ScrapQty,SplitWO) VALUES(@MultiWOID ,@WorkOrder,@PartNo,@OperationNo,@TargetQty,@DeliveredQty,@HMIID,@CreatedOn,@IsCompleted ,@ProcessQty,@DDLWorkCentre ,@IsSubmit,@ScrapQty,@SplitWO)";
                
                using (var con = _connectionFactory.GetConnection)
                {
                    res = _connectionFactory.GetConnection.Execute(query, livewolist);//( commandTimeout: 60);
                    con.Close();
                }
            }
            catch (Exception ex)
            {

            }
            return Task.FromResult<int>(res);
        }

        public List<tblgenericworkentry> genericworkcode()
        {
            var workcodelist = new List<tblgenericworkentry>();
            using (i_facility_tsalEntities db = new i_facility_tsalEntities())
            {
                string correcteddate = GetCorrectedDate();
                //DateTime newdate = Convert.ToDateTime(correcteddate);

                workcodelist = db.tblgenericworkentries.Where(m=>m.CorrectedDate==correcteddate).OrderBy(m => m.GWEntryID).ToList();
            }
            return workcodelist;
        }
        public Task<int> insert_genericworkcode(List<MyDAL.Model.tblgenericworkentry> datalist)
        {
            int res = 0;
            List<SQLDAL.DAL.genericworkentry> genericlist = new List<DAL.genericworkentry>();
            foreach (var row in datalist)
            {
                SQLDAL.DAL.genericworkentry generiworkclist = new DAL.genericworkentry();
                generiworkclist.GWEntryID = row.GWEntryID;
                generiworkclist.GWCodeID = row.GWCodeID;
                generiworkclist.StartDateTime = row.StartDateTime;
                generiworkclist.EndDateTime = row.EndDateTime;
                generiworkclist.CorrectedDate = row.CorrectedDate;
                generiworkclist.MachineID = row.MachineID;
                generiworkclist.Shift = row.Shift;
                generiworkclist.GWCodeDesc = row.GWCodeDesc;
                generiworkclist.GWCode = row.GWCode;
                generiworkclist.DoneWithRow = row.DoneWithRow;
                genericlist.Add(generiworkclist);


            }
            try
            {
                ConnectionFactory _connectionFactory = new ConnectionFactory();
                string query = "INSERT INTO[i_facility_tsal].[dbo].[tblgenericworkentry](GWEntryID,GWCodeID,StartDateTime,EndDateTime,CorrectedDate,MachineID,Shift,GWCodeDesc,GWCode,DoneWithRow) VALUES(@GWEntryID,@GWCodeID,@StartDateTime,@EndDateTime,@CorrectedDate,@MachineID,@Shift,@GWCodeDesc,@GWCode,@DoneWithRow)";
                  using (var con = _connectionFactory.GetConnection)
                {
                    res = _connectionFactory.GetConnection.Execute(query, genericlist);//( commandTimeout: 60);
                    con.Close();
                }
            }
            catch (Exception ex)
            {

            }
            return Task.FromResult<int>(res);
        }
        public List<tblhmiscreen> hmlistsql()
        {
            var hmelist = new List<tblhmiscreen>();
            using (i_facility_tsalEntities db = new i_facility_tsalEntities())
            {
                string correcteddate = GetCorrectedDate();
                //DateTime newdate = Convert.ToDateTime(correcteddate);

                hmelist = db.tblhmiscreens.Where(m=>m.CorrectedDate==correcteddate).OrderBy(m => m.HMIID).ToList();
            }
            return hmelist;
        }



        public Task<int> insert_hmiscreen(List<MyDAL.Model.tblhmiscreen> datalist)
        {
            int res = 0;
            List<SQLDAL.DAL.hmiscreen> hmlist = new List<DAL.hmiscreen>();
            foreach (var row in datalist)
            {
                SQLDAL.DAL.hmiscreen hmist = new DAL.hmiscreen();
                hmist.HMIID = row.HMIID;
                hmist.MachineID = row.MachineID;
                hmist.OperationNo = row.OperationNo;
                hmist.OperatiorID = row.OperatiorID;
                hmist.OperatorDet = row.OperatorDet;
                hmist.PartNo = row.PartNo;
                hmist.PEStartTime = row.PEStartTime;
                hmist.ProcessQty = row.ProcessQty;
                hmist.Prod_FAI = row.Prod_FAI;
                hmist.Project = row.Project;
                hmist.Rej_Qty = row.Rej_Qty;
                hmist.Shift = row.Shift;
                hmist.Date = row.Date;
                hmist.Status = row.Status;
                hmist.Delivered_Qty = row.Delivered_Qty;
                hmist.Time = row.Time;
                hmist.Work_Order_No = row.Work_Order_No;
                hmist.Target_Qty = row.Target_Qty;
                hmist.CorrectedDate = row.CorrectedDate;
                hmist.isWorkOrder = row.isWorkOrder;
                hmist.isWorkInProgress = row.isWorkInProgress;
                hmist.isUpdate = row.isUpdate;
                hmist.IsMultiWO = row.IsMultiWO;
                hmist.IsHold = row.IsHold;
                hmist.DDLWokrCentre = row.DDLWokrCentre;
                hmist.DoneWithRow = row.DoneWithRow;
                hmist.SplitWO = row.SplitWO;
                hmist.HMIQuarter = row.HMIQuarter;
                hmist.HMIMonth = row.HMIMonth;
                hmist.HMIWeekNumber = row.HMIWeekNumber;
                hmist.HMIYear = row.HMIYear;
                hmist.batchCount = Convert.ToInt32(row.batchCount);

                hmlist.Add(hmist);

            }
            try
            {
                ConnectionFactory _connectionFactory = new ConnectionFactory();
                string query = "INSERT INTO [i_facility_tsal].[dbo].[tblhmiscreen](HMIID,MachineID,OperatiorID, Shift,Date,Time,Project,PartNo,OperationNo,Rej_Qty,Work_Order_No,Target_Qty,Delivered_Qty,Status,CorrectedDate,Prod_FAI,isUpdate,DoneWithRow,isWorkInProgress,isWorkOrder,OperatorDet,PEStartTime,ProcessQty,DDLWokrCentre,IsMultiWO,IsHold,SplitWO,HMIMonth,HMIYear,HMIWeekNumber,HMIQuarter,batchCount) VALUES(@HMIID,@MachineID,@OperatiorID,@Shift,@Date,@Time,@Project,@PartNo,@OperationNo,@Rej_Qty,@Work_Order_No,@Target_Qty,@Delivered_Qty,@Status,@CorrectedDate,@Prod_FAI,@isUpdate,@DoneWithRow,@isWorkInProgress,@isWorkOrder,@OperatorDet,@PEStartTime,@ProcessQty,@DDLWokrCentre,@IsMultiWO,@IsHold,@SplitWO,@HMIMonth,@HMIYear,@HMIWeekNumber,@HMIQuarter,@batchCount)";
                  using (var con = _connectionFactory.GetConnection)
                {
                    res = _connectionFactory.GetConnection.Execute(query, hmlist);//( commandTimeout: 60);
                    con.Close();
                }
            }
            catch (Exception ex)
            {

            }
            return Task.FromResult<int>(res);
        }

        public List<tbllossofentry> lossilstsql()
        {
            var losslist = new List<tbllossofentry>();
            using (i_facility_tsalEntities db = new i_facility_tsalEntities())
            {
                string correcteddate = GetCorrectedDate();
                //DateTime newdate = Convert.ToDateTime(correcteddate);

                losslist = db.tbllossofentries.Where(m=>m.CorrectedDate==correcteddate).OrderBy(m => m.LossID).ToList();
            }
            return losslist;
        }
        public Task<int> insert_lossofentry(List<MyDAL.Model.tbllossofentry> datalist)
        {
            int res = 0;
            List<SQLDAL.DAL.lossofentry> lossofentlist = new List<DAL.lossofentry>();
            foreach (var row in datalist)
            {
                SQLDAL.DAL.lossofentry listrow1 = new DAL.lossofentry();
                listrow1.LossID = row.LossID;
                listrow1.MessageCodeID = row.MessageCodeID;
                listrow1.StartDateTime = row.StartDateTime;
                listrow1.EndDateTime = row.EndDateTime;
                listrow1.EntryTime = row.EntryTime;
                listrow1.CorrectedDate = row.CorrectedDate;
                listrow1.MachineID = row.MachineID;
                listrow1.Shift = row.Shift;
                listrow1.MessageDesc = row.MessageDesc;
                listrow1.MessageCode = row.MessageCode;
                listrow1.IsUpdate = row.IsUpdate;
                listrow1.DoneWithRow = row.DoneWithRow;
                listrow1.IsStart = row.IsStart;
                listrow1.IsScreen = row.IsScreen;
                listrow1.ForRefresh = row.ForRefresh;
                listrow1.LossMonth = row.LossMonth;
                listrow1.LossQuarter = row.LossQuarter;
                listrow1.LossYear = row.LossYear;
                listrow1.LossWeekNumber = row.LossWeekNumber;
                lossofentlist.Add(listrow1);

            }

            try
            {
                ConnectionFactory _connectionFactory = new ConnectionFactory();
                string query = "INSERT INTO [i_facility_tsal].[dbo].[tbllossofentry](LossID,MessageCodeID,StartDateTime,EndDateTime,EntryTime,CorrectedDate,MachineID,Shift,MessageDesc,MessageCode,IsUpdate,DoneWithRow,IsStart,IsScreen,ForRefresh,LossMonth,LossYear,LossWeekNumber,LossQuarter) VALUES(@LossID,@MessageCodeID,@StartDateTime,@EndDateTime,@EntryTime,@CorrectedDate,@MachineID,@Shift,@MessageDesc,@MessageCode,@IsUpdate,@DoneWithRow,@IsStart,@IsScreen,@ForRefresh,@LossMonth,@LossYear,@LossWeekNumber,@LossQuarter)";

                using (var con = _connectionFactory.GetConnection)
                {
                    res = _connectionFactory.GetConnection.Execute(query,lossofentlist);//( commandTimeout: 60);
                    con.Close();
                }
            }
            catch (Exception ex)
            {

            }
            return Task.FromResult<int>(res);
        }

        public List<tbloeedashboardvariable> oeelistvariablelistsql()
        {
            var oeelist = new List<tbloeedashboardvariable>();
            using (i_facility_tsalEntities db = new i_facility_tsalEntities())
            {
                string correcteddate = GetCorrectedDate();
                DateTime newdate = Convert.ToDateTime(correcteddate);

                oeelist = db.tbloeedashboardvariables.Where(m=>m.CreatedOn==newdate).OrderBy(m => m.OEEVariablesID).ToList();
            }
            return oeelist;
        }
        public Task<int> insert_oeedashboardvariablelist(List<MyDAL.Model.tbloeedashboardvariable> datalist)
        {
            int res = 0;
            List<SQLDAL.DAL.oeedashboardvariables> Oeevarllist = new List<DAL.oeedashboardvariables>();
            foreach (var row in datalist)
            {
                SQLDAL.DAL.oeedashboardvariables oeelist = new DAL.oeedashboardvariables();
                oeelist.OEEVariablesID = row.OEEVariablesID;
                oeelist.PlantID = row.PlantID;
                oeelist.ShopID = row.ShopID;
                oeelist.CellID = row.CellID;
                oeelist.WCID = row.WCID;
                oeelist.StartDate = row.StartDate;
                oeelist.EndDate = row.EndDate;
                oeelist.MinorLosses = row.MinorLosses;
                oeelist.Blue = row.Blue;
                oeelist.Green = row.Green;
                oeelist.SettingTime = row.SettingTime;
                oeelist.ROALossess = row.ROALossess;
                oeelist.DownTimeBreakdown = row.DownTimeBreakdown;
                oeelist.SummationOfSCTvsPP = row.SummationOfSCTvsPP;
                oeelist.ScrapQtyTime = row.ScrapQtyTime;
                oeelist.ReWOTime = row.ReWOTime;
                oeelist.Loss1Name = row.Loss1Name;
                oeelist.Loss1Value = row.Loss1Value;
                oeelist.Loss2Name = row.Loss2Name;
                oeelist.Loss2Value = row.Loss2Value;
                oeelist.Loss3Name = row.Loss3Name;
                oeelist.Loss3Value = row.Loss3Value;
                oeelist.Loss4Name = row.Loss4Name;
                oeelist.Loss4Value = row.Loss4Value;
                oeelist.Loss5Name = row.Loss5Name;
                oeelist.Loss5Value = row.Loss5Value;
                oeelist.CreatedOn = row.CreatedOn;
                oeelist.CreatedBy = row.CreatedBy;
                oeelist.IsDeleted = row.IsDeleted;


                Oeevarllist.Add(oeelist);

            }
            try
            {
                ConnectionFactory _connectionFactory = new ConnectionFactory();
                string query = "INSERT INTO [i_facility_tsal].[dbo].[tbloeedashboardvariables](OEEVariablesID,PlantID,ShopID,CellID,WCID,StartDate,EndDate,MinorLosses,Blue,Green,SettingTime,ROALossess,DownTimeBreakdown,SummationOfSCTvsPP,ScrapQtyTime,ReWOTime,Loss1Name,Loss1Value,Loss2Name,Loss2Value,Loss3Name,Loss3Value,Loss4Name,Loss4Value,Loss5Name,Loss5Value,CreatedOn,CreatedBy,IsDeleted) VALUES(@OEEVariablesID,@PlantID,@ShopID,@CellID,@WCID,@StartDate,@EndDate,@MinorLosses,@Blue,@Green,@SettingTime,@ROALossess,@DownTimeBreakdown,@SummationOfSCTvsPP,@ScrapQtyTime,@ReWOTime,@Loss1Name,@Loss1Value,@Loss2Name,@Loss2Value,@Loss3Name,@Loss3Value,@Loss4Name,@Loss4Value,@Loss5Name,@Loss5Value,@CreatedOn,@CreatedBy,@IsDeleted)";
               
                using (var con = _connectionFactory.GetConnection)
                {
                    res = _connectionFactory.GetConnection.Execute(query, Oeevarllist);//( commandTimeout: 60);
                    con.Close();
                }
            }
            catch (Exception ex)
            {

            }
            return Task.FromResult<int>(res);
        }
        public List<tbloeedashboardfinalvariable> oeelistvariablefinallistsql()
        {
            var oeevarfinallist = new List<tbloeedashboardfinalvariable>();
            using (i_facility_tsalEntities db = new i_facility_tsalEntities())
            {
                string correcteddate = GetCorrectedDate();
               DateTime newdate = Convert.ToDateTime(correcteddate);

                oeevarfinallist = db.tbloeedashboardfinalvariables.Where(m=>m.CreatedOn==newdate).OrderBy(m => m.OEEDashboardID).ToList();
            }
            return oeevarfinallist;
        }
        public Task<int> insert_oeedashboardfinalvarlist(List<MyDAL.Model.tbloeedashboardfinalvariable> datalist)
        {
            int res = 0;
            List<SQLDAL.DAL.oeedashboardfinalvariable> Oeevarfinalllist = new List<DAL.oeedashboardfinalvariable>();
            foreach (var row in datalist)
            {
                SQLDAL.DAL.oeedashboardfinalvariable oeelist1 = new DAL.oeedashboardfinalvariable();
                oeelist1.OEEDashboardID = row.OEEDashboardID;
                oeelist1.PlantID = row.PlantID;
                oeelist1.ShopID = row.ShopID;
                oeelist1.CellID = row.CellID;
                oeelist1.WCID = row.WCID;
                oeelist1.StartDate = row.StartDate;
                oeelist1.EndDate = row.EndDate;
                oeelist1.OEE = row.OEE;
                oeelist1.Availability = row.Availability;
                oeelist1.Performance = row.Performance;
                oeelist1.Quality = row.Quality;
                oeelist1.IsOverallPlantWise = row.IsOverallPlantWise;
                oeelist1.IsOverallShopWise = row.IsOverallShopWise;
                oeelist1.IsOverallWCWise = row.IsOverallWCWise;
                oeelist1.Loss1Name = row.Loss1Name;
                oeelist1.Loss1Value = row.Loss1Value;
                oeelist1.Loss2Name = row.Loss2Name;
                oeelist1.Loss2Value = row.Loss2Value;
                oeelist1.Loss3Name = row.Loss3Name;
                oeelist1.Loss3Value = row.Loss3Value;
                oeelist1.Loss4Name = row.Loss4Name;
                oeelist1.Loss4Value = row.Loss4Value;
                oeelist1.Loss5Name = row.Loss5Name;
                oeelist1.Loss5Value = row.Loss5Value;
                oeelist1.IPAddress = row.IPAddress;
                oeelist1.CreatedOn = row.CreatedOn;
                oeelist1.CreatedBy = row.CreatedBy;
                oeelist1.IsDeleted = row.IsDeleted;
                oeelist1.IsOverallCellWise = row.IsOverallCellWise;
                oeelist1.IsToday = row.IsToday;


                Oeevarfinalllist.Add(oeelist1);

            }
            try
            {
                ConnectionFactory _connectionFactory = new ConnectionFactory();
                string query = "INSERT INTO [i_facility_tsal].[dbo].[tbloeedashboardfinalvariables](OEEDashboardID,PlantID,ShopID,CellID,WCID,StartDate,EndDate,OEE,Availability,Performance,Quality,IsOverallPlantWise,IsOverallShopWise,IsOverallWCWise,Loss1Name,Loss1Value,Loss2Name,Loss2Value,Loss3Name,Loss3Value,Loss4Name,Loss4Value,Loss5Name,Loss5Value,IPAddress,CreatedOn,CreatedBy,IsDeleted,IsOverallCellWise,IsToday) VALUES(@OEEDashboardID,@PlantID,@ShopID,@CellID,@WCID,@StartDate,@EndDate,@OEE,@Availability,@Performance,@Quality,@IsOverallPlantWise,@IsOverallShopWise,@IsOverallWCWise,@Loss1Name,@Loss1Value,@Loss2Name,@Loss2Value,@Loss3Name,@Loss3Value,@Loss4Name,@Loss4Value,@Loss5Name,@Loss5Value,@IPAddress,@CreatedOn,@CreatedBy,@IsDeleted,@IsOverallCellWise,@IsToday)";
                    using (var con = _connectionFactory.GetConnection)
                {
                    res = _connectionFactory.GetConnection.Execute(query, Oeevarfinalllist);//( commandTimeout: 60);
                    con.Close();
                }
            }
            catch (Exception ex)
            {

            }
            return Task.FromResult<int>(res);
        }*/
        public List<tblplant> sqlPlantList()
        {
            var dlist = new List<tblplant>();
            using (unitworksccsEntities db = new unitworksccsEntities())
            {
               // string correcteddate = GetCorrectedDate();
                //DateTime newdate = Convert.ToDateTime(correcteddate);


                // dlist = db.tblddls.Where(m => m.CorrectedDate == correcteddate).OrderBy(m => m.DDLID).ToList();
                dlist = db.tblplants.Where(m => m.IsDeleted == 0).ToList();

            }
            return dlist;
        }
        //public List<tblddl> ddllistsql1()
        //{
        //    var dlist = new List<tblddl>();
        //    using (i_facility_tsalEntities db = new i_facility_tsalEntities())
        //    {
        //        string correcteddate = GetCorrectedDate();
        //        //DateTime newdate = Convert.ToDateTime(correcteddate);


        //        dlist = db.tblddls.Where(m => m.CorrectedDate == correcteddate && m.IsCompleted==0).OrderBy(m => m.DDLID).ToList();
        //    }
        //    return dlist;
        //}
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
        //            res = con.Execute(query, ddllist,commandTimeout: 600);
        //             con.Close();
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    return Task.FromResult<int>(res);
        //}

        //public Task<int> delete_ddlistsql(List<MySQLDAL.tblddl> datalist)
        //{
        //    int res = 0;


        //    //foreach (var item in datalist)
        //    //{
        //        try
        //        {
        //            ConnectionFactory _connectionFactory = new ConnectionFactory();
        //            string query = "delete from [i_facility_tsal].[dbo].[tblddl] where DDLID =@DDLID";
        //            using (var con = _connectionFactory.GetConnection)
        //            {
        //                res = con.Execute(query, datalist,commandTimeout: 600);
        //                con.Close();
        //            }
        //        }
        //        catch (Exception ex)
        //        {

        //        }
        //    //}
        //    return Task.FromResult<int>(res);
        //}
        //public Task<int> Update_ddlistsql(List<int> datalist)
        //{
        //    int res = 0;
        //    foreach (var item in datalist)
        //    {
        //        try
        //        {
        //            ConnectionFactory _connectionFactory = new ConnectionFactory();
        //            string query = "Update [i_facility_tsal].[dbo].[tblddl] Set IsCompleted=1 where DDLID =" + item + "";
        //            using (var con = _connectionFactory.GetConnection)
        //            {
        //                res = _connectionFactory.GetConnection.Execute(query, con, commandTimeout: 600);
        //                con.Close();
        //            }
        //        }
        //        catch (Exception ex)
        //        {

        //        }
        //    }
        //    return Task.FromResult<int>(res);
        //}

        /* public List<tblmimic> mimicsql()
         {
             var mlist = new List<tblmimic>();
             using (i_facility_tsalEntities db = new i_facility_tsalEntities())
             {
                 string correcteddate = GetCorrectedDate();
                 //DateTime newdate = Convert.ToDateTime(correcteddate);

                 mlist = db.tblmimics.Where(m=>m.CorrectedDate==correcteddate).OrderBy(m => m.mid).ToList();
             }
             return mlist;
         }
         public Task<int> insert_mimics(List<MyDAL.Model.tblmimic> datalist)
         {
             int res = 0;
             List<SQLDAL.DAL.mimics> mimicsistsql = new List<DAL.mimics>();
             foreach (var row in datalist)
             {
                 SQLDAL.DAL.mimics mlist = new DAL.mimics();
                 mlist.mid = row.mid;
                 mlist.MachineOnTime = row.MachineOnTime;
                 mlist.OperatingTime = row.OperatingTime;
                 mlist.SetupTime = row.SetupTime;
                 mlist.IdleTime = row.IdleTime;
                 mlist.MachineOffTime = row.MachineOffTime;
                 mlist.BreakdownTime = row.BreakdownTime;
                 mlist.MachineID = row.MachineID;
                 mlist.Shift = row.Shift;
                 mlist.CorrectedDate = row.CorrectedDate;



                 mimicsistsql.Add(mlist);

             }
             try
             {
                 ConnectionFactory _connectionFactory = new ConnectionFactory();
                 string query = "INSERT INTO[i_facility_tsal].[dbo].[tblmimics](mid,MachineOnTime,OperatingTime,SetupTime,IdleTime,MachineOffTime,BreakdownTime,MachineID,Shift,CorrectedDate) VALUES    using (var con = _connectionFactory.GetConnection)
                 {
                     res = _connectionFactory.GetConnection.Execute(query, mimicsistsql);//( commandTimeout: 60);
                     con.Close();
                 }
             }
             catch (Exception ex)
             {

             }
             return Task.FromResult<int>(res);
         }

         public List<tblmodulehelper> modulerSQL()
         {
             var modulelist = new List<tblmodulehelper>();
             using (i_facility_tsalEntities db = new i_facility_tsalEntities())
             {

                 modulelist = db.tblmodulehelpers.OrderBy(m => m.ID).ToList();
             }
             return modulelist;
         }
         public Task<int> insert_module(List<MyDAL.Model.tblmodulehelper> datalist)
         {
             int res = 0;
             List<SQLDAL.DAL.modulehelper> modulist = new List<DAL.modulehelper>();
             foreach (var row in datalist)
             {
                 SQLDAL.DAL.modulehelper mlist = new DAL.modulehelper();
                 mlist.ID = row.ID;
                 mlist.ModuleID = row.ModuleID;
                 mlist.RoleID = row.RoleID;
                 mlist.IsAll = row.IsAll;
                 mlist.IsAdded = row.IsAdded;
                 mlist.IsEdited = row.IsEdited;
                 mlist.IsRemoved = row.IsRemoved;
                 mlist.IsReadonly = row.IsReadonly;
                 mlist.IsHidden = row.IsHidden;
                 mlist.IsDeleted = row.IsDeleted;

                 modulist.Add(mlist);
             }

             try
             {
                 ConnectionFactory _connectionFactory = new ConnectionFactory();
                 string query = "INSERT INTO [i_facility_tsal].[dbo].[tblmodulehelper](ID,ModuleID,RoleID,IsAll,IsAdded,IsEdited,IsRemoved,IsReadonly,IsHidden,IsDeleted) VALUES(@ID,@ModuleID,@RoleID,@IsAll,@IsAdded,@IsEdited,@IsRemoved,@IsReadonly,@IsHidden,@IsDeleted)";

                 using (var con = _connectionFactory.GetConnection)
                 {
                     res = _connectionFactory.GetConnection.Execute(query, modulist);//( commandTimeout: 60);
                     con.Close();
                 }
             }
             catch (Exception ex)
             {

             }
             return Task.FromResult<int>(res);
         }
         public List<tblshift_mstr>masterSQL()
         {
             var shiftlistmysql = new List<tblshift_mstr>();
             using (i_facility_tsalEntities db = new i_facility_tsalEntities())
             {

                 shiftlistmysql = db.tblshift_mstr.OrderBy(m => m.ShiftID).ToList();
             }
             return shiftlistmysql;
         }
         public Task<int> insert_shiftmaster(List<MyDAL.Model.tblshift_mstr> datalist)
         {
             int res = 0;
             List<SQLDAL.DAL.shift_mstr> shiftlist = new List<DAL.shift_mstr>();
             foreach (var row in datalist)
             {
                 SQLDAL.DAL.shift_mstr smlist = new DAL.shift_mstr();
                 smlist.ShiftID = row.ShiftID;
                 smlist.ShiftName = row.ShiftName;
                 smlist.StartTime = row.StartTime;
                 smlist.EndTime = row.EndTime;
                 smlist.IsDeleted = row.IsDeleted;
                 smlist.CreatedOn = row.CreatedOn;
                 smlist.CreatedBy = row.CreatedBy;
                 smlist.ModifiedOn = row.ModifiedOn;
                 smlist.ModifiedBy = row.ModifiedBy;
                 smlist.Duration = row.Duration;

                 shiftlist.Add(smlist);
             }

             try
             {
                 ConnectionFactory _connectionFactory = new ConnectionFactory();
                 string query = "INSERT INTO [i_facility_tsal].[dbo].[tblshift_mstr](ShiftID,ShiftName,StartTime,EndTime,IsDeleted,CreatedOn,CreatedBy,ModifiedOn,ModifiedBy,Duration) VALUES(@ShiftID,@ShiftName,@StartTime,@EndTime,@IsDeleted,@CreatedOn,@CreatedBy,@ModifiedOn,@ModifiedBy,@Duration)";

                 using (var con = _connectionFactory.GetConnection)
                 {
                     res = _connectionFactory.GetConnection.Execute(query, shiftlist);//( commandTimeout: 60);
                     con.Close();
                 }
             }
             catch (Exception ex)
             {

             }
             return Task.FromResult<int>(res);
         }
         public List<recipientmailid> reciepientSQL()
         {
             var reciplist = new List<recipientmailid>();
             using (i_facility_tsalEntities db = new i_facility_tsalEntities())
             {

                 reciplist = db.recipientmailids.OrderBy(m => m.RE_ID).ToList();
             }
             return reciplist;
         }
         public Task<int> insert_recipient(List<MyDAL.Model.recipientmailid> datalist)
         {
             int res = 0;
             List<SQLDAL.DAL.recipient> recipilist = new List<DAL.recipient>();
             foreach (var row in datalist)
             {
                 SQLDAL.DAL.recipient rlist = new DAL.recipient();
                 rlist.RE_ID = row.RE_ID;
                 rlist.MailID = row.MailID;
                 rlist.AutoEmailType = row.AutoEmailType;
                 rlist.DisplayName = row.DisplayName;
                 rlist.RecipientType = row.RecipientType;
                 rlist.IsDeleted = row.IsDeleted;
                 rlist.CreatedOn = row.CreatedOn;
                 rlist.CreatedBy = row.CreatedBy;
                 rlist.ModifiedOn = row.ModifiedOn;
                 rlist.ModifiedBy = row.ModifiedBy;

                 recipilist.Add(rlist);
             }

             try
             {
                 ConnectionFactory _connectionFactory = new ConnectionFactory();
                 string query = ";INSERT INTO [i_facility_tsal].[dbo].[recipientmailid](RE_ID,MailID,AutoEmailType,DisplayName,RecipientType,IsDeleted,CreatedOn,CreatedBy,ModifiedOn,ModifiedBy) VALUES(@RE_ID,@MailID,@AutoEmailType,@DisplayName,@RecipientType,@IsDeleted,@CreatedOn,@CreatedBy,@ModifiedOn,@ModifiedBy)";

                 using (var con = _connectionFactory.GetConnection)
                 {
                     res = _connectionFactory.GetConnection.Execute(query, recipilist);//( commandTimeout: 60);
                     con.Close();
                 }
             }
             catch (Exception ex)
             {

             }
             return Task.FromResult<int>(res);
         }
         public List<pcb_details> pcbsql()
         {
             var pcblist = new List<pcb_details>();
             using (i_facility_tsalEntities db = new i_facility_tsalEntities())
             {

                 pcblist = db.pcb_details.OrderBy(m => m.PCBID).ToList();
             }
             return pcblist;
         }
         public Task<int> insert_pcbdetails(List<MyDAL.Model.pcb_details> datalist)
         {
             int res = 0;
             List<SQLDAL.DAL.pcbdetails> pcbpilist = new List<DAL.pcbdetails>();
             foreach (var row in datalist)
             {
                 SQLDAL.DAL.pcbdetails rlist = new DAL.pcbdetails();
                 rlist.PCBID = row.PCBID;
                 rlist.PCBNo = row.PCBNo;
                 rlist.PCBIPAddress = row.PCBIPAddress;
                 rlist.PCBMACAddress = row.PCBMACAddress;
                 rlist.MachineID = row.MachineID;
                 rlist.IsDeleted = row.IsDeleted;
                 rlist.CreatedOn = row.CreatedOn;
                 rlist.CreatedBy = row.CreatedBy;
                 rlist.ModifiedOn = row.ModifiedOn;
                 rlist.ModifiedBy = row.ModifiedBy;

                 pcbpilist.Add(rlist);
             }

             try
             {
                 ConnectionFactory _connectionFactory = new ConnectionFactory();
                 string query = "INSERT INTO [i_facility_tsal].[dbo].[pcb_details](PCBID,PCBNo,PCBIPAddress,PCBMACAddress,MachineID,IsDeleted,CreatedOn,CreatedBy,ModifiedOn,ModifiedBy) VALUES(@PCBID,@PCBNo,@PCBIPAddress,@PCBMACAddress,@MachineID,@IsDeleted,@CreatedOn,@CreatedBy,@ModifiedOn,@ModifiedBy)";

                 using (var con = _connectionFactory.GetConnection)
                 {
                     res = _connectionFactory.GetConnection.Execute(query, pcbpilist);//( commandTimeout: 60);
                     con.Close();
                 }
             }
             catch (Exception ex)
             {

             }
             return Task.FromResult<int>(res);
         }
         public List<pcbdps_master> pcbdpssql()
         {
             var pcblist = new List<pcbdps_master>();
             using (i_facility_tsalEntities db = new i_facility_tsalEntities())
             {

                 pcblist = db.pcbdps_master.OrderBy(m => m.PcbDpsMasterID).ToList();
             }
             return pcblist;
         }
         public Task<int> insert_pcbdps(List<MyDAL.Model.pcbdps_master> datalist)
         {
             int res = 0;
             List<SQLDAL.DAL.pcbdps_master> pcbdpsilist = new List<DAL.pcbdps_master>();
             foreach (var row in datalist)
             {
                 SQLDAL.DAL.pcbdps_master rlist = new DAL.pcbdps_master();
                 rlist.PcbDpsMasterID = row.PcbDpsMasterID;
                 rlist.Pin17 = row.Pin17;
                 rlist.Pin18 = row.Pin18;
                 rlist.Pin19 = row.Pin19;
                 rlist.Pin20 = row.Pin20;
                 rlist.Pin22 = row.Pin22;
                 rlist.Pin23 = row.Pin23;
                 rlist.Pin24 = row.Pin24;
                 rlist.Pin25 = row.Pin25;
                 rlist.Pin26 = row.Pin26;
                 rlist.MachineID = row.MachineID;
                 rlist.ColorValue = row.ColorValue;
                 rlist.CreatedOn = row.CreatedOn;
                 rlist.IsDeleted = row.IsDeleted;
                 pcbdpsilist.Add(rlist);
             }

             try
             {
                 ConnectionFactory _connectionFactory = new ConnectionFactory();
                 string query = "INSERT INTO [i_facility_tsal].[dbo].[pcb_details](PcbDpsMasterID,Pin17,Pin18,Pin19,Pin20,Pin22,Pin23,Pin24,Pin25,Pin26,MachineID,ColorValue,CreatedOn,IsDeleted) VALUES(@PcbDpsMasterID,@Pin17,@Pin18,@Pin19,@Pin20,@Pin22,@Pin23,@Pin24,@Pin25,@Pin26,@MachineID,@ColorValue,@CreatedOn,@IsDeleted)";

                 using (var con = _connectionFactory.GetConnection)
                 {
                     res = _connectionFactory.GetConnection.Execute(query, pcbdpsilist);//( commandTimeout: 60);
                     con.Close();
                 }
             }
             catch (Exception ex)
             {

             }
             return Task.FromResult<int>(res);
         }

     }*/
    }
}



