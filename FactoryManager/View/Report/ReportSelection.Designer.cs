
using System.Windows.Forms;

namespace FactoryManager.View.Report
{
    partial class ReportSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportSelection));
            this.Header = new System.Windows.Forms.Panel();
            this.DatabaseFileName = new System.Windows.Forms.Label();
            this.Browse = new FontAwesome.Sharp.IconButton();
            this.flpReports = new System.Windows.Forms.FlowLayoutPanel();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(72)))));
            this.Header.Controls.Add(this.DatabaseFileName);
            this.Header.Controls.Add(this.Browse);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Padding = new System.Windows.Forms.Padding(10);
            this.Header.Size = new System.Drawing.Size(1150, 56);
            this.Header.TabIndex = 0;
            // 
            // DatabaseFileName
            // 
            this.DatabaseFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DatabaseFileName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(160)))), ((int)(((byte)(72)))));
            this.DatabaseFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatabaseFileName.ForeColor = System.Drawing.Color.White;
            this.DatabaseFileName.Location = new System.Drawing.Point(161, 12);
            this.DatabaseFileName.Name = "DatabaseFileName";
            this.DatabaseFileName.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.DatabaseFileName.Size = new System.Drawing.Size(977, 33);
            this.DatabaseFileName.TabIndex = 12;
            this.DatabaseFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Browse
            // 
            this.Browse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(72)))));
            this.Browse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Browse.FlatAppearance.BorderSize = 0;
            this.Browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Browse.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Browse.ForeColor = System.Drawing.Color.White;
            this.Browse.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.Browse.IconColor = System.Drawing.Color.White;
            this.Browse.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Browse.IconSize = 18;
            this.Browse.Location = new System.Drawing.Point(12, 12);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(134, 33);
            this.Browse.TabIndex = 11;
            this.Browse.TabStop = false;
            this.Browse.Text = "  Välj databasfil...";
            this.Browse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Browse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Browse.UseVisualStyleBackColor = false;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // flpReports
            // 
            this.flpReports.AutoScroll = true;
            this.flpReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(72)))));
            this.flpReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpReports.Location = new System.Drawing.Point(0, 56);
            this.flpReports.Margin = new System.Windows.Forms.Padding(5);
            this.flpReports.Name = "flpReports";
            this.flpReports.Padding = new System.Windows.Forms.Padding(10);
            this.flpReports.Size = new System.Drawing.Size(1150, 624);
            this.flpReports.TabIndex = 1;
            // 
            // ReportSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1150, 680);
            this.Controls.Add(this.flpReports);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportSelection";
            this.Text = "AccessReport";
            this.Header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.FlowLayoutPanel flpReports;
        private FontAwesome.Sharp.IconButton Browse;
        private Label DatabaseFileName;
    }
}