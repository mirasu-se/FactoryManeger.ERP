namespace FactoryManager.View.Dialog
{
    partial class NotificationBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotificationBox));
            this.Header = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.MessageBoxIcon = new FontAwesome.Sharp.IconButton();
            this.Footer = new System.Windows.Forms.Panel();
            this.OK = new FontAwesome.Sharp.IconButton();
            this.Separator = new Bunifu.Framework.UI.BunifuSeparator();
            this.Message = new System.Windows.Forms.Label();
            this.Header.SuspendLayout();
            this.Footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.White;
            this.Header.Controls.Add(this.Title);
            this.Header.Controls.Add(this.MessageBoxIcon);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(500, 45);
            this.Header.TabIndex = 126;
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Title.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Margin = new System.Windows.Forms.Padding(0);
            this.Title.Name = "Title";
            this.Title.Padding = new System.Windows.Forms.Padding(5);
            this.Title.Size = new System.Drawing.Size(455, 45);
            this.Title.TabIndex = 121;
            this.Title.Text = "USER QUESTION TITLE?";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MessageBoxIcon
            // 
            this.MessageBoxIcon.AutoSize = true;
            this.MessageBoxIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MessageBoxIcon.Cursor = System.Windows.Forms.Cursors.Default;
            this.MessageBoxIcon.Dock = System.Windows.Forms.DockStyle.Right;
            this.MessageBoxIcon.FlatAppearance.BorderSize = 0;
            this.MessageBoxIcon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MessageBoxIcon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MessageBoxIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MessageBoxIcon.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MessageBoxIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MessageBoxIcon.IconChar = FontAwesome.Sharp.IconChar.Bell;
            this.MessageBoxIcon.IconColor = System.Drawing.Color.Orange;
            this.MessageBoxIcon.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.MessageBoxIcon.IconSize = 20;
            this.MessageBoxIcon.Location = new System.Drawing.Point(455, 0);
            this.MessageBoxIcon.Margin = new System.Windows.Forms.Padding(0);
            this.MessageBoxIcon.Name = "MessageBoxIcon";
            this.MessageBoxIcon.Size = new System.Drawing.Size(45, 45);
            this.MessageBoxIcon.TabIndex = 120;
            this.MessageBoxIcon.TabStop = false;
            this.MessageBoxIcon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MessageBoxIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MessageBoxIcon.UseVisualStyleBackColor = false;
            // 
            // Footer
            // 
            this.Footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Footer.Controls.Add(this.OK);
            this.Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Footer.Location = new System.Drawing.Point(0, 240);
            this.Footer.Name = "Footer";
            this.Footer.Padding = new System.Windows.Forms.Padding(10);
            this.Footer.Size = new System.Drawing.Size(500, 60);
            this.Footer.TabIndex = 128;
            // 
            // OK
            // 
            this.OK.AutoSize = true;
            this.OK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.OK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OK.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OK.FlatAppearance.BorderSize = 0;
            this.OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OK.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OK.ForeColor = System.Drawing.Color.Gray;
            this.OK.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.OK.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(190)))), ((int)(((byte)(72)))));
            this.OK.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.OK.IconSize = 20;
            this.OK.Location = new System.Drawing.Point(10, 10);
            this.OK.Margin = new System.Windows.Forms.Padding(0);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(480, 40);
            this.OK.TabIndex = 120;
            this.OK.TabStop = false;
            this.OK.Text = "OK";
            this.OK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.OK.UseVisualStyleBackColor = false;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Separator
            // 
            this.Separator.BackColor = System.Drawing.Color.Transparent;
            this.Separator.Dock = System.Windows.Forms.DockStyle.Top;
            this.Separator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(170)))), ((int)(((byte)(72)))));
            this.Separator.LineThickness = 5;
            this.Separator.Location = new System.Drawing.Point(0, 45);
            this.Separator.Name = "Separator";
            this.Separator.Size = new System.Drawing.Size(500, 2);
            this.Separator.TabIndex = 129;
            this.Separator.Transparency = 255;
            this.Separator.Vertical = false;
            // 
            // Message
            // 
            this.Message.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Message.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Message.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Message.ForeColor = System.Drawing.Color.White;
            this.Message.Location = new System.Drawing.Point(0, 47);
            this.Message.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Message.Name = "Message";
            this.Message.Padding = new System.Windows.Forms.Padding(20);
            this.Message.Size = new System.Drawing.Size(500, 193);
            this.Message.TabIndex = 130;
            this.Message.Text = resources.GetString("Message.Text");
            this.Message.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NotificationBox
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(70)))));
            this.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.ControlBox = false;
            this.Controls.Add(this.Message);
            this.Controls.Add(this.Separator);
            this.Controls.Add(this.Footer);
            this.Controls.Add(this.Header);
            this.DoubleBuffered = true;
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("NotificationBox.IconOptions.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NotificationBox";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.Footer.ResumeLayout(false);
            this.Footer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Header;
        private FontAwesome.Sharp.IconButton MessageBoxIcon;
        private System.Windows.Forms.Panel Footer;
        private FontAwesome.Sharp.IconButton OK;
        private System.Windows.Forms.Label Title;
        private Bunifu.Framework.UI.BunifuSeparator Separator;
        private System.Windows.Forms.Label Message;
    }
}