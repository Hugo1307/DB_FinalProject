
namespace BD_FinalProject
{
    partial class CustomTextBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomTextBox));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lb_Title = new System.Windows.Forms.Label();
            this.Pb_Close = new System.Windows.Forms.PictureBox();
            this.Lb_Body = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Close)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(450, 61);
            this.panel1.TabIndex = 0;
            // 
            // Lb_Title
            // 
            this.Lb_Title.BackColor = System.Drawing.Color.Transparent;
            this.Lb_Title.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lb_Title.ForeColor = System.Drawing.Color.White;
            this.Lb_Title.Location = new System.Drawing.Point(13, 15);
            this.Lb_Title.Name = "Lb_Title";
            this.Lb_Title.Size = new System.Drawing.Size(376, 32);
            this.Lb_Title.TabIndex = 13;
            this.Lb_Title.Text = "Visibility";
            // 
            // Pb_Close
            // 
            this.Pb_Close.Image = ((System.Drawing.Image)(resources.GetObject("Pb_Close.Image")));
            this.Pb_Close.Location = new System.Drawing.Point(400, 12);
            this.Pb_Close.Name = "Pb_Close";
            this.Pb_Close.Size = new System.Drawing.Size(36, 36);
            this.Pb_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb_Close.TabIndex = 0;
            this.Pb_Close.TabStop = false;
            this.Pb_Close.Click += new System.EventHandler(this.Pb_Close_Click);
            // 
            // Lb_Body
            // 
            this.Lb_Body.BackColor = System.Drawing.Color.Transparent;
            this.Lb_Body.Font = new System.Drawing.Font("Oswald", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lb_Body.ForeColor = System.Drawing.Color.Black;
            this.Lb_Body.Location = new System.Drawing.Point(16, 79);
            this.Lb_Body.Name = "Lb_Body";
            this.Lb_Body.Size = new System.Drawing.Size(418, 145);
            this.Lb_Body.TabIndex = 14;
            this.Lb_Body.Text = "Visibility";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 190);
            this.panel2.TabIndex = 15;
            // 
            // CustomTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(450, 250);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Lb_Body);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomTextBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomTextBox";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Pb_Close;
        private System.Windows.Forms.Label Lb_Title;
        private System.Windows.Forms.Label Lb_Body;
        private System.Windows.Forms.Panel panel2;
    }
}