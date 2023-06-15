using System;

namespace FactoryManager.View.Dialog
{
    public partial class ServiceStopDialog : DevExpress.XtraEditors.XtraForm
    {
        static ServiceStopDialog serviceStopDialog;
        static string Button_id;

        public ServiceStopDialog()
        {
            InitializeComponent();
        }

        public static string ShowBox(string txtMessage, string txtTitle)
        {
            serviceStopDialog = new ServiceStopDialog();
            serviceStopDialog.Title.Text = txtTitle;
            serviceStopDialog.Message.Text = txtMessage;
            serviceStopDialog.ShowDialog();
            return Button_id;
        }

        private void YES_Click(object sender, EventArgs e)
        {
            Button_id = "1";
            serviceStopDialog.Close();
        }

        private void NO_Click(object sender, EventArgs e)
        {
            Button_id = "2";
            serviceStopDialog.Close();
        }
    }
}