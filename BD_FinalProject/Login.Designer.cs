
namespace BD_FinalProject
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lb_LoginResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Tb_Email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Lb_Register = new System.Windows.Forms.Label();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Tb_Password = new System.Windows.Forms.TextBox();
            this.Timer_Result = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(133)))));
            this.panel1.Controls.Add(this.Lb_LoginResult);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 168);
            this.panel1.TabIndex = 0;
            // 
            // Lb_LoginResult
            // 
            this.Lb_LoginResult.Font = new System.Drawing.Font("Oswald", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lb_LoginResult.ForeColor = System.Drawing.Color.White;
            this.Lb_LoginResult.Location = new System.Drawing.Point(12, 118);
            this.Lb_LoginResult.Name = "Lb_LoginResult";
            this.Lb_LoginResult.Size = new System.Drawing.Size(326, 22);
            this.Lb_LoginResult.TabIndex = 1;
            this.Lb_LoginResult.Text = "Login";
            this.Lb_LoginResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lb_LoginResult.Visible = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Oswald", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tb_Email
            // 
            this.Tb_Email.BackColor = System.Drawing.Color.White;
            this.Tb_Email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tb_Email.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tb_Email.Location = new System.Drawing.Point(29, 57);
            this.Tb_Email.Name = "Tb_Email";
            this.Tb_Email.Size = new System.Drawing.Size(288, 24);
            this.Tb_Email.TabIndex = 1;
            this.Tb_Email.Text = "hugogoncalves13@ua.pt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Oswald", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(26, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.Lb_Register);
            this.panel2.Controls.Add(this.Btn_Login);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Tb_Password);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Tb_Email);
            this.panel2.Location = new System.Drawing.Point(0, 164);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 288);
            this.panel2.TabIndex = 1;
            // 
            // Lb_Register
            // 
            this.Lb_Register.AutoSize = true;
            this.Lb_Register.Font = new System.Drawing.Font("Oswald", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lb_Register.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Lb_Register.Location = new System.Drawing.Point(148, 240);
            this.Lb_Register.Name = "Lb_Register";
            this.Lb_Register.Size = new System.Drawing.Size(51, 20);
            this.Lb_Register.TabIndex = 6;
            this.Lb_Register.Text = "Register";
            this.Lb_Register.Click += new System.EventHandler(this.Lb_Register_Click);
            // 
            // Btn_Login
            // 
            this.Btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(133)))));
            this.Btn_Login.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(133)))));
            this.Btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Login.Font = new System.Drawing.Font("Oswald", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Login.Location = new System.Drawing.Point(128, 175);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(94, 42);
            this.Btn_Login.TabIndex = 5;
            this.Btn_Login.Text = "Login";
            this.Btn_Login.UseVisualStyleBackColor = false;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Oswald", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(26, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // Tb_Password
            // 
            this.Tb_Password.BackColor = System.Drawing.Color.White;
            this.Tb_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tb_Password.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tb_Password.Location = new System.Drawing.Point(29, 119);
            this.Tb_Password.Name = "Tb_Password";
            this.Tb_Password.Size = new System.Drawing.Size(288, 24);
            this.Tb_Password.TabIndex = 3;
            this.Tb_Password.Text = "test@ua";
            this.Tb_Password.UseSystemPasswordChar = true;
            // 
            // Timer_Result
            // 
            this.Timer_Result.Interval = 3000;
            this.Timer_Result.Tick += new System.EventHandler(this.Timer_Result_Tick);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tb_Email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Lb_Register;
        private System.Windows.Forms.Button Btn_Login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Tb_Password;
        private System.Windows.Forms.Label Lb_LoginResult;
        private System.Windows.Forms.Timer Timer_Result;
    }
}