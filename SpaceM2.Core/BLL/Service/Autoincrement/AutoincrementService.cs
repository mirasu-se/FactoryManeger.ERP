using System;
using System.Data;
using System.Data.OleDb;
using System.Threading.Tasks;
using Dapper;

namespace SpaceM2.Core.BLL.Service
{
    public class AutoincrementService : IAutoincrementService
    {

        public AutoincrementModel GetAutoincrementNumber(string firstColumName, string secondColumName, string tableName)
        {
            var sql = @"SELECT  " + firstColumName + "," + secondColumName + " FROM " + tableName + " WHERE " + firstColumName + " = ( SELECT MAX(" + firstColumName + ") FROM " + tableName + ") AND ( SELECT MAX(" + secondColumName + ") FROM " + tableName + ");";

            using IDbConnection db = new OleDbConnection(ConnectionService.GetConnectionString());
            if (db.State == ConnectionState.Closed)
                db.Open();

            var autoincrementModel = db.QuerySingleOrDefault<AutoincrementModel>(sql);
            autoincrementModel.Id += 1;
            autoincrementModel.Number += 1;

            return autoincrementModel;
        }
    }
}
