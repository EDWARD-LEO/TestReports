namespace DESIGNER
{
    partial class DashboardReport
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
            this.btnReporte1 = new System.Windows.Forms.Button();
            this.btnReporte2 = new System.Windows.Forms.Button();
            this.btnReporte3 = new System.Windows.Forms.Button();
            this.btnReporte4 = new System.Windows.Forms.Button();
            this.btnReporte5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnReporte1
            // 
            this.btnReporte1.Location = new System.Drawing.Point(94, 119);
            this.btnReporte1.Margin = new System.Windows.Forms.Padding(4);
            this.btnReporte1.Name = "btnReporte1";
            this.btnReporte1.Size = new System.Drawing.Size(226, 39);
            this.btnReporte1.TabIndex = 0;
            this.btnReporte1.Text = "Reporte de empleados";
            this.btnReporte1.UseVisualStyleBackColor = true;
            this.btnReporte1.Click += new System.EventHandler(this.btnReporte1_Click);
            // 
            // btnReporte2
            // 
            this.btnReporte2.Location = new System.Drawing.Point(94, 165);
            this.btnReporte2.Name = "btnReporte2";
            this.btnReporte2.Size = new System.Drawing.Size(226, 42);
            this.btnReporte2.TabIndex = 1;
            this.btnReporte2.Text = "Exportar empleados";
            this.btnReporte2.UseVisualStyleBackColor = true;
            this.btnReporte2.Click += new System.EventHandler(this.btnReporte2_Click);
            // 
            // btnReporte3
            // 
            this.btnReporte3.Location = new System.Drawing.Point(412, 119);
            this.btnReporte3.Name = "btnReporte3";
            this.btnReporte3.Size = new System.Drawing.Size(253, 39);
            this.btnReporte3.TabIndex = 2;
            this.btnReporte3.Text = "Reporte de productos";
            this.btnReporte3.UseVisualStyleBackColor = true;
            this.btnReporte3.Click += new System.EventHandler(this.btnReporte3_Click);
            // 
            // btnReporte4
            // 
            this.btnReporte4.Location = new System.Drawing.Point(412, 165);
            this.btnReporte4.Name = "btnReporte4";
            this.btnReporte4.Size = new System.Drawing.Size(253, 42);
            this.btnReporte4.TabIndex = 3;
            this.btnReporte4.Text = "Exportar productos";
            this.btnReporte4.UseVisualStyleBackColor = true;
            this.btnReporte4.Click += new System.EventHandler(this.btnReporte4_Click);
            // 
            // btnReporte5
            // 
            this.btnReporte5.Location = new System.Drawing.Point(94, 273);
            this.btnReporte5.Name = "btnReporte5";
            this.btnReporte5.Size = new System.Drawing.Size(226, 45);
            this.btnReporte5.TabIndex = 4;
            this.btnReporte5.Text = "Gráfico pedidos";
            this.btnReporte5.UseVisualStyleBackColor = true;
            this.btnReporte5.Click += new System.EventHandler(this.btnReporte5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Indicar año:";
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(206, 325);
            this.txtAnio.MaxLength = 4;
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(114, 23);
            this.txtAnio.TabIndex = 6;
            this.txtAnio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DashboardReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 460);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReporte5);
            this.Controls.Add(this.btnReporte4);
            this.Controls.Add(this.btnReporte3);
            this.Controls.Add(this.btnReporte2);
            this.Controls.Add(this.btnReporte1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DashboardReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardReport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReporte1;
        private System.Windows.Forms.Button btnReporte2;
        private System.Windows.Forms.Button btnReporte3;
        private System.Windows.Forms.Button btnReporte4;
        private System.Windows.Forms.Button btnReporte5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAnio;
    }
}