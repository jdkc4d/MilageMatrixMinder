using System.Collections.ObjectModel;

namespace Milage_Matrix_Minder
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
            this.cb_StartLocation = new System.Windows.Forms.ComboBox();
            this.cb_EndLocation = new System.Windows.Forms.ComboBox();
            this.btn_AppendMilageReport = new System.Windows.Forms.Button();
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
            this.label1.Location = new System.Drawing.Point(17, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(669, 2);
            this.label1.TabIndex = 0;
            // 
            // btn_ExportCSV
            // 
            this.btn_ExportCSV.Location = new System.Drawing.Point(609, 109);
            this.btn_ExportCSV.Name = "btn_ExportCSV";
            this.btn_ExportCSV.Size = new System.Drawing.Size(75, 23);
            this.btn_ExportCSV.TabIndex = 4;
            this.btn_ExportCSV.Text = "Export CSV";
            this.btn_ExportCSV.UseVisualStyleBackColor = true;
            this.btn_ExportCSV.Click += new System.EventHandler(this.btn_ExportCSV_Click);
            // 
            // dtp_AddMilage
            // 
            this.dtp_AddMilage.Enabled = false;
            this.dtp_AddMilage.Location = new System.Drawing.Point(15, 67);
            this.dtp_AddMilage.Name = "dtp_AddMilage";
            this.dtp_AddMilage.Size = new System.Drawing.Size(200, 20);
            this.dtp_AddMilage.TabIndex = 5;
            // 
            // lbl_AppendInstructions
            // 
            this.lbl_AppendInstructions.AutoSize = true;
            this.lbl_AppendInstructions.Location = new System.Drawing.Point(14, 49);
            this.lbl_AppendInstructions.Name = "lbl_AppendInstructions";
            this.lbl_AppendInstructions.Size = new System.Drawing.Size(255, 13);
            this.lbl_AppendInstructions.TabIndex = 6;
            this.lbl_AppendInstructions.Text = "Choose a date, starting location and ending location.";
            // 
            // cb_StartLocation
            // 
            this.cb_StartLocation.Enabled = false;
            this.cb_StartLocation.FormattingEnabled = true;
            this.cb_StartLocation.Location = new System.Drawing.Point(257, 65);
            this.cb_StartLocation.Name = "cb_StartLocation";
            this.cb_StartLocation.Size = new System.Drawing.Size(121, 21);
            this.cb_StartLocation.TabIndex = 7;
            // 
            // cb_EndLocation
            // 
            this.cb_EndLocation.Enabled = false;
            this.cb_EndLocation.FormattingEnabled = true;
            this.cb_EndLocation.Location = new System.Drawing.Point(422, 65);
            this.cb_EndLocation.Name = "cb_EndLocation";
            this.cb_EndLocation.Size = new System.Drawing.Size(121, 21);
            this.cb_EndLocation.TabIndex = 8;
            // 
            // btn_AppendMilageReport
            // 
            this.btn_AppendMilageReport.Enabled = false;
            this.btn_AppendMilageReport.Location = new System.Drawing.Point(579, 65);
            this.btn_AppendMilageReport.Name = "btn_AppendMilageReport";
            this.btn_AppendMilageReport.Size = new System.Drawing.Size(97, 23);
            this.btn_AppendMilageReport.TabIndex = 9;
            this.btn_AppendMilageReport.Text = "Append Report";
            this.btn_AppendMilageReport.UseVisualStyleBackColor = true;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 137);
            this.Controls.Add(this.btn_AppendMilageReport);
            this.Controls.Add(this.cb_EndLocation);
            this.Controls.Add(this.cb_StartLocation);
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
        private System.Windows.Forms.ComboBox cb_StartLocation;
        private System.Windows.Forms.ComboBox cb_EndLocation;
        private System.Windows.Forms.Button btn_AppendMilageReport;

        //These variables are for the Matrix and Report, so the form has them all the time while running.
        private string MilageMatrix;
        private string MilageReport;

        //This is a Collection of Office Objects
        private Collection<Office> Branches;
    }
}

