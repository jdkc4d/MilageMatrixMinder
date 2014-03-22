﻿namespace Milage_Matrix_Minder
{
    partial class frm_main
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
            this.lbl_ImportCSVConfig = new System.Windows.Forms.Label();
            this.ofd_MilageMatrix = new System.Windows.Forms.OpenFileDialog();
            this.tb_MilageMatrix = new System.Windows.Forms.TextBox();
            this.btn_MilageMatrix = new System.Windows.Forms.Button();
            this.btn_MatrixMinderSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ExportCSV = new System.Windows.Forms.Button();
            this.dtp_AddMilage = new System.Windows.Forms.DateTimePicker();
            this.lbl_AppendInstructions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_ImportCSVConfig
            // 
            this.lbl_ImportCSVConfig.AutoSize = true;
            this.lbl_ImportCSVConfig.Location = new System.Drawing.Point(14, 16);
            this.lbl_ImportCSVConfig.Name = "lbl_ImportCSVConfig";
            this.lbl_ImportCSVConfig.Size = new System.Drawing.Size(163, 13);
            this.lbl_ImportCSVConfig.TabIndex = 0;
            this.lbl_ImportCSVConfig.Text = "Import your Milage Matrix (*.csv): ";
            // 
            // ofd_MilageMatrix
            // 
            this.ofd_MilageMatrix.Filter = "Comma Separated Values|*.csv|All Files|*.*";
            this.ofd_MilageMatrix.InitialDirectory = "%userprofile%\\Desktop";
            this.ofd_MilageMatrix.Title = "Select Milage Matrix File";
            // 
            // tb_MilageMatrix
            // 
            this.tb_MilageMatrix.Location = new System.Drawing.Point(183, 13);
            this.tb_MilageMatrix.Name = "tb_MilageMatrix";
            this.tb_MilageMatrix.Size = new System.Drawing.Size(329, 20);
            this.tb_MilageMatrix.TabIndex = 1;
            // 
            // btn_MilageMatrix
            // 
            this.btn_MilageMatrix.Location = new System.Drawing.Point(518, 12);
            this.btn_MilageMatrix.Name = "btn_MilageMatrix";
            this.btn_MilageMatrix.Size = new System.Drawing.Size(77, 23);
            this.btn_MilageMatrix.TabIndex = 2;
            this.btn_MilageMatrix.Text = "Browse";
            this.btn_MilageMatrix.UseVisualStyleBackColor = true;
            this.btn_MilageMatrix.Click += new System.EventHandler(this.btn_MilageMatrix_Click);
            // 
            // btn_MatrixMinderSubmit
            // 
            this.btn_MatrixMinderSubmit.Enabled = false;
            this.btn_MatrixMinderSubmit.Location = new System.Drawing.Point(601, 12);
            this.btn_MatrixMinderSubmit.Name = "btn_MatrixMinderSubmit";
            this.btn_MatrixMinderSubmit.Size = new System.Drawing.Size(75, 23);
            this.btn_MatrixMinderSubmit.TabIndex = 3;
            this.btn_MatrixMinderSubmit.Text = "Import";
            this.btn_MatrixMinderSubmit.UseVisualStyleBackColor = true;
            this.btn_MatrixMinderSubmit.Click += new System.EventHandler(this.btn_MatrixMinderSubmit_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.CausesValidation = false;
            this.label1.Location = new System.Drawing.Point(17, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(669, 2);
            this.label1.TabIndex = 0;
            // 
            // btn_ExportCSV
            // 
            this.btn_ExportCSV.Location = new System.Drawing.Point(609, 280);
            this.btn_ExportCSV.Name = "btn_ExportCSV";
            this.btn_ExportCSV.Size = new System.Drawing.Size(75, 23);
            this.btn_ExportCSV.TabIndex = 4;
            this.btn_ExportCSV.Text = "Export CSV";
            this.btn_ExportCSV.UseVisualStyleBackColor = true;
            // 
            // dtp_AddMilage
            // 
            this.dtp_AddMilage.Location = new System.Drawing.Point(14, 99);
            this.dtp_AddMilage.Name = "dtp_AddMilage";
            this.dtp_AddMilage.Size = new System.Drawing.Size(200, 20);
            this.dtp_AddMilage.TabIndex = 5;
            // 
            // lbl_AppendInstructions
            // 
            this.lbl_AppendInstructions.AutoSize = true;
            this.lbl_AppendInstructions.Location = new System.Drawing.Point(14, 80);
            this.lbl_AppendInstructions.Name = "lbl_AppendInstructions";
            this.lbl_AppendInstructions.Size = new System.Drawing.Size(255, 13);
            this.lbl_AppendInstructions.TabIndex = 6;
            this.lbl_AppendInstructions.Text = "Choose a date, starting location and ending location.";
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 307);
            this.Controls.Add(this.lbl_AppendInstructions);
            this.Controls.Add(this.dtp_AddMilage);
            this.Controls.Add(this.btn_ExportCSV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_MatrixMinderSubmit);
            this.Controls.Add(this.btn_MilageMatrix);
            this.Controls.Add(this.tb_MilageMatrix);
            this.Controls.Add(this.lbl_ImportCSVConfig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frm_main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Milage Matrix Minder";
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ImportCSVConfig;
        private System.Windows.Forms.OpenFileDialog ofd_MilageMatrix;
        private System.Windows.Forms.TextBox tb_MilageMatrix;
        private System.Windows.Forms.Button btn_MilageMatrix;
        private System.Windows.Forms.Button btn_MatrixMinderSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ExportCSV;
        private System.Windows.Forms.DateTimePicker dtp_AddMilage;
        private System.Windows.Forms.Label lbl_AppendInstructions;
    }
}

