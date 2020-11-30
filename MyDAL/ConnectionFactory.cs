using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDAL
{
  public  class ConnectionFactory: IConnectionFactory
    {

        //static String ServerName = "192.168.1.31"; //Localhost
        //static String username = "root";
        //static String password = "srks4$";
        //static String port = "3306";
        //static String DB = "i_facility"; //Common


        static String ServerName = "localhost"; //Localhost
        static String username = "root";
        static String password = "1068";
        static String port = "3306";
        static String DB = "unitworksccs"; //Common



        public static String DBCon = "unitworksccs";

      //  public readonly string DBconnFull = @"Data Source = " + ServerName + "; User ID = " + username + "; Password = " + password + ";Initial Catalog = " + DB + ";port = " + port + "; Persist Security Info=True";

        public static String DBConfig = "i_facility_configuration";
        public static String DBLive = "i_facility_live";
        public static string DBDashboard = "i_facility_dashboard";
        public static string DBHistory = "i_facility_history";


        public readonly string connectionString = @"Data Source = " + ServerName + "; User ID = " + username + "; Password = " + password + ";Initial Catalog = " + DB + ";port = " + port + "; Persist Security Info=True";

        public readonly string connectionStringConfig = @"Data Source = " + ServerName + "; User ID = " + username + "; Password = " + password + ";Initial Catalog = " + DBConfig + ";port = " + port + "; Persist Security Info=True";
        public readonly string connectionStringLive = @"Data Source = " + ServerName + "; User ID = " + username + "; Password = " + password + ";Initial Catalog = " + DBLive + "; port = " + port + "; Persist Security Info=True";
        public readonly string connectionStringDashboard = @"Data Source = " + ServerName + "; User ID = " + username + "; Password = " + password + ";Initial Catalog = " + DBDashboard + ";port = " + port + "; Persist Security Info=True";
        public readonly string connectionStringHistory = @"Data Source = " + ServerName + "; User ID = " + username + "; Password = " + password + ";Initial Catalog = " + DBHistory + "; port = " + port + ";Persist Security Info=True";

        public IDbConnection GetConnection
        {

            get
            {
                var factory = DbProviderFactories.GetFactory("MySql.Data.MySqlClient");
                var conn = factory.CreateConnection();
                conn.ConnectionString = connectionString;
                conn.Open();
                return conn;
            }


        }

        public IDbConnection GetConnectionConfig
        {

            get
            {
                var factory = DbProviderFactories.GetFactory("MySql.Data.MySqlClient");
                var conn = factory.CreateConnection();
                conn.ConnectionString = connectionStringConfig;
                conn.Open();
                return conn;
            }


        }

        public IDbConnection GetConnectionLive
        {
            get
            {
                var factory = DbProviderFactories.GetFactory("MySql.Data.MySqlClient");
                var conn = factory.CreateConnection();
                conn.ConnectionString = connectionStringLive;
                conn.Open();
                return conn;
            }
        }

        public IDbConnection GetConnectionHistory
        {
            get
            {
                var factory = DbProviderFactories.GetFactory("MySql.Data.MySqlClient");
                var conn = factory.CreateConnection();
                conn.ConnectionString = connectionStringHistory;
                conn.Open();
                return conn;
            }
        }
        public IDbConnection GetConnectionDashboard
        {
            get
            {
                var factory = DbProviderFactories.GetFactory("MySql.Data.MySqlClient");
                var conn = factory.CreateConnection();
                conn.ConnectionString = connectionStringDashboard;
                conn.Open();
                return conn;
            }
        }

        //public ConnectionFactory()
        //{
        //    GetConnection = GetConnection;
        //}


    }
}
