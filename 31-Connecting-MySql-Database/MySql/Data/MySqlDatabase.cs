using System;
using MySql.Data.MySqlClient;

namespace MySql.Data
{
    public class MySqlDatabase
    {
        public MySqlConnection Connection { get; }

        public MySqlDatabase(string connectionString)
        {
            Connection = new MySqlConnection(connectionString ?? throw new ArgumentNullException(nameof(connectionString)));
        }

        public void Open()
        {
            if (Connection.State == System.Data.ConnectionState.Closed)
            {
                Connection.Open();
            }
        }

        public void Close()
        {
            if (Connection.State == System.Data.ConnectionState.Open)
            {
                Connection.Close();
            }
        }
    }
}