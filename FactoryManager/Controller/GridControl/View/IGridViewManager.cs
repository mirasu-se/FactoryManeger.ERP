namespace FactoryManager.Controller.GridControl.View
{
    public interface IGridViewManager
    {
        void ConfigureDataGrid();
        void FillDataGrid(string viewName);
        void FocusLastRow();
    }
}