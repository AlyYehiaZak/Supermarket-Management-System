namespace SupermarketManagementSystem
{
    partial class ManageTransactions
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
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textbox_ManageTransactions_Cname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textbox_ManageTransactions_DOT = new System.Windows.Forms.TextBox();
            this.button_ManageTransactions_Insert = new System.Windows.Forms.Button();
            this.button_ManageTransactions_Edit = new System.Windows.Forms.Button();
            this.button_ManageTransactions_Delete = new System.Windows.Forms.Button();
            this.combobox_ManageTransactions_TID = new System.Windows.Forms.ComboBox();
            this.getbydate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(580, 367);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 38);
            this.button3.TabIndex = 21;
            this.button3.Text = "Return";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "Transaction ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "Customer Name";
            // 
            // textbox_ManageTransactions_Cname
            // 
            this.textbox_ManageTransactions_Cname.Location = new System.Drawing.Point(236, 134);
            this.textbox_ManageTransactions_Cname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textbox_ManageTransactions_Cname.Name = "textbox_ManageTransactions_Cname";
            this.textbox_ManageTransactions_Cname.Size = new System.Drawing.Size(180, 27);
            this.textbox_ManageTransactions_Cname.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 205);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 19);
            this.label3.TabIndex = 26;
            this.label3.Text = "Date Of Transaction";
            // 
            // textbox_ManageTransactions_DOT
            // 
            this.textbox_ManageTransactions_DOT.Location = new System.Drawing.Point(236, 200);
            this.textbox_ManageTransactions_DOT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textbox_ManageTransactions_DOT.Name = "textbox_ManageTransactions_DOT";
            this.textbox_ManageTransactions_DOT.Size = new System.Drawing.Size(180, 27);
            this.textbox_ManageTransactions_DOT.TabIndex = 27;
            // 
            // button_ManageTransactions_Insert
            // 
            this.button_ManageTransactions_Insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_ManageTransactions_Insert.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ManageTransactions_Insert.ForeColor = System.Drawing.Color.White;
            this.button_ManageTransactions_Insert.Location = new System.Drawing.Point(110, 295);
            this.button_ManageTransactions_Insert.Name = "button_ManageTransactions_Insert";
            this.button_ManageTransactions_Insert.Size = new System.Drawing.Size(102, 38);
            this.button_ManageTransactions_Insert.TabIndex = 28;
            this.button_ManageTransactions_Insert.Text = "INSERT";
            this.button_ManageTransactions_Insert.UseVisualStyleBackColor = false;
            this.button_ManageTransactions_Insert.Click += new System.EventHandler(this.button_ManageTransactions_Insert_Click);
            // 
            // button_ManageTransactions_Edit
            // 
            this.button_ManageTransactions_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_ManageTransactions_Edit.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ManageTransactions_Edit.ForeColor = System.Drawing.Color.White;
            this.button_ManageTransactions_Edit.Location = new System.Drawing.Point(267, 295);
            this.button_ManageTransactions_Edit.Name = "button_ManageTransactions_Edit";
            this.button_ManageTransactions_Edit.Size = new System.Drawing.Size(102, 38);
            this.button_ManageTransactions_Edit.TabIndex = 29;
            this.button_ManageTransactions_Edit.Text = "EDIT";
            this.button_ManageTransactions_Edit.UseVisualStyleBackColor = false;
            this.button_ManageTransactions_Edit.Click += new System.EventHandler(this.button_ManageTransactions_Edit_Click);
            // 
            // button_ManageTransactions_Delete
            // 
            this.button_ManageTransactions_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_ManageTransactions_Delete.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ManageTransactions_Delete.ForeColor = System.Drawing.Color.White;
            this.button_ManageTransactions_Delete.Location = new System.Drawing.Point(422, 295);
            this.button_ManageTransactions_Delete.Name = "button_ManageTransactions_Delete";
            this.button_ManageTransactions_Delete.Size = new System.Drawing.Size(102, 38);
            this.button_ManageTransactions_Delete.TabIndex = 30;
            this.button_ManageTransactions_Delete.Text = "DELETE";
            this.button_ManageTransactions_Delete.UseVisualStyleBackColor = false;
            this.button_ManageTransactions_Delete.Click += new System.EventHandler(this.button_ManageTransactions_Delete_Click);
            // 
            // combobox_ManageTransactions_TID
            // 
            this.combobox_ManageTransactions_TID.FormattingEnabled = true;
            this.combobox_ManageTransactions_TID.Location = new System.Drawing.Point(236, 75);
            this.combobox_ManageTransactions_TID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combobox_ManageTransactions_TID.Name = "combobox_ManageTransactions_TID";
            this.combobox_ManageTransactions_TID.Size = new System.Drawing.Size(180, 27);
            this.combobox_ManageTransactions_TID.TabIndex = 31;
            this.combobox_ManageTransactions_TID.SelectedIndexChanged += new System.EventHandler(this.combobox_ManageTransactions_TID_SelectedIndexChanged);
            // 
            // getbydate
            // 
            this.getbydate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.getbydate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getbydate.ForeColor = System.Drawing.Color.White;
            this.getbydate.Location = new System.Drawing.Point(379, 338);
            this.getbydate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.getbydate.Name = "getbydate";
            this.getbydate.Size = new System.Drawing.Size(129, 72);
            this.getbydate.TabIndex = 32;
            this.getbydate.Text = "get by date";
            this.getbydate.UseVisualStyleBackColor = false;
            this.getbydate.Click += new System.EventHandler(this.getbydate_Click);
            // 
            // ManageTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 421);
            this.Controls.Add(this.getbydate);
            this.Controls.Add(this.combobox_ManageTransactions_TID);
            this.Controls.Add(this.button_ManageTransactions_Delete);
            this.Controls.Add(this.button_ManageTransactions_Edit);
            this.Controls.Add(this.button_ManageTransactions_Insert);
            this.Controls.Add(this.textbox_ManageTransactions_DOT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textbox_ManageTransactions_Cname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Name = "ManageTransactions";
            this.Text = "Manage_Transactions";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textbox_ManageTransactions_Cname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textbox_ManageTransactions_DOT;
        private System.Windows.Forms.Button button_ManageTransactions_Insert;
        private System.Windows.Forms.Button button_ManageTransactions_Edit;
        private System.Windows.Forms.Button button_ManageTransactions_Delete;
        private System.Windows.Forms.ComboBox combobox_ManageTransactions_TID;
        private System.Windows.Forms.Button getbydate;
    }
}