using System.Windows.Forms;

namespace FactoryManager.Controller.GridControl.FormValidation
{
    public interface IFieldValidationHelper
    {
        bool HasValidationErrors(Control.ControlCollection controls);
    }
}