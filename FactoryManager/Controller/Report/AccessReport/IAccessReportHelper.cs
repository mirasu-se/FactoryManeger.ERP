namespace FactoryManager.Controller.Report.AccessReport
{
    public interface IAccessReportHelper
    {
        void Preview_Report(string databasePath, string reportName);
        void Print_Report(string databasePath, string reportName);
    }
}