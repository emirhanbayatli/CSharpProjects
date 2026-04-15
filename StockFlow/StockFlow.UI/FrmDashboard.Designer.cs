namespace StockFlow.UI
{
    partial class FrmDashboard
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
            panel1 = new Panel();
            lblTotalProductCount = new Label();
            label1 = new Label();
            panel2 = new Panel();
            lblCriticalStockCount = new Label();
            label3 = new Label();
            panel3 = new Panel();
            lblTotalCategoryCount = new Label();
            label5 = new Label();
            panel4 = new Panel();
            labelLogo = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(52, 152, 219);
            panel1.Controls.Add(lblTotalProductCount);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(290, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(280, 150);
            panel1.TabIndex = 0;
            // 
            // lblTotalProductCount
            // 
            lblTotalProductCount.AutoSize = true;
            lblTotalProductCount.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold);
            lblTotalProductCount.ForeColor = Color.White;
            lblTotalProductCount.Location = new Point(15, 60);
            lblTotalProductCount.Name = "lblTotalProductCount";
            lblTotalProductCount.Size = new Size(54, 62);
            lblTotalProductCount.TabIndex = 4;
            lblTotalProductCount.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(129, 28);
            label1.TabIndex = 3;
            label1.Text = "Toplam Ürün";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(231, 76, 60);
            panel2.Controls.Add(lblCriticalStockCount);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(600, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(280, 150);
            panel2.TabIndex = 1;
            // 
            // lblCriticalStockCount
            // 
            lblCriticalStockCount.AutoSize = true;
            lblCriticalStockCount.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold);
            lblCriticalStockCount.ForeColor = Color.White;
            lblCriticalStockCount.Location = new Point(15, 60);
            lblCriticalStockCount.Name = "lblCriticalStockCount";
            lblCriticalStockCount.Size = new Size(54, 62);
            lblCriticalStockCount.TabIndex = 4;
            lblCriticalStockCount.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(20, 20);
            label3.Name = "label3";
            label3.Size = new Size(212, 28);
            label3.TabIndex = 3;
            label3.Text = "Kritik Stoktaki Ürünler";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(46, 204, 113);
            panel3.Controls.Add(lblTotalCategoryCount);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(910, 40);
            panel3.Name = "panel3";
            panel3.Size = new Size(280, 150);
            panel3.TabIndex = 2;
            // 
            // lblTotalCategoryCount
            // 
            lblTotalCategoryCount.AutoSize = true;
            lblTotalCategoryCount.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold);
            lblTotalCategoryCount.ForeColor = Color.White;
            lblTotalCategoryCount.Location = new Point(15, 60);
            lblTotalCategoryCount.Name = "lblTotalCategoryCount";
            lblTotalCategoryCount.Size = new Size(54, 62);
            lblTotalCategoryCount.TabIndex = 4;
            lblTotalCategoryCount.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(20, 20);
            label5.Name = "label5";
            label5.Size = new Size(160, 28);
            label5.TabIndex = 3;
            label5.Text = "Toplam Kategori";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(30, 43, 60);
            panel4.Controls.Add(labelLogo);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label6);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 652);
            panel4.TabIndex = 3;
            // 
            // labelLogo
            // 
            labelLogo.AutoSize = true;
            labelLogo.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            labelLogo.ForeColor = Color.White;
            labelLogo.Location = new Point(25, 30);
            labelLogo.Name = "labelLogo";
            labelLogo.Size = new Size(151, 38);
            labelLogo.TabIndex = 7;
            labelLogo.Text = "StockFlow";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Cursor = Cursors.Hand;
            label8.Font = new Font("Segoe UI", 12F);
            label8.ForeColor = Color.Gainsboro;
            label8.Location = new Point(30, 240);
            label8.Name = "label8";
            label8.Size = new Size(101, 28);
            label8.TabIndex = 6;
            label8.Text = "Stok Takip";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Cursor = Cursors.Hand;
            label7.Font = new Font("Segoe UI", 12F);
            label7.ForeColor = Color.Gainsboro;
            label7.Location = new Point(30, 180);
            label7.Name = "label7";
            label7.Size = new Size(77, 28);
            label7.TabIndex = 5;
            label7.Text = "Ürünler";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = Color.Gainsboro;
            label6.Location = new Point(30, 120);
            label6.Name = "label6";
            label6.Size = new Size(109, 28);
            label6.TabIndex = 4;
            label6.Text = "Kategoriler";
            label6.Click += label6_Click;
            // 
            // FrmDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 250);
            ClientSize = new Size(1230, 652);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalProductCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCriticalStockCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTotalCategoryCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelLogo; 
    }
}