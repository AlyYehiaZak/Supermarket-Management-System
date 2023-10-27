namespace SupermarketManagementSystem
{
    partial class StockControllerPage
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
            this.button_ViewData_StockController = new System.Windows.Forms.Button();
            this.combobox_Categories_StockController = new System.Windows.Forms.ComboBox();
            this.label_Categories = new System.Windows.Forms.Label();
            this.LOGOUT = new System.Windows.Forms.Button();
            this.dataGridView_StockController = new System.Windows.Forms.DataGridView();
            this.button_StockController_GoStock = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_StockController)).BeginInit();
            this.SuspendLayout();
            // 
            // button_ViewData_StockController
            // 
            this.button_ViewData_StockController.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_ViewData_StockController.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ViewData_StockController.ForeColor = System.Drawing.Color.White;
            this.button_ViewData_StockController.Location = new System.Drawing.Point(19, 113);
            this.button_ViewData_StockController.Margin = new System.Windows.Forms.Padding(2);
            this.button_ViewData_StockController.Name = "button_ViewData_StockController";
            this.button_ViewData_StockController.Size = new System.Drawing.Size(113, 37);
            this.button_ViewData_StockController.TabIndex = 9;
            this.button_ViewData_StockController.Text = "View Data";
            this.button_ViewData_StockController.UseVisualStyleBackColor = false;
            this.button_ViewData_StockController.Click += new System.EventHandler(this.button_ViewData_StockController_Click);
            // 
            // combobox_Categories_StockController
            // 
            this.combobox_Categories_StockController.FormattingEnabled = true;
            this.combobox_Categories_StockController.Location = new System.Drawing.Point(19, 61);
            this.combobox_Categories_StockController.Margin = new System.Windows.Forms.Padding(2);
            this.combobox_Categories_StockController.Name = "combobox_Categories_StockController";
            this.combobox_Categories_StockController.Size = new System.Drawing.Size(113, 21);
            this.combobox_Categories_StockController.TabIndex = 10;
            // 
            // label_Categories
            // 
            this.label_Categories.AutoSize = true;
            this.label_Categories.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Categories.ForeColor = System.Drawing.Color.Black;
            this.label_Categories.Location = new System.Drawing.Point(15, 21);
            this.label_Categories.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Categories.Name = "label_Categories";
            this.label_Categories.Size = new System.Drawing.Size(96, 21);
            this.label_Categories.TabIndex = 11;
            this.label_Categories.Text = "Categories";
            // 
            // LOGOUT
            // 
            this.LOGOUT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LOGOUT.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGOUT.ForeColor = System.Drawing.Color.White;
            this.LOGOUT.Location = new System.Drawing.Point(480, 375);
            this.LOGOUT.Margin = new System.Windows.Forms.Padding(2);
            this.LOGOUT.Name = "LOGOUT";
            this.LOGOUT.Size = new System.Drawing.Size(68, 26);
            this.LOGOUT.TabIndex = 12;
            this.LOGOUT.Text = "LOGOUT";
            this.LOGOUT.UseVisualStyleBackColor = false;
            this.LOGOUT.Click += new System.EventHandler(this.LOGOUT_Click);
            // 
            // dataGridView_StockController
            // 
            this.dataGridView_StockController.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_StockController.Location = new System.Drawing.Point(26, 184);
            this.dataGridView_StockController.Name = "dataGridView_StockController";
            this.dataGridView_StockController.Size = new System.Drawing.Size(380, 217);
            this.dataGridView_StockController.TabIndex = 13;
            // 
            // button_StockController_GoStock
            // 
            this.button_StockController_GoStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_StockController_GoStock.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_StockController_GoStock.ForeColor = System.Drawing.Color.White;
            this.button_StockController_GoStock.Location = new System.Drawing.Point(166, 113);
            this.button_StockController_GoStock.Margin = new System.Windows.Forms.Padding(2);
            this.button_StockController_GoStock.Name = "button_StockController_GoStock";
            this.button_StockController_GoStock.Size = new System.Drawing.Size(115, 37);
            this.button_StockController_GoStock.TabIndex = 14;
            this.button_StockController_GoStock.Text = "GO RESTOCK";
            this.button_StockController_GoStock.UseVisualStyleBackColor = false;
            this.button_StockController_GoStock.Click += new System.EventHandler(this.button_StockController_GoStock_Click);
            // 
            // StockControllerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(569, 450);
            this.Controls.Add(this.button_StockController_GoStock);
            this.Controls.Add(this.dataGridView_StockController);
            this.Controls.Add(this.LOGOUT);
            this.Controls.Add(this.label_Categories);
            this.Controls.Add(this.combobox_Categories_StockController);
            this.Controls.Add(this.button_ViewData_StockController);
            this.Name = "StockControllerPage";
            this.Text = "Stock Controller Page";
            this.Load += new System.EventHandler(this.StockControllerPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_StockController)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_ViewData_StockController;
        private System.Windows.Forms.ComboBox combobox_Categories_StockController;
        private System.Windows.Forms.Label label_Categories;
        private System.Windows.Forms.Button LOGOUT;
        private System.Windows.Forms.DataGridView dataGridView_StockController;
        private System.Windows.Forms.Button button_StockController_GoStock;
    }
}