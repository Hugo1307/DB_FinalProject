
namespace BD_FinalProject
{
    partial class GoalPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoalPanel));
            this.Pb_GoalPicture = new System.Windows.Forms.PictureBox();
            this.Lb_GoalDescription = new System.Windows.Forms.Label();
            this.Lb_GoalName = new System.Windows.Forms.Label();
            this.Lb_GoalValue = new System.Windows.Forms.Label();
            this.Pb_DeleteGoal = new System.Windows.Forms.PictureBox();
            this.Pb_ViewGoal = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_GoalPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_DeleteGoal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_ViewGoal)).BeginInit();
            this.SuspendLayout();
            // 
            // Pb_GoalPicture
            // 
            this.Pb_GoalPicture.Image = global::BD_FinalProject.Properties.Resources.user_icon_black;
            this.Pb_GoalPicture.Location = new System.Drawing.Point(75, 26);
            this.Pb_GoalPicture.Name = "Pb_GoalPicture";
            this.Pb_GoalPicture.Size = new System.Drawing.Size(100, 100);
            this.Pb_GoalPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb_GoalPicture.TabIndex = 1;
            this.Pb_GoalPicture.TabStop = false;
            // 
            // Lb_GoalDescription
            // 
            this.Lb_GoalDescription.BackColor = System.Drawing.Color.Transparent;
            this.Lb_GoalDescription.Font = new System.Drawing.Font("Oswald", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lb_GoalDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(173)))), ((int)(((byte)(68)))));
            this.Lb_GoalDescription.Location = new System.Drawing.Point(11, 199);
            this.Lb_GoalDescription.Name = "Lb_GoalDescription";
            this.Lb_GoalDescription.Size = new System.Drawing.Size(226, 72);
            this.Lb_GoalDescription.TabIndex = 8;
            this.Lb_GoalDescription.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque nunc nisi, " +
    "consequat sit amet est sed, consectetur vulputate ligula. Nam id nibh tellus.";
            this.Lb_GoalDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Lb_GoalName
            // 
            this.Lb_GoalName.BackColor = System.Drawing.Color.Transparent;
            this.Lb_GoalName.Font = new System.Drawing.Font("Oswald SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lb_GoalName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(173)))), ((int)(((byte)(68)))));
            this.Lb_GoalName.Location = new System.Drawing.Point(11, 143);
            this.Lb_GoalName.Name = "Lb_GoalName";
            this.Lb_GoalName.Size = new System.Drawing.Size(226, 46);
            this.Lb_GoalName.TabIndex = 7;
            this.Lb_GoalName.Text = "Goal Name";
            this.Lb_GoalName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lb_GoalValue
            // 
            this.Lb_GoalValue.BackColor = System.Drawing.Color.Transparent;
            this.Lb_GoalValue.Font = new System.Drawing.Font("Oswald Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lb_GoalValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(173)))), ((int)(((byte)(68)))));
            this.Lb_GoalValue.Location = new System.Drawing.Point(11, 308);
            this.Lb_GoalValue.Name = "Lb_GoalValue";
            this.Lb_GoalValue.Size = new System.Drawing.Size(226, 35);
            this.Lb_GoalValue.TabIndex = 9;
            this.Lb_GoalValue.Text = " 220 €";
            this.Lb_GoalValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pb_DeleteGoal
            // 
            this.Pb_DeleteGoal.Image = ((System.Drawing.Image)(resources.GetObject("Pb_DeleteGoal.Image")));
            this.Pb_DeleteGoal.Location = new System.Drawing.Point(57, 381);
            this.Pb_DeleteGoal.Name = "Pb_DeleteGoal";
            this.Pb_DeleteGoal.Size = new System.Drawing.Size(50, 50);
            this.Pb_DeleteGoal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb_DeleteGoal.TabIndex = 10;
            this.Pb_DeleteGoal.TabStop = false;
            // 
            // Pb_ViewGoal
            // 
            this.Pb_ViewGoal.Image = ((System.Drawing.Image)(resources.GetObject("Pb_ViewGoal.Image")));
            this.Pb_ViewGoal.Location = new System.Drawing.Point(139, 381);
            this.Pb_ViewGoal.Name = "Pb_ViewGoal";
            this.Pb_ViewGoal.Size = new System.Drawing.Size(50, 50);
            this.Pb_ViewGoal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb_ViewGoal.TabIndex = 11;
            this.Pb_ViewGoal.TabStop = false;
            // 
            // GoalPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Pb_ViewGoal);
            this.Controls.Add(this.Pb_DeleteGoal);
            this.Controls.Add(this.Lb_GoalValue);
            this.Controls.Add(this.Lb_GoalDescription);
            this.Controls.Add(this.Lb_GoalName);
            this.Controls.Add(this.Pb_GoalPicture);
            this.Name = "GoalPanel";
            this.Size = new System.Drawing.Size(250, 450);
            this.Load += new System.EventHandler(this.GoalPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pb_GoalPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_DeleteGoal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_ViewGoal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Pb_GoalPicture;
        private System.Windows.Forms.Label Lb_GoalDescription;
        private System.Windows.Forms.Label Lb_GoalName;
        private System.Windows.Forms.Label Lb_GoalValue;
        private System.Windows.Forms.PictureBox Pb_DeleteGoal;
        private System.Windows.Forms.PictureBox Pb_ViewGoal;
    }
}
