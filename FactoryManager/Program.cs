using System;
using System.Windows.Forms;
using FactoryManager.AppService.ApplicationLogger;
using FactoryManager.AppService.CommandPrompt;
using FactoryManager.AppService.ConfigurationReader;
using FactoryManager.AppService.DateTimeCounting;
using FactoryManager.View;
using FactoryManager.View.GridControl.GridForm;
using FactoryManager.Controller.Dialog.MessageBox;
using FactoryManager.Controller.GridControl.Selection;
using FactoryManager.Controller.GridControl.FormValidation;
using SimpleInjector;
using SimpleInjector.Diagnostics;
using SpaceM2.Core.BLL.Model;
using SpaceM2.Core.BLL.Service;
using FactoryManager.AppService.ViewInitialization;
using FactoryManager.AppService.ViewInitialization.Docking;
using FactoryManager.Controller.GridControl.View;
using FactoryManager.Controller.GridControl.GridForm;
using FactoryManager.Controller.Report.AccessReport;
using FactoryManager.Controller.Report.Selection;

namespace FactoryManager
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var container = Bootstrap();
            Application.Run(container.GetInstance<Login>());
        }

        static readonly Container container = new Container();

        private static Container Bootstrap()
        {
            // Register startup services for instance:
            ConfigureStartUpService();
            

            container.Register<ICommandPromptHelper, CommandPromptHelper>(Lifestyle.Singleton);
            container.Register<ICurrentDateTimeHelper, CurrentDateTimeHelper>(Lifestyle.Singleton);
            container.Register<IDockingFormHelper, DockingFormHelper>(Lifestyle.Singleton);
            container.Register<IDialogMessageHelper, DialogMessageHelper>(Lifestyle.Singleton);

            container.Register<UserModel>(Lifestyle.Singleton);

            ConfigureDataGridService();

            ConfigureDataGridForms();

            ConfigureReportService();

            ConfigureBLLService();

            AutoRegisterWindowsForms(container);

            container.Verify();

            return container;
        }

        private static void ConfigureStartUpService()
        {
            container.Register<IConfigurationReader, ConfigurationReader>(Lifestyle.Singleton);
            container.Register<IAssemblyReader, AssemblyReader>(Lifestyle.Singleton);
            container.Register<ILogHelper, LogHelper>(Lifestyle.Singleton);
        }

        private static void ConfigureDataGridService()
        {
            container.Register<IGridSelectionHelper, GridSelectionHelper>(Lifestyle.Singleton);
            container.Register<IGridViewManager, GridViewManager>(Lifestyle.Singleton);
            container.Register<IGridFormManager, GridFormManager>(Lifestyle.Singleton);
            container.Register<IFieldValidationHelper, FieldValidationHelper>(Lifestyle.Singleton);
        }

        private static void ConfigureDataGridForms()
        {
            container.Register<IProjectForm, ProjectForm>(Lifestyle.Singleton);
        }

        private static void ConfigureReportService()
        {
            container.Register<IReportSelectionHelper, ReportSelectionHelper>(Lifestyle.Singleton);
            container.Register<IAccessReportHelper, AccessReportHelper>(Lifestyle.Singleton);
        }

        private static void ConfigureBLLService()
        {
            container.Register<IAutoincrementService, AutoincrementService>(Lifestyle.Singleton);
            container.Register<IProjectRepository, ProjectRepository>(Lifestyle.Singleton);
            container.Register<IUserRepository, UserRepository>(Lifestyle.Singleton);
            container.Register<IBankAccountRepository, BankAccountRepository>(Lifestyle.Singleton);
            container.Register<IQuantityRepository, QuantityRepository>(Lifestyle.Singleton);
        }

        private static void AutoRegisterWindowsForms(Container container)
        {
            var types = container.GetTypesToRegister<Form>(typeof(Program).Assembly);

            foreach (var type in types)
            {
                var registration =
                    Lifestyle.Singleton.CreateRegistration(type, container);

                registration.SuppressDiagnosticWarning(
                    DiagnosticType.DisposableTransientComponent,
                    "Forms should be disposed by app code; not by the container.");

                container.AddRegistration(type, registration);
            }
        }
    }
}
