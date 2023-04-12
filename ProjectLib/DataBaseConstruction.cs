using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLib
{
    public class DataBaseConstruction : IDisposable
    {
        public bool IsConnected { get; private set; }
        SqlConnection _connection;
        string connectionstring = @"Data Source = DESKTOP-AVGELME\STP; Initial Catalog = ProjectDB; Integrated Security = True;";

        public DataBaseConstruction()
        {
            ConnectionOpen();
        }

        public void ConnectionOpen()
        {
            _connection = new SqlConnection(connectionstring);
            _connection.Open();
            IsConnected = true;
        }

        public void ConnectionClose()
        {
            _connection.Close();
            IsConnected = false;
        }

        public SqlConnection GetConnection()
        {
            return _connection;
        }

        public DataTable ExecuteSql(string sql)
        {
            DataTable dataTable = new DataTable();
            SqlCommand command = new SqlCommand(sql, _connection);
            var reader = command.ExecuteReader();
            dataTable.Load(reader);

            return dataTable;
        }

        public void ExecuteSqlNonQuery(string sql)
        {
            SqlCommand command = new SqlCommand(sql, _connection);
            command.ExecuteNonQuery();
        }

        public void Dispose()
        {
            ConnectionClose();
        }
    }
}
