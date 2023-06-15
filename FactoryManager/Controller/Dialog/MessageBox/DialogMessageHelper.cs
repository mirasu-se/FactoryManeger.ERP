using System.Windows.Forms;
using FactoryManager.AppService.CommandPrompt;
using FactoryManager.View.Dialog;

namespace FactoryManager.Controller.Dialog.MessageBox
{
    public class DialogMessageHelper : IDialogMessageHelper
    {
        private readonly ICommandPromptHelper commandPromptHelper;
        public DialogMessageHelper(ICommandPromptHelper _commandPromptHelper)
        {
            this.commandPromptHelper = _commandPromptHelper;
        }
        public void AskToCloseApplication()
        {
            string result = OptionBox.ShowBox("Do you really want to exit the program?", "APPLICATION EXIT");
            if (result.Equals("1"))
            {
                Application.Exit();
            }
        }
        public  void AskToShutdownSystem()
        {
            string result = OptionBox.ShowBox("Do you really want to shutdown your computer?", "SYSTEM SHUTDOWN");
            if (result.Equals("1"))
            {
                commandPromptHelper.Execute(1,"shutdown /s");
            }
        }

        public void AskToLockDesktop()
        {
            string result = OptionBox.ShowBox("Do you really want to lock your desktop?", "DESKTOP LOCK");
            if (result.Equals("1"))
            {
                commandPromptHelper.Execute(1,"rundll32.exe user32.dll,LockWorkStation");
            }
        }
    }
}
