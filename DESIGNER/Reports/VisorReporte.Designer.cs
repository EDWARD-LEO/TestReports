namespace DESIGNER.Reports
{
    partial class VisorReporte
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
            this.visorRpt = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // visorRpt
            // 
            this.visorRpt.ActiveViewIndex = -1;
            this.visorRpt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.visorRpt.Cursor = System.Windows.Forms.Cursors.Default;
            this.visorRpt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visorRpt.Location = new System.Drawing.Point(0, 0);
            this.visorRpt.Name = "visorRpt";
            this.visorRpt.Size = new System.Drawing.Size(956, 609);
            this.visorRpt.TabIndex = 0;
            this.visorRpt.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // VisorReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 609);
            this.Controls.Add(this.visorRpt);
            this.Name = "VisorReporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VisorReporte";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer visorRpt;
    }
}