using FactoryManager.View;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace FactoryManager.AppService.ViewInitialization
{
    public class AssemblyReader : IAssemblyReader
    {
        public List<AppForm> GetAllForms()
        {
            List<AppForm> appForms = new List<AppForm>();
            Type formType = typeof(Form);
            foreach (Type type in Assembly.GetExecutingAssembly().GetTypes())
                if (formType.IsAssignableFrom(type)
                    && type.Name != "MainForm"
                    && type.Name != "MessageDialog"
                    && type.Name != "NotificationDialog"
                    && type.Name != "LoadingScreen")
                {
                    appForms.Add(new AppForm { Id = type.FullName, Name = type.Name });
                }
            return appForms;
        }

        public void RegisterAllForms()
        {
            var appForms = GetAllForms();
            MainView.FormList.DataSource = appForms;
            MainView.FormList.ValueMember = "Id";
            MainView.FormList.DisplayMember = "Name";
        }
    }
}
