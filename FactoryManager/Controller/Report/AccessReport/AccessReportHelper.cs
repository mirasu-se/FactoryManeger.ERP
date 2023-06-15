using FactoryManager.AppService.CommandPrompt;
using System;
using System.Reflection;
using System.Windows.Forms;
using Access = Microsoft.Office.Interop.Access;

namespace FactoryManager.Controller.Report.AccessReport
{
    public class AccessReportHelper : IAccessReportHelper
    {
        private static readonly object moMissing = Missing.Value;

        public void Print_Report(string databasePath, string reportName)
        {

            Access.Application oAccess = null;

            try
            {
                // Start a new instance of Access for Automation:
                oAccess = new Access.Application
                {
                    Visible = false
                };

                // Make sure Access is hidden
                if (oAccess.Visible) oAccess.Visible = false;

                oAccess.OpenCurrentDatabase(databasePath, false, "");

                // Select the report name in the database window and give focus to the database window:
                oAccess.DoCmd.SelectObject(Access.AcObjectType.acReport, reportName, true);

                var reportFilter = "((([Moduler Excel].[Modulnummer_(Sammansatt)2])='101319'))";
                // Print the report:
                oAccess.DoCmd.OpenReport(
                   reportName,
                   Access.AcView.acViewNormal,
                   moMissing,// Query name
                   reportFilter,
                   Access.AcWindowMode.acWindowNormal,
                   moMissing);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


        public void Preview_Report(string databasePath, string reportName)
        {
            Access.Application oAccess = null;

            try
            {
                // Start a new instance of Access for Automation:
                oAccess = new Access.Application
                {
                    Visible = false
                };
                // Make sure Access is visible:
                if (!oAccess.Visible) oAccess.Visible = true;

                // Open database in exclusive mode:
                oAccess.OpenCurrentDatabase(databasePath, true);

                // Select the report name in the database window and give focus to the database window:
                oAccess.DoCmd.SelectObject(Access.AcObjectType.acReport, reportName, true);
                oAccess.DoCmd.ShowToolbar("Ribbon", Access.AcShowToolbar.acToolbarNo);
                oAccess.DoCmd.ShowToolbar("Status Bar", Access.AcShowToolbar.acToolbarNo);
                oAccess.DoCmd.ShowToolbar("Menu Bar", Access.AcShowToolbar.acToolbarNo);

                oAccess.CommandBars["Menu Bar"].Enabled = false;
                //oAccess.CommandBars["Print Preview"].Enabled = false;
                //oAccess.CommandBars["Print Preview Popup"].Enabled = false;


                oAccess.DoCmd.NavigateTo("acNavigationCategoryObjectType");
                oAccess.DoCmd.RunCommand(Access.AcCommand.acCmdWindowHide);
                oAccess.DoCmd.LockNavigationPane(true);

                // Maximize the Access window:
                oAccess.RunCommand(Access.AcCommand.acCmdAppMaximize);

                var reportFilter = "((([Moduler Excel].[Modulnummer_(Sammansatt)2])='101319'))";
                // Preview the report:
                oAccess.DoCmd.OpenReport(
                   reportName,
                   Access.AcView.acViewReport,
                   moMissing,
                   reportFilter,
                   Access.AcWindowMode.acWindowNormal,
                   moMissing);

                // Maximize the report window:
                oAccess.DoCmd.Maximize();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
