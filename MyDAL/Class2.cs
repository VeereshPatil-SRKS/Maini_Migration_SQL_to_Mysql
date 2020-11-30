using System;
using MySql.Data.MySqlClient;


namespace MySQLDAL
{
    class Class2
    {
        static String ServerName = @"SRKS-TECH3-PC\SQLEXPRESS" /*"TCP:SRKS_TECH-1,19040"*/;
        static String username = "root";
        static String password = "srks4$";
        static String port = "3306";
        static String DB = "mazakdaq";

        public MySqlConnection msqlConnection = new MySqlConnection("server = " + ServerName + ";userid = " + username + ";Password = " + password + ";database = " + DB + ";port = " + port + ";persist security info=False");


        //For Other Servers
        public void open()
        {
            if (msqlConnection.State != System.Data.ConnectionState.Open)
                msqlConnection.Open();
        }

        public void close()
        {

            msqlConnection.Close();
        }

        public void Dispose()
        {
            msqlConnection.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
