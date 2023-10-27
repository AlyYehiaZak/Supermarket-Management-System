
namespace SupermarketManagementSystem
{
    partial class transactionsreportpage
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
            this.Returntotrans = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.written_date = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gettrnsrpt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Returntotrans
            // 
            this.Returntotrans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Returntotrans.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Returntotrans.ForeColor = System.Drawing.Color.White;
            this.Returntotrans.Location = new System.Drawing.Point(12, 11);
            this.Returntotrans.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Returntotrans.Name = "Returntotrans";
            this.Returntotrans.Size = new System.Drawing.Size(129, 72);
            this.Returntotrans.TabIndex = 11;
            this.Returntotrans.Text = "Return";
            this.Returntotrans.UseVisualStyleBackColor = false;
            this.Returntotrans.Click += new System.EventHandler(this.Returntotrans_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(-1, 92);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1422, 577);
            this.crystalReportViewer1.TabIndex = 12;
            // 
            // written_date
            // 
            this.written_date.Location = new System.Drawing.Point(615, 37);
            this.written_date.Name = "written_date";
            this.written_date.Size = new System.Drawing.Size(188, 27);
            this.written_date.TabIndex = 13;
            this.written_date.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(446, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 28);
            this.label1.TabIndex = 14;
            this.label1.Text = "Choose Date";
            // 
            // gettrnsrpt
            // 
            this.gettrnsrpt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gettrnsrpt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gettrnsrpt.ForeColor = System.Drawing.Color.White;
            this.gettrnsrpt.Location = new System.Drawing.Point(1011, 15);
            this.gettrnsrpt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gettrnsrpt.Name = "gettrnsrpt";
            this.gettrnsrpt.Size = new System.Drawing.Size(129, 72);
            this.gettrnsrpt.TabIndex = 15;
            this.gettrnsrpt.Text = "Get Report";
            this.gettrnsrpt.UseVisualStyleBackColor = false;
            this.gettrnsrpt.Click += new System.EventHandler(this.gettrnsrpt_Click);
            // 
            // transactionsreportpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 681);
            this.Controls.Add(this.gettrnsrpt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.written_date);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.Returntotrans);
            this.Name = "transactionsreportpage";
            this.Text = "transactionsreportpage";
            this.Load += new System.EventHandler(this.transactionsreportpage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Returntotrans;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.TextBox written_date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button gettrnsrpt;
    }
}