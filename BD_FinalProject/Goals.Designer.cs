
namespace BD_FinalProject
{
    partial class Goals
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Goals));
            this.label1 = new System.Windows.Forms.Label();
            this.Cb_WorkspaceSelection = new System.Windows.Forms.ComboBox();
            this.P_User_Cards = new System.Windows.Forms.Panel();
            this.Pb_AddGoal = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_AddGoal)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(79, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "Goals";
            // 
            // Cb_WorkspaceSelection
            // 
            this.Cb_WorkspaceSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_WorkspaceSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cb_WorkspaceSelection.Font = new System.Drawing.Font("Oswald Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Cb_WorkspaceSelection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(173)))), ((int)(((byte)(68)))));
            this.Cb_WorkspaceSelection.FormattingEnabled = true;
            this.Cb_WorkspaceSelection.Location = new System.Drawing.Point(46, 101);
            this.Cb_WorkspaceSelection.Name = "Cb_WorkspaceSelection";
            this.Cb_WorkspaceSelection.Size = new System.Drawing.Size(319, 40);
            this.Cb_WorkspaceSelection.TabIndex = 8;
            this.Cb_WorkspaceSelection.SelectedIndexChanged += new System.EventHandler(this.Cb_WorkspaceSelection_SelectedIndexChanged);
            // 
            // P_User_Cards
            // 
            this.P_User_Cards.Location = new System.Drawing.Point(37, 178);
            this.P_User_Cards.Name = "P_User_Cards";
            this.P_User_Cards.Size = new System.Drawing.Size(1187, 450);
            this.P_User_Cards.TabIndex = 9;
            // 
            // Pb_AddGoal
            // 
            this.Pb_AddGoal.Image = ((System.Drawing.Image)(resources.GetObject("Pb_AddGoal.Image")));
            this.Pb_AddGoal.Location = new System.Drawing.Point(1178, 86);
            this.Pb_AddGoal.Name = "Pb_AddGoal";
            this.Pb_AddGoal.Size = new System.Drawing.Size(40, 40);
            this.Pb_AddGoal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Pb_AddGoal.TabIndex = 9;
            this.Pb_AddGoal.TabStop = false;
            this.Pb_AddGoal.Click += new System.EventHandler(this.Pb_AddGoal_Click);
            // 
            // Goals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Pb_AddGoal);
            this.Controls.Add(this.P_User_Cards);
            this.Controls.Add(this.Cb_WorkspaceSelection);
            this.Controls.Add(this.label1);
            this.Name = "Goals";
            this.Size = new System.Drawing.Size(1268, 669);
            this.Load += new System.EventHandler(this.Goals_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pb_AddGoal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cb_WorkspaceSelection;
        private System.Windows.Forms.Panel P_User_Cards;
        private System.Windows.Forms.PictureBox Pb_AddGoal;
    }
}
