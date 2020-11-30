using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDAL.DAO
{
   public class Reopository<T> where T : class
    {

        // Get List of Data based on tbl
        public List<T> GetList(string qry, IDbConnection con)
        {
            IList<T> Tlista = SqlMapper.Query<T>(con, qry, null, commandType: CommandType.Text).ToList();
            // IList<T> Tlista = mys.Query<T>(con, qry, null, commandType: CommandType.Text).ToList();
            return Tlista.ToList();
        }

        // Get Single Row 
        public T GetFirstOrDefault(string qry, IDbConnection con)
        {
            T Tlista = SqlMapper.Query<T>(con, qry, null, commandType: CommandType.Text).FirstOrDefault();
            return Tlista;
        }

        public int Insert(string qry, IDbConnection con)
        {
            int a = SqlMapper.Execute(con, qry, null, commandType: CommandType.Text);
            return a;
        }
        public int update(string qry, IDbConnection con)
        {
            int a = SqlMapper.Execute(con, qry, null, commandType: CommandType.Text);
            return a;
        }
    }
}
