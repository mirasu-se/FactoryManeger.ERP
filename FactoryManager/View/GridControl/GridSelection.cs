using System;
using System.Windows.Forms;
using FactoryManager.AppService.ApplicationLogger;
using FactoryManager.Controller.GridControl.Selection;

namespace FactoryManager.View.DataGrid
{
    public partial class GridSelection : Form
    {
        private readonly ILogHelper logHelper;
        private readonly log4net.ILog loggerLog;
        private readonly IGridSelectionHelper gridSelectionHelper;

        public GridSelection(
            ILogHelper _logHelper,
            IGridSelectionHelper _gridSelectionHelper)
        {
            this.logHelper = _logHelper;
            loggerLog = logHelper.GetLogger();
            this.gridSelectionHelper = _gridSelectionHelper;

            InitializeComponent();
        }

        private void Activity_Click(object sender, EventArgs e)
        {
            gridSelectionHelper.DisplayGrid((sender as Button).Text);
            loggerLog.Info("User has opened " + (sender as Button).Text + " section");
        }

        private void User_Click(object sender, EventArgs e)
        {
            gridSelectionHelper.DisplayGrid((sender as Button).Text);
            loggerLog.Info("User has opened " + (sender as Button).Text + " section");
        }

        private void UserRole_Click(object sender, EventArgs e)
        {
            gridSelectionHelper.DisplayGrid((sender as Button).Text);
            loggerLog.Info("User has opened " + (sender as Button).Text + " section");
        }

        private void Component_Click(object sender, EventArgs e)
        {
            gridSelectionHelper.DisplayGrid((sender as Button).Text);
            loggerLog.Info("User has opened " + (sender as Button).Text + " section");
        }

        private void Factory_Click(object sender, EventArgs e)
        {
            gridSelectionHelper.DisplayGrid((sender as Button).Text);
            loggerLog.Info("User has opened " + (sender as Button).Text + " section");
        }

        private void Order_Click(object sender, EventArgs e)
        {
            gridSelectionHelper.DisplayGrid((sender as Button).Text);
            loggerLog.Info("User has opened " + (sender as Button).Text + " section");
        }

        private void Construction_Click(object sender, EventArgs e)
        {
            gridSelectionHelper.DisplayGrid((sender as Button).Text);
            loggerLog.Info("User has opened " + (sender as Button).Text + " section");
        }

        private void Employee_Click(object sender, EventArgs e)
        {
            gridSelectionHelper.DisplayGrid((sender as Button).Text);
            loggerLog.Info("User has opened " + (sender as Button).Text + " section");
        }

        private void Account_Click(object sender, EventArgs e)
        {
            gridSelectionHelper.DisplayGrid((sender as Button).Text);
            loggerLog.Info("User has opened " + (sender as Button).Text + " section");
        }

        private void SupplierAddress_Click(object sender, EventArgs e)
        {
            gridSelectionHelper.DisplayGrid((sender as Button).Text);
            loggerLog.Info("User has opened " + (sender as Button).Text + " section");
        }

        private void Supplier_Click(object sender, EventArgs e)
        {
            gridSelectionHelper.DisplayGrid((sender as Button).Text);
            loggerLog.Info("User has opened " + (sender as Button).Text + " section");
        }

        private void ApartmentType_Click(object sender, EventArgs e)
        {
            gridSelectionHelper.DisplayGrid((sender as Button).Text);
            loggerLog.Info("User has opened " + (sender as Button).Text + " section");
        }

        private void Module_Click(object sender, EventArgs e)
        {
            gridSelectionHelper.DisplayGrid((sender as Button).Text);
            loggerLog.Info("User has opened " + (sender as Button).Text + " section");
        }

        private void ModuleType_Click(object sender, EventArgs e)
        {
            gridSelectionHelper.DisplayGrid((sender as Button).Text);
            loggerLog.Info("User has opened " + (sender as Button).Text + " section");
        }

        private void Pricelis_Click(object sender, EventArgs e)
        {
            gridSelectionHelper.DisplayGrid((sender as Button).Text);
            loggerLog.Info("User has opened " + (sender as Button).Text + " section");
        }

        private void Project_Click(object sender, EventArgs e)
        {
            gridSelectionHelper.DisplayGrid((sender as Button).Text);
            loggerLog.Info("User has opened " + (sender as Button).Text + " section");
        }

        private void Quantity_Click(object sender, EventArgs e)
        {
            gridSelectionHelper.DisplayGrid((sender as Button).Text);
            loggerLog.Info("User has opened " + (sender as Button).Text + " section");
        }

        private void Station_Click(object sender, EventArgs e)
        {
            gridSelectionHelper.DisplayGrid((sender as Button).Text);
            loggerLog.Info("User has opened " + (sender as Button).Text + " section");
        }

        private void Selfcontrol_Click(object sender, EventArgs e)
        {
            gridSelectionHelper.DisplayGrid((sender as Button).Text);
            loggerLog.Info("User has opened " + (sender as Button).Text + " section");
        }

        private void ModuletypeWalls_Click(object sender, EventArgs e)
        {
            gridSelectionHelper.DisplayGrid((sender as Button).Text);
            loggerLog.Info("User has opened " + (sender as Button).Text + " section");
        }

        private void Walls_Click(object sender, EventArgs e)
        {
            gridSelectionHelper.DisplayGrid((sender as Button).Text);
            loggerLog.Info("User has opened " + (sender as Button).Text + " section");
        }

        private void GridView_Click(object sender, EventArgs e)
        {
            gridSelectionHelper.DisplayGrid((sender as Button).Text);
            loggerLog.Info("User has opened " + (sender as Button).Text + " section");
        }
    }
}
