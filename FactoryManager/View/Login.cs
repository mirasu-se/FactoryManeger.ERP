using System;
using System.Windows.Forms;
using FactoryManager.AppService.DateTimeCounting;
using FactoryManager.AppService.ApplicationLogger;
using FactoryManager.AppService.ConfigurationReader;
using System.Threading;
using DevExpress.XtraSplashScreen;
using FactoryManager.Controller.Dialog.MessageBox;
using FactoryManager.AppService.CommandPrompt;
using FactoryManager.View.Dialog;
using FactoryManager.AppService.ViewInitialization;
using FactoryManager.AppService.ViewInitialization.Docking;
using SpaceM2.Core.BLL.Model;
using SpaceM2.Core.BLL.Service;

namespace FactoryManager.View
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        private readonly ILogHelper logHelper;
        private log4net.ILog loggerLog;

        private readonly IAssemblyReader assemblyReader;
        private readonly IDockingFormHelper dockingFormHelper;
        private readonly IConfigurationReader configurationReader;
        private readonly ICurrentDateTimeHelper currentDateTimeHelper;
        private readonly IDialogMessageHelper dialogMessageHelper;
        private readonly ICommandPromptHelper commandPromptHelper;

        private readonly IUserRepository userRepository;

        public Login(
            ILogHelper _logHelper,
            IAssemblyReader _assemblyReader,
            IDockingFormHelper _dockingFormHelper,
            IConfigurationReader _configurationReader, 
            ICurrentDateTimeHelper _currentDateTimeHelper, 
            IDialogMessageHelper _dialogMessageHelper, 
            ICommandPromptHelper _commandPromptHelper,
            IUserRepository _userRepository
            )
        {
            this.logHelper = _logHelper;

            this.assemblyReader = _assemblyReader;
            this.dockingFormHelper = _dockingFormHelper;
            this.configurationReader = _configurationReader;
            this.currentDateTimeHelper = _currentDateTimeHelper;
            this.dialogMessageHelper = _dialogMessageHelper;
            this.commandPromptHelper = _commandPromptHelper;
            this.userRepository = _userRepository;

            InitializeComponent();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Maximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                Maximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                Maximize.IconChar = FontAwesome.Sharp.IconChar.Compress;
            }
        }

        private void ButtoneExit_Click(object sender, EventArgs e)
        {
            dialogMessageHelper.AskToCloseApplication();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            loggerLog = logHelper.GetLogger();
            bool isAccessRunning = commandPromptHelper.CheckIfProcessIsAlreadyRunning("MSACCESS");
            bool isExcelRunning = commandPromptHelper.CheckIfProcessIsAlreadyRunning("EXCEL");
            if (isAccessRunning || isExcelRunning)
            {
                string result = ServiceStopDialog.ShowBox(
                "Kära kunder, 'Factory Manager' använder Microsoft Office-automatisering för att utföra sina operationer. \n\n" +
                "Programmet upptäckte att en förekomst av Microsoft Access eller Microsoft Excel redan kördes på datorn. " +
                "Innan du startar Factory Manager, spara ditt arbete och stäng Microsoft Office-applikationer. " +
                "Om du vill du kan döda den instansen genom att trycka på knappen 'Tvinga appen att avsluta' och Factory Manager kommer att starta.",
                "MEDDELANDE OM MICROSOFT OFFICE AUTOMATION");
                if (result == "1")
                    Application.Exit();
                else
                    commandPromptHelper.Execute(1, "taskkill /F /IM msaccess.exe");
                    commandPromptHelper.Execute(1, "taskkill /F /IM excel.exe");
                NotificationBox.ShowBox("Grattis. Microsoft Office-applikationer har stoppats från listan över program som körs.", "MICROSOFT ACCESS STÄNGD");
            }
            AppVersionLabel.Text = configurationReader.GetAppName() + " v " + configurationReader.GetAppVersion();
            CopyrightLabel.Text = configurationReader.GetAppCopyright() + currentDateTimeHelper.GetCopyrightYear();
        }

        private void PerformLoginAction()
        {
            try
            {

                SplashScreenManager.ShowForm(this, typeof(LoadingScreen), true, true, false);
                for (int i = 1; i <= 100; i++)
                {
                    SplashScreenManager.Default.SetWaitFormCaption("AUTENTISERING");
                    SplashScreenManager.Default.SetWaitFormDescription("Vänta medan dina data valideras!");
                    Thread.Sleep(50);
                }
                SplashScreenManager.CloseForm(false);

                var isUserValid = userRepository.ValidateUser(LoginTextBox.Text);

                if (isUserValid == true)
                {
                    UserModel user = userRepository.GetLogedInUser(LoginTextBox.Text);
                    MainView app = new MainView(logHelper, assemblyReader, dockingFormHelper, dialogMessageHelper, currentDateTimeHelper, user)
                    {
                        TopLevel = true,
                        Owner = this
                    };
                    LoginTextBox.ResetText();
                    app.Show();
                    Hide();
                    loggerLog.Info("User validation succesfull!");
                }
                else
                {
                    NotificationBox.ShowBox(
                        "Ditt lösenord var felaktigt!" +
                        "\n" +
                        "Kontrollera att du har angett allt korrekt ta hand om versaler och gemener. " +
                        "\n" +
                        "Om problemet kvarstår kontaktar du systemadministratören. ",
                        "LOGIN ERROR");
                    loggerLog.Info("User login refused! No users with provided password!");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                loggerLog.Error(ex.Message.ToString());
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            PerformLoginAction();
        }

        private void LoginTextBox_Enter(object sender, EventArgs e)
        {
            LoginTextBox.Text = "";
            LoginTextBox.isPassword = true;
        }

        private void LoginTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                PerformLoginAction();
            }
        }
    }
}