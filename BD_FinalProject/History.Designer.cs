
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
            this.label1 = new System.Windows.Forms.Label();
            this.Cb_WorkspaceSelection = new System.Windows.Forms.ComboBox();
            this.Lbx_HistoryItems = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Dp_StartDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Dp_EndDate = new System.Windows.Forms.DateTimePicker();
            this.Btn_ApplyFilters = new System.Windows.Forms.Button();
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
            this.Lbx_HistoryItems.Location = new System.Drawing.Point(46, 230);
            this.Lbx_HistoryItems.Name = "Lbx_HistoryItems";
            this.Lbx_HistoryItems.Size = new System.Drawing.Size(1174, 405);
            this.Lbx_HistoryItems.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Oswald SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(37, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Filter By: ";
            // 
            // Dp_StartDate
            // 
            this.Dp_StartDate.Font = new System.Drawing.Font("Oswald", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Dp_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dp_StartDate.Location = new System.Drawing.Point(116, 186);
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
            this.label3.Location = new System.Drawing.Point(46, 185);
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
            this.label4.Location = new System.Drawing.Point(236, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "End Date: ";
            // 
            // Dp_EndDate
            // 
            this.Dp_EndDate.Font = new System.Drawing.Font("Oswald", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Dp_EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dp_EndDate.Location = new System.Drawing.Point(301, 186);
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
            this.Btn_ApplyFilters.Location = new System.Drawing.Point(431, 174);
            this.Btn_ApplyFilters.Name = "Btn_ApplyFilters";
            this.Btn_ApplyFilters.Size = new System.Drawing.Size(94, 37);
            this.Btn_ApplyFilters.TabIndex = 16;
            this.Btn_ApplyFilters.Text = "Apply";
            this.Btn_ApplyFilters.UseVisualStyleBackColor = false;
            this.Btn_ApplyFilters.Click += new System.EventHandler(this.Btn_ApplyFilters_Click);
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
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
    }
}
