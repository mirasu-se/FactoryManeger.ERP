using System.Data.OleDb;

namespace SpaceM2.Core.BLL
{
    public class ConnectionService
    {
        public static string GetConnectionString()
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Data\SpaceM2.accdb";
            return connectionString;
        }

        private static OleDbConnection GetDatabaseConnection()
        {
            OleDbConnection oleDbConnection = new OleDbConnection
            {
                ConnectionString = GetConnectionString()
            };
            return oleDbConnection;
        }

        public static OleDbConnection CreateDatabaseConnection()
        {
            var oleDbConnection = GetDatabaseConnection();
            oleDbConnection.Open();
            return oleDbConnection;
        }
    }
}
