
namespace BD_FinalProject
{
    partial class Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            this.label1 = new System.Windows.Forms.Label();
            this.P_User_Cards = new System.Windows.Forms.Panel();
            this.Cb_WorkspaceSelection = new System.Windows.Forms.ComboBox();
            this.Pb_AddUser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_AddUser)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(80, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "Users";
            // 
            // P_User_Cards
            // 
            this.P_User_Cards.Location = new System.Drawing.Point(39, 159);
            this.P_User_Cards.Name = "P_User_Cards";
            this.P_User_Cards.Size = new System.Drawing.Size(1187, 450);
            this.P_User_Cards.TabIndex = 5;
            // 
            // Cb_WorkspaceSelection
            // 
            this.Cb_WorkspaceSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_WorkspaceSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cb_WorkspaceSelection.Font = new System.Drawing.Font("Oswald Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Cb_WorkspaceSelection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(173)))), ((int)(((byte)(68)))));
            this.Cb_WorkspaceSelection.FormattingEnabled = true;
            this.Cb_WorkspaceSelection.Location = new System.Drawing.Point(41, 96);
            this.Cb_WorkspaceSelection.Name = "Cb_WorkspaceSelection";
            this.Cb_WorkspaceSelection.Size = new System.Drawing.Size(319, 40);
            this.Cb_WorkspaceSelection.TabIndex = 7;
            this.Cb_WorkspaceSelection.SelectedIndexChanged += new System.EventHandler(this.Cb_WorkspaceSelection_SelectedIndexChanged);
            // 
            // Pb_AddUser
            // 
            this.Pb_AddUser.Image = ((System.Drawing.Image)(resources.GetObject("Pb_AddUser.Image")));
            this.Pb_AddUser.Location = new System.Drawing.Point(1178, 86);
            this.Pb_AddUser.Name = "Pb_AddUser";
            this.Pb_AddUser.Size = new System.Drawing.Size(40, 40);
            this.Pb_AddUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Pb_AddUser.TabIndex = 8;
            this.Pb_AddUser.TabStop = false;
            this.Pb_AddUser.Click += new System.EventHandler(this.Pb_AddUser_Click);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Pb_AddUser);
            this.Controls.Add(this.Cb_WorkspaceSelection);
            this.Controls.Add(this.P_User_Cards);
            this.Controls.Add(this.label1);
            this.Name = "Users";
            this.Size = new System.Drawing.Size(1268, 669);
            this.Load += new System.EventHandler(this.Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pb_AddUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel P_User_Cards;
        private System.Windows.Forms.ComboBox Cb_WorkspaceSelection;
        private System.Windows.Forms.PictureBox Pb_AddUser;
    }
}
