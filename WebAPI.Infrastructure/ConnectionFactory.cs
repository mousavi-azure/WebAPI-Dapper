using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;

namespace WebAPI.Infrastructure
{
    public class ConnectionFactory : IConnectionFactory
    {
        private readonly string connectionString;
        public ConnectionFactory(string cs)
        {
            connectionString = cs;
        }
        public IDbConnection GetConnection
        {
            get
            {
                var factory = DbProviderFactories.GetFactory("System.Data.SqlClient");
                var conn = factory.CreateConnection();
                conn.ConnectionString = connectionString;
                conn.Open();
                return conn;
            }
        }
    }
}
