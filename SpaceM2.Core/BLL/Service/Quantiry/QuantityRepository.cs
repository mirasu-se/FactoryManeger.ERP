using System.Data;
using System.Data.OleDb;
using System.Collections.Generic;
using SpaceM2.Core.BLL.Model;
using System.Threading.Tasks;
using Dapper;

namespace SpaceM2.Core.BLL.Service
{
    public class QuantityRepository : IQuantityRepository
    {
        public async Task<IEnumerable<QuantityModel>> GetAll()
        {
            using IDbConnection db = new OleDbConnection(ConnectionService.GetConnectionString());
            if (db.State == ConnectionState.Closed)
                db.Open();
            var result = await db.QueryAsync<QuantityModel>("SELECT * FROM Mängder", commandType: CommandType.Text);
            return result;
        }
    }
}
