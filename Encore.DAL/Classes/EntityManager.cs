using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using Encore.DAL.Interfaces;

namespace Encore.DAL
{
    public class EntityManager : IEntityManager
    {
        private readonly IDbConnection _connection;

        public EntityManager()
        {
        }

        public EntityManager(IDbConnection connection)
        {
            _connection = connection;
        }

        public List<T> GetEntitiesList<T>()
        {
            if (_connection.State != ConnectionState.Open)
                _connection.Open();
            var entityType = typeof(T);
            var qry = "SELECT * FROM " + entityType.Name;
            var result = _connection.Query<T>(qry).ToList();
            _connection.Close();
            return result;
        }

        public T GetEntityById<T>(int Id)
        {
            if (_connection.State != ConnectionState.Open)
                _connection.Open();
            var entityType = typeof (T);
            var qry = "SELECT * FROM " + entityType.Name + " WHERE ID = @Id";
            var param = new DynamicParameters();
            param.Add("@Id",Id, DbType.Int32);
            var result = _connection.Query<T>(qry,param).FirstOrDefault();
            _connection.Close();
            return result;
        }

    }
}
