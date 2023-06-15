namespace FactoryManager.Controller.Dialog.MessageBox
{
    public interface IDialogMessageHelper
    {
        void AskToCloseApplication();
        void AskToShutdownSystem();
        void AskToLockDesktop();
    }
}