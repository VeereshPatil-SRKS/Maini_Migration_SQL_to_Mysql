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

        public async Task<int> SQL_to_Mysql()
        {
            IntoFile("SQL_to_Mysql");
            int resultsu = 0;



            //mysql data
            MyDAL.ConnectionFactory con = new MyDAL.ConnectionFactory();
            MyDAL.IConnectionFactory _iconne;

            SRKSDAO srksMysql = new SRKSDAO();
            _iconne = new MyDAL.ConnectionFactory();
            srksMysql = new SRKSDAO(_iconne);

            var MysqlData = srksMysql.getplant();//2,3
            int countList = MysqlData.Count();


            //sql data

            SQLDAL.ConnectionFactory conSql = new SQLDAL.ConnectionFactory();
            SQLDAL.IConnectionFactory _iconneSQL;

            SQLDAO plantDAO = new SQLDAO();

            _iconneSQL = new SQLDAL.ConnectionFactory();
            plantDAO = new SQLDAO(_iconneSQL);


            var plantSql = plantDAO.GetPlantDetails();  //Get SQL
            sqlCount = plantSql.Count;

            IntoFile("Sql list count" + plantSql.Count);

            var ddlids = MysqlData.Select(m => m.PlantID).ToList();  // IDs 
            IntoFile("sql IDs Count" + ddlids.Count);


            var det = plantSql.Where(m => !ddlids.Contains(m.PlantID)).ToList();
            var res7 = det.ToList();
            IntoFile("Start_ddl Except SQL data:" + res7.Count);
            if (res7.Count > 0)
            {
                //  resultsu = await srksMysql.insertPlnatinMYsql(res7);


                // resultsu = await srksMysql.insert_ddlMysqlPlant(res7);


              List<configuration_tblplant> mysqlPlant = new  List<configuration_tblplant>();


                foreach (var row in res7)
                {
                    configuration_tblplant dlist = new configuration_tblplant();
                    dlist.PlantID = row.PlantID;
                    dlist.PlantName = row.PlantName;
                    dlist.PlantDesc = row.PlantDesc;
                    dlist.CreatedOn = row.CreatedOn;
                    dlist.CreatedBy = row.CreatedBy;

                    dlist.IsDeleted = row.IsDeleted;

                    mysqlPlant.Add(dlist);

                }


                resultsu = await srksMysql.insert_ddlMysqlPlantMysql(mysqlPlant);


               //  resultsu = await plantDAO.insert_ddlMysqlPlantSQl(res7); 

                IntoFile("inserted Successfully");
                
               
            }
            return resultsu;
        }

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
