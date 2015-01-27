using System;
using System.Data;
using System.Data.SqlClient;
using Encore.DAL.Interfaces;

namespace Encore.DAL.Factories
{
    public class SqlDbConnectionFactory : IDbConnectionFactory
    {
        private readonly string _connectionString;

        public SqlDbConnectionFactory(string connectionString)
        {
            if (connectionString == null)
            {
                throw new ArgumentNullException("connectionString");
            }
            _connectionString = connectionString;
        }

        public IDbConnection Create()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
