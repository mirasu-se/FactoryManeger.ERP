using DevExpress.XtraGrid.Views.Grid;

namespace FactoryManager.Controller.GridControl.GridForm
{
    public class GridFormManager : IGridFormManager
    {
        private readonly IProjectForm projectForm;

        public GridFormManager(IProjectForm _projectForm)
        {
            projectForm = _projectForm;
        }

        public void ReturnNewForm(string viewName, GridView DataGridView)
        {
            switch (viewName)
            {
                case "Projekt":
                    projectForm.ReturnNewForm(DataGridView);
                    break;
                case "Mängder":
                    //QuantityForm.ReturnNewForm(GridView.DataGridView);
                    break;
            }
        }
        public void ReturnEditForm(string viewName, GridView DataGridView)
        {
            switch (viewName)
            {
                case "Projekt":
                    projectForm.ReturnEditForm(DataGridView);
                    break;
                case "Mängder":
                    //QuantityForm.ReturnEditForm(DataGridView);
                    break;
            }
        }
    }
}
