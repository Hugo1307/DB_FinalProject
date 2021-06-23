
namespace BD_FinalProject
{
    partial class AddIncome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddIncome));
            this.label1 = new System.Windows.Forms.Label();
            this.Tb_IncomeName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Tb_IncomeValue = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Dp_Date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Rb_Visible = new System.Windows.Forms.RadioButton();
            this.Rb_Hidden = new System.Windows.Forms.RadioButton();
            this.Btn_AddTransaction = new System.Windows.Forms.Button();
            this.Pb_ChooseDocument = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.P_ChooseUploadFile = new System.Windows.Forms.Panel();
            this.P_UploadFileChosen = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lb_ChosenFilePath = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Tb_Category = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tb_IncomeValue)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_ChooseDocument)).BeginInit();
            this.P_ChooseUploadFile.SuspendLayout();
            this.P_UploadFileChosen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Oswald SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(173)))), ((int)(((byte)(68)))));
            this.label1.Location = new System.Drawing.Point(37, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add Income";
            // 
            // Tb_IncomeName
            // 
            this.Tb_IncomeName.BackColor = System.Drawing.Color.White;
            this.Tb_IncomeName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tb_IncomeName.Font = new System.Drawing.Font("Oswald Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tb_IncomeName.Location = new System.Drawing.Point(44, 137);
            this.Tb_IncomeName.Name = "Tb_IncomeName";
            this.Tb_IncomeName.Size = new System.Drawing.Size(700, 29);
            this.Tb_IncomeName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(37, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(173)))), ((int)(((byte)(68)))));
            this.panel1.Location = new System.Drawing.Point(42, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 33);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(173)))), ((int)(((byte)(68)))));
            this.panel2.Controls.Add(this.Tb_IncomeValue);
            this.panel2.Location = new System.Drawing.Point(41, 216);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(704, 33);
            this.panel2.TabIndex = 8;
            // 
            // Tb_IncomeValue
            // 
            this.Tb_IncomeValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tb_IncomeValue.DecimalPlaces = 2;
            this.Tb_IncomeValue.Font = new System.Drawing.Font("Oswald Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tb_IncomeValue.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Tb_IncomeValue.Location = new System.Drawing.Point(2, 2);
            this.Tb_IncomeValue.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.Tb_IncomeValue.Name = "Tb_IncomeValue";
            this.Tb_IncomeValue.Size = new System.Drawing.Size(699, 29);
            this.Tb_IncomeValue.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(37, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "Value";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(173)))), ((int)(((byte)(68)))));
            this.panel3.Controls.Add(this.Dp_Date);
            this.panel3.Location = new System.Drawing.Point(41, 299);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(704, 33);
            this.panel3.TabIndex = 11;
            // 
            // Dp_Date
            // 
            this.Dp_Date.CalendarFont = new System.Drawing.Font("Oswald", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Dp_Date.Font = new System.Drawing.Font("Oswald Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Dp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dp_Date.Location = new System.Drawing.Point(2, 2);
            this.Dp_Date.Margin = new System.Windows.Forms.Padding(0);
            this.Dp_Date.Name = "Dp_Date";
            this.Dp_Date.Size = new System.Drawing.Size(700, 29);
            this.Dp_Date.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(37, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 27);
            this.label4.TabIndex = 10;
            this.label4.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(37, 466);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 27);
            this.label5.TabIndex = 12;
            this.label5.Text = "Visibility";
            // 
            // Rb_Visible
            // 
            this.Rb_Visible.AutoSize = true;
            this.Rb_Visible.Checked = true;
            this.Rb_Visible.Font = new System.Drawing.Font("Oswald", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Rb_Visible.ForeColor = System.Drawing.Color.Black;
            this.Rb_Visible.Location = new System.Drawing.Point(41, 506);
            this.Rb_Visible.Name = "Rb_Visible";
            this.Rb_Visible.Size = new System.Drawing.Size(66, 30);
            this.Rb_Visible.TabIndex = 13;
            this.Rb_Visible.TabStop = true;
            this.Rb_Visible.Text = "Visible";
            this.Rb_Visible.UseVisualStyleBackColor = true;
            // 
            // Rb_Hidden
            // 
            this.Rb_Hidden.AutoSize = true;
            this.Rb_Hidden.Font = new System.Drawing.Font("Oswald", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Rb_Hidden.ForeColor = System.Drawing.Color.Black;
            this.Rb_Hidden.Location = new System.Drawing.Point(122, 506);
            this.Rb_Hidden.Name = "Rb_Hidden";
            this.Rb_Hidden.Size = new System.Drawing.Size(68, 30);
            this.Rb_Hidden.TabIndex = 14;
            this.Rb_Hidden.Text = "Hidden";
            this.Rb_Hidden.UseVisualStyleBackColor = true;
            // 
            // Btn_AddTransaction
            // 
            this.Btn_AddTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(173)))), ((int)(((byte)(68)))));
            this.Btn_AddTransaction.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(173)))), ((int)(((byte)(68)))));
            this.Btn_AddTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_AddTransaction.Font = new System.Drawing.Font("Oswald", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_AddTransaction.ForeColor = System.Drawing.Color.White;
            this.Btn_AddTransaction.Location = new System.Drawing.Point(33, 580);
            this.Btn_AddTransaction.Name = "Btn_AddTransaction";
            this.Btn_AddTransaction.Size = new System.Drawing.Size(245, 42);
            this.Btn_AddTransaction.TabIndex = 16;
            this.Btn_AddTransaction.Text = "Add Income";
            this.Btn_AddTransaction.UseVisualStyleBackColor = false;
            this.Btn_AddTransaction.Click += new System.EventHandler(this.Btn_AddTransaction_Click);
            // 
            // Pb_ChooseDocument
            // 
            this.Pb_ChooseDocument.Image = ((System.Drawing.Image)(resources.GetObject("Pb_ChooseDocument.Image")));
            this.Pb_ChooseDocument.Location = new System.Drawing.Point(15, 18);
            this.Pb_ChooseDocument.Name = "Pb_ChooseDocument";
            this.Pb_ChooseDocument.Size = new System.Drawing.Size(46, 46);
            this.Pb_ChooseDocument.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb_ChooseDocument.TabIndex = 17;
            this.Pb_ChooseDocument.TabStop = false;
            this.Pb_ChooseDocument.Click += new System.EventHandler(this.Pb_ChooseDocument_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(173)))), ((int)(((byte)(68)))));
            this.label6.Location = new System.Drawing.Point(73, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 32);
            this.label6.TabIndex = 18;
            this.label6.Text = "Choose File...";
            // 
            // P_ChooseUploadFile
            // 
            this.P_ChooseUploadFile.BackColor = System.Drawing.Color.Transparent;
            this.P_ChooseUploadFile.Controls.Add(this.Pb_ChooseDocument);
            this.P_ChooseUploadFile.Controls.Add(this.label6);
            this.P_ChooseUploadFile.Location = new System.Drawing.Point(233, 463);
            this.P_ChooseUploadFile.Name = "P_ChooseUploadFile";
            this.P_ChooseUploadFile.Size = new System.Drawing.Size(450, 79);
            this.P_ChooseUploadFile.TabIndex = 19;
            // 
            // P_UploadFileChosen
            // 
            this.P_UploadFileChosen.Controls.Add(this.pictureBox1);
            this.P_UploadFileChosen.Controls.Add(this.Lb_ChosenFilePath);
            this.P_UploadFileChosen.Location = new System.Drawing.Point(233, 463);
            this.P_UploadFileChosen.Name = "P_UploadFileChosen";
            this.P_UploadFileChosen.Size = new System.Drawing.Size(450, 79);
            this.P_UploadFileChosen.TabIndex = 20;
            this.P_UploadFileChosen.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // Lb_ChosenFilePath
            // 
            this.Lb_ChosenFilePath.AutoSize = true;
            this.Lb_ChosenFilePath.BackColor = System.Drawing.Color.Transparent;
            this.Lb_ChosenFilePath.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lb_ChosenFilePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(173)))), ((int)(((byte)(68)))));
            this.Lb_ChosenFilePath.Location = new System.Drawing.Point(79, 26);
            this.Lb_ChosenFilePath.Name = "Lb_ChosenFilePath";
            this.Lb_ChosenFilePath.Size = new System.Drawing.Size(102, 32);
            this.Lb_ChosenFilePath.TabIndex = 19;
            this.Lb_ChosenFilePath.Text = "Choose File...";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(173)))), ((int)(((byte)(68)))));
            this.panel4.Controls.Add(this.Tb_Category);
            this.panel4.Location = new System.Drawing.Point(40, 385);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(704, 33);
            this.panel4.TabIndex = 14;
            // 
            // Tb_Category
            // 
            this.Tb_Category.BackColor = System.Drawing.Color.White;
            this.Tb_Category.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tb_Category.Font = new System.Drawing.Font("Oswald Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tb_Category.Location = new System.Drawing.Point(2, 2);
            this.Tb_Category.Name = "Tb_Category";
            this.Tb_Category.Size = new System.Drawing.Size(700, 29);
            this.Tb_Category.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(37, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 27);
            this.label7.TabIndex = 13;
            this.label7.Text = "Category";
            // 
            // AddIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Btn_AddTransaction);
            this.Controls.Add(this.Rb_Hidden);
            this.Controls.Add(this.Rb_Visible);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Tb_IncomeName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.P_ChooseUploadFile);
            this.Controls.Add(this.P_UploadFileChosen);
            this.Name = "AddIncome";
            this.Size = new System.Drawing.Size(1268, 669);
            this.Load += new System.EventHandler(this.AddIncome_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Tb_IncomeValue)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pb_ChooseDocument)).EndInit();
            this.P_ChooseUploadFile.ResumeLayout(false);
            this.P_ChooseUploadFile.PerformLayout();
            this.P_UploadFileChosen.ResumeLayout(false);
            this.P_UploadFileChosen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tb_IncomeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker Dp_Date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton Rb_Visible;
        private System.Windows.Forms.RadioButton Rb_Hidden;
        private System.Windows.Forms.Button Btn_AddTransaction;
        private System.Windows.Forms.PictureBox Pb_ChooseDocument;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel P_ChooseUploadFile;
        private System.Windows.Forms.Panel P_UploadFileChosen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Lb_ChosenFilePath;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox Tb_Category;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown Tb_IncomeValue;
    }
}
