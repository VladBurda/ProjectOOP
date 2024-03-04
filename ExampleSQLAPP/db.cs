using System;
using Microsoft.Data.SqlClient;

namespace ExampleSQLAPP
{
    class DB
    {
        SqlConnection connection = new SqlConnection("Data Source=(local);Initial Catalog=Project_W67949;Integrated Security=True;Encrypt=False");

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void CloseConnection()
        {
              if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public SqlConnection GetConnection()
        {
            return connection;
        }
    }
}
