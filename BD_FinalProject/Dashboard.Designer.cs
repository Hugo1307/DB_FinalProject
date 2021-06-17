
namespace BD_FinalProject
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Pb_AddTransaction = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_AddTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(133)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Pb_AddTransaction);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(51, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 307);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Oswald", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quick Actions";
            // 
            // Pb_AddTransaction
            // 
            this.Pb_AddTransaction.Image = ((System.Drawing.Image)(resources.GetObject("Pb_AddTransaction.Image")));
            this.Pb_AddTransaction.Location = new System.Drawing.Point(54, 95);
            this.Pb_AddTransaction.Name = "Pb_AddTransaction";
            this.Pb_AddTransaction.Size = new System.Drawing.Size(64, 64);
            this.Pb_AddTransaction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb_AddTransaction.TabIndex = 4;
            this.Pb_AddTransaction.TabStop = false;
            this.Pb_AddTransaction.Click += new System.EventHandler(this.Pb_AddTransaction_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Oswald", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(33, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Add Transaction";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(1268, 669);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_AddTransaction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Pb_AddTransaction;
        private System.Windows.Forms.Label label1;
    }
}
