using DevExpress.XtraGrid.Views.Grid;

namespace FactoryManager.Controller.GridControl.GridForm
{
    public interface IGridFormManager
    {
        void ReturnEditForm(string viewName, GridView DataGridView);
        void ReturnNewForm(string viewName, GridView DataGridView);
    }
}