using System;
using SpaceM2.Core.BLL.Model;
using SpaceM2.Core.BLL.Service;
using FactoryManager.View.Dialog;
using FactoryManager.Controller.GridControl.GridForm;
using FactoryManager.Controller.GridControl.FormValidation;
using FactoryManager.Controller.GridControl.View;

namespace FactoryManager.View.GridControl.GridForm
{
    public partial class ProjectForm : DevExpress.XtraEditors.XtraForm, IProjectForm
    {
        private readonly IFieldValidationHelper fieldValidationHelper;
        private readonly IAutoincrementService autoincrementService;
        private readonly IProjectRepository projectRepository;
        private readonly IGridViewManager gridViewManager;


        static ProjectForm projectForm;

        public ProjectForm(
            IFieldValidationHelper _fieldValidationHelper,
            IAutoincrementService _autoincrementService,
            IProjectRepository _projectRepository,
            IGridViewManager _gridViewManager)
        {
            this.fieldValidationHelper = _fieldValidationHelper;
            this.autoincrementService = _autoincrementService;
            this.projectRepository = _projectRepository;
            this.gridViewManager = _gridViewManager;

            InitializeComponent();
        }

        public void ReturnNewForm(DevExpress.XtraGrid.Views.Grid.GridView DataGridView)
        {
            projectForm = new ProjectForm(fieldValidationHelper, autoincrementService, projectRepository, gridViewManager);

            var autoincrementModel = autoincrementService.GetAutoincrementNumber("Project_Id", "ProjectNumber", "Project");
            projectForm.ProjectIdTextEdit.Text = autoincrementModel.Id.ToString();
            projectForm.ProjectNumberTextEdit.Text = autoincrementModel.Number.ToString();
            projectForm.ProjectNameTextEdit.ResetText();
            projectForm.DescriptionTextEdit.ResetText();
            projectForm.StatusKeyComboBox.SelectedIndex = -1;
            projectForm.MunicipalityNameTextEdit.ResetText();
            projectForm.CustomerNameTextEdit.ResetText();

            projectForm.InsertBtn.Show();

            projectForm.ShowDialog();
        }

        public void ReturnEditForm(DevExpress.XtraGrid.Views.Grid.GridView DataGridView)
        {
            try
            {
                projectForm = new ProjectForm(fieldValidationHelper, autoincrementService, projectRepository, gridViewManager);

                var project = projectRepository.GetById(25);

                projectForm.ProjectIdTextEdit.Text = project.ProjectId.ToString();
                projectForm.ProjectNumberTextEdit.Text = project.ProjectNumber.ToString();
                projectForm.ProjectNameTextEdit.Text = project.ProjectName.ToString();
                projectForm.DescriptionTextEdit.Text = project.Description.ToString();
                projectForm.StatusKeyComboBox.SelectedItem = project.StatusKey.ToString();
                projectForm.CustomerNameTextEdit.Text = project.CustomerName.ToString();
                projectForm.MunicipalityNameTextEdit.Text = project.MunicipalityName.ToString();

                projectForm.UpdateBtn.Show();
                projectForm.DeleteBtn.Show();

                projectForm.ShowDialog();
            }
            catch(Exception ex)
            {
                System.Windows.MessageBox.Show(ex.ToString());
            }
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            if (fieldValidationHelper.HasValidationErrors(Controls))
                return;

            ProjectModel project = new ProjectModel
            {
                ProjectNumber = ProjectNumberTextEdit.Text,
                ProjectName = ProjectNameTextEdit.Text,
                StatusKey = StatusKeyComboBox.Text,
                Description = DescriptionTextEdit.Text,
                CustomerName = CustomerNameTextEdit.Text,
                MunicipalityName = MunicipalityNameTextEdit.Text
            };

            projectRepository.Add(project);

            gridViewManager.FillDataGrid(MainView.SectionIndicator.Text);

            Close();
        }


        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (fieldValidationHelper.HasValidationErrors(Controls))
                return;

            ProjectModel project = new ProjectModel
            {
                ProjectNumber = ProjectNumberTextEdit.Text,
                ProjectName = ProjectNameTextEdit.Text,
                StatusKey = StatusKeyComboBox.Text,
                Description = DescriptionTextEdit.Text,
                CustomerName = CustomerNameTextEdit.Text,
                MunicipalityName = MunicipalityNameTextEdit.Text
            };

            projectRepository.Modify(project, project.ProjectId);

            gridViewManager.FillDataGrid(MainView.SectionIndicator.Text);

            Close();
        }

        private void CboProjectStatus_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (StatusKeyComboBox.Text.Trim() == string.Empty)
            {
                errorProviderApp.SetError(StatusKeyComboBox, "Du måste välja projektstatus!");
                e.Cancel = true;
            }
            else
                errorProviderApp.SetError(StatusKeyComboBox, "");
        }

        private void TboxProjectName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (ProjectNameTextEdit.Text.Trim() == string.Empty)
            {
                errorProviderApp.SetError(ProjectNameTextEdit, "Projektnamn krävs!");
                e.Cancel = true;
            }
            else
                errorProviderApp.SetError(ProjectNameTextEdit, "");
        }

        private void TboxCustomer_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (CustomerNameTextEdit.Text.Trim() == string.Empty)
            {
                errorProviderApp.SetError(CustomerNameTextEdit, "Kund krävs!");
                e.Cancel = true;
            }
            else
                errorProviderApp.SetError(CustomerNameTextEdit, "");
        }

        private void TboxMunicipality_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MunicipalityNameTextEdit.Text.Trim() == string.Empty)
            {
                errorProviderApp.SetError(MunicipalityNameTextEdit, "Kommun krävs!");
                e.Cancel = true;
            }
            else
                errorProviderApp.SetError(MunicipalityNameTextEdit, "");
        }

        private void CloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            var result = OptionBox.ShowBox(
                "Är du säker på att du vill ta bort projekt " +
                ProjectNameTextEdit.Text +
                " med nummer " +
                ProjectNumberTextEdit.Text +
                "?",
                "TA BORT PROJEKT");

            if (result.Equals("1"))
            {
                projectRepository.Remove(Convert.ToInt32(projectForm.ProjectIdTextEdit.Text));
                gridViewManager.FillDataGrid(MainView.SectionIndicator.Text);
            }
        }
    }
}
