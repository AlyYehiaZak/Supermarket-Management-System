
namespace SupermarketManagementSystem
{
    partial class itemreportpage
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
            this.returntosales = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // returntosales
            // 
            this.returntosales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.returntosales.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returntosales.ForeColor = System.Drawing.Color.White;
            this.returntosales.Location = new System.Drawing.Point(12, 11);
            this.returntosales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.returntosales.Name = "returntosales";
            this.returntosales.Size = new System.Drawing.Size(129, 72);
            this.returntosales.TabIndex = 11;
            this.returntosales.Text = "Return";
            this.returntosales.UseVisualStyleBackColor = false;
            this.returntosales.Click += new System.EventHandler(this.returntosales_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(2, 99);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1436, 619);
            this.crystalReportViewer1.TabIndex = 12;
            // 
            // itemreportpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 720);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.returntosales);
            this.Name = "itemreportpage";
            this.Text = "itemreportpage";
            this.Load += new System.EventHandler(this.itemreportpage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button returntosales;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}