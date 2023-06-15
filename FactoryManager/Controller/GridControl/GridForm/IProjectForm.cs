namespace FactoryManager.Controller.GridControl.GridForm
{
    public interface IProjectForm
    {
        void ReturnEditForm(DevExpress.XtraGrid.Views.Grid.GridView DataGridView);
        void ReturnNewForm(DevExpress.XtraGrid.Views.Grid.GridView DataGridView);
    }
}