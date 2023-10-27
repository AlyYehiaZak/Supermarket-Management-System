namespace SupermarketManagementSystem
{
    partial class RestockPage
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
            this.textBox_Restock_ItemsRemain = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Restock_ItemName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Restock_GetNumber = new System.Windows.Forms.Button();
            this.textBox_Restock_NumberItemsAdded = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Restock_Restock = new System.Windows.Forms.Button();
            this.button_Restock_GoBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Restock_ItemsRemain
            // 
            this.textBox_Restock_ItemsRemain.Location = new System.Drawing.Point(200, 108);
            this.textBox_Restock_ItemsRemain.Name = "textBox_Restock_ItemsRemain";
            this.textBox_Restock_ItemsRemain.Size = new System.Drawing.Size(121, 20);
            this.textBox_Restock_ItemsRemain.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item Name";
            // 
            // comboBox_Restock_ItemName
            // 
            this.comboBox_Restock_ItemName.FormattingEnabled = true;
            this.comboBox_Restock_ItemName.Location = new System.Drawing.Point(200, 57);
            this.comboBox_Restock_ItemName.Name = "comboBox_Restock_ItemName";
            this.comboBox_Restock_ItemName.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Restock_ItemName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Items Remaining";
            // 
            // button_Restock_GetNumber
            // 
            this.button_Restock_GetNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_Restock_GetNumber.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Restock_GetNumber.ForeColor = System.Drawing.Color.White;
            this.button_Restock_GetNumber.Location = new System.Drawing.Point(341, 105);
            this.button_Restock_GetNumber.Margin = new System.Windows.Forms.Padding(2);
            this.button_Restock_GetNumber.Name = "button_Restock_GetNumber";
            this.button_Restock_GetNumber.Size = new System.Drawing.Size(147, 24);
            this.button_Restock_GetNumber.TabIndex = 10;
            this.button_Restock_GetNumber.Text = "Get Number Of Item";
            this.button_Restock_GetNumber.UseVisualStyleBackColor = false;
            this.button_Restock_GetNumber.Click += new System.EventHandler(this.button_Restock_GetNumber_Click);
            // 
            // textBox_Restock_NumberItemsAdded
            // 
            this.textBox_Restock_NumberItemsAdded.Location = new System.Drawing.Point(200, 155);
            this.textBox_Restock_NumberItemsAdded.Name = "textBox_Restock_NumberItemsAdded";
            this.textBox_Restock_NumberItemsAdded.Size = new System.Drawing.Size(121, 20);
            this.textBox_Restock_NumberItemsAdded.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Number Of Items To Be Added";
            // 
            // button_Restock_Restock
            // 
            this.button_Restock_Restock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_Restock_Restock.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Restock_Restock.ForeColor = System.Drawing.Color.White;
            this.button_Restock_Restock.Location = new System.Drawing.Point(200, 218);
            this.button_Restock_Restock.Margin = new System.Windows.Forms.Padding(2);
            this.button_Restock_Restock.Name = "button_Restock_Restock";
            this.button_Restock_Restock.Size = new System.Drawing.Size(113, 37);
            this.button_Restock_Restock.TabIndex = 13;
            this.button_Restock_Restock.Text = "Restock";
            this.button_Restock_Restock.UseVisualStyleBackColor = false;
            this.button_Restock_Restock.Click += new System.EventHandler(this.button_Restock_Restock_Click);
            // 
            // button_Restock_GoBack
            // 
            this.button_Restock_GoBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_Restock_GoBack.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Restock_GoBack.ForeColor = System.Drawing.Color.White;
            this.button_Restock_GoBack.Location = new System.Drawing.Point(420, 229);
            this.button_Restock_GoBack.Margin = new System.Windows.Forms.Padding(2);
            this.button_Restock_GoBack.Name = "button_Restock_GoBack";
            this.button_Restock_GoBack.Size = new System.Drawing.Size(68, 26);
            this.button_Restock_GoBack.TabIndex = 14;
            this.button_Restock_GoBack.Text = "Go Back";
            this.button_Restock_GoBack.UseVisualStyleBackColor = false;
            this.button_Restock_GoBack.Click += new System.EventHandler(this.button_Restock_GoBack_Click);
            // 
            // RestockPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 290);
            this.Controls.Add(this.button_Restock_GoBack);
            this.Controls.Add(this.button_Restock_Restock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Restock_NumberItemsAdded);
            this.Controls.Add(this.button_Restock_GetNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_Restock_ItemName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Restock_ItemsRemain);
            this.Name = "RestockPage";
            this.Text = "RestockPage";
            this.Load += new System.EventHandler(this.RestockPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Restock_ItemsRemain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Restock_ItemName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Restock_GetNumber;
        private System.Windows.Forms.TextBox textBox_Restock_NumberItemsAdded;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Restock_Restock;
        private System.Windows.Forms.Button button_Restock_GoBack;
    }
}