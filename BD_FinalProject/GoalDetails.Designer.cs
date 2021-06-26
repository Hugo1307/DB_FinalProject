
namespace BD_FinalProject
{
    partial class GoalDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoalDetails));
            this.label1 = new System.Windows.Forms.Label();
            this.Lb_GoalName = new System.Windows.Forms.Label();
            this.Pb_GoalImage = new System.Windows.Forms.PictureBox();
            this.Btn_AddTransaction = new System.Windows.Forms.Button();
            this.Pb_DecreaseGoalBalance = new System.Windows.Forms.PictureBox();
            this.Pb_IncreaseGoalBalance = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Lb_GoalValue = new System.Windows.Forms.Label();
            this.Lb_GoalDeadline = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_ApplyChanges = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Tb_GoalDescription = new System.Windows.Forms.TextBox();
            this.Pb_EditGoalDescription = new System.Windows.Forms.PictureBox();
            this.Tb_GoalBalance = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_GoalImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_DecreaseGoalBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_IncreaseGoalBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_EditGoalDescription)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(149, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "Goal Details";
            // 
            // Lb_GoalName
            // 
            this.Lb_GoalName.AutoSize = true;
            this.Lb_GoalName.BackColor = System.Drawing.Color.Transparent;
            this.Lb_GoalName.Font = new System.Drawing.Font("Oswald Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lb_GoalName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(173)))), ((int)(((byte)(68)))));
            this.Lb_GoalName.Location = new System.Drawing.Point(40, 116);
            this.Lb_GoalName.Name = "Lb_GoalName";
            this.Lb_GoalName.Size = new System.Drawing.Size(143, 36);
            this.Lb_GoalName.TabIndex = 20;
            this.Lb_GoalName.Text = "First Workspace";
            // 
            // Pb_GoalImage
            // 
            this.Pb_GoalImage.Image = global::BD_FinalProject.Properties.Resources.goal_icon_black_xl;
            this.Pb_GoalImage.Location = new System.Drawing.Point(75, 175);
            this.Pb_GoalImage.Name = "Pb_GoalImage";
            this.Pb_GoalImage.Size = new System.Drawing.Size(156, 156);
            this.Pb_GoalImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb_GoalImage.TabIndex = 27;
            this.Pb_GoalImage.TabStop = false;
            // 
            // Btn_AddTransaction
            // 
            this.Btn_AddTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(173)))), ((int)(((byte)(68)))));
            this.Btn_AddTransaction.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(173)))), ((int)(((byte)(68)))));
            this.Btn_AddTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_AddTransaction.Font = new System.Drawing.Font("Oswald", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_AddTransaction.ForeColor = System.Drawing.Color.White;
            this.Btn_AddTransaction.Location = new System.Drawing.Point(970, 588);
            this.Btn_AddTransaction.Name = "Btn_AddTransaction";
            this.Btn_AddTransaction.Size = new System.Drawing.Size(245, 42);
            this.Btn_AddTransaction.TabIndex = 31;
            this.Btn_AddTransaction.Text = "Delete Goal";
            this.Btn_AddTransaction.UseVisualStyleBackColor = false;
            // 
            // Pb_DecreaseGoalBalance
            // 
            this.Pb_DecreaseGoalBalance.Image = ((System.Drawing.Image)(resources.GetObject("Pb_DecreaseGoalBalance.Image")));
            this.Pb_DecreaseGoalBalance.Location = new System.Drawing.Point(45, 401);
            this.Pb_DecreaseGoalBalance.Name = "Pb_DecreaseGoalBalance";
            this.Pb_DecreaseGoalBalance.Size = new System.Drawing.Size(46, 46);
            this.Pb_DecreaseGoalBalance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb_DecreaseGoalBalance.TabIndex = 32;
            this.Pb_DecreaseGoalBalance.TabStop = false;
            this.Pb_DecreaseGoalBalance.Click += new System.EventHandler(this.Pb_DecreaseGoalBalance_Click);
            // 
            // Pb_IncreaseGoalBalance
            // 
            this.Pb_IncreaseGoalBalance.Image = ((System.Drawing.Image)(resources.GetObject("Pb_IncreaseGoalBalance.Image")));
            this.Pb_IncreaseGoalBalance.Location = new System.Drawing.Point(195, 401);
            this.Pb_IncreaseGoalBalance.Name = "Pb_IncreaseGoalBalance";
            this.Pb_IncreaseGoalBalance.Size = new System.Drawing.Size(46, 46);
            this.Pb_IncreaseGoalBalance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb_IncreaseGoalBalance.TabIndex = 33;
            this.Pb_IncreaseGoalBalance.TabStop = false;
            this.Pb_IncreaseGoalBalance.Click += new System.EventHandler(this.Pb_IncreaseGoalBalance_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(40, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 32);
            this.label5.TabIndex = 34;
            this.label5.Text = "Goal Balance";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(40, 468);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 32);
            this.label8.TabIndex = 36;
            this.label8.Text = "Goal Value";
            // 
            // Lb_GoalValue
            // 
            this.Lb_GoalValue.AutoSize = true;
            this.Lb_GoalValue.BackColor = System.Drawing.Color.Transparent;
            this.Lb_GoalValue.Font = new System.Drawing.Font("Oswald Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lb_GoalValue.ForeColor = System.Drawing.Color.Black;
            this.Lb_GoalValue.Location = new System.Drawing.Point(42, 511);
            this.Lb_GoalValue.Name = "Lb_GoalValue";
            this.Lb_GoalValue.Size = new System.Drawing.Size(63, 24);
            this.Lb_GoalValue.TabIndex = 37;
            this.Lb_GoalValue.Text = "250,00 €";
            // 
            // Lb_GoalDeadline
            // 
            this.Lb_GoalDeadline.AutoSize = true;
            this.Lb_GoalDeadline.BackColor = System.Drawing.Color.Transparent;
            this.Lb_GoalDeadline.Font = new System.Drawing.Font("Oswald Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lb_GoalDeadline.ForeColor = System.Drawing.Color.Black;
            this.Lb_GoalDeadline.Location = new System.Drawing.Point(42, 597);
            this.Lb_GoalDeadline.Name = "Lb_GoalDeadline";
            this.Lb_GoalDeadline.Size = new System.Drawing.Size(76, 24);
            this.Lb_GoalDeadline.TabIndex = 39;
            this.Lb_GoalDeadline.Text = "24/06/2021";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(40, 554);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 32);
            this.label10.TabIndex = 38;
            this.label10.Text = "Goal Deadline";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(296, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 32);
            this.label4.TabIndex = 40;
            this.label4.Text = "Goal Description";
            // 
            // Btn_ApplyChanges
            // 
            this.Btn_ApplyChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(173)))), ((int)(((byte)(68)))));
            this.Btn_ApplyChanges.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(173)))), ((int)(((byte)(68)))));
            this.Btn_ApplyChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ApplyChanges.Font = new System.Drawing.Font("Oswald", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_ApplyChanges.ForeColor = System.Drawing.Color.White;
            this.Btn_ApplyChanges.Location = new System.Drawing.Point(700, 588);
            this.Btn_ApplyChanges.Name = "Btn_ApplyChanges";
            this.Btn_ApplyChanges.Size = new System.Drawing.Size(245, 42);
            this.Btn_ApplyChanges.TabIndex = 41;
            this.Btn_ApplyChanges.Text = "Apply Changes";
            this.Btn_ApplyChanges.UseVisualStyleBackColor = false;
            this.Btn_ApplyChanges.Visible = false;
            this.Btn_ApplyChanges.Click += new System.EventHandler(this.Btn_ApplyChanges_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Oswald Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(261, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(806, 110);
            this.label2.TabIndex = 28;
            this.label2.Text = "Here is the goal description";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(408, 427);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 42;
            // 
            // Tb_GoalDescription
            // 
            this.Tb_GoalDescription.BackColor = System.Drawing.Color.White;
            this.Tb_GoalDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tb_GoalDescription.Font = new System.Drawing.Font("Oswald Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tb_GoalDescription.Location = new System.Drawing.Point(301, 221);
            this.Tb_GoalDescription.Multiline = true;
            this.Tb_GoalDescription.Name = "Tb_GoalDescription";
            this.Tb_GoalDescription.Size = new System.Drawing.Size(914, 110);
            this.Tb_GoalDescription.TabIndex = 42;
            this.Tb_GoalDescription.Text = "Here is the goal description";
            // 
            // Pb_EditGoalDescription
            // 
            this.Pb_EditGoalDescription.Image = ((System.Drawing.Image)(resources.GetObject("Pb_EditGoalDescription.Image")));
            this.Pb_EditGoalDescription.Location = new System.Drawing.Point(1183, 337);
            this.Pb_EditGoalDescription.Name = "Pb_EditGoalDescription";
            this.Pb_EditGoalDescription.Size = new System.Drawing.Size(32, 32);
            this.Pb_EditGoalDescription.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb_EditGoalDescription.TabIndex = 43;
            this.Pb_EditGoalDescription.TabStop = false;
            this.Pb_EditGoalDescription.Click += new System.EventHandler(this.Pb_EditGoalDescription_Click);
            // 
            // Tb_GoalBalance
            // 
            this.Tb_GoalBalance.BackColor = System.Drawing.Color.White;
            this.Tb_GoalBalance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tb_GoalBalance.Font = new System.Drawing.Font("Oswald Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Tb_GoalBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(173)))), ((int)(((byte)(68)))));
            this.Tb_GoalBalance.Location = new System.Drawing.Point(100, 408);
            this.Tb_GoalBalance.Name = "Tb_GoalBalance";
            this.Tb_GoalBalance.Size = new System.Drawing.Size(92, 30);
            this.Tb_GoalBalance.TabIndex = 44;
            this.Tb_GoalBalance.Text = "25,00 €";
            this.Tb_GoalBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GoalDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Tb_GoalBalance);
            this.Controls.Add(this.Pb_EditGoalDescription);
            this.Controls.Add(this.Btn_ApplyChanges);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Lb_GoalDeadline);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Lb_GoalValue);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Pb_IncreaseGoalBalance);
            this.Controls.Add(this.Pb_DecreaseGoalBalance);
            this.Controls.Add(this.Btn_AddTransaction);
            this.Controls.Add(this.Pb_GoalImage);
            this.Controls.Add(this.Lb_GoalName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tb_GoalDescription);
            this.Name = "GoalDetails";
            this.Size = new System.Drawing.Size(1268, 669);
            this.Load += new System.EventHandler(this.GoalDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pb_GoalImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_DecreaseGoalBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_IncreaseGoalBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_EditGoalDescription)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lb_GoalName;
        private System.Windows.Forms.PictureBox Pb_GoalImage;
        private System.Windows.Forms.Button Btn_AddTransaction;
        private System.Windows.Forms.PictureBox Pb_DecreaseGoalBalance;
        private System.Windows.Forms.PictureBox Pb_IncreaseGoalBalance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Lb_GoalValue;
        private System.Windows.Forms.Label Lb_GoalDeadline;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_ApplyChanges;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox Tb_GoalDescription;
        private System.Windows.Forms.PictureBox Pb_EditGoalDescription;
        private System.Windows.Forms.TextBox Tb_GoalBalance;
    }
}
