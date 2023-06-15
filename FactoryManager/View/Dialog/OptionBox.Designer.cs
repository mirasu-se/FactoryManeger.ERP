namespace FactoryManager.View.Dialog
{
    partial class OptionBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionBox));
            this.Footer = new System.Windows.Forms.Panel();
            this.NO = new FontAwesome.Sharp.IconButton();
            this.YES = new FontAwesome.Sharp.IconButton();
            this.Header = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.NotificationIcon = new FontAwesome.Sharp.IconButton();
            this.Separator = new Bunifu.Framework.UI.BunifuSeparator();
            this.Message = new System.Windows.Forms.Label();
            this.Footer.SuspendLayout();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // Footer
            // 
            this.Footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Footer.Controls.Add(this.NO);
            this.Footer.Controls.Add(this.YES);
            this.Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Footer.Location = new System.Drawing.Point(0, 240);
            this.Footer.Name = "Footer";
            this.Footer.Padding = new System.Windows.Forms.Padding(10);
            this.Footer.Size = new System.Drawing.Size(500, 60);
            this.Footer.TabIndex = 123;
            // 
            // NO
            // 
            this.NO.AutoSize = true;
            this.NO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.NO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NO.Dock = System.Windows.Forms.DockStyle.Right;
            this.NO.FlatAppearance.BorderSize = 0;
            this.NO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NO.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NO.ForeColor = System.Drawing.Color.White;
            this.NO.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.NO.IconColor = System.Drawing.Color.Orange;
            this.NO.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.NO.IconSize = 20;
            this.NO.Location = new System.Drawing.Point(419, 10);
            this.NO.Margin = new System.Windows.Forms.Padding(0);
            this.NO.Name = "NO";
            this.NO.Size = new System.Drawing.Size(71, 40);
            this.NO.TabIndex = 118;
            this.NO.TabStop = false;
            this.NO.Text = "NEJ";
            this.NO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NO.UseVisualStyleBackColor = false;
            this.NO.Click += new System.EventHandler(this.NO_Click);
            // 
            // YES
            // 
            this.YES.AutoSize = true;
            this.YES.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.YES.Cursor = System.Windows.Forms.Cursors.Hand;
            this.YES.Dock = System.Windows.Forms.DockStyle.Left;
            this.YES.FlatAppearance.BorderSize = 0;
            this.YES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YES.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.YES.ForeColor = System.Drawing.Color.White;
            this.YES.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.YES.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(190)))), ((int)(((byte)(72)))));
            this.YES.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.YES.IconSize = 20;
            this.YES.Location = new System.Drawing.Point(10, 10);
            this.YES.Margin = new System.Windows.Forms.Padding(0);
            this.YES.Name = "YES";
            this.YES.Padding = new System.Windows.Forms.Padding(5);
            this.YES.Size = new System.Drawing.Size(74, 40);
            this.YES.TabIndex = 117;
            this.YES.TabStop = false;
            this.YES.Text = "JA";
            this.YES.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.YES.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.YES.UseVisualStyleBackColor = false;
            this.YES.Click += new System.EventHandler(this.YES_Click);
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.White;
            this.Header.Controls.Add(this.Title);
            this.Header.Controls.Add(this.NotificationIcon);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(500, 45);
            this.Header.TabIndex = 125;
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Title.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Title.ForeColor = System.Drawing.Color.GreenYellow;
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Margin = new System.Windows.Forms.Padding(0);
            this.Title.Name = "Title";
            this.Title.Padding = new System.Windows.Forms.Padding(5);
            this.Title.Size = new System.Drawing.Size(455, 45);
            this.Title.TabIndex = 121;
            this.Title.Text = "USER QUESTION TITLE?";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NotificationIcon
            // 
            this.NotificationIcon.AutoSize = true;
            this.NotificationIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.NotificationIcon.Cursor = System.Windows.Forms.Cursors.Default;
            this.NotificationIcon.Dock = System.Windows.Forms.DockStyle.Right;
            this.NotificationIcon.FlatAppearance.BorderSize = 0;
            this.NotificationIcon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.NotificationIcon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.NotificationIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NotificationIcon.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NotificationIcon.ForeColor = System.Drawing.Color.White;
            this.NotificationIcon.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            this.NotificationIcon.IconColor = System.Drawing.Color.YellowGreen;
            this.NotificationIcon.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.NotificationIcon.IconSize = 20;
            this.NotificationIcon.Location = new System.Drawing.Point(455, 0);
            this.NotificationIcon.Margin = new System.Windows.Forms.Padding(0);
            this.NotificationIcon.Name = "NotificationIcon";
            this.NotificationIcon.Size = new System.Drawing.Size(45, 45);
            this.NotificationIcon.TabIndex = 120;
            this.NotificationIcon.TabStop = false;
            this.NotificationIcon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NotificationIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NotificationIcon.UseVisualStyleBackColor = false;
            // 
            // Separator
            // 
            this.Separator.BackColor = System.Drawing.Color.Transparent;
            this.Separator.Dock = System.Windows.Forms.DockStyle.Top;
            this.Separator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(170)))), ((int)(((byte)(72)))));
            this.Separator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(170)))), ((int)(((byte)(52)))));
            this.Separator.LineThickness = 5;
            this.Separator.Location = new System.Drawing.Point(0, 45);
            this.Separator.Name = "Separator";
            this.Separator.Size = new System.Drawing.Size(500, 2);
            this.Separator.TabIndex = 122;
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
            this.Message.TabIndex = 127;
            this.Message.Text = resources.GetString("Message.Text");
            // 
            // OptionBox
            // 
            this.ActiveGlowColor = System.Drawing.Color.White;
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(70)))));
            this.Appearance.ForeColor = System.Drawing.Color.Bisque;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.ControlBox = false;
            this.Controls.Add(this.Message);
            this.Controls.Add(this.Separator);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.Footer);
            this.DoubleBuffered = true;
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("OptionBox.IconOptions.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionBox";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Footer.ResumeLayout(false);
            this.Footer.PerformLayout();
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Footer;
        private FontAwesome.Sharp.IconButton NO;
        private FontAwesome.Sharp.IconButton YES;
        private System.Windows.Forms.Panel Header;
        private FontAwesome.Sharp.IconButton NotificationIcon;
        private System.Windows.Forms.Label Title;
        private Bunifu.Framework.UI.BunifuSeparator Separator;
        private System.Windows.Forms.Label Message;
    }
}