using FactoryManager.View.DataGrid;
using SpaceM2.Core.BLL.Service;

namespace FactoryManager.Controller.GridControl.View
{
    public class GridViewManager : IGridViewManager
    {
        private readonly IProjectRepository projectRepository;
        private readonly IQuantityRepository quantityRepository;

        public GridViewManager(IProjectRepository _projectRepository, IQuantityRepository _quantityRepository)
        {
            this.projectRepository = _projectRepository;
            this.quantityRepository = _quantityRepository;
        }

        public void ConfigureDataGrid()
        {
            GridView.DataGridView.OptionsView.ColumnAutoWidth = false;
            GridView.DataGridView.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            GridView.DataGridView.BestFitColumns();
        }

        public void FillDataGrid(string viewName)
        {
            switch (viewName)
            {
                case "Projekt":
                    GridView.DataGridControl.BindingContext = new System.Windows.Forms.BindingContext();
                    GridView.DataGridControl.DataSource = projectRepository.GetAll();
                    break;
                case "Mängder":
                    GridView.DataGridControl.BindingContext = new System.Windows.Forms.BindingContext();
                    GridView.DataGridControl.DataSource = quantityRepository.GetAll();
                    break;
            }
        }

        public void FocusLastRow()
        {
            GridView.DataGridView.MoveLast();
        }
    }
}
