using FactoryManager.View;
using FactoryManager.View.Dialog;
using FactoryManager.View.Report;
using FactoryManager.Controller.Report.AccessReport;
using Microsoft.Office.Interop.Access.Dao;
using System;
using System.Drawing;
using System.Windows.Forms;
using Access = Microsoft.Office.Interop.Access;

namespace FactoryManager.Controller.Report.Selection
{
    public class ReportSelectionHelper : IReportSelectionHelper
    {
        private readonly IAccessReportHelper accessReportHelper;

        public ReportSelectionHelper(IAccessReportHelper _accessReportHelper)
        {
            this.accessReportHelper = _accessReportHelper;
        }

        public void GetReports()
        {
            string fileName = ReportSelection.GetAccessFilePath();

            var reportPanel = ReportSelection.ReturnReportPanel();

            if (reportPanel.Controls.Count == 0)
            {
                OpenFileDialog dlg = new OpenFileDialog
                {
                    Filter = "Microsoft Access (*.accdb;*.mdb)|*.accdb;*.mdb"
                };

                if (fileName.Length > 0)
                {
                    dlg.FileName = fileName;
                }

                if (dlg.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }

                ReportSelection.CreateAccessFilePath(dlg.FileName);

                Access.Application oAccess = new Access.Application
                {
                    Visible = false
                };

                oAccess.OpenCurrentDatabase(ReportSelection.GetAccessFilePath(), false, "");

                string sql = "SELECT [Name] FROM MSysObjects WHERE Type = -32764";

                Database db = oAccess.CurrentDb();
                Recordset recordSet = db.OpenRecordset(sql, Type.Missing, Type.Missing, Type.Missing);

                reportPanel.Controls.Clear();

                while (!recordSet.EOF)
                {
                    for (int i = 0; i < recordSet.RecordCount; i++)
                    {
                        int buttonWidth = reportPanel.Width / 7 + 40;
                        var buttonHeight = buttonWidth;

                        var reportButton = new FontAwesome.Sharp.IconButton
                        {
                            Name = "ReportForm" + i.ToString(),
                            Text = recordSet.Fields[0].Value.ToUpper(),
                            FlatStyle = FlatStyle.Flat,
                            BackColor = Color.FromArgb(50, 150, 72),
                            ForeColor = Color.White,
                            IconColor = Color.White,
                            IconChar = FontAwesome.Sharp.IconChar.Print,
                            IconFont = FontAwesome.Sharp.IconFont.Auto,
                            TabIndex = i,
                            Size = new Size(buttonWidth, buttonHeight),
                            ImageAlign = ContentAlignment.MiddleCenter,
                            TextAlign = ContentAlignment.BottomCenter,
                            TextImageRelation = TextImageRelation.ImageAboveText,
                            UseVisualStyleBackColor = false,
                            Cursor = Cursors.Hand
                        };
                        recordSet.MoveNext();
                        reportButton.FlatAppearance.BorderSize = 0;                      
                        reportButton.Click += new EventHandler(ReportButton_Click);
                        reportPanel.Controls.Add(reportButton);
                    }
                }

                recordSet.Close();
                recordSet = null;
                db.Close();
                db = null;
                oAccess.CloseCurrentDatabase();
                oAccess = null;
            }
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            MainView.FormList.SelectedIndex = MainView.FormList.FindStringExact((sender as Button).Name);
            OpenReportForm();
        }

        public void OpenReportForm()
        {
            if (MainView.FormList.SelectedItem is AppForm appForm)
            {
                Type objectType = Type.GetType(appForm.Id);
                if (objectType != null)
                {
                    if (Activator.CreateInstance(objectType, accessReportHelper) is Form form)
                    {
                        form.ShowDialog();
                    }
                }
            }
            else
            {
                NotificationBox.ShowBox("Rapporteringsformuläret är inte tillgängligt i den nuvarande församlingen! \n\n Kontakta programutvecklare om problemet kvarstår!", "INITIALIZATION ERROR");
            }
        }
    }
}
