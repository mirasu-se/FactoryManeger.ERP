namespace FactoryManager.View
{
    partial class Login
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.LogInManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::FactoryManager.View.Dialog.LoadingScreen), false, false, true);
            this.FooterPanel = new System.Windows.Forms.Panel();
            this.CopyrightLabel = new System.Windows.Forms.Label();
            this.PoweredByLabel = new System.Windows.Forms.Label();
            this.AppVersionLabel = new System.Windows.Forms.Label();
            this.MainLoginPanel = new System.Windows.Forms.Panel();
            this.LeftSidePanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoginTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ButtonLogIn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ButtoneExit = new FontAwesome.Sharp.IconButton();
            this.Maximize = new FontAwesome.Sharp.IconButton();
            this.TopHeaderPanel = new System.Windows.Forms.Panel();
            this.Minimize = new FontAwesome.Sharp.IconButton();
            this.FooterPanel.SuspendLayout();
            this.MainLoginPanel.SuspendLayout();
            this.LeftSidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TopHeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogInManager
            // 
            this.LogInManager.ClosingDelay = 3000;
            // 
            // FooterPanel
            // 
            this.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(72)))));
            this.FooterPanel.Controls.Add(this.CopyrightLabel);
            this.FooterPanel.Controls.Add(this.PoweredByLabel);
            this.FooterPanel.Controls.Add(this.AppVersionLabel);
            this.FooterPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FooterPanel.Location = new System.Drawing.Point(1, 630);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Size = new System.Drawing.Size(1148, 49);
            this.FooterPanel.TabIndex = 106;
            // 
            // CopyrightLabel
            // 
            this.CopyrightLabel.BackColor = System.Drawing.Color.Transparent;
            this.CopyrightLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CopyrightLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CopyrightLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CopyrightLabel.ForeColor = System.Drawing.Color.White;
            this.CopyrightLabel.Location = new System.Drawing.Point(260, 0);
            this.CopyrightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CopyrightLabel.Name = "CopyrightLabel";
            this.CopyrightLabel.Padding = new System.Windows.Forms.Padding(10);
            this.CopyrightLabel.Size = new System.Drawing.Size(628, 49);
            this.CopyrightLabel.TabIndex = 103;
            this.CopyrightLabel.Text = "Copyright ©  Milenko Raic | Software Development";
            this.CopyrightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PoweredByLabel
            // 
            this.PoweredByLabel.BackColor = System.Drawing.Color.Transparent;
            this.PoweredByLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.PoweredByLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PoweredByLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PoweredByLabel.ForeColor = System.Drawing.Color.White;
            this.PoweredByLabel.Location = new System.Drawing.Point(888, 0);
            this.PoweredByLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PoweredByLabel.Name = "PoweredByLabel";
            this.PoweredByLabel.Padding = new System.Windows.Forms.Padding(15);
            this.PoweredByLabel.Size = new System.Drawing.Size(260, 49);
            this.PoweredByLabel.TabIndex = 102;
            this.PoweredByLabel.Text = "Powered by Microsoft Access DB Engine";
            this.PoweredByLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AppVersionLabel
            // 
            this.AppVersionLabel.BackColor = System.Drawing.Color.Transparent;
            this.AppVersionLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.AppVersionLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AppVersionLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AppVersionLabel.ForeColor = System.Drawing.Color.White;
            this.AppVersionLabel.Location = new System.Drawing.Point(0, 0);
            this.AppVersionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AppVersionLabel.Name = "AppVersionLabel";
            this.AppVersionLabel.Padding = new System.Windows.Forms.Padding(10);
            this.AppVersionLabel.Size = new System.Drawing.Size(260, 49);
            this.AppVersionLabel.TabIndex = 100;
            this.AppVersionLabel.Text = "Factory Manager";
            this.AppVersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainLoginPanel
            // 
            this.MainLoginPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(170)))), ((int)(((byte)(72)))));
            this.MainLoginPanel.Controls.Add(this.LeftSidePanel);
            this.MainLoginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLoginPanel.Location = new System.Drawing.Point(1, 1);
            this.MainLoginPanel.Name = "MainLoginPanel";
            this.MainLoginPanel.Size = new System.Drawing.Size(1148, 678);
            this.MainLoginPanel.TabIndex = 105;
            // 
            // LeftSidePanel
            // 
            this.LeftSidePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LeftSidePanel.Controls.Add(this.pictureBox1);
            this.LeftSidePanel.Controls.Add(this.LoginTextBox);
            this.LeftSidePanel.Controls.Add(this.ButtonLogIn);
            this.LeftSidePanel.Location = new System.Drawing.Point(282, 47);
            this.LeftSidePanel.Name = "LeftSidePanel";
            this.LeftSidePanel.Size = new System.Drawing.Size(585, 576);
            this.LeftSidePanel.TabIndex = 96;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(170)))), ((int)(((byte)(72)))));
            this.pictureBox1.BackgroundImage = global::FactoryManager.Properties.Resources.app_cover_green;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(157, 70);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(10);
            this.pictureBox1.Size = new System.Drawing.Size(271, 188);
            this.pictureBox1.TabIndex = 85;
            this.pictureBox1.TabStop = false;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LoginTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(70)))));
            this.LoginTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LoginTextBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LoginTextBox.ForeColor = System.Drawing.Color.White;
            this.LoginTextBox.HintForeColor = System.Drawing.Color.White;
            this.LoginTextBox.HintText = "Enter password";
            this.LoginTextBox.isPassword = false;
            this.LoginTextBox.LineFocusedColor = System.Drawing.Color.LawnGreen;
            this.LoginTextBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(170)))), ((int)(((byte)(72)))));
            this.LoginTextBox.LineMouseHoverColor = System.Drawing.Color.YellowGreen;
            this.LoginTextBox.LineThickness = 2;
            this.LoginTextBox.Location = new System.Drawing.Point(126, 315);
            this.LoginTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(332, 35);
            this.LoginTextBox.TabIndex = 93;
            this.LoginTextBox.TabStop = false;
            this.LoginTextBox.Text = "Ange ditt lösenord här...";
            this.LoginTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LoginTextBox.Enter += new System.EventHandler(this.LoginTextBox_Enter);
            this.LoginTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoginTextBox_KeyPress);
            // 
            // ButtonLogIn
            // 
            this.ButtonLogIn.ActiveBorderThickness = 2;
            this.ButtonLogIn.ActiveCornerRadius = 10;
            this.ButtonLogIn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ButtonLogIn.ActiveForecolor = System.Drawing.Color.GreenYellow;
            this.ButtonLogIn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(72)))));
            this.ButtonLogIn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ButtonLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(170)))), ((int)(((byte)(72)))));
            this.ButtonLogIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonLogIn.BackgroundImage")));
            this.ButtonLogIn.ButtonText = "LOGGA IN";
            this.ButtonLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonLogIn.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonLogIn.ForeColor = System.Drawing.Color.GreenYellow;
            this.ButtonLogIn.IdleBorderThickness = 2;
            this.ButtonLogIn.IdleCornerRadius = 10;
            this.ButtonLogIn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ButtonLogIn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(72)))));
            this.ButtonLogIn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(72)))));
            this.ButtonLogIn.Location = new System.Drawing.Point(245, 359);
            this.ButtonLogIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonLogIn.Name = "ButtonLogIn";
            this.ButtonLogIn.Size = new System.Drawing.Size(95, 55);
            this.ButtonLogIn.TabIndex = 94;
            this.ButtonLogIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonLogIn.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // ButtoneExit
            // 
            this.ButtoneExit.AutoSize = true;
            this.ButtoneExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(170)))), ((int)(((byte)(72)))));
            this.ButtoneExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtoneExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtoneExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtoneExit.FlatAppearance.BorderSize = 0;
            this.ButtoneExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtoneExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(170)))), ((int)(((byte)(72)))));
            this.ButtoneExit.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.ButtoneExit.IconColor = System.Drawing.Color.White;
            this.ButtoneExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtoneExit.IconSize = 18;
            this.ButtoneExit.Location = new System.Drawing.Point(1108, 0);
            this.ButtoneExit.Margin = new System.Windows.Forms.Padding(0);
            this.ButtoneExit.Name = "ButtoneExit";
            this.ButtoneExit.Padding = new System.Windows.Forms.Padding(2);
            this.ButtoneExit.Size = new System.Drawing.Size(40, 40);
            this.ButtoneExit.TabIndex = 97;
            this.ButtoneExit.TabStop = false;
            this.ButtoneExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtoneExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ButtoneExit.UseVisualStyleBackColor = false;
            this.ButtoneExit.Click += new System.EventHandler(this.ButtoneExit_Click);
            // 
            // Maximize
            // 
            this.Maximize.AutoSize = true;
            this.Maximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(170)))), ((int)(((byte)(72)))));
            this.Maximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Maximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Maximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.Maximize.FlatAppearance.BorderSize = 0;
            this.Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Maximize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(170)))), ((int)(((byte)(72)))));
            this.Maximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.Maximize.IconColor = System.Drawing.Color.White;
            this.Maximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Maximize.IconSize = 18;
            this.Maximize.Location = new System.Drawing.Point(1068, 0);
            this.Maximize.Margin = new System.Windows.Forms.Padding(0);
            this.Maximize.Name = "Maximize";
            this.Maximize.Padding = new System.Windows.Forms.Padding(2);
            this.Maximize.Size = new System.Drawing.Size(40, 40);
            this.Maximize.TabIndex = 98;
            this.Maximize.TabStop = false;
            this.Maximize.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Maximize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Maximize.UseVisualStyleBackColor = false;
            this.Maximize.Click += new System.EventHandler(this.Maximize_Click);
            // 
            // TopHeaderPanel
            // 
            this.TopHeaderPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TopHeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(72)))));
            this.TopHeaderPanel.Controls.Add(this.Minimize);
            this.TopHeaderPanel.Controls.Add(this.Maximize);
            this.TopHeaderPanel.Controls.Add(this.ButtoneExit);
            this.TopHeaderPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.TopHeaderPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(170)))), ((int)(((byte)(72)))));
            this.TopHeaderPanel.Location = new System.Drawing.Point(1, 1);
            this.TopHeaderPanel.Margin = new System.Windows.Forms.Padding(4);
            this.TopHeaderPanel.Name = "TopHeaderPanel";
            this.TopHeaderPanel.Size = new System.Drawing.Size(1148, 40);
            this.TopHeaderPanel.TabIndex = 126;
            // 
            // Minimize
            // 
            this.Minimize.AutoSize = true;
            this.Minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(170)))), ((int)(((byte)(72)))));
            this.Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.Minimize.FlatAppearance.BorderSize = 0;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(170)))), ((int)(((byte)(72)))));
            this.Minimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.Minimize.IconColor = System.Drawing.Color.White;
            this.Minimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Minimize.IconSize = 18;
            this.Minimize.Location = new System.Drawing.Point(1028, 0);
            this.Minimize.Margin = new System.Windows.Forms.Padding(0);
            this.Minimize.Name = "Minimize";
            this.Minimize.Padding = new System.Windows.Forms.Padding(2);
            this.Minimize.Size = new System.Drawing.Size(40, 40);
            this.Minimize.TabIndex = 99;
            this.Minimize.TabStop = false;
            this.Minimize.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Minimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Minimize.UseVisualStyleBackColor = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Login
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1150, 680);
            this.ControlBox = false;
            this.Controls.Add(this.TopHeaderPanel);
            this.Controls.Add(this.FooterPanel);
            this.Controls.Add(this.MainLoginPanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("Login.IconOptions.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.FooterPanel.ResumeLayout(false);
            this.MainLoginPanel.ResumeLayout(false);
            this.LeftSidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TopHeaderPanel.ResumeLayout(false);
            this.TopHeaderPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel FooterPanel;
        private System.Windows.Forms.Label PoweredByLabel;
        private System.Windows.Forms.Label AppVersionLabel;
        private System.Windows.Forms.Panel MainLoginPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonLogIn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox LoginTextBox;
        private DevExpress.XtraSplashScreen.SplashScreenManager LogInManager;
        private System.Windows.Forms.Label CopyrightLabel;
        private System.Windows.Forms.Panel LeftSidePanel;
        private FontAwesome.Sharp.IconButton ButtoneExit;
        private FontAwesome.Sharp.IconButton Maximize;
        private System.Windows.Forms.Panel TopHeaderPanel;
        private FontAwesome.Sharp.IconButton Minimize;
    }
}

