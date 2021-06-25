
namespace BD_FinalProject
{
    partial class History
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(History));
            this.label1 = new System.Windows.Forms.Label();
            this.Cb_WorkspaceSelection = new System.Windows.Forms.ComboBox();
            this.Lbx_HistoryItems = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Dp_StartDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Dp_EndDate = new System.Windows.Forms.DateTimePicker();
            this.Btn_ApplyFilters = new System.Windows.Forms.Button();
            this.P_HistoryDetails = new System.Windows.Forms.Panel();
            this.Lb_ActionUser = new System.Windows.Forms.Label();
            this.Lb_ActionDate = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_OpenDocument = new System.Windows.Forms.Button();
            this.Lb_DocumentValue = new System.Windows.Forms.Label();
            this.Lb_DocumentDate = new System.Windows.Forms.Label();
            this.Lb_DocumentName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Lb_ActionType = new System.Windows.Forms.Label();
            this.Pb_ActionType = new System.Windows.Forms.PictureBox();
            this.P_HistoryDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_ActionType)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(98, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "History";
            // 
            // Cb_WorkspaceSelection
            // 
            this.Cb_WorkspaceSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_WorkspaceSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cb_WorkspaceSelection.Font = new System.Drawing.Font("Oswald Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Cb_WorkspaceSelection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(173)))), ((int)(((byte)(68)))));
            this.Cb_WorkspaceSelection.FormattingEnabled = true;
            this.Cb_WorkspaceSelection.Location = new System.Drawing.Point(42, 98);
            this.Cb_WorkspaceSelection.Name = "Cb_WorkspaceSelection";
            this.Cb_WorkspaceSelection.Size = new System.Drawing.Size(319, 40);
            this.Cb_WorkspaceSelection.TabIndex = 9;
            this.Cb_WorkspaceSelection.SelectedIndexChanged += new System.EventHandler(this.Cb_WorkspaceSelection_SelectedIndexChanged);
            // 
            // Lbx_HistoryItems
            // 
            this.Lbx_HistoryItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Lbx_HistoryItems.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbx_HistoryItems.FormattingEnabled = true;
            this.Lbx_HistoryItems.ItemHeight = 27;
            this.Lbx_HistoryItems.Location = new System.Drawing.Point(46, 242);
            this.Lbx_HistoryItems.Name = "Lbx_HistoryItems";
            this.Lbx_HistoryItems.Size = new System.Drawing.Size(574, 351);
            this.Lbx_HistoryItems.TabIndex = 10;
            this.Lbx_HistoryItems.SelectedIndexChanged += new System.EventHandler(this.Lbx_HistoryItems_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Oswald SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(37, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Filter By: ";
            // 
            // Dp_StartDate
            // 
            this.Dp_StartDate.Font = new System.Drawing.Font("Oswald", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Dp_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dp_StartDate.Location = new System.Drawing.Point(116, 198);
            this.Dp_StartDate.Name = "Dp_StartDate";
            this.Dp_StartDate.Size = new System.Drawing.Size(100, 25);
            this.Dp_StartDate.TabIndex = 12;
            this.Dp_StartDate.Value = new System.DateTime(2021, 6, 20, 2, 8, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Oswald", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(46, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Start Date: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Oswald", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(236, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "End Date: ";
            // 
            // Dp_EndDate
            // 
            this.Dp_EndDate.Font = new System.Drawing.Font("Oswald", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Dp_EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dp_EndDate.Location = new System.Drawing.Point(301, 198);
            this.Dp_EndDate.Name = "Dp_EndDate";
            this.Dp_EndDate.Size = new System.Drawing.Size(100, 25);
            this.Dp_EndDate.TabIndex = 14;
            this.Dp_EndDate.Value = new System.DateTime(2021, 7, 9, 2, 10, 0, 0);
            // 
            // Btn_ApplyFilters
            // 
            this.Btn_ApplyFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(133)))));
            this.Btn_ApplyFilters.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(133)))));
            this.Btn_ApplyFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ApplyFilters.Font = new System.Drawing.Font("Oswald", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_ApplyFilters.ForeColor = System.Drawing.Color.Black;
            this.Btn_ApplyFilters.Location = new System.Drawing.Point(431, 186);
            this.Btn_ApplyFilters.Name = "Btn_ApplyFilters";
            this.Btn_ApplyFilters.Size = new System.Drawing.Size(94, 37);
            this.Btn_ApplyFilters.TabIndex = 16;
            this.Btn_ApplyFilters.Text = "Apply";
            this.Btn_ApplyFilters.UseVisualStyleBackColor = false;
            this.Btn_ApplyFilters.Click += new System.EventHandler(this.Btn_ApplyFilters_Click);
            // 
            // P_HistoryDetails
            // 
            this.P_HistoryDetails.Controls.Add(this.Lb_ActionUser);
            this.P_HistoryDetails.Controls.Add(this.Lb_ActionDate);
            this.P_HistoryDetails.Controls.Add(this.label12);
            this.P_HistoryDetails.Controls.Add(this.label13);
            this.P_HistoryDetails.Controls.Add(this.label5);
            this.P_HistoryDetails.Controls.Add(this.Btn_OpenDocument);
            this.P_HistoryDetails.Controls.Add(this.Lb_DocumentValue);
            this.P_HistoryDetails.Controls.Add(this.Lb_DocumentDate);
            this.P_HistoryDetails.Controls.Add(this.Lb_DocumentName);
            this.P_HistoryDetails.Controls.Add(this.label9);
            this.P_HistoryDetails.Controls.Add(this.label8);
            this.P_HistoryDetails.Controls.Add(this.label7);
            this.P_HistoryDetails.Controls.Add(this.label6);
            this.P_HistoryDetails.Controls.Add(this.Lb_ActionType);
            this.P_HistoryDetails.Controls.Add(this.Pb_ActionType);
            this.P_HistoryDetails.Location = new System.Drawing.Point(672, 142);
            this.P_HistoryDetails.Name = "P_HistoryDetails";
            this.P_HistoryDetails.Size = new System.Drawing.Size(537, 405);
            this.P_HistoryDetails.TabIndex = 17;
            this.P_HistoryDetails.Visible = false;
            // 
            // Lb_ActionUser
            // 
            this.Lb_ActionUser.AutoSize = true;
            this.Lb_ActionUser.BackColor = System.Drawing.Color.Transparent;
            this.Lb_ActionUser.Font = new System.Drawing.Font("Oswald Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lb_ActionUser.ForeColor = System.Drawing.Color.Black;
            this.Lb_ActionUser.Location = new System.Drawing.Point(75, 154);
            this.Lb_ActionUser.Name = "Lb_ActionUser";
            this.Lb_ActionUser.Size = new System.Drawing.Size(64, 20);
            this.Lb_ActionUser.TabIndex = 30;
            this.Lb_ActionUser.Text = "23/06/2021";
            // 
            // Lb_ActionDate
            // 
            this.Lb_ActionDate.AutoSize = true;
            this.Lb_ActionDate.BackColor = System.Drawing.Color.Transparent;
            this.Lb_ActionDate.Font = new System.Drawing.Font("Oswald Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lb_ActionDate.ForeColor = System.Drawing.Color.Black;
            this.Lb_ActionDate.Location = new System.Drawing.Point(74, 125);
            this.Lb_ActionDate.Name = "Lb_ActionDate";
            this.Lb_ActionDate.Size = new System.Drawing.Size(75, 20);
            this.Lb_ActionDate.TabIndex = 29;
            this.Lb_ActionDate.Text = "First Document";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Oswald Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(40, 153);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 22);
            this.label12.TabIndex = 28;
            this.label12.Text = "User:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Oswald Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(39, 124);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 22);
            this.label13.TabIndex = 27;
            this.label13.Text = "Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Oswald SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(25, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 24);
            this.label5.TabIndex = 26;
            this.label5.Text = "Action details";
            // 
            // Btn_OpenDocument
            // 
            this.Btn_OpenDocument.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(133)))));
            this.Btn_OpenDocument.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(133)))));
            this.Btn_OpenDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_OpenDocument.Font = new System.Drawing.Font("Oswald", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_OpenDocument.ForeColor = System.Drawing.Color.Black;
            this.Btn_OpenDocument.Location = new System.Drawing.Point(39, 331);
            this.Btn_OpenDocument.Name = "Btn_OpenDocument";
            this.Btn_OpenDocument.Size = new System.Drawing.Size(183, 37);
            this.Btn_OpenDocument.TabIndex = 18;
            this.Btn_OpenDocument.Text = "Open Document";
            this.Btn_OpenDocument.UseVisualStyleBackColor = false;
            this.Btn_OpenDocument.Click += new System.EventHandler(this.Btn_OpenDocument_Click);
            // 
            // Lb_DocumentValue
            // 
            this.Lb_DocumentValue.AutoSize = true;
            this.Lb_DocumentValue.BackColor = System.Drawing.Color.Transparent;
            this.Lb_DocumentValue.Font = new System.Drawing.Font("Oswald Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lb_DocumentValue.ForeColor = System.Drawing.Color.Black;
            this.Lb_DocumentValue.Location = new System.Drawing.Point(77, 281);
            this.Lb_DocumentValue.Name = "Lb_DocumentValue";
            this.Lb_DocumentValue.Size = new System.Drawing.Size(45, 20);
            this.Lb_DocumentValue.TabIndex = 25;
            this.Lb_DocumentValue.Text = "200,00";
            // 
            // Lb_DocumentDate
            // 
            this.Lb_DocumentDate.AutoSize = true;
            this.Lb_DocumentDate.BackColor = System.Drawing.Color.Transparent;
            this.Lb_DocumentDate.Font = new System.Drawing.Font("Oswald Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lb_DocumentDate.ForeColor = System.Drawing.Color.Black;
            this.Lb_DocumentDate.Location = new System.Drawing.Point(73, 252);
            this.Lb_DocumentDate.Name = "Lb_DocumentDate";
            this.Lb_DocumentDate.Size = new System.Drawing.Size(64, 20);
            this.Lb_DocumentDate.TabIndex = 24;
            this.Lb_DocumentDate.Text = "23/06/2021";
            // 
            // Lb_DocumentName
            // 
            this.Lb_DocumentName.AutoSize = true;
            this.Lb_DocumentName.BackColor = System.Drawing.Color.Transparent;
            this.Lb_DocumentName.Font = new System.Drawing.Font("Oswald Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lb_DocumentName.ForeColor = System.Drawing.Color.Black;
            this.Lb_DocumentName.Location = new System.Drawing.Point(77, 223);
            this.Lb_DocumentName.Name = "Lb_DocumentName";
            this.Lb_DocumentName.Size = new System.Drawing.Size(75, 20);
            this.Lb_DocumentName.TabIndex = 23;
            this.Lb_DocumentName.Text = "First Document";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Oswald Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(38, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 22);
            this.label9.TabIndex = 22;
            this.label9.Text = "Value:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Oswald Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(39, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 22);
            this.label8.TabIndex = 21;
            this.label8.Text = "Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Oswald Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(38, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 22);
            this.label7.TabIndex = 20;
            this.label7.Text = "Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Oswald SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(25, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 24);
            this.label6.TabIndex = 19;
            this.label6.Text = "Document details";
            // 
            // Lb_ActionType
            // 
            this.Lb_ActionType.AutoSize = true;
            this.Lb_ActionType.BackColor = System.Drawing.Color.Transparent;
            this.Lb_ActionType.Font = new System.Drawing.Font("Oswald SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lb_ActionType.ForeColor = System.Drawing.Color.Black;
            this.Lb_ActionType.Location = new System.Drawing.Point(92, 34);
            this.Lb_ActionType.Name = "Lb_ActionType";
            this.Lb_ActionType.Size = new System.Drawing.Size(155, 35);
            this.Lb_ActionType.TabIndex = 18;
            this.Lb_ActionType.Text = "Document Upload";
            // 
            // Pb_ActionType
            // 
            this.Pb_ActionType.Image = ((System.Drawing.Image)(resources.GetObject("Pb_ActionType.Image")));
            this.Pb_ActionType.Location = new System.Drawing.Point(30, 27);
            this.Pb_ActionType.Name = "Pb_ActionType";
            this.Pb_ActionType.Size = new System.Drawing.Size(50, 50);
            this.Pb_ActionType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb_ActionType.TabIndex = 0;
            this.Pb_ActionType.TabStop = false;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.P_HistoryDetails);
            this.Controls.Add(this.Btn_ApplyFilters);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Dp_EndDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Dp_StartDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lbx_HistoryItems);
            this.Controls.Add(this.Cb_WorkspaceSelection);
            this.Controls.Add(this.label1);
            this.Name = "History";
            this.Size = new System.Drawing.Size(1268, 669);
            this.Load += new System.EventHandler(this.History_Load);
            this.P_HistoryDetails.ResumeLayout(false);
            this.P_HistoryDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_ActionType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cb_WorkspaceSelection;
        private System.Windows.Forms.ListBox Lbx_HistoryItems;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker Dp_StartDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker Dp_EndDate;
        private System.Windows.Forms.Button Btn_ApplyFilters;
        private System.Windows.Forms.Panel P_HistoryDetails;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Lb_ActionType;
        private System.Windows.Forms.PictureBox Pb_ActionType;
        private System.Windows.Forms.Button Btn_OpenDocument;
        private System.Windows.Forms.Label Lb_DocumentValue;
        private System.Windows.Forms.Label Lb_DocumentDate;
        private System.Windows.Forms.Label Lb_DocumentName;
        private System.Windows.Forms.Label Lb_ActionUser;
        private System.Windows.Forms.Label Lb_ActionDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
    }
}
