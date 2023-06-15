namespace FactoryManager.AppService.ViewInitialization.Docking
{
    public interface IDockingFormHelper
    {
        bool CheckIfFormIsAlreadyOpened(string formName);
        void CloseAllOpenForms(string formName);
        void OpenDockingForm();
        void OpenGridSelection();
        void OpenReportSelection();
    }
}