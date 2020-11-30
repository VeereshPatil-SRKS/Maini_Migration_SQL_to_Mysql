using MyDAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDAL
{
    public class MYSQLDAO
    {
        private string GetCorrectedDate()
        {
            using (mazakdaqEntities1 db = new mazakdaqEntities1())
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

        /*    public List<tbllivemodedb> getLiveMode(List<int> modeids)
            {
                var Livemodelist = new List<tbllivemodedb>();
                using (mazakdaqEntities1 db = new mazakdaqEntities1())
                {
                    //string fromDate = DateTime.Now.AddDays(-1).ToString();
                    //string prvdate = DateTime.Now.AddDays(-1).ToString();
                    //string curctdate = DateTime.Now.ToString();
                    //var frDate = DateTime.Now.AddDays(-1).ToString();

                    //livemodelist = db.tbllivemodedbs.where(m => !modeids.contains(m.modeid)).where (m => m.correcteddate >= fromdate || m.correcteddate =< curctdate).take(30000).orderby(m => m.modeid).tolist();
                    string correcteddate = GetCorrectedDate();

                    Livemodelist = db.tbllivemodedbs.Where(m => !modeids.Contains(m.ModeID)&& m.CorrectedDate== correcteddate).Take(30000).OrderBy(m => m.ModeID).ToList();
                }
                return Livemodelist;
            }
         /*   public List<tblmode> getMode(List<int> modeids, int prevmodeid)
            {
                var modelist = new List<tblmode>();
                using (mazakdaqEntities1 db = new mazakdaqEntities1())
                {
                    string correcteddate = GetCorrectedDate();

                    modelist = db.tblmodes.Where(m => !modeids.Contains(m.ModeID) && m.ModeID > prevmodeid).Take(30000).OrderBy(m => m.ModeID).ToList();
                }
                return modelist;
            }

            public List<tblmode> getMode(List<int> modeids)
            {
                var modelist = new List<tblmode>();
                using (mazakdaqEntities1 db = new mazakdaqEntities1())
                {
                    string correcteddate = GetCorrectedDate();
                    int modeid = 2580548;

                    modelist = db.tblmodes.Where(m => !modeids.Contains(m.ModeID) && m.ModeID > modeid && m.CorrectedDate==correcteddate).Take(30000).OrderBy(m => m.ModeID).ToList();
                }
                return modelist;
            }
            public List<tbllivehmiscreen> hmiscreenMode(List<int> livehmids)
            {
                var Livehmiilist = new List<tbllivehmiscreen>();
                using (mazakdaqEntities1 db = new mazakdaqEntities1())
                {
                    string correcteddate = GetCorrectedDate();
                    Livehmiilist = db.tbllivehmiscreens.Where(m => !livehmids.Contains(m.HMIID) && m.CorrectedDate==correcteddate).Take(30000).
                    OrderBy(m => m.HMIID).ToList();
                }
                return Livehmiilist;
            }
            public List<tbllivelossofentry> lossofentry(List<int> lossids)
            {
                var Livelossentrylist = new List<tbllivelossofentry>();
                using (mazakdaqEntities1 db = new mazakdaqEntities1())
                {
                    string correcteddate = GetCorrectedDate();
                    Livelossentrylist = db.tbllivelossofentries.Where(m => !lossids.Contains(m.LossID)&& m.CorrectedDate== correcteddate).Take(30000).OrderBy(m => m.LossID).ToList();
                }
                return Livelossentrylist;
            }
            public List<tbllivemultiwoselection> livemultiwoselctionlist(List<int> woids)
            {
                var livemultiwolist = new List<tbllivemultiwoselection>();
                using (mazakdaqEntities1 db = new mazakdaqEntities1())
                {
                   string correcteddate = GetCorrectedDate();
                    DateTime newdate = Convert.ToDateTime(correcteddate);


                    livemultiwolist = db.tbllivemultiwoselections.Where(m => !woids.Contains(m.MultiWOID) && m.CreatedOn==newdate).Take(30000).OrderBy(m => m.MultiWOID).ToList();
                }
                return livemultiwolist;
            }

            public List<tbl_multiwoselection> multiwoselctionlist(List<int> woids)
            {
                var multiwolist = new List<tbl_multiwoselection>();
                using (mazakdaqEntities1 db = new mazakdaqEntities1())
                {
                    string correcteddate = GetCorrectedDate();
                    DateTime newdate = Convert.ToDateTime(correcteddate);

                    multiwolist = db.tbl_multiwoselection.Where(m =>!woids.Contains(m.MultiWOID)&& m.CreatedOn==newdate).Take(30000).OrderBy(m => m.MultiWOID).ToList();
                }
                return multiwolist;
            }

            public List<tblgenericworkentry> workcodelistmy(List<int> workcodeids)
            {
                var workcodelistmysql = new List<tblgenericworkentry>();
                using (mazakdaqEntities1 db = new mazakdaqEntities1())
                {
                    string correcteddate = GetCorrectedDate();
                    //DateTime newdate = Convert.ToDateTime(correcteddate);


                    workcodelistmysql = db.tblgenericworkentries.Where(m => !workcodeids.Contains(m.GWEntryID)&& m.CorrectedDate== correcteddate).Take(30000).OrderBy(m => m.GWEntryID).ToList();
                }
                return workcodelistmysql;
            }

            public List<tblhmiscreen> hmlist(List<int> hmids)
            {
                var hmilist = new List<tblhmiscreen>();
                using (mazakdaqEntities1 db = new mazakdaqEntities1())
                {
                    string correcteddate = GetCorrectedDate();
                    //DateTime newdate = Convert.ToDateTime(correcteddate);

                    hmilist = db.tblhmiscreens.Where(m => !hmids.Contains(m.HMIID)&& m.CorrectedDate==correcteddate).OrderBy(m => m.HMIID).Take(30000).ToList();
                }
                return hmilist;
            }
            public List<tbllossofentry> lossoflist(List<int> lossids)
            {
                var losslist = new List<tbllossofentry>();
                using (mazakdaqEntities1 db = new mazakdaqEntities1())
                {
                    string correcteddate = GetCorrectedDate();
                    //DateTime newdate = Convert.ToDateTime(correcteddate);

                    losslist = db.tbllossofentries.Where(m => !lossids.Contains(m.LossID)&&m.CorrectedDate==correcteddate).Take(30000).OrderBy(m => m.LossID).ToList();
                }
                return losslist;
            }
            public List<tbloeedashboardvariable> oeevariable(List<int> oeeids)
            {
                var oeevarlist = new List<tbloeedashboardvariable>();
                using (mazakdaqEntities1 db = new mazakdaqEntities1())
                {
                    string correcteddate = GetCorrectedDate();
                    DateTime newdate = Convert.ToDateTime(correcteddate);


                    oeevarlist = db.tbloeedashboardvariables.Where(m => !oeeids.Contains(m.OEEVariablesID)&&m.CreatedOn==newdate).Take(30000).OrderBy(m => m.OEEVariablesID).ToList();
                }
                return oeevarlist;
            }

            public List<tbloeedashboardfinalvariable> oeevarfinal(List<int> oeefinalids)
            {
                var oeevarfinallist = new List<tbloeedashboardfinalvariable>();
                using (mazakdaqEntities1 db = new mazakdaqEntities1())
                {
                    string correcteddate = GetCorrectedDate();
                    DateTime newdate = Convert.ToDateTime(correcteddate);

                    oeevarfinallist = db.tbloeedashboardfinalvariables.Where(m => !oeefinalids.Contains(m.OEEDashboardID)&& m.CreatedOn==newdate).Take(30000).OrderBy(m => m.OEEDashboardID).ToList();
                }
                return oeevarfinallist;
            }*/

        public List<tblddl> ddllistmysql(List<int> ddlids)
        {
            var ddllistsqls = new List<tblddl>();
            using (mazakdaqEntities1 db = new mazakdaqEntities1())
            {
                string correcteddate = GetCorrectedDate();
                //DateTime newdate = Convert.ToDateTime(correcteddate);
                try
                {

                    ddllistsqls = db.tblddls.Where(m => (!ddlids.Contains(m.DDLID)) && m.CorrectedDate == correcteddate).OrderBy(m => m.DDLID).ToList();
                }
                catch(Exception ex)
                {

                }
            }
            return ddllistsqls;
        }
        public List<tblddl> ddllistmysql1()
        {
            var ddllistsqls = new List<tblddl>();
            using (mazakdaqEntities1 db = new mazakdaqEntities1())
            {
                string correcteddate = GetCorrectedDate();
                //DateTime newdate = Convert.ToDateTime(correcteddate);
                try
                {

                    ddllistsqls = db.tblddls.Where(m => m.CorrectedDate == correcteddate).OrderBy(m => m.DDLID).ToList();
                }
                catch(Exception ex)
                {

                }
            }
            return ddllistsqls;
        }
        public List<tblddl> ddllistmysql2()
        {
            var ddllistsqls = new List<tblddl>();
            using (mazakdaqEntities1 db = new mazakdaqEntities1())
            {
                string correcteddate = GetCorrectedDate();
                //DateTime newdate = Convert.ToDateTime(correcteddate);


                ddllistsqls = db.tblddls.Where(m => m.CorrectedDate == correcteddate && m.IsCompleted==1).OrderBy(m => m.DDLID).ToList();
            }
            return ddllistsqls;
        }
        /*  public List<tblmimic> mimiclistmysql(List<int> mimicids)
          {
              var mimiclistmysq = new List<tblmimic>();
              using (mazakdaqEntities1 db = new mazakdaqEntities1())
              {
                  string correcteddate = GetCorrectedDate();
                  //DateTime newdate = Convert.ToDateTime(correcteddate);


                  mimiclistmysq = db.tblmimics.Where(m =>!mimicids.Contains(m.mid)&&m.CorrectedDate==correcteddate).Take(30000).OrderBy(m => m.mid).ToList();
              }
              return mimiclistmysq;
          }
          public List<tblmodulehelper> modulemysql(List<int> moduleids)
          {
              var modulelistmysq = new List<tblmodulehelper>();
              using (mazakdaqEntities1 db = new mazakdaqEntities1())
              {
                 // string correcteddate = GetCorrectedDate();
                  //DateTime newdate = Convert.ToDateTime(correcteddate);



                  modulelistmysq = db.tblmodulehelpers.Where(m => !moduleids.Contains(m.ID)).Take(30000).OrderBy(m => m.ID).ToList();
              }
              return modulelistmysq;
          }
          public List<recipientmailid> recipmysql(List<int> recipids)
          {
              var recipientlistmysq = new List<recipientmailid>();
              using (mazakdaqEntities1 db = new mazakdaqEntities1())
              {

                  recipientlistmysq = db.recipientmailids.Where(m => !recipids.Contains(m.RE_ID)).Take(30000).OrderBy(m => m.RE_ID).ToList();
              }
              return recipientlistmysq;
          }

          public List<tblshift_mstr> shiftmysql(List<int> shifids)
          {
              var mstrlistmysq = new List<tblshift_mstr>();
              using (mazakdaqEntities1 db = new mazakdaqEntities1())
              {
                  string correcteddate = GetCorrectedDate();
                  DateTime newdate = Convert.ToDateTime(correcteddate);



                  mstrlistmysq = db.tblshift_mstr.Where(m => !shifids.Contains(m.ShiftID)&&m.CreatedOn== newdate).Take(30000).OrderBy(m => m.ShiftID).ToList();
              }
              return mstrlistmysq;
          }
          public List<pcb_details> pcbmysql(List<int> pcbids)
          {
              var pcblistmysq = new List<pcb_details>();
              using (mazakdaqEntities1 db = new mazakdaqEntities1())
              {
                  // string correcteddate = GetCorrectedDate();
                  //DateTime newdate = Convert.ToDateTime(correcteddate);



                  pcblistmysq = db.pcb_details.Where(m => !pcbids.Contains(m.PCBID)).Take(30000).OrderBy(m => m.PCBID).ToList();
              }
              return pcblistmysq;
          }
          public List<pcbdps_master> pcbdpsmysql(List<int> pcbdpsids)
          {
              var pcbdpslistmysq = new List<pcbdps_master>();
              using (mazakdaqEntities1 db = new mazakdaqEntities1())
              {
                  // string correcteddate = GetCorrectedDate();
                  //DateTime newdate = Convert.ToDateTime(correcteddate);



                  pcbdpslistmysq = db.pcbdps_master.Where(m => !pcbdpsids.Contains(m.PcbDpsMasterID)).Take(30000).OrderBy(m => m.PcbDpsMasterID).ToList();
              }
              return pcbdpslistmysq;
          }
      }*/
    }

}



    


    


