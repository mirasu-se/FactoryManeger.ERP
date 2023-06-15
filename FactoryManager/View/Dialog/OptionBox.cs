using System;

namespace FactoryManager.View.Dialog
{
    public partial class OptionBox : DevExpress.XtraEditors.XtraForm
    {
        static OptionBox optionBox;
        static string Button_id;

        public OptionBox()
        {
            InitializeComponent();
        }

        public static string ShowBox(string txtMessage, string txtTitle)
        {
            optionBox = new OptionBox();
            optionBox.Title.Text = txtTitle;
            optionBox.Message.Text = txtMessage;
            optionBox.ShowDialog();
            return Button_id;
        }

        private void YES_Click(object sender, EventArgs e)
        {
            Button_id = "1";
            optionBox.Close();
        }

        private void NO_Click(object sender, EventArgs e)
        {
            Button_id = "2";
            optionBox.Close();
        }
    }
}