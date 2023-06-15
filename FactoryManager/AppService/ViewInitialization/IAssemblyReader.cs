using System.Collections.Generic;

namespace FactoryManager.AppService.ViewInitialization
{
    public interface IAssemblyReader
    {
        List<AppForm> GetAllForms();
        void RegisterAllForms();
    }
}