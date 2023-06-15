using System;
using System.Windows.Forms;

namespace FactoryManager.View.Dialog
{
    public partial class NotificationBox : DevExpress.XtraEditors.XtraForm
    {
        static NotificationBox notificationBox;
        static string Button_id;

        public NotificationBox()
        {
            InitializeComponent();
        }

        public static string ShowBox(string txtMessage, string txtTitle)
        {
            notificationBox = new NotificationBox
            {
                TopLevel = true,
            };
            notificationBox.Title.Text = txtTitle;
            notificationBox.Message.Text = txtMessage;
            notificationBox.ShowDialog();
            return Button_id;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            Button_id = "1";
            notificationBox.Close();
        }
    }
}