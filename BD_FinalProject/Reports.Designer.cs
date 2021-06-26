
namespace BD_FinalProject
{
    partial class Reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            this.label1 = new System.Windows.Forms.Label();
            this.Cb_WorkspaceSelection = new System.Windows.Forms.ComboBox();
            this.P_Report_Cards = new System.Windows.Forms.Panel();
            this.Pb_CreateReport = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_CreateReport)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Oswald SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(173)))), ((int)(((byte)(68)))));
            this.label1.Location = new System.Drawing.Point(37, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 46);
            this.label1.TabIndex = 6;
            this.label1.Text = "Reports";
            // 
            // Cb_WorkspaceSelection
            // 
            this.Cb_WorkspaceSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_WorkspaceSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cb_WorkspaceSelection.Font = new System.Drawing.Font("Oswald Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Cb_WorkspaceSelection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(173)))), ((int)(((byte)(68)))));
            this.Cb_WorkspaceSelection.FormattingEnabled = true;
            this.Cb_WorkspaceSelection.Location = new System.Drawing.Point(44, 103);
            this.Cb_WorkspaceSelection.Name = "Cb_WorkspaceSelection";
            this.Cb_WorkspaceSelection.Size = new System.Drawing.Size(319, 40);
            this.Cb_WorkspaceSelection.TabIndex = 10;
            this.Cb_WorkspaceSelection.SelectedIndexChanged += new System.EventHandler(this.Cb_WorkspaceSelection_SelectedIndexChanged);
            // 
            // P_Report_Cards
            // 
            this.P_Report_Cards.Location = new System.Drawing.Point(44, 175);
            this.P_Report_Cards.Name = "P_Report_Cards";
            this.P_Report_Cards.Size = new System.Drawing.Size(1187, 450);
            this.P_Report_Cards.TabIndex = 11;
            // 
            // Pb_CreateReport
            // 
            this.Pb_CreateReport.Image = ((System.Drawing.Image)(resources.GetObject("Pb_CreateReport.Image")));
            this.Pb_CreateReport.Location = new System.Drawing.Point(1178, 86);
            this.Pb_CreateReport.Name = "Pb_CreateReport";
            this.Pb_CreateReport.Size = new System.Drawing.Size(40, 40);
            this.Pb_CreateReport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Pb_CreateReport.TabIndex = 12;
            this.Pb_CreateReport.TabStop = false;
            this.Pb_CreateReport.Click += new System.EventHandler(this.Pb_CreateReport_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Pb_CreateReport);
            this.Controls.Add(this.P_Report_Cards);
            this.Controls.Add(this.Cb_WorkspaceSelection);
            this.Controls.Add(this.label1);
            this.Name = "Reports";
            this.Size = new System.Drawing.Size(1268, 669);
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pb_CreateReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cb_WorkspaceSelection;
        private System.Windows.Forms.Panel P_Report_Cards;
        private System.Windows.Forms.PictureBox Pb_CreateReport;
    }
}
