using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Assign2
{
    class MyDB
    {
        private static MyDB _instance;

        private SqlConnection _connection;

        private MyDB()
        {
            _connection = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=StudentsDB;Data Source=DESKTOP-O1HT8PC;MultipleActiveResultSets=True;");
        }

        public static MyDB GetInstance()
        {
            if (_instance == null)
                _instance = new MyDB();
            return _instance;
        }

        public void ExecuteSQL(string sql)
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
            var command = _connection.CreateCommand();
            command.CommandText = sql;
            command.ExecuteNonQuery();

            _connection.Close();
        }
        public SqlDataReader ExecuteSelectSQL(string sql)
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
            var command = _connection.CreateCommand();
            command.CommandText = sql;
            return command.ExecuteReader();

        }


    }
}
