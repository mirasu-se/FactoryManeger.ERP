namespace FactoryManager.View.Dialog
{
    partial class LoadingScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingScreen));
            this.FormDisplayTimer = new System.Windows.Forms.Timer(this.components);
            this.GridPanel = new System.Windows.Forms.Panel();
            this.CenterPanel = new System.Windows.Forms.Panel();
            this.LogoSpinner = new System.Windows.Forms.PictureBox();
            this.lmPanel = new System.Windows.Forms.Panel();
            this.rmPanel = new System.Windows.Forms.Panel();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.progressPanel1 = new DevExpress.XtraWaitForm.ProgressPanel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.LoadingGif = new System.Windows.Forms.PictureBox();
            this.GridPanel.SuspendLayout();
            this.CenterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoSpinner)).BeginInit();
            this.BottomPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingGif)).BeginInit();
            this.SuspendLayout();
            // 
            // FormDisplayTimer
            // 
            this.FormDisplayTimer.Enabled = true;
            this.FormDisplayTimer.Interval = 10;
            // 
            // GridPanel
            // 
            this.GridPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(49)))));
            this.GridPanel.Controls.Add(this.CenterPanel);
            this.GridPanel.Controls.Add(this.BottomPanel);
            this.GridPanel.Controls.Add(this.TopPanel);
            this.GridPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridPanel.Location = new System.Drawing.Point(0, 0);
            this.GridPanel.Name = "GridPanel";
            this.GridPanel.Padding = new System.Windows.Forms.Padding(10, 25, 10, 10);
            this.GridPanel.Size = new System.Drawing.Size(499, 481);
            this.GridPanel.TabIndex = 104;
            // 
            // CenterPanel
            // 
            this.CenterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(49)))));
            this.CenterPanel.Controls.Add(this.LogoSpinner);
            this.CenterPanel.Controls.Add(this.lmPanel);
            this.CenterPanel.Controls.Add(this.rmPanel);
            this.CenterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CenterPanel.Location = new System.Drawing.Point(10, 118);
            this.CenterPanel.Name = "CenterPanel";
            this.CenterPanel.Size = new System.Drawing.Size(479, 260);
            this.CenterPanel.TabIndex = 106;
            // 
            // LogoSpinner
            // 
            this.LogoSpinner.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LogoSpinner.Image = global::FactoryManager.Properties.Resources.Double_Ring_1_1s_150px;
            this.LogoSpinner.Location = new System.Drawing.Point(164, 55);
            this.LogoSpinner.Name = "LogoSpinner";
            this.LogoSpinner.Size = new System.Drawing.Size(150, 150);
            this.LogoSpinner.TabIndex = 111;
            this.LogoSpinner.TabStop = false;
            // 
            // lmPanel
            // 
            this.lmPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(49)))));
            this.lmPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.lmPanel.Location = new System.Drawing.Point(0, 0);
            this.lmPanel.Name = "lmPanel";
            this.lmPanel.Size = new System.Drawing.Size(112, 260);
            this.lmPanel.TabIndex = 110;
            // 
            // rmPanel
            // 
            this.rmPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(49)))));
            this.rmPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rmPanel.Location = new System.Drawing.Point(367, 0);
            this.rmPanel.Name = "rmPanel";
            this.rmPanel.Size = new System.Drawing.Size(112, 260);
            this.rmPanel.TabIndex = 109;
            // 
            // BottomPanel
            // 
            this.BottomPanel.Controls.Add(this.progressPanel1);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(10, 378);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(479, 93);
            this.BottomPanel.TabIndex = 105;
            // 
            // progressPanel1
            // 
            this.progressPanel1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progressPanel1.Appearance.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressPanel1.Appearance.ForeColor = System.Drawing.Color.White;
            this.progressPanel1.Appearance.Options.UseBackColor = true;
            this.progressPanel1.Appearance.Options.UseFont = true;
            this.progressPanel1.Appearance.Options.UseForeColor = true;
            this.progressPanel1.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.progressPanel1.AppearanceCaption.ForeColor = System.Drawing.Color.White;
            this.progressPanel1.AppearanceCaption.Options.UseBackColor = true;
            this.progressPanel1.AppearanceCaption.Options.UseFont = true;
            this.progressPanel1.AppearanceCaption.Options.UseForeColor = true;
            this.progressPanel1.AppearanceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.progressPanel1.AppearanceDescription.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.DisabledText;
            this.progressPanel1.AppearanceDescription.Options.UseBackColor = true;
            this.progressPanel1.AppearanceDescription.Options.UseFont = true;
            this.progressPanel1.AppearanceDescription.Options.UseForeColor = true;
            this.progressPanel1.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.progressPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressPanel1.ImageHorzOffset = 20;
            this.progressPanel1.LineAnimationElementHeight = 8;
            this.progressPanel1.Location = new System.Drawing.Point(0, 0);
            this.progressPanel1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.progressPanel1.Name = "progressPanel1";
            this.progressPanel1.RingAnimationDiameter = 10;
            this.progressPanel1.Size = new System.Drawing.Size(479, 93);
            this.progressPanel1.TabIndex = 112;
            this.progressPanel1.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Line;
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.LoadingGif);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(10, 25);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(479, 93);
            this.TopPanel.TabIndex = 103;
            // 
            // LoadingGif
            // 
            this.LoadingGif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(49)))));
            this.LoadingGif.BackgroundImage = global::FactoryManager.Properties.Resources.app_cover_transparent;
            this.LoadingGif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LoadingGif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoadingGif.Location = new System.Drawing.Point(0, 0);
            this.LoadingGif.Name = "LoadingGif";
            this.LoadingGif.Size = new System.Drawing.Size(479, 93);
            this.LoadingGif.TabIndex = 109;
            this.LoadingGif.TabStop = false;
            // 
            // LoadingScreen
            // 
            this.ActiveGlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(170)))), ((int)(((byte)(72)))));
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(170)))), ((int)(((byte)(72)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(499, 481);
            this.Controls.Add(this.GridPanel);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(70)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.InactiveGlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(170)))), ((int)(((byte)(72)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoadingScreen";
            this.GridPanel.ResumeLayout(false);
            this.CenterPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoSpinner)).EndInit();
            this.BottomPanel.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LoadingGif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer FormDisplayTimer;
        private System.Windows.Forms.Panel GridPanel;
        private System.Windows.Forms.Panel CenterPanel;
        private System.Windows.Forms.PictureBox LogoSpinner;
        private System.Windows.Forms.Panel lmPanel;
        private System.Windows.Forms.Panel rmPanel;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.PictureBox LoadingGif;
        private DevExpress.XtraWaitForm.ProgressPanel progressPanel1;
    }
}