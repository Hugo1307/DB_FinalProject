
namespace BD_FinalProject
{
    partial class CreateWorkspacePopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateWorkspacePopup));
            this.Lb_Title = new System.Windows.Forms.Label();
            this.Pb_Close = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Tb_WorkspaceName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Btn_CreateUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Close)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lb_Title
            // 
            this.Lb_Title.BackColor = System.Drawing.Color.Transparent;
            this.Lb_Title.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lb_Title.ForeColor = System.Drawing.Color.White;
            this.Lb_Title.Location = new System.Drawing.Point(13, 13);
            this.Lb_Title.Name = "Lb_Title";
            this.Lb_Title.Size = new System.Drawing.Size(359, 32);
            this.Lb_Title.TabIndex = 13;
            this.Lb_Title.Text = "Create Workspace";
            // 
            // Pb_Close
            // 
            this.Pb_Close.Image = ((System.Drawing.Image)(resources.GetObject("Pb_Close.Image")));
            this.Pb_Close.Location = new System.Drawing.Point(382, 11);
            this.Pb_Close.Name = "Pb_Close";
            this.Pb_Close.Size = new System.Drawing.Size(36, 36);
            this.Pb_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb_Close.TabIndex = 0;
            this.Pb_Close.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(133)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Lb_Title);
            this.panel1.Controls.Add(this.Pb_Close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 61);
            this.panel1.TabIndex = 1;
            // 
            // Tb_WorkspaceName
            // 
            this.Tb_WorkspaceName.BackColor = System.Drawing.Color.White;
            this.Tb_WorkspaceName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tb_WorkspaceName.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tb_WorkspaceName.Location = new System.Drawing.Point(26, 51);
            this.Tb_WorkspaceName.Name = "Tb_WorkspaceName";
            this.Tb_WorkspaceName.Size = new System.Drawing.Size(382, 29);
            this.Tb_WorkspaceName.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(133)))));
            this.panel2.Location = new System.Drawing.Point(24, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 33);
            this.panel2.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.Btn_CreateUser);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.Tb_WorkspaceName);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(0, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(434, 170);
            this.panel3.TabIndex = 15;
            // 
            // Btn_CreateUser
            // 
            this.Btn_CreateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(133)))));
            this.Btn_CreateUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(133)))));
            this.Btn_CreateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_CreateUser.Font = new System.Drawing.Font("Oswald", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_CreateUser.ForeColor = System.Drawing.Color.White;
            this.Btn_CreateUser.Location = new System.Drawing.Point(23, 105);
            this.Btn_CreateUser.Name = "Btn_CreateUser";
            this.Btn_CreateUser.Size = new System.Drawing.Size(182, 38);
            this.Btn_CreateUser.TabIndex = 19;
            this.Btn_CreateUser.Text = "Create Workspace";
            this.Btn_CreateUser.UseVisualStyleBackColor = false;
            this.Btn_CreateUser.Click += new System.EventHandler(this.Btn_CreateUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Oswald", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "Workspace name";
            // 
            // CreateWorkspacePopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 230);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateWorkspacePopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateWorkspacePopup";
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Close)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lb_Title;
        private System.Windows.Forms.PictureBox Pb_Close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Tb_WorkspaceName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_CreateUser;
    }
}