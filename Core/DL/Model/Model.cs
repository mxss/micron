using System.Data;
using Core.DL.Module.Db;
using Dapper;

namespace Core.DL.Model {
    public abstract class Model {
        protected static IDbConnection Connection() => DbConnection.Connection();

        protected static void ExecuteSql(string sql, object parameters) => Connection().Execute(sql, parameters);

        protected static int ExecuteScalarInt(string sql) {
            return Connection().ExecuteScalar<int>(sql);
        }
    }
}