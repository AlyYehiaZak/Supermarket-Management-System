namespace SupermarketManagementSystem
{
    partial class CashierPage
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
            this.button_cashier = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label_transactions = new System.Windows.Forms.Label();
            this.LOGOUT = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_cashier
            // 
            this.button_cashier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_cashier.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cashier.ForeColor = System.Drawing.Color.White;
            this.button_cashier.Location = new System.Drawing.Point(27, 45);
            this.button_cashier.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_cashier.Name = "button_cashier";
            this.button_cashier.Size = new System.Drawing.Size(113, 37);
            this.button_cashier.TabIndex = 8;
            this.button_cashier.Text = "View Data";
            this.button_cashier.UseVisualStyleBackColor = false;
            this.button_cashier.Click += new System.EventHandler(this.button_cashier_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 134);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(434, 206);
            this.dataGridView1.TabIndex = 9;
            // 
            // label_transactions
            // 
            this.label_transactions.AutoSize = true;
            this.label_transactions.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_transactions.ForeColor = System.Drawing.Color.Black;
            this.label_transactions.Location = new System.Drawing.Point(31, 15);
            this.label_transactions.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_transactions.Name = "label_transactions";
            this.label_transactions.Size = new System.Drawing.Size(107, 21);
            this.label_transactions.TabIndex = 10;
            this.label_transactions.Text = "Transactions";
            // 
            // LOGOUT
            // 
            this.LOGOUT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LOGOUT.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGOUT.ForeColor = System.Drawing.Color.White;
            this.LOGOUT.Location = new System.Drawing.Point(513, 330);
            this.LOGOUT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LOGOUT.Name = "LOGOUT";
            this.LOGOUT.Size = new System.Drawing.Size(68, 26);
            this.LOGOUT.TabIndex = 11;
            this.LOGOUT.Text = "LOGOUT";
            this.LOGOUT.UseVisualStyleBackColor = false;
            this.LOGOUT.Click += new System.EventHandler(this.LOGOUT_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(177, 45);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 37);
            this.button1.TabIndex = 12;
            this.button1.Text = "ADD Transaction";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CashierPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LOGOUT);
            this.Controls.Add(this.label_transactions);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_cashier);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CashierPage";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_cashier;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_transactions;
        private System.Windows.Forms.Button LOGOUT;
        private System.Windows.Forms.Button button1;
    }
}