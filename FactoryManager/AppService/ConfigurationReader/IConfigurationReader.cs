namespace FactoryManager.AppService.ConfigurationReader
{
    public interface IConfigurationReader
    {
        string GetAppCopyright();
        string GetAppName();
        string GetAppVersion();
        string GetConnectionString();
    }
}