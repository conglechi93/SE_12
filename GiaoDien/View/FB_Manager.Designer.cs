﻿namespace GiaoDien
{
    partial class FB_Manager
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
            this.dtg_Search = new System.Windows.Forms.DataGridView();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Read = new System.Windows.Forms.Button();
            this.txt_Message = new System.Windows.Forms.TextBox();
            this.txt_Subject = new System.Windows.Forms.TextBox();
            this.lb_Message = new System.Windows.Forms.Label();
            this.lb_Subject = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Search)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_Search
            // 
            this.dtg_Search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Search.Location = new System.Drawing.Point(31, 78);
            this.dtg_Search.Margin = new System.Windows.Forms.Padding(4);
            this.dtg_Search.Name = "dtg_Search";
            this.dtg_Search.RowHeadersWidth = 51;
            this.dtg_Search.Size = new System.Drawing.Size(352, 418);
            this.dtg_Search.TabIndex = 0;
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_Delete.Location = new System.Drawing.Point(779, 453);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(167, 43);
            this.btn_Delete.TabIndex = 5;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            // 
            // btn_Read
            // 
            this.btn_Read.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_Read.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Read.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Read.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_Read.Location = new System.Drawing.Point(519, 453);
            this.btn_Read.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Read.Name = "btn_Read";
            this.btn_Read.Size = new System.Drawing.Size(167, 43);
            this.btn_Read.TabIndex = 5;
            this.btn_Read.Text = "Read";
            this.btn_Read.UseVisualStyleBackColor = false;
            // 
            // txt_Message
            // 
            this.txt_Message.BackColor = System.Drawing.Color.LightGray;
            this.txt_Message.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Message.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Message.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_Message.Location = new System.Drawing.Point(411, 105);
            this.txt_Message.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Message.Multiline = true;
            this.txt_Message.Name = "txt_Message";
            this.txt_Message.Size = new System.Drawing.Size(622, 301);
            this.txt_Message.TabIndex = 8;
            // 
            // txt_Subject
            // 
            this.txt_Subject.BackColor = System.Drawing.Color.LightGray;
            this.txt_Subject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Subject.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Subject.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_Subject.Location = new System.Drawing.Point(411, 38);
            this.txt_Subject.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Subject.Name = "txt_Subject";
            this.txt_Subject.Size = new System.Drawing.Size(375, 22);
            this.txt_Subject.TabIndex = 9;
            // 
            // lb_Message
            // 
            this.lb_Message.AutoSize = true;
            this.lb_Message.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Message.ForeColor = System.Drawing.Color.Navy;
            this.lb_Message.Location = new System.Drawing.Point(405, 78);
            this.lb_Message.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Message.Name = "lb_Message";
            this.lb_Message.Size = new System.Drawing.Size(89, 23);
            this.lb_Message.TabIndex = 6;
            this.lb_Message.Text = "Message:";
            // 
            // lb_Subject
            // 
            this.lb_Subject.AutoSize = true;
            this.lb_Subject.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Subject.ForeColor = System.Drawing.Color.Navy;
            this.lb_Subject.Location = new System.Drawing.Point(405, 11);
            this.lb_Subject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Subject.Name = "lb_Subject";
            this.lb_Subject.Size = new System.Drawing.Size(78, 23);
            this.lb_Subject.TabIndex = 7;
            this.lb_Subject.Text = "Subject:";
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(40, 37);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(150, 22);
            this.txt_Search.TabIndex = 10;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(196, 32);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(144, 33);
            this.btn_Search.TabIndex = 11;
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // FB_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 519);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.txt_Message);
            this.Controls.Add(this.txt_Subject);
            this.Controls.Add(this.lb_Message);
            this.Controls.Add(this.lb_Subject);
            this.Controls.Add(this.btn_Read);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.dtg_Search);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FB_Manager";
            this.Text = "FB_Manager";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_Search;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Read;
        private System.Windows.Forms.TextBox txt_Message;
        private System.Windows.Forms.TextBox txt_Subject;
        private System.Windows.Forms.Label lb_Message;
        private System.Windows.Forms.Label lb_Subject;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btn_Search;
    }
}