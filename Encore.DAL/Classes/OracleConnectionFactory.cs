
using System;
using System.Data;
using Encore.DAL.Interfaces;
using Oracle.ManagedDataAccess.Client;

namespace Encore.DAL.Factories
{
    public class OrclDbConnectionFactory : IDbConnectionFactory
    {
        private readonly string _connectionString;

        public OrclDbConnectionFactory(string connectionString)
        {
            if (connectionString == null)
            {
                throw new ArgumentNullException("connectionString");
            }
            _connectionString = connectionString;
        }

        public IDbConnection Create()
        {            
            return new OracleConnection(_connectionString);
        }
    }
}

