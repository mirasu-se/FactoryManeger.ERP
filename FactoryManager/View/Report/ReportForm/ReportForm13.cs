using FactoryManager.Controller.Report.AccessReport;
using System;

namespace FactoryManager.View.Report.ReportForm
{
    public partial class ReportForm13 : DevExpress.XtraEditors.XtraForm
    {
        private readonly IAccessReportHelper accessReportHelper;

        public ReportForm13(IAccessReportHelper _accessReportHelper)
        {
            this.accessReportHelper = _accessReportHelper;
            InitializeComponent();
        }

        private void CloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Priview_Click(object sender, EventArgs e)
        {
            accessReportHelper.Preview_Report(ReportSelection.GetAccessFilePath(), FormTitle.Text);
        }
    }
}
