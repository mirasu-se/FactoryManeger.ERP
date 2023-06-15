using System.Data;
using System.Data.OleDb;
using System.Collections.Generic;
using SpaceM2.Core.BLL.Model;
using System.Threading.Tasks;
using Dapper;
using System.Linq;

namespace SpaceM2.Core.BLL.Service
{
    public class ProjectRepository : IProjectRepository
    {
        private const bool isUsingUnderscore = true;

        public IEnumerable<ProjectModel> GetAll()
        {
            DefaultTypeMap.MatchNamesWithUnderscores = isUsingUnderscore;
            using IDbConnection db = new OleDbConnection(ConnectionService.GetConnectionString());
            if (db.State == ConnectionState.Closed)
                db.Open();
            var projectModel =  db.Query<ProjectModel>("SELECT * FROM Project;", commandType: CommandType.Text);
            return projectModel;
            //NotificationBox.ShowBox("Alla projekt har lyckats hämtas från databasen!", "DATABASINFO");
        }

        public ProjectModel GetById(int id)
        {
            DefaultTypeMap.MatchNamesWithUnderscores = isUsingUnderscore;
            using IDbConnection db = new OleDbConnection(ConnectionService.GetConnectionString());
            if (db.State == ConnectionState.Closed)
                db.Open();

            string sql = "SELECT * FROM Project WHERE Project_Id = @Id;";

            var projectModel = db.QuerySingleOrDefault<ProjectModel>(sql, new { Id = id });
            return projectModel;
            //NotificationBox.ShowBox("Alla projekt har lyckats hämtas från databasen!", "DATABASINFO");
        }

        public async Task<int> Add(ProjectModel project)
        {
            DefaultTypeMap.MatchNamesWithUnderscores = isUsingUnderscore;
            using IDbConnection db = new OleDbConnection(ConnectionService.GetConnectionString());

            if (db.State == ConnectionState.Closed)
                db.Open();
            var sql = @"INSERT INTO Project (
                [ProjectNumber], 
                [ProjectName],  
                [StatusKey],
                [Description],
                [CustomerName],
                [MunicipalityName]) 
                Values (
                @ProjectNumber,
                @ProjectName,
                @StatusKey, 
                @Description,
                @CustomerName, 
                @MunicipalityName);";
            var affectedRows = await db.ExecuteAsync(sql, project);
            return affectedRows;
            //NotificationBox.ShowBox("Nytt projekt har lagts till i databasen!", "DATABASINFO");
        }

        public async Task<int> Modify(ProjectModel project, int id)
        {
            DefaultTypeMap.MatchNamesWithUnderscores = isUsingUnderscore;
            using IDbConnection db = new OleDbConnection(ConnectionService.GetConnectionString());

            if (db.State == ConnectionState.Closed)
                db.Open();
            var sql = @"UPDATE Project SET
                [ProjectNumber] = @ProjectNumber,
                [ProjectName] = @ProjectName,
                [StatusKey] = @StatusKey,
                [Description] = @Description,
                [CustomerName] = @CustomerName,
                [MunicipalityName] = @MunicipalityName
                WHERE ProjectNumber = @Id;";
            var affectedRows = await db.ExecuteAsync(sql, new {project, Id = id });
            return affectedRows;
            //NotificationBox.ShowBox("Projektdata har uppdaterats framgångsrikt!", "DATABASINFO");
        }

        public async Task<int> Remove(int id)
        {
            DefaultTypeMap.MatchNamesWithUnderscores = isUsingUnderscore;
            using IDbConnection db = new OleDbConnection(ConnectionService.GetConnectionString());
            if (db.State == ConnectionState.Closed)
                db.Open();
            var sql = "DELETE FROM Project WHERE Project_Id = @Id;";
            var affectedRows = await db.ExecuteAsync(sql, new {Id = id });
            return affectedRows;
            //NotificationBox.ShowBox("Projektet har tagits bort från databasen.", "DATABASINFO");
        }
    }
}
