using DevExpress.XtraSplashScreen;
using FactoryManager.AppService.ApplicationLogger;
using FactoryManager.AppService.DateTimeCounting;
using FactoryManager.View.Dialog;
using FactoryManager.Controller.Dialog.MessageBox;
using System;
using System.Threading;
using System.Windows.Forms;
using SpaceM2.Core.BLL.Model;
using FactoryManager.AppService.ViewInitialization;
using FactoryManager.AppService.ViewInitialization.Docking;

namespace FactoryManager.View
{
    public partial class MainView : DevExpress.XtraEditors.XtraForm
    {
        private readonly ILogHelper logHelper;
        private log4net.ILog loggerLog;

        private readonly IAssemblyReader assemblyReader;
        private readonly IDockingFormHelper dockingFormHelper;
        private readonly IDialogMessageHelper dialogMessageHelper;
        private readonly ICurrentDateTimeHelper currentDateTimeHelper;

        public static Form MainFormPublic;
        public static ComboBox FormList;
        public static Panel DockingPanel;
        public static Label SectionIndicator;

        public MainView(
            ILogHelper _logHelper, 
            IAssemblyReader _assemblyReader, 
            IDockingFormHelper _dockingFormHelper, 
            IDialogMessageHelper _dialogMessageHelper,
            ICurrentDateTimeHelper _currentDateTimeHelper,
            UserModel user)
        {
            this.logHelper = _logHelper;

            this.assemblyReader = _assemblyReader;
            this.dockingFormHelper = _dockingFormHelper;
            this.dialogMessageHelper = _dialogMessageHelper;
            this.currentDateTimeHelper = _currentDateTimeHelper;

            InitializeComponent();

            MainFormPublic = this;
            FormList = cboAppForms;
            DockingPanel = MainPanel;
            SectionIndicator = LabelIndicator;

            LabelUserName.Text = user.FirstName + " " + user.LastName;
            LabelUserRole.Text = user.RoleKey;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            loggerLog = logHelper.GetLogger();
            assemblyReader.RegisterAllForms();
            Home.PerformClick();
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

        private void DateTimeTimer_Tick(object sender, EventArgs e)
        {
            var dateTime = currentDateTimeHelper.GetAllDateTimeValues();
            CurrentDateTimeLabel.Text = dateTime.CurrentDate ;
            CurrentWeekLabel.Text = "VECKA " + dateTime.WeekNumber.ToString();
            TimeLabel.Text = dateTime.CurrentDay + ", " + dateTime.CurrentTime;
        }

        private void DisplayLogoutWaitForm()
        {
            SplashScreenManager.ShowForm(this, typeof(LoadingScreen), true, true, false);
            for (int i = 1; i <= 100; i++)
            {
                SplashScreenManager.Default.SetWaitFormCaption("LOGGAR UT");
                SplashScreenManager.Default.SetWaitFormDescription("Vänta en stund innan du loggar ut!!");
                Thread.Sleep(50);
            }
            SplashScreenManager.CloseForm(false);
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            DisplayLogoutWaitForm();
            Hide();
            Owner.Show();
            loggerLog.Info("User logged OUT!");
        }


        private void Home_Click(object sender, EventArgs e)
        {
            LabelIndicator.Text = (sender as Button).Text.ToUpper();
            if (dockingFormHelper.CheckIfFormIsAlreadyOpened((sender as Button).Name) == false)
            {
                dockingFormHelper.CloseAllOpenForms((sender as Button).Name);
                cboAppForms.SelectedIndex = cboAppForms.FindStringExact((sender as Button).Name);
                dockingFormHelper.OpenDockingForm();
            }
        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            LabelIndicator.Text = (sender as Button).Text.ToUpper();
            if (dockingFormHelper.CheckIfFormIsAlreadyOpened((sender as Button).Name) == false)
            {
                dockingFormHelper.CloseAllOpenForms((sender as Button).Name);
                cboAppForms.SelectedIndex = cboAppForms.FindStringExact((sender as Button).Name);
                dockingFormHelper.OpenDockingForm();
            }
        }


        private void Project_Click(object sender, EventArgs e)
        {
            LabelIndicator.Text = (sender as Button).Text.ToUpper();
            if (dockingFormHelper.CheckIfFormIsAlreadyOpened((sender as Button).Name) == false)
            {
                dockingFormHelper.CloseAllOpenForms((sender as Button).Name);
                cboAppForms.SelectedIndex = cboAppForms.FindStringExact((sender as Button).Name);
                dockingFormHelper.OpenDockingForm();
            }
        }

        private void GridSelection_Click(object sender, EventArgs e)
        {
            LabelIndicator.Text = (sender as Button).Text.ToUpper();
            if (dockingFormHelper.CheckIfFormIsAlreadyOpened((sender as Button).Name) == false)
            {
                dockingFormHelper.CloseAllOpenForms((sender as Button).Name);
                cboAppForms.SelectedIndex = cboAppForms.FindStringExact((sender as Button).Name);
                dockingFormHelper.OpenGridSelection();
            }
        }

        private void AccessReport_Click(object sender, EventArgs e)
        {
            LabelIndicator.Text = (sender as Button).Text.ToUpper();
            if (dockingFormHelper.CheckIfFormIsAlreadyOpened((sender as Button).Name) == false)
            {
                dockingFormHelper.CloseAllOpenForms((sender as Button).Name);
                cboAppForms.SelectedIndex = cboAppForms.FindStringExact((sender as Button).Name);
                dockingFormHelper.OpenReportSelection();
            }
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            LabelIndicator.Text = (sender as Button).Text.ToUpper();
            if (dockingFormHelper.CheckIfFormIsAlreadyOpened((sender as Button).Name) == false)
            {
                dockingFormHelper.CloseAllOpenForms((sender as Button).Name);
                cboAppForms.SelectedIndex = cboAppForms.FindStringExact((sender as Button).Name);
                dockingFormHelper.OpenDockingForm();
            }
        }
    }
}
