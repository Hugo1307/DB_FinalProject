
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
            this.Pb_CheckHistory = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Pb_AddTransaction = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Pb_RefreshWorkspaces = new System.Windows.Forms.PictureBox();
            this.Pb_AddWorkspace = new System.Windows.Forms.PictureBox();
            this.Lbx_AllWorkspaces = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_CheckHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_AddTransaction)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_RefreshWorkspaces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_AddWorkspace)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(133)))));
            this.panel1.Controls.Add(this.Pb_CheckHistory);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Pb_AddTransaction);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(51, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 235);
            this.panel1.TabIndex = 0;
            // 
            // Pb_CheckHistory
            // 
            this.Pb_CheckHistory.Image = ((System.Drawing.Image)(resources.GetObject("Pb_CheckHistory.Image")));
            this.Pb_CheckHistory.Location = new System.Drawing.Point(182, 95);
            this.Pb_CheckHistory.Name = "Pb_CheckHistory";
            this.Pb_CheckHistory.Size = new System.Drawing.Size(62, 62);
            this.Pb_CheckHistory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb_CheckHistory.TabIndex = 8;
            this.Pb_CheckHistory.TabStop = false;
            this.Pb_CheckHistory.Click += new System.EventHandler(this.Pb_CheckHistory_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Oswald ExtraLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(164, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "Check History";
            // 
            // Pb_AddTransaction
            // 
            this.Pb_AddTransaction.Image = ((System.Drawing.Image)(resources.GetObject("Pb_AddTransaction.Image")));
            this.Pb_AddTransaction.Location = new System.Drawing.Point(52, 95);
            this.Pb_AddTransaction.Name = "Pb_AddTransaction";
            this.Pb_AddTransaction.Size = new System.Drawing.Size(62, 62);
            this.Pb_AddTransaction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb_AddTransaction.TabIndex = 6;
            this.Pb_AddTransaction.TabStop = false;
            this.Pb_AddTransaction.Click += new System.EventHandler(this.Pb_AddTransaction_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Oswald ExtraLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(42, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "Add Income";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Oswald SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quick Actions";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(133)))));
            this.panel2.Controls.Add(this.Pb_RefreshWorkspaces);
            this.panel2.Controls.Add(this.Pb_AddWorkspace);
            this.panel2.Controls.Add(this.Lbx_AllWorkspaces);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(717, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(490, 558);
            this.panel2.TabIndex = 6;
            // 
            // Pb_RefreshWorkspaces
            // 
            this.Pb_RefreshWorkspaces.Image = ((System.Drawing.Image)(resources.GetObject("Pb_RefreshWorkspaces.Image")));
            this.Pb_RefreshWorkspaces.Location = new System.Drawing.Point(377, 29);
            this.Pb_RefreshWorkspaces.Name = "Pb_RefreshWorkspaces";
            this.Pb_RefreshWorkspaces.Size = new System.Drawing.Size(36, 36);
            this.Pb_RefreshWorkspaces.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Pb_RefreshWorkspaces.TabIndex = 6;
            this.Pb_RefreshWorkspaces.TabStop = false;
            this.Pb_RefreshWorkspaces.Click += new System.EventHandler(this.Pb_RefreshWorkspaces_Click);
            // 
            // Pb_AddWorkspace
            // 
            this.Pb_AddWorkspace.Image = ((System.Drawing.Image)(resources.GetObject("Pb_AddWorkspace.Image")));
            this.Pb_AddWorkspace.Location = new System.Drawing.Point(423, 29);
            this.Pb_AddWorkspace.Name = "Pb_AddWorkspace";
            this.Pb_AddWorkspace.Size = new System.Drawing.Size(36, 36);
            this.Pb_AddWorkspace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Pb_AddWorkspace.TabIndex = 5;
            this.Pb_AddWorkspace.TabStop = false;
            this.Pb_AddWorkspace.Click += new System.EventHandler(this.Pb_AddWorkspace_Click);
            // 
            // Lbx_AllWorkspaces
            // 
            this.Lbx_AllWorkspaces.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(133)))));
            this.Lbx_AllWorkspaces.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Lbx_AllWorkspaces.Font = new System.Drawing.Font("Oswald Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbx_AllWorkspaces.ForeColor = System.Drawing.Color.White;
            this.Lbx_AllWorkspaces.FormattingEnabled = true;
            this.Lbx_AllWorkspaces.ItemHeight = 22;
            this.Lbx_AllWorkspaces.Location = new System.Drawing.Point(30, 90);
            this.Lbx_AllWorkspaces.Name = "Lbx_AllWorkspaces";
            this.Lbx_AllWorkspaces.Size = new System.Drawing.Size(429, 440);
            this.Lbx_AllWorkspaces.TabIndex = 4;
            this.Lbx_AllWorkspaces.SelectedIndexChanged += new System.EventHandler(this.Lbx_AllWorkspaces_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Oswald SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(25, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 41);
            this.label4.TabIndex = 3;
            this.label4.Text = "Workspaces";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(1268, 669);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_CheckHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_AddTransaction)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_RefreshWorkspaces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_AddWorkspace)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox Lbx_AllWorkspaces;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox Pb_AddTransaction;
        private System.Windows.Forms.PictureBox Pb_AddWorkspace;
        private System.Windows.Forms.PictureBox Pb_RefreshWorkspaces;
        private System.Windows.Forms.PictureBox Pb_CheckHistory;
        private System.Windows.Forms.Label label3;
    }
}
