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
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 315);
            this.Controls.Add(this.btn_MatrixMinderSubmit);
            this.Controls.Add(this.btn_MilageMatrix);
            this.Controls.Add(this.tb_MilageMatrix);
            this.Controls.Add(this.lbl_ImportCSVConfig);
            this.Name = "frm_main";
            this.Text = "Milage Matrix Minder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ImportCSVConfig;
        private System.Windows.Forms.OpenFileDialog ofd_MilageMatrix;
        private System.Windows.Forms.TextBox tb_MilageMatrix;
        private System.Windows.Forms.Button btn_MilageMatrix;
        private System.Windows.Forms.Button btn_MatrixMinderSubmit;
    }
}

