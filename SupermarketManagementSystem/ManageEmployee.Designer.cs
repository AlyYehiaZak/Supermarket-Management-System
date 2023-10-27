namespace SupermarketManagementSystem
{
    partial class manage_employee
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
            this.combobox_role = new System.Windows.Forms.ComboBox();
            this.button_cashier = new System.Windows.Forms.Button();
            this.label_transactions = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button_ManageEmp_Insert = new System.Windows.Forms.Button();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.comboBox_role_manage = new System.Windows.Forms.ComboBox();
            this.textBox_salary = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_branchid = new System.Windows.Forms.ComboBox();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // combobox_role
            // 
            this.combobox_role.FormattingEnabled = true;
            this.combobox_role.Location = new System.Drawing.Point(82, 23);
            this.combobox_role.Margin = new System.Windows.Forms.Padding(2);
            this.combobox_role.Name = "combobox_role";
            this.combobox_role.Size = new System.Drawing.Size(97, 21);
            this.combobox_role.TabIndex = 13;
            // 
            // button_cashier
            // 
            this.button_cashier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_cashier.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cashier.ForeColor = System.Drawing.Color.White;
            this.button_cashier.Location = new System.Drawing.Point(43, 60);
            this.button_cashier.Margin = new System.Windows.Forms.Padding(2);
            this.button_cashier.Name = "button_cashier";
            this.button_cashier.Size = new System.Drawing.Size(113, 37);
            this.button_cashier.TabIndex = 15;
            this.button_cashier.Text = "View Data";
            this.button_cashier.UseVisualStyleBackColor = false;
            this.button_cashier.Click += new System.EventHandler(this.button_cashier_Click);
            // 
            // label_transactions
            // 
            this.label_transactions.AutoSize = true;
            this.label_transactions.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_transactions.ForeColor = System.Drawing.Color.Black;
            this.label_transactions.Location = new System.Drawing.Point(16, 24);
            this.label_transactions.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_transactions.Name = "label_transactions";
            this.label_transactions.Size = new System.Drawing.Size(50, 21);
            this.label_transactions.TabIndex = 16;
            this.label_transactions.Text = "ROLE";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 116);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(362, 214);
            this.dataGridView1.TabIndex = 17;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(760, 329);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 26);
            this.button3.TabIndex = 22;
            this.button3.Text = "Return";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_ManageEmp_Insert
            // 
            this.button_ManageEmp_Insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_ManageEmp_Insert.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ManageEmp_Insert.ForeColor = System.Drawing.Color.White;
            this.button_ManageEmp_Insert.Location = new System.Drawing.Point(437, 270);
            this.button_ManageEmp_Insert.Margin = new System.Windows.Forms.Padding(2);
            this.button_ManageEmp_Insert.Name = "button_ManageEmp_Insert";
            this.button_ManageEmp_Insert.Size = new System.Drawing.Size(113, 37);
            this.button_ManageEmp_Insert.TabIndex = 23;
            this.button_ManageEmp_Insert.Text = "Insert";
            this.button_ManageEmp_Insert.UseVisualStyleBackColor = false;
            this.button_ManageEmp_Insert.Click += new System.EventHandler(this.button_ManageEmp_Insert_Click);
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(502, 131);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(100, 20);
            this.textBox_ID.TabIndex = 24;
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(502, 174);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(100, 20);
            this.textBox_username.TabIndex = 25;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(504, 215);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(100, 20);
            this.textBox_password.TabIndex = 26;
            // 
            // comboBox_role_manage
            // 
            this.comboBox_role_manage.FormattingEnabled = true;
            this.comboBox_role_manage.Location = new System.Drawing.Point(695, 130);
            this.comboBox_role_manage.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_role_manage.Name = "comboBox_role_manage";
            this.comboBox_role_manage.Size = new System.Drawing.Size(97, 21);
            this.comboBox_role_manage.TabIndex = 27;
            // 
            // textBox_salary
            // 
            this.textBox_salary.Location = new System.Drawing.Point(695, 175);
            this.textBox_salary.Name = "textBox_salary";
            this.textBox_salary.Size = new System.Drawing.Size(100, 20);
            this.textBox_salary.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(412, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 21);
            this.label1.TabIndex = 30;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(409, 174);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 31;
            this.label2.Text = "Username";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(409, 218);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 32;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(609, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 21);
            this.label4.TabIndex = 33;
            this.label4.Text = "Role";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(620, 173);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 21);
            this.label5.TabIndex = 34;
            this.label5.Text = "Salary";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(609, 215);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 21);
            this.label6.TabIndex = 35;
            this.label6.Text = "BranchID";
            // 
            // comboBox_branchid
            // 
            this.comboBox_branchid.FormattingEnabled = true;
            this.comboBox_branchid.Location = new System.Drawing.Point(695, 215);
            this.comboBox_branchid.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_branchid.Name = "comboBox_branchid";
            this.comboBox_branchid.Size = new System.Drawing.Size(97, 21);
            this.comboBox_branchid.TabIndex = 36;
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_delete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ForeColor = System.Drawing.Color.White;
            this.button_delete.Location = new System.Drawing.Point(578, 270);
            this.button_delete.Margin = new System.Windows.Forms.Padding(2);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(113, 37);
            this.button_delete.TabIndex = 37;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_update.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.ForeColor = System.Drawing.Color.White;
            this.button_update.Location = new System.Drawing.Point(715, 270);
            this.button_update.Margin = new System.Windows.Forms.Padding(2);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(113, 37);
            this.button_update.TabIndex = 38;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // manage_employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 366);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.comboBox_branchid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_salary);
            this.Controls.Add(this.comboBox_role_manage);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.button_ManageEmp_Insert);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label_transactions);
            this.Controls.Add(this.button_cashier);
            this.Controls.Add(this.combobox_role);
            this.Controls.Add(this.button_delete);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "manage_employee";
            this.Text = "Manage_employee";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.manage_employee_FormClosing);
            this.Load += new System.EventHandler(this.manage_employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combobox_role;
        private System.Windows.Forms.Button button_cashier;
        private System.Windows.Forms.Label label_transactions;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button_ManageEmp_Insert;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.ComboBox comboBox_role_manage;
        private System.Windows.Forms.TextBox textBox_salary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_branchid;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_update;
    }
}