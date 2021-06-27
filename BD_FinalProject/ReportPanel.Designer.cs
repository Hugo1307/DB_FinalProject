
namespace BD_FinalProject
{
    partial class ReportPanel
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportPanel));
            this.Pb_DeleteReport = new System.Windows.Forms.PictureBox();
            this.Lb_ReportDate = new System.Windows.Forms.Label();
            this.Lb_ReportName = new System.Windows.Forms.Label();
            this.Pb_UserPicture = new System.Windows.Forms.PictureBox();
            this.Lb_TotalValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_DeleteReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_UserPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // Pb_DeleteReport
            // 
            this.Pb_DeleteReport.Image = ((System.Drawing.Image)(resources.GetObject("Pb_DeleteReport.Image")));
            this.Pb_DeleteReport.Location = new System.Drawing.Point(100, 349);
            this.Pb_DeleteReport.Name = "Pb_DeleteReport";
            this.Pb_DeleteReport.Size = new System.Drawing.Size(50, 50);
            this.Pb_DeleteReport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb_DeleteReport.TabIndex = 11;
            this.Pb_DeleteReport.TabStop = false;
            this.Pb_DeleteReport.Click += new System.EventHandler(this.Pb_DeleteReport_Click);
            // 
            // Lb_ReportDate
            // 
            this.Lb_ReportDate.BackColor = System.Drawing.Color.Transparent;
            this.Lb_ReportDate.Font = new System.Drawing.Font("Oswald Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lb_ReportDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(173)))), ((int)(((byte)(68)))));
            this.Lb_ReportDate.Location = new System.Drawing.Point(0, 229);
            this.Lb_ReportDate.Name = "Lb_ReportDate";
            this.Lb_ReportDate.Size = new System.Drawing.Size(250, 35);
            this.Lb_ReportDate.TabIndex = 10;
            this.Lb_ReportDate.Text = "22/06/2021 - 25/06/2021";
            this.Lb_ReportDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lb_ReportName
            // 
            this.Lb_ReportName.BackColor = System.Drawing.Color.Transparent;
            this.Lb_ReportName.Font = new System.Drawing.Font("Oswald SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lb_ReportName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(173)))), ((int)(((byte)(68)))));
            this.Lb_ReportName.Location = new System.Drawing.Point(0, 170);
            this.Lb_ReportName.Name = "Lb_ReportName";
            this.Lb_ReportName.Size = new System.Drawing.Size(250, 46);
            this.Lb_ReportName.TabIndex = 9;
            this.Lb_ReportName.Text = "Report 1";
            this.Lb_ReportName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pb_UserPicture
            // 
            this.Pb_UserPicture.Image = ((System.Drawing.Image)(resources.GetObject("Pb_UserPicture.Image")));
            this.Pb_UserPicture.Location = new System.Drawing.Point(75, 51);
            this.Pb_UserPicture.Name = "Pb_UserPicture";
            this.Pb_UserPicture.Size = new System.Drawing.Size(100, 100);
            this.Pb_UserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb_UserPicture.TabIndex = 8;
            this.Pb_UserPicture.TabStop = false;
            // 
            // Lb_TotalValue
            // 
            this.Lb_TotalValue.BackColor = System.Drawing.Color.Transparent;
            this.Lb_TotalValue.Font = new System.Drawing.Font("Oswald Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lb_TotalValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(173)))), ((int)(((byte)(68)))));
            this.Lb_TotalValue.Location = new System.Drawing.Point(0, 264);
            this.Lb_TotalValue.Name = "Lb_TotalValue";
            this.Lb_TotalValue.Size = new System.Drawing.Size(250, 35);
            this.Lb_TotalValue.TabIndex = 12;
            this.Lb_TotalValue.Text = "2000 €";
            this.Lb_TotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReportPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Lb_TotalValue);
            this.Controls.Add(this.Pb_DeleteReport);
            this.Controls.Add(this.Lb_ReportDate);
            this.Controls.Add(this.Lb_ReportName);
            this.Controls.Add(this.Pb_UserPicture);
            this.Name = "ReportPanel";
            this.Size = new System.Drawing.Size(250, 450);
            this.Load += new System.EventHandler(this.ReportPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pb_DeleteReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_UserPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Pb_DeleteReport;
        private System.Windows.Forms.Label Lb_ReportDate;
        private System.Windows.Forms.Label Lb_ReportName;
        private System.Windows.Forms.PictureBox Pb_UserPicture;
        private System.Windows.Forms.Label Lb_TotalValue;
    }
}
