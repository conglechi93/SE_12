namespace GiaoDien
{
    partial class DailyPlan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_PrevioursDay = new System.Windows.Forms.Button();
            this.btn_NextDay = new System.Windows.Forms.Button();
            this.dtpk_Date = new System.Windows.Forms.DateTimePicker();
            this.pnlJob = new System.Windows.Forms.Panel();
            this.mnsMain = new System.Windows.Forms.MenuStrip();
            this.mnsi_AddJob = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsi_ToDay = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.mnsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pnlJob);
            this.panel1.Location = new System.Drawing.Point(16, 33);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 596);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_PrevioursDay);
            this.panel3.Controls.Add(this.btn_NextDay);
            this.panel3.Controls.Add(this.dtpk_Date);
            this.panel3.Location = new System.Drawing.Point(4, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(997, 33);
            this.panel3.TabIndex = 1;
            // 
            // btn_PrevioursDay
            // 
            this.btn_PrevioursDay.Location = new System.Drawing.Point(4, 1);
            this.btn_PrevioursDay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_PrevioursDay.Name = "btn_PrevioursDay";
            this.btn_PrevioursDay.Size = new System.Drawing.Size(100, 28);
            this.btn_PrevioursDay.TabIndex = 3;
            this.btn_PrevioursDay.Text = "Hôm qua";
            this.btn_PrevioursDay.UseVisualStyleBackColor = true;
            // 
            // btn_NextDay
            // 
            this.btn_NextDay.Location = new System.Drawing.Point(893, 4);
            this.btn_NextDay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_NextDay.Name = "btn_NextDay";
            this.btn_NextDay.Size = new System.Drawing.Size(100, 28);
            this.btn_NextDay.TabIndex = 2;
            this.btn_NextDay.Text = "Ngày mai";
            this.btn_NextDay.UseVisualStyleBackColor = true;
            // 
            // dtpk_Date
            // 
            this.dtpk_Date.Location = new System.Drawing.Point(353, 5);
            this.dtpk_Date.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpk_Date.Name = "dtpk_Date";
            this.dtpk_Date.Size = new System.Drawing.Size(265, 22);
            this.dtpk_Date.TabIndex = 1;
            // 
            // pnlJob
            // 
            this.pnlJob.Location = new System.Drawing.Point(4, 39);
            this.pnlJob.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlJob.Name = "pnlJob";
            this.pnlJob.Size = new System.Drawing.Size(997, 550);
            this.pnlJob.TabIndex = 0;
            // 
            // mnsMain
            // 
            this.mnsMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsi_AddJob,
            this.mnsi_ToDay});
            this.mnsMain.Location = new System.Drawing.Point(0, 0);
            this.mnsMain.Name = "mnsMain";
            this.mnsMain.Size = new System.Drawing.Size(1033, 28);
            this.mnsMain.TabIndex = 1;
            this.mnsMain.Text = "menuStrip1";
            // 
            // mnsi_AddJob
            // 
            this.mnsi_AddJob.Name = "mnsi_AddJob";
            this.mnsi_AddJob.Size = new System.Drawing.Size(90, 24);
            this.mnsi_AddJob.Text = "Thêm việc";
            // 
            // mnsi_ToDay
            // 
            this.mnsi_ToDay.Name = "mnsi_ToDay";
            this.mnsi_ToDay.Size = new System.Drawing.Size(83, 24);
            this.mnsi_ToDay.Text = "Hôm nay";
            // 
            // DailyPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 629);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mnsMain);
            this.MainMenuStrip = this.mnsMain;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DailyPlan";
            this.Text = "Lịch trong ngày";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.mnsMain.ResumeLayout(false);
            this.mnsMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_PrevioursDay;
        private System.Windows.Forms.Button btn_NextDay;
        private System.Windows.Forms.DateTimePicker dtpk_Date;
        private System.Windows.Forms.Panel pnlJob;
        private System.Windows.Forms.MenuStrip mnsMain;
        private System.Windows.Forms.ToolStripMenuItem mnsi_AddJob;
        private System.Windows.Forms.ToolStripMenuItem mnsi_ToDay;
    }
}