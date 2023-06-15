
using System.Windows.Forms;

namespace FactoryManager.View.GridControl.GridForm
{
    partial class ProjectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectForm));
            this.errorProviderApp = new System.Windows.Forms.ErrorProvider(this.components);
            this.FormPanel = new System.Windows.Forms.Panel();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.dataLayoutControl2 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.ProjectIdTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ProjectNumberTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ProjectNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CustomerNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.StatusKeyComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.MunicipalityNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.DescriptionTextEdit = new DevExpress.XtraEditors.MemoEdit();
            this.ProjectLayoutControl = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Header = new System.Windows.Forms.Panel();
            this.FormTitle = new System.Windows.Forms.Label();
            this.CloseForm = new FontAwesome.Sharp.IconButton();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.Footer = new System.Windows.Forms.FlowLayoutPanel();
            this.InsertBtn = new FontAwesome.Sharp.IconButton();
            this.UpdateBtn = new FontAwesome.Sharp.IconButton();
            this.DeleteBtn = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).BeginInit();
            this.FormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl2)).BeginInit();
            this.dataLayoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectIdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectNumberTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusKeyComboBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MunicipalityNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectLayoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.Header.SuspendLayout();
            this.Footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProviderApp
            // 
            this.errorProviderApp.ContainerControl = this;
            // 
            // FormPanel
            // 
            this.FormPanel.AutoScroll = true;
            this.FormPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.FormPanel.Controls.Add(this.bunifuSeparator2);
            this.FormPanel.Controls.Add(this.dataLayoutControl2);
            this.FormPanel.Controls.Add(this.Header);
            this.FormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormPanel.Location = new System.Drawing.Point(0, 0);
            this.FormPanel.Margin = new System.Windows.Forms.Padding(2);
            this.FormPanel.Name = "FormPanel";
            this.FormPanel.Size = new System.Drawing.Size(696, 377);
            this.FormPanel.TabIndex = 127;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(170)))), ((int)(((byte)(72)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(0, 372);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(696, 5);
            this.bunifuSeparator2.TabIndex = 132;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // dataLayoutControl2
            // 
            this.dataLayoutControl2.Controls.Add(this.ProjectIdTextEdit);
            this.dataLayoutControl2.Controls.Add(this.ProjectNumberTextEdit);
            this.dataLayoutControl2.Controls.Add(this.ProjectNameTextEdit);
            this.dataLayoutControl2.Controls.Add(this.CustomerNameTextEdit);
            this.dataLayoutControl2.Controls.Add(this.StatusKeyComboBox);
            this.dataLayoutControl2.Controls.Add(this.MunicipalityNameTextEdit);
            this.dataLayoutControl2.Controls.Add(this.DescriptionTextEdit);
            this.dataLayoutControl2.Location = new System.Drawing.Point(12, 45);
            this.dataLayoutControl2.Name = "dataLayoutControl2";
            this.dataLayoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(738, 46, 650, 400);
            this.dataLayoutControl2.Root = this.ProjectLayoutControl;
            this.dataLayoutControl2.Size = new System.Drawing.Size(679, 293);
            this.dataLayoutControl2.TabIndex = 127;
            this.dataLayoutControl2.Text = "dataLayoutControl2";
            // 
            // ProjectIdTextEdit
            // 
            this.ProjectIdTextEdit.Location = new System.Drawing.Point(22, 60);
            this.ProjectIdTextEdit.Name = "ProjectIdTextEdit";
            this.ProjectIdTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ProjectIdTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectIdTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.ProjectIdTextEdit.Properties.Appearance.Options.UseBackColor = true;
            this.ProjectIdTextEdit.Properties.Appearance.Options.UseFont = true;
            this.ProjectIdTextEdit.Properties.Appearance.Options.UseForeColor = true;
            this.ProjectIdTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.ProjectIdTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.ProjectIdTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ProjectIdTextEdit.Properties.Mask.EditMask = "N0";
            this.ProjectIdTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.ProjectIdTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.ProjectIdTextEdit.Properties.ReadOnly = true;
            this.ProjectIdTextEdit.Size = new System.Drawing.Size(180, 24);
            this.ProjectIdTextEdit.StyleController = this.dataLayoutControl2;
            this.ProjectIdTextEdit.TabIndex = 1;
            this.ProjectIdTextEdit.TabStop = false;
            // 
            // ProjectNumberTextEdit
            // 
            this.ProjectNumberTextEdit.Location = new System.Drawing.Point(206, 60);
            this.ProjectNumberTextEdit.Name = "ProjectNumberTextEdit";
            this.ProjectNumberTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ProjectNumberTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectNumberTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.ProjectNumberTextEdit.Properties.Appearance.Options.UseBackColor = true;
            this.ProjectNumberTextEdit.Properties.Appearance.Options.UseFont = true;
            this.ProjectNumberTextEdit.Properties.Appearance.Options.UseForeColor = true;
            this.ProjectNumberTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.ProjectNumberTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.ProjectNumberTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ProjectNumberTextEdit.Properties.ReadOnly = true;
            this.ProjectNumberTextEdit.Size = new System.Drawing.Size(223, 24);
            this.ProjectNumberTextEdit.StyleController = this.dataLayoutControl2;
            this.ProjectNumberTextEdit.TabIndex = 2;
            this.ProjectNumberTextEdit.TabStop = false;
            // 
            // ProjectNameTextEdit
            // 
            this.ProjectNameTextEdit.Location = new System.Drawing.Point(22, 108);
            this.ProjectNameTextEdit.Name = "ProjectNameTextEdit";
            this.ProjectNameTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ProjectNameTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectNameTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.ProjectNameTextEdit.Properties.Appearance.Options.UseBackColor = true;
            this.ProjectNameTextEdit.Properties.Appearance.Options.UseFont = true;
            this.ProjectNameTextEdit.Properties.Appearance.Options.UseForeColor = true;
            this.ProjectNameTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ProjectNameTextEdit.Size = new System.Drawing.Size(635, 24);
            this.ProjectNameTextEdit.StyleController = this.dataLayoutControl2;
            this.ProjectNameTextEdit.TabIndex = 4;
            this.ProjectNameTextEdit.Validating += new System.ComponentModel.CancelEventHandler(this.TboxProjectName_Validating);
            // 
            // CustomerNameTextEdit
            // 
            this.CustomerNameTextEdit.Location = new System.Drawing.Point(22, 154);
            this.CustomerNameTextEdit.Name = "CustomerNameTextEdit";
            this.CustomerNameTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.CustomerNameTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.CustomerNameTextEdit.Properties.Appearance.Options.UseBackColor = true;
            this.CustomerNameTextEdit.Properties.Appearance.Options.UseFont = true;
            this.CustomerNameTextEdit.Properties.Appearance.Options.UseForeColor = true;
            this.CustomerNameTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.CustomerNameTextEdit.Size = new System.Drawing.Size(635, 24);
            this.CustomerNameTextEdit.StyleController = this.dataLayoutControl2;
            this.CustomerNameTextEdit.TabIndex = 6;
            this.CustomerNameTextEdit.Validating += new System.ComponentModel.CancelEventHandler(this.TboxCustomer_Validating);
            // 
            // StatusKeyComboBox
            // 
            this.StatusKeyComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StatusKeyComboBox.Location = new System.Drawing.Point(433, 60);
            this.StatusKeyComboBox.Name = "StatusKeyComboBox";
            this.StatusKeyComboBox.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.StatusKeyComboBox.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusKeyComboBox.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.StatusKeyComboBox.Properties.Appearance.Options.UseBackColor = true;
            this.StatusKeyComboBox.Properties.Appearance.Options.UseFont = true;
            this.StatusKeyComboBox.Properties.Appearance.Options.UseForeColor = true;
            this.StatusKeyComboBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.StatusKeyComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.StatusKeyComboBox.Properties.Items.AddRange(new object[] {
            "Pågående",
            "Avslutat"});
            this.StatusKeyComboBox.Size = new System.Drawing.Size(224, 26);
            this.StatusKeyComboBox.StyleController = this.dataLayoutControl2;
            this.StatusKeyComboBox.TabIndex = 3;
            this.StatusKeyComboBox.TabStop = false;
            this.StatusKeyComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.CboProjectStatus_Validating);
            // 
            // MunicipalityNameTextEdit
            // 
            this.MunicipalityNameTextEdit.Location = new System.Drawing.Point(22, 200);
            this.MunicipalityNameTextEdit.Name = "MunicipalityNameTextEdit";
            this.MunicipalityNameTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.MunicipalityNameTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MunicipalityNameTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.MunicipalityNameTextEdit.Properties.Appearance.Options.UseBackColor = true;
            this.MunicipalityNameTextEdit.Properties.Appearance.Options.UseFont = true;
            this.MunicipalityNameTextEdit.Properties.Appearance.Options.UseForeColor = true;
            this.MunicipalityNameTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.MunicipalityNameTextEdit.Size = new System.Drawing.Size(635, 24);
            this.MunicipalityNameTextEdit.StyleController = this.dataLayoutControl2;
            this.MunicipalityNameTextEdit.TabIndex = 7;
            this.MunicipalityNameTextEdit.Validating += new System.ComponentModel.CancelEventHandler(this.TboxMunicipality_Validating);
            // 
            // DescriptionTextEdit
            // 
            this.DescriptionTextEdit.Location = new System.Drawing.Point(22, 246);
            this.DescriptionTextEdit.Name = "DescriptionTextEdit";
            this.DescriptionTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.DescriptionTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.DescriptionTextEdit.Properties.Appearance.Options.UseBackColor = true;
            this.DescriptionTextEdit.Properties.Appearance.Options.UseFont = true;
            this.DescriptionTextEdit.Properties.Appearance.Options.UseForeColor = true;
            this.DescriptionTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.DescriptionTextEdit.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DescriptionTextEdit.Size = new System.Drawing.Size(635, 25);
            this.DescriptionTextEdit.StyleController = this.dataLayoutControl2;
            this.DescriptionTextEdit.TabIndex = 5;
            // 
            // ProjectLayoutControl
            // 
            this.ProjectLayoutControl.AppearanceItemCaption.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectLayoutControl.AppearanceItemCaption.ForeColor = System.Drawing.Color.White;
            this.ProjectLayoutControl.AppearanceItemCaption.Options.UseFont = true;
            this.ProjectLayoutControl.AppearanceItemCaption.Options.UseForeColor = true;
            this.ProjectLayoutControl.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.ProjectLayoutControl.GroupBordersVisible = false;
            this.ProjectLayoutControl.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup4});
            this.ProjectLayoutControl.Name = "Root";
            this.ProjectLayoutControl.Padding = new DevExpress.XtraLayout.Utils.Padding(20, 20, 40, 20);
            this.ProjectLayoutControl.Size = new System.Drawing.Size(679, 293);
            this.ProjectLayoutControl.TextVisible = false;
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.AllowDrawBackground = false;
            this.layoutControlGroup4.GroupBordersVisible = false;
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem5,
            this.layoutControlItem2,
            this.layoutControlItem1,
            this.layoutControlItem4});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup4.Name = "autoGeneratedGroup0";
            this.layoutControlGroup4.Size = new System.Drawing.Size(639, 233);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.ProjectNameTextEdit;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "ItemForProjektnamn";
            this.layoutControlItem3.Size = new System.Drawing.Size(639, 46);
            this.layoutControlItem3.Text = "Projektnamn";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(84, 15);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.CustomerNameTextEdit;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 94);
            this.layoutControlItem6.Name = "ItemForKundnamn";
            this.layoutControlItem6.Size = new System.Drawing.Size(639, 46);
            this.layoutControlItem6.Text = "Kundnamn";
            this.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(84, 15);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.MunicipalityNameTextEdit;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 140);
            this.layoutControlItem7.Name = "ItemForKommun";
            this.layoutControlItem7.Size = new System.Drawing.Size(639, 46);
            this.layoutControlItem7.Text = "Kommun";
            this.layoutControlItem7.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(84, 15);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.DescriptionTextEdit;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 186);
            this.layoutControlItem5.Name = "ItemForBeskrivning";
            this.layoutControlItem5.Size = new System.Drawing.Size(639, 47);
            this.layoutControlItem5.Text = "Beskrivning";
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(84, 15);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.ProjectNumberTextEdit;
            this.layoutControlItem2.Location = new System.Drawing.Point(184, 0);
            this.layoutControlItem2.Name = "ItemForProjektnummer";
            this.layoutControlItem2.Size = new System.Drawing.Size(227, 48);
            this.layoutControlItem2.Text = "Projektnummer";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(84, 15);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.layoutControlItem1.Control = this.ProjectIdTextEdit;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "ItemForID";
            this.layoutControlItem1.Size = new System.Drawing.Size(184, 48);
            this.layoutControlItem1.Text = "ProjektID";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(84, 15);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.StatusKeyComboBox;
            this.layoutControlItem4.Location = new System.Drawing.Point(411, 0);
            this.layoutControlItem4.Name = "ItemForProjektstatus";
            this.layoutControlItem4.Size = new System.Drawing.Size(228, 48);
            this.layoutControlItem4.Text = "Projektstatus";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(84, 15);
            // 
            // Header
            // 
            this.Header.Controls.Add(this.FormTitle);
            this.Header.Controls.Add(this.CloseForm);
            this.Header.Controls.Add(this.bunifuSeparator1);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(696, 39);
            this.Header.TabIndex = 129;
            // 
            // FormTitle
            // 
            this.FormTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.FormTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(170)))), ((int)(((byte)(72)))));
            this.FormTitle.Location = new System.Drawing.Point(0, 5);
            this.FormTitle.Name = "FormTitle";
            this.FormTitle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.FormTitle.Size = new System.Drawing.Size(651, 34);
            this.FormTitle.TabIndex = 133;
            this.FormTitle.Text = "Space M2 For smart living AB";
            this.FormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CloseForm
            // 
            this.CloseForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseForm.FlatAppearance.BorderSize = 0;
            this.CloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseForm.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseForm.ForeColor = System.Drawing.Color.White;
            this.CloseForm.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.CloseForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(170)))), ((int)(((byte)(72)))));
            this.CloseForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CloseForm.IconSize = 30;
            this.CloseForm.Location = new System.Drawing.Point(651, 5);
            this.CloseForm.Name = "CloseForm";
            this.CloseForm.Size = new System.Drawing.Size(45, 34);
            this.CloseForm.TabIndex = 132;
            this.CloseForm.UseVisualStyleBackColor = true;
            this.CloseForm.Click += new System.EventHandler(this.CloseForm_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(170)))), ((int)(((byte)(72)))));
            this.bunifuSeparator1.LineThickness = 3;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 0);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(696, 5);
            this.bunifuSeparator1.TabIndex = 131;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // Footer
            // 
            this.Footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Footer.Controls.Add(this.InsertBtn);
            this.Footer.Controls.Add(this.UpdateBtn);
            this.Footer.Controls.Add(this.DeleteBtn);
            this.Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Footer.Location = new System.Drawing.Point(0, 377);
            this.Footer.Margin = new System.Windows.Forms.Padding(2);
            this.Footer.Name = "Footer";
            this.Footer.Padding = new System.Windows.Forms.Padding(32, 10, 10, 10);
            this.Footer.Size = new System.Drawing.Size(696, 68);
            this.Footer.TabIndex = 125;
            // 
            // InsertBtn
            // 
            this.InsertBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(170)))), ((int)(((byte)(72)))));
            this.InsertBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InsertBtn.FlatAppearance.BorderSize = 0;
            this.InsertBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(170)))), ((int)(((byte)(72)))));
            this.InsertBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertBtn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.InsertBtn.ForeColor = System.Drawing.Color.White;
            this.InsertBtn.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.InsertBtn.IconColor = System.Drawing.Color.White;
            this.InsertBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.InsertBtn.IconSize = 25;
            this.InsertBtn.Location = new System.Drawing.Point(34, 12);
            this.InsertBtn.Margin = new System.Windows.Forms.Padding(2, 2, 8, 2);
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(144, 42);
            this.InsertBtn.TabIndex = 10;
            this.InsertBtn.TabStop = false;
            this.InsertBtn.Text = "SPARA";
            this.InsertBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.InsertBtn.UseVisualStyleBackColor = false;
            this.InsertBtn.Visible = false;
            this.InsertBtn.Click += new System.EventHandler(this.InsertBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.Goldenrod;
            this.UpdateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateBtn.FlatAppearance.BorderSize = 0;
            this.UpdateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UpdateBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.UpdateBtn.IconColor = System.Drawing.Color.White;
            this.UpdateBtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.UpdateBtn.IconSize = 25;
            this.UpdateBtn.Location = new System.Drawing.Point(188, 12);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(2, 2, 8, 2);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(144, 42);
            this.UpdateBtn.TabIndex = 11;
            this.UpdateBtn.TabStop = false;
            this.UpdateBtn.Text = "UPPDATERA";
            this.UpdateBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Visible = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Brown;
            this.DeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.DeleteBtn.FlatAppearance.BorderSize = 0;
            this.DeleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.DeleteBtn.IconColor = System.Drawing.Color.White;
            this.DeleteBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DeleteBtn.IconSize = 23;
            this.DeleteBtn.Location = new System.Drawing.Point(343, 12);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(144, 42);
            this.DeleteBtn.TabIndex = 24;
            this.DeleteBtn.Text = "REDIGERA";
            this.DeleteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ProjectForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(696, 445);
            this.Controls.Add(this.FormPanel);
            this.Controls.Add(this.Footer);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("ProjectForm.IconOptions.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projekt";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).EndInit();
            this.FormPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl2)).EndInit();
            this.dataLayoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProjectIdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectNumberTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusKeyComboBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MunicipalityNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectLayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.Header.ResumeLayout(false);
            this.Footer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProviderApp;
        private Panel FormPanel;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl2;
        private DevExpress.XtraEditors.TextEdit ProjectIdTextEdit;
        private DevExpress.XtraEditors.TextEdit ProjectNumberTextEdit;
        private DevExpress.XtraEditors.TextEdit ProjectNameTextEdit;
        private DevExpress.XtraEditors.TextEdit CustomerNameTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup ProjectLayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.ComboBoxEdit StatusKeyComboBox;
        private Panel Header;
        private FlowLayoutPanel Footer;
        private FontAwesome.Sharp.IconButton InsertBtn;
        private FontAwesome.Sharp.IconButton UpdateBtn;
        private DevExpress.XtraEditors.TextEdit MunicipalityNameTextEdit;
        private DevExpress.XtraEditors.MemoEdit DescriptionTextEdit;
        private Label FormTitle;
        private FontAwesome.Sharp.IconButton CloseForm;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private FontAwesome.Sharp.IconButton DeleteBtn;
    }
}