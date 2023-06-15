using FactoryManager.Controller.Report.AccessReport;
using System;

namespace FactoryManager.View.Report.ReportForm
{
    public partial class ReportForm3 : DevExpress.XtraEditors.XtraForm
    {
        private readonly IAccessReportHelper accessReportHelper;

        public ReportForm3(IAccessReportHelper _accessReportHelper)
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
