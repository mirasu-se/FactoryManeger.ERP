using FactoryManager.View;
using FactoryManager.Controller.GridControl.GridForm;
using FactoryManager.Controller.GridControl.View;
using System;
using System.Windows.Forms;

namespace FactoryManager.Controller.GridControl.Selection
{
    public class GridSelectionHelper : IGridSelectionHelper
    {
        private readonly IGridFormManager gridFormManager;
        private readonly IGridViewManager gridViewManager;

        public GridSelectionHelper(IGridFormManager _gridFormManager, IGridViewManager _gridTableManager)
        {
            this.gridFormManager = _gridFormManager;
            this.gridViewManager = _gridTableManager;
        }

        public void DisplayGrid(string buttonName)
        {
            MainView.SectionIndicator.Text = buttonName;
            MainView.FormList.SelectedIndex = MainView.FormList.FindStringExact("GridView");

            if (MainView.FormList.SelectedItem is AppForm appForm)
            {
                Type objectType = Type.GetType(appForm.Id);
                if (objectType != null)
                {
                    if (Activator.CreateInstance(objectType, gridFormManager, gridViewManager) is System.Windows.Forms.Form form)
                    {
                        form.TopLevel = false;
                        form.Dock = DockStyle.Fill;
                        MainView.DockingPanel.Controls.Clear();
                        MainView.DockingPanel.Controls.Add(form);
                        form.Show();
                    }
                }
            }
        }
    }
}
