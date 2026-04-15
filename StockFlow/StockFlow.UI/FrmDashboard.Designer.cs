namespace StockFlow.UI
{
    partial class FrmDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            panel1 = new System.Windows.Forms.Panel();
            lblTotalProductCount = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            panel3 = new System.Windows.Forms.Panel();
            lblTotalCategoryCount = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            panel4 = new System.Windows.Forms.Panel();
            labelLogo = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            dataGridViewCriticalStock = new System.Windows.Forms.DataGridView();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            dataGridViewZeroStockProduct = new System.Windows.Forms.DataGridView();
            panel2 = new System.Windows.Forms.Panel();
            lblTotalStokCount = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCriticalStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewZeroStockProduct).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            panel1.Controls.Add(lblTotalProductCount);
            panel1.Controls.Add(label1);
            panel1.Location = new System.Drawing.Point(290, 30);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(300, 130);
            panel1.TabIndex = 0;
            // 
            // lblTotalProductCount
            // 
            lblTotalProductCount.AutoSize = true;
            lblTotalProductCount.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold);
            lblTotalProductCount.ForeColor = System.Drawing.Color.White;
            lblTotalProductCount.Location = new System.Drawing.Point(15, 50);
            lblTotalProductCount.Name = "lblTotalProductCount";
            lblTotalProductCount.Size = new System.Drawing.Size(54, 62);
            lblTotalProductCount.TabIndex = 4;
            lblTotalProductCount.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(20, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(142, 28);
            label1.TabIndex = 3;
            label1.Text = "Total Products";
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            panel3.Controls.Add(lblTotalCategoryCount);
            panel3.Controls.Add(label5);
            panel3.Location = new System.Drawing.Point(604, 30);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(300, 130);
            panel3.TabIndex = 2;
            // 
            // lblTotalCategoryCount
            // 
            lblTotalCategoryCount.AutoSize = true;
            lblTotalCategoryCount.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold);
            lblTotalCategoryCount.ForeColor = System.Drawing.Color.White;
            lblTotalCategoryCount.Location = new System.Drawing.Point(15, 50);
            lblTotalCategoryCount.Name = "lblTotalCategoryCount";
            lblTotalCategoryCount.Size = new System.Drawing.Size(54, 62);
            lblTotalCategoryCount.TabIndex = 4;
            lblTotalCategoryCount.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            label5.ForeColor = System.Drawing.Color.White;
            label5.Location = new System.Drawing.Point(20, 15);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(159, 28);
            label5.TabIndex = 3;
            label5.Text = "Total Categories";
            // 
            // panel4
            // 
            panel4.BackColor = System.Drawing.Color.FromArgb(30, 43, 60);
            panel4.Controls.Add(labelLogo);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label6);
            panel4.Dock = System.Windows.Forms.DockStyle.Left;
            panel4.Location = new System.Drawing.Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(250, 652);
            panel4.TabIndex = 3;
            // 
            // labelLogo
            // 
            labelLogo.AutoSize = true;
            labelLogo.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            labelLogo.ForeColor = System.Drawing.Color.White;
            labelLogo.Location = new System.Drawing.Point(25, 30);
            labelLogo.Name = "labelLogo";
            labelLogo.Size = new System.Drawing.Size(151, 38);
            labelLogo.TabIndex = 7;
            labelLogo.Text = "StockFlow";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Cursor = System.Windows.Forms.Cursors.Hand;
            label8.Font = new System.Drawing.Font("Segoe UI", 12F);
            label8.ForeColor = System.Drawing.Color.Gainsboro;
            label8.Location = new System.Drawing.Point(30, 240);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(141, 28);
            label8.TabIndex = 6;
            label8.Text = "Stock Tracking";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Cursor = System.Windows.Forms.Cursors.Hand;
            label7.Font = new System.Drawing.Font("Segoe UI", 12F);
            label7.ForeColor = System.Drawing.Color.Gainsboro;
            label7.Location = new System.Drawing.Point(30, 180);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(89, 28);
            label7.TabIndex = 5;
            label7.Text = "Products";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = System.Windows.Forms.Cursors.Hand;
            label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            label6.ForeColor = System.Drawing.Color.Gainsboro;
            label6.Location = new System.Drawing.Point(30, 120);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(105, 28);
            label6.TabIndex = 4;
            label6.Text = "Categories";
            label6.Click += label6_Click;
            // 
            // dataGridViewCriticalStock
            // 
            dataGridViewCriticalStock.AllowUserToAddRows = false;
            dataGridViewCriticalStock.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(249, 249, 249);
            dataGridViewCriticalStock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCriticalStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCriticalStock.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCriticalStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(243, 156, 18);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(243, 156, 18);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridViewCriticalStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCriticalStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCriticalStock.EnableHeadersVisualStyles = false;
            dataGridViewCriticalStock.GridColor = System.Drawing.Color.FromArgb(224, 224, 224);
            dataGridViewCriticalStock.Location = new System.Drawing.Point(290, 225);
            dataGridViewCriticalStock.Name = "dataGridViewCriticalStock";
            dataGridViewCriticalStock.ReadOnly = true;
            dataGridViewCriticalStock.RowHeadersVisible = false;
            dataGridViewCriticalStock.RowHeadersWidth = 51;
            dataGridViewCriticalStock.RowTemplate.Height = 40;
            dataGridViewCriticalStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCriticalStock.Size = new System.Drawing.Size(900, 165);
            dataGridViewCriticalStock.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            label2.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            label2.Location = new System.Drawing.Point(285, 185);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(262, 31);
            label2.TabIndex = 5;
            label2.Text = "Low Stock Level Items";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            label3.ForeColor = System.Drawing.Color.FromArgb(231, 76, 60);
            label3.Location = new System.Drawing.Point(285, 415);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(193, 31);
            label3.TabIndex = 6;
            label3.Text = "Out of Stock Items";
            // 
            // dataGridViewZeroStockProduct
            // 
            dataGridViewZeroStockProduct.AllowUserToAddRows = false;
            dataGridViewZeroStockProduct.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(249, 249, 249);
            dataGridViewZeroStockProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewZeroStockProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewZeroStockProduct.BackgroundColor = System.Drawing.Color.White;
            dataGridViewZeroStockProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridViewZeroStockProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewZeroStockProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewZeroStockProduct.EnableHeadersVisualStyles = false;
            dataGridViewZeroStockProduct.GridColor = System.Drawing.Color.FromArgb(224, 224, 224);
            dataGridViewZeroStockProduct.Location = new System.Drawing.Point(290, 455);
            dataGridViewZeroStockProduct.Name = "dataGridViewZeroStockProduct";
            dataGridViewZeroStockProduct.ReadOnly = true;
            dataGridViewZeroStockProduct.RowHeadersVisible = false;
            dataGridViewZeroStockProduct.RowHeadersWidth = 51;
            dataGridViewZeroStockProduct.RowTemplate.Height = 40;
            dataGridViewZeroStockProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridViewZeroStockProduct.Size = new System.Drawing.Size(900, 165);
            dataGridViewZeroStockProduct.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.LightCoral;
            panel2.Controls.Add(lblTotalStokCount);
            panel2.Controls.Add(label9);
            panel2.Location = new System.Drawing.Point(918, 30);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(300, 130);
            panel2.TabIndex = 8;
            // 
            // lblTotalStokCount
            // 
            lblTotalStokCount.AutoSize = true;
            lblTotalStokCount.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold);
            lblTotalStokCount.ForeColor = System.Drawing.Color.White;
            lblTotalStokCount.Location = new System.Drawing.Point(15, 50);
            lblTotalStokCount.Name = "lblTotalStokCount";
            lblTotalStokCount.Size = new System.Drawing.Size(54, 62);
            lblTotalStokCount.TabIndex = 4;
            lblTotalStokCount.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            label9.ForeColor = System.Drawing.Color.White;
            label9.Location = new System.Drawing.Point(20, 15);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(186, 28);
            label9.TabIndex = 3;
            label9.Text = "Total Stock Quantity";
            // 
            // FrmDashboard
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(245, 246, 250);
            ClientSize = new System.Drawing.Size(1230, 652);
            Controls.Add(panel2);
            Controls.Add(dataGridViewZeroStockProduct);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridViewCriticalStock);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "FrmDashboard";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += FrmDashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCriticalStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewZeroStockProduct).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalProductCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTotalCategoryCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.DataGridView dataGridViewCriticalStock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewZeroStockProduct;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalStokCount;
        private System.Windows.Forms.Label label9;
    }
}