
namespace FactoryManager.View.Report.ReportForm
{
    partial class ReportForm8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm8));
            this.Header = new System.Windows.Forms.Panel();
            this.FormTitle = new System.Windows.Forms.Label();
            this.CloseForm = new FontAwesome.Sharp.IconButton();
            this.Priview = new FontAwesome.Sharp.IconButton();
            this.Print = new FontAwesome.Sharp.IconButton();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.Controls.Add(this.FormTitle);
            this.Header.Controls.Add(this.CloseForm);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(5, 5);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(686, 50);
            this.Header.TabIndex = 130;
            // 
            // FormTitle
            // 
            this.FormTitle.BackColor = System.Drawing.Color.Transparent;
            this.FormTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormTitle.ForeColor = System.Drawing.Color.White;
            this.FormTitle.Location = new System.Drawing.Point(0, 0);
            this.FormTitle.Name = "FormTitle";
            this.FormTitle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.FormTitle.Size = new System.Drawing.Size(641, 50);
            this.FormTitle.TabIndex = 133;
            this.FormTitle.Text = "Inköpsorder från Excel";
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
            this.CloseForm.IconColor = System.Drawing.Color.White;
            this.CloseForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CloseForm.IconSize = 30;
            this.CloseForm.Location = new System.Drawing.Point(641, 0);
            this.CloseForm.Name = "CloseForm";
            this.CloseForm.Size = new System.Drawing.Size(45, 50);
            this.CloseForm.TabIndex = 132;
            this.CloseForm.UseVisualStyleBackColor = true;
            this.CloseForm.Click += new System.EventHandler(this.CloseForm_Click);
            // 
            // Priview
            // 
            this.Priview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Priview.BackColor = System.Drawing.Color.Teal;
            this.Priview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Priview.FlatAppearance.BorderSize = 0;
            this.Priview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.Priview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Priview.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Priview.ForeColor = System.Drawing.Color.White;
            this.Priview.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.Priview.IconColor = System.Drawing.Color.White;
            this.Priview.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Priview.IconSize = 25;
            this.Priview.Location = new System.Drawing.Point(477, 296);
            this.Priview.Margin = new System.Windows.Forms.Padding(2, 2, 8, 2);
            this.Priview.Name = "Priview";
            this.Priview.Size = new System.Drawing.Size(92, 42);
            this.Priview.TabIndex = 132;
            this.Priview.TabStop = false;
            this.Priview.Text = "PREVIEW";
            this.Priview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Priview.UseVisualStyleBackColor = false;
            this.Priview.Click += new System.EventHandler(this.Priview_Click);
            // 
            // Print
            // 
            this.Print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Print.BackColor = System.Drawing.Color.SeaGreen;
            this.Print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Print.FlatAppearance.BorderSize = 0;
            this.Print.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(170)))), ((int)(((byte)(72)))));
            this.Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Print.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Print.ForeColor = System.Drawing.Color.White;
            this.Print.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.Print.IconColor = System.Drawing.Color.White;
            this.Print.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Print.IconSize = 25;
            this.Print.Location = new System.Drawing.Point(579, 296);
            this.Print.Margin = new System.Windows.Forms.Padding(2, 2, 8, 2);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(92, 42);
            this.Print.TabIndex = 133;
            this.Print.TabStop = false;
            this.Print.Text = "PRINT";
            this.Print.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Print.UseVisualStyleBackColor = false;
            // 
            // separatorControl1
            // 
            this.separatorControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.separatorControl1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(170)))), ((int)(((byte)(72)))));
            this.separatorControl1.Location = new System.Drawing.Point(5, 55);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Padding = new System.Windows.Forms.Padding(0);
            this.separatorControl1.Size = new System.Drawing.Size(686, 15);
            this.separatorControl1.TabIndex = 135;
            // 
            // ReportForm8
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 354);
            this.ControlBox = false;
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.Priview);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.Header);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("ReportForm8.IconOptions.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReportForm8";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Label FormTitle;
        private FontAwesome.Sharp.IconButton CloseForm;
        private FontAwesome.Sharp.IconButton Priview;
        private FontAwesome.Sharp.IconButton Print;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
    }
}