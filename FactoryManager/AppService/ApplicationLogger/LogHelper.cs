using System.Runtime.CompilerServices;

namespace FactoryManager.AppService.ApplicationLogger
{
    public class LogHelper : ILogHelper
    {
        public log4net.ILog GetLogger([CallerFilePath] string filename = "")
        {
            return log4net.LogManager.GetLogger(filename);
        }
    }
}
