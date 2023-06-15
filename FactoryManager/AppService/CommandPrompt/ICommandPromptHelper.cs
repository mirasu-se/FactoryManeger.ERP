namespace FactoryManager.AppService.CommandPrompt
{
    public interface ICommandPromptHelper
    {
        bool CheckIfProcessIsAlreadyRunning(string process);
        void KillProcess(string process);
        void Execute(int proccesType, string command);
    }
}