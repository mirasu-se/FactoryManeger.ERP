using System;
using System.Windows.Forms;
using FactoryManager.Controller.GridControl.View;
using FactoryManager.Controller.GridControl.GridForm;

namespace FactoryManager.View.DataGrid
{
    public partial class GridView : Form
    {
        private readonly IGridFormManager gridFormManager;
        private readonly IGridViewManager gridViewManager;

        public static DevExpress.XtraGrid.GridControl DataGridControl;
        public static DevExpress.XtraGrid.Views.Grid.GridView DataGridView;

        public GridView(IGridFormManager _gridFormManager, IGridViewManager _gridViewManager)
        {
            this.gridFormManager = _gridFormManager;
            this.gridViewManager = _gridViewManager;

            InitializeComponent();
            DataGridControl = gridControl1;
            DataGridView = gridView1;
        }

        private void GridView_Load(object sender, EventArgs e)
        {
            gridViewManager.ConfigureDataGrid();
            gridViewManager.FillDataGrid(MainView.SectionIndicator.Text);
            gridViewManager.FocusLastRow();
        }

        private void AddRow_Click(object sender, EventArgs e)
        {
            gridFormManager.ReturnNewForm(MainView.SectionIndicator.Text, DataGridView);
        }

        private void EditRow_Click(object sender, EventArgs e)
        {
            gridFormManager.ReturnEditForm(MainView.SectionIndicator.Text, DataGridView);
        }
    }
}
