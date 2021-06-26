
namespace BD_FinalProject
{
    partial class CreateReportPopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateReportPopup));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lb_Title = new System.Windows.Forms.Label();
            this.Pb_Close = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Dp_ReportStart = new System.Windows.Forms.DateTimePicker();
            this.Dp_ReportEnd = new System.Windows.Forms.DateTimePicker();
            this.Lb_ActiveWorkspace = new System.Windows.Forms.Label();
            this.Btn_CreateReport = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Close)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(553, 61);
            this.panel1.TabIndex = 2;
            // 
            // Lb_Title
            // 
            this.Lb_Title.BackColor = System.Drawing.Color.Transparent;
            this.Lb_Title.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lb_Title.ForeColor = System.Drawing.Color.White;
            this.Lb_Title.Location = new System.Drawing.Point(13, 13);
            this.Lb_Title.Name = "Lb_Title";
            this.Lb_Title.Size = new System.Drawing.Size(485, 32);
            this.Lb_Title.TabIndex = 13;
            this.Lb_Title.Text = "Create Report";
            // 
            // Pb_Close
            // 
            this.Pb_Close.Image = ((System.Drawing.Image)(resources.GetObject("Pb_Close.Image")));
            this.Pb_Close.Location = new System.Drawing.Point(504, 11);
            this.Pb_Close.Name = "Pb_Close";
            this.Pb_Close.Size = new System.Drawing.Size(36, 36);
            this.Pb_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb_Close.TabIndex = 0;
            this.Pb_Close.TabStop = false;
            this.Pb_Close.Click += new System.EventHandler(this.Pb_Close_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Btn_CreateReport);
            this.panel2.Controls.Add(this.Lb_ActiveWorkspace);
            this.panel2.Controls.Add(this.Dp_ReportEnd);
            this.panel2.Controls.Add(this.Dp_ReportStart);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(553, 216);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Oswald", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "Active Workspace:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Oswald", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(25, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 26);
            this.label2.TabIndex = 16;
            this.label2.Text = "Start Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Oswald", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(280, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 26);
            this.label3.TabIndex = 17;
            this.label3.Text = "End Date:";
            // 
            // Dp_ReportStart
            // 
            this.Dp_ReportStart.CalendarFont = new System.Drawing.Font("Oswald", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Dp_ReportStart.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.Dp_ReportStart.CalendarTitleForeColor = System.Drawing.Color.White;
            this.Dp_ReportStart.Font = new System.Drawing.Font("Oswald", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Dp_ReportStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dp_ReportStart.Location = new System.Drawing.Point(99, 83);
            this.Dp_ReportStart.Margin = new System.Windows.Forms.Padding(0);
            this.Dp_ReportStart.Name = "Dp_ReportStart";
            this.Dp_ReportStart.Size = new System.Drawing.Size(157, 25);
            this.Dp_ReportStart.TabIndex = 18;
            // 
            // Dp_ReportEnd
            // 
            this.Dp_ReportEnd.CalendarFont = new System.Drawing.Font("Oswald", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Dp_ReportEnd.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.Dp_ReportEnd.CalendarTitleForeColor = System.Drawing.Color.White;
            this.Dp_ReportEnd.Font = new System.Drawing.Font("Oswald", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Dp_ReportEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dp_ReportEnd.Location = new System.Drawing.Point(346, 83);
            this.Dp_ReportEnd.Margin = new System.Windows.Forms.Padding(0);
            this.Dp_ReportEnd.Name = "Dp_ReportEnd";
            this.Dp_ReportEnd.Size = new System.Drawing.Size(157, 25);
            this.Dp_ReportEnd.TabIndex = 19;
            // 
            // Lb_ActiveWorkspace
            // 
            this.Lb_ActiveWorkspace.AutoSize = true;
            this.Lb_ActiveWorkspace.BackColor = System.Drawing.Color.Transparent;
            this.Lb_ActiveWorkspace.Font = new System.Drawing.Font("Oswald Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lb_ActiveWorkspace.ForeColor = System.Drawing.Color.Black;
            this.Lb_ActiveWorkspace.Location = new System.Drawing.Point(132, 31);
            this.Lb_ActiveWorkspace.Name = "Lb_ActiveWorkspace";
            this.Lb_ActiveWorkspace.Size = new System.Drawing.Size(102, 22);
            this.Lb_ActiveWorkspace.TabIndex = 20;
            this.Lb_ActiveWorkspace.Text = "Active Workspace:";
            // 
            // Btn_CreateReport
            // 
            this.Btn_CreateReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(133)))));
            this.Btn_CreateReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(133)))));
            this.Btn_CreateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_CreateReport.Font = new System.Drawing.Font("Oswald", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_CreateReport.ForeColor = System.Drawing.Color.White;
            this.Btn_CreateReport.Location = new System.Drawing.Point(25, 145);
            this.Btn_CreateReport.Name = "Btn_CreateReport";
            this.Btn_CreateReport.Size = new System.Drawing.Size(182, 38);
            this.Btn_CreateReport.TabIndex = 21;
            this.Btn_CreateReport.Text = "Create Report";
            this.Btn_CreateReport.UseVisualStyleBackColor = false;
            this.Btn_CreateReport.Click += new System.EventHandler(this.Btn_CreateReport_Click);
            // 
            // CreateReportPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(553, 275);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateReportPopup";
            this.Text = "CreateReport";
            this.Load += new System.EventHandler(this.CreateReportPopup_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Close)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lb_Title;
        private System.Windows.Forms.PictureBox Pb_Close;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lb_ActiveWorkspace;
        private System.Windows.Forms.DateTimePicker Dp_ReportEnd;
        private System.Windows.Forms.DateTimePicker Dp_ReportStart;
        private System.Windows.Forms.Button Btn_CreateReport;
    }
}