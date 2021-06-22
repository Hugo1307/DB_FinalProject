
namespace BD_FinalProject
{
    partial class UserPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPanel));
            this.Pb_UserPicture = new System.Windows.Forms.PictureBox();
            this.Lb_UserName = new System.Windows.Forms.Label();
            this.Lb_UserEmail = new System.Windows.Forms.Label();
            this.Pb_DeleteUser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_UserPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_DeleteUser)).BeginInit();
            this.SuspendLayout();
            // 
            // Pb_UserPicture
            // 
            this.Pb_UserPicture.Image = global::BD_FinalProject.Properties.Resources.user_icon_black;
            this.Pb_UserPicture.Location = new System.Drawing.Point(75, 52);
            this.Pb_UserPicture.Name = "Pb_UserPicture";
            this.Pb_UserPicture.Size = new System.Drawing.Size(100, 100);
            this.Pb_UserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb_UserPicture.TabIndex = 0;
            this.Pb_UserPicture.TabStop = false;
            // 
            // Lb_UserName
            // 
            this.Lb_UserName.BackColor = System.Drawing.Color.Transparent;
            this.Lb_UserName.Font = new System.Drawing.Font("Oswald SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lb_UserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(173)))), ((int)(((byte)(68)))));
            this.Lb_UserName.Location = new System.Drawing.Point(0, 171);
            this.Lb_UserName.Name = "Lb_UserName";
            this.Lb_UserName.Size = new System.Drawing.Size(250, 46);
            this.Lb_UserName.TabIndex = 5;
            this.Lb_UserName.Text = "Users";
            this.Lb_UserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lb_UserEmail
            // 
            this.Lb_UserEmail.BackColor = System.Drawing.Color.Transparent;
            this.Lb_UserEmail.Font = new System.Drawing.Font("Oswald Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lb_UserEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(173)))), ((int)(((byte)(68)))));
            this.Lb_UserEmail.Location = new System.Drawing.Point(0, 222);
            this.Lb_UserEmail.Name = "Lb_UserEmail";
            this.Lb_UserEmail.Size = new System.Drawing.Size(250, 35);
            this.Lb_UserEmail.TabIndex = 6;
            this.Lb_UserEmail.Text = "First Workspace";
            this.Lb_UserEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pb_DeleteUser
            // 
            this.Pb_DeleteUser.Image = ((System.Drawing.Image)(resources.GetObject("Pb_DeleteUser.Image")));
            this.Pb_DeleteUser.Location = new System.Drawing.Point(100, 350);
            this.Pb_DeleteUser.Name = "Pb_DeleteUser";
            this.Pb_DeleteUser.Size = new System.Drawing.Size(50, 50);
            this.Pb_DeleteUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb_DeleteUser.TabIndex = 7;
            this.Pb_DeleteUser.TabStop = false;
            // 
            // UserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Pb_DeleteUser);
            this.Controls.Add(this.Lb_UserEmail);
            this.Controls.Add(this.Lb_UserName);
            this.Controls.Add(this.Pb_UserPicture);
            this.Name = "UserPanel";
            this.Size = new System.Drawing.Size(250, 450);
            this.Load += new System.EventHandler(this.UserPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pb_UserPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_DeleteUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Pb_UserPicture;
        private System.Windows.Forms.Label Lb_UserName;
        private System.Windows.Forms.Label Lb_UserEmail;
        private System.Windows.Forms.PictureBox Pb_DeleteUser;
    }
}
