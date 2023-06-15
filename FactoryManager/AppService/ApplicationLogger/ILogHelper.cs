using System.Runtime.CompilerServices;
using log4net;

namespace FactoryManager.AppService.ApplicationLogger
{
    public interface ILogHelper
    {
        ILog GetLogger([CallerFilePath] string filename = "");
    }
}