using System;
using System.Linq;
using System.Windows.Forms;
using FactoryManager.AppService.ApplicationLogger;
using FactoryManager.View;
using FactoryManager.View.DataGrid;
using FactoryManager.View.Report;
using FactoryManager.Controller.GridControl.Selection;
using FactoryManager.Controller.Report.Selection;

namespace FactoryManager.AppService.ViewInitialization.Docking
{
    public class DockingFormHelper : IDockingFormHelper
    {
        private readonly ILogHelper logHelper;
        private readonly IGridSelectionHelper gridSelectionHelper;
        private readonly IReportSelectionHelper reportSelectionHelper;

        public DockingFormHelper(ILogHelper _logHelper, IGridSelectionHelper _gridSelectionHelper, IReportSelectionHelper _reportSelectionHelper)
        {
            this.logHelper = _logHelper;
            this.gridSelectionHelper = _gridSelectionHelper;
            this.reportSelectionHelper = _reportSelectionHelper;
        }

        public bool CheckIfFormIsAlreadyOpened(string formName)
        {
            bool isOpened= false;
            Form[] forms = Application.OpenForms.Cast<Form>().ToArray();
            foreach (Form form in forms)
            {
                if (form.Name == formName)
                {
                    isOpened = true;
                }
                else
                {
                    isOpened = false;
                }
            }
            return isOpened;
        }

        public void CloseAllOpenForms(string formName)
        {
            Form[] forms = Application.OpenForms.Cast<Form>().ToArray();
            foreach (Form form in forms)
            {
                if (form.Name != "Login" && form.Name != "MainView" && form.Name != "LoadingScreen" && form.Name != formName)
                {
                    form.Close();
                }
            }
        }

        public void OpenDockingForm()
        {
            if (MainView.FormList.SelectedItem is AppForm appForm)
            {
                Type objectType = Type.GetType(appForm.Id);
                if (objectType != null)
                {
                    if (Activator.CreateInstance(objectType) is Form form)
                    {
                        form.TopLevel = false;
                        form.Dock = DockStyle.Fill;
                        MainView.DockingPanel.Controls.Clear();
                        MainView.DockingPanel.Controls.Add(form);
                        form.Show();
                    }
                }
            }
        }

        public void OpenGridSelection()
        {
            Form gridSelection = new GridSelection(
                logHelper,
                gridSelectionHelper)
            {
                TopLevel = false,
                Dock = DockStyle.Fill
            };
            MainView.DockingPanel.Controls.Clear();
            MainView.DockingPanel.Controls.Add(gridSelection);
            gridSelection.Show();
        }

        public void OpenReportSelection()
        {
            Form reportSelection = new ReportSelection(
                reportSelectionHelper)
            {
                TopLevel = false,
                Dock = DockStyle.Fill
            };
            MainView.DockingPanel.Controls.Clear();
            MainView.DockingPanel.Controls.Add(reportSelection);
            reportSelection.Show();
        }
    }
}
