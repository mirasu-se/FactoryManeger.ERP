using System;
using System.Windows.Forms;
using FactoryManager.Controller.Report.Selection;

namespace FactoryManager.View.Report
{
    public partial class ReportSelection : Form
    {
        private readonly IReportSelectionHelper reportSelectionHelper;

        static Label AccessFileName;
        static Panel ReportPanel;

        public ReportSelection(IReportSelectionHelper _reportSelectionHelper)
        {
            this.reportSelectionHelper = _reportSelectionHelper;
            
            InitializeComponent();

            AccessFileName = DatabaseFileName;
            ReportPanel = flpReports;
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            reportSelectionHelper.GetReports();
        }

        public static string GetAccessFilePath()
        {
            var accessFilePath = AccessFileName.Text;
            return accessFilePath;
        }

        public static void CreateAccessFilePath(string filePath)
        {
            AccessFileName.Text = filePath;
        }

        public static Panel ReturnReportPanel()
        {
            var panel = ReportPanel;
            return panel;
        }
    }
}
