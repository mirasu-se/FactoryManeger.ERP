using DevExpress.XtraWaitForm;
using System;

namespace FactoryManager.View.Dialog
{
    public partial class LoadingScreen : WaitForm
    {
        public LoadingScreen()
        {
            InitializeComponent();
        }

        public override void SetCaption(string caption)
        {
            base.SetCaption(caption);
            this.progressPanel1.Caption = caption;
        }

        public override void SetDescription(string description)
        {
            base.SetDescription(description);
            this.progressPanel1.Description = description;
        }

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        public enum WaitFormCommand
        {

        }
    }
}