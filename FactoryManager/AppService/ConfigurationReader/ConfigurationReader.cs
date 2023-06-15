using System;

namespace FactoryManager.AppService.ConfigurationReader
{
    public class ConfigurationReader : IConfigurationReader
    {
        public string GetConnectionString()
        {
            var connectionString = Properties.Settings.Default.SpaceM2DatabaseConnectionString;
            return connectionString;
        }
        public string GetAppName()
        {
            string appName = System.Configuration.ConfigurationManager.AppSettings["AppName"];
            return appName;
        }
        public string GetAppVersion()
        {
            string appVersion = System.Configuration.ConfigurationManager.AppSettings["AppVersion"];
            return appVersion;
        }
        public string GetAppCopyright()
        {
            string copyright = System.Configuration.ConfigurationManager.AppSettings["Copyright"];
            return copyright;
        }
    }
}
