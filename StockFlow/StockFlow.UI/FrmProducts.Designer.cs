namespace StockFlow.UI
{
    partial class FrmProducts
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
            panelSidebar = new System.Windows.Forms.Panel();
            lblLogo = new System.Windows.Forms.Label();
            lblDashboard = new System.Windows.Forms.Label();
            lblCategories = new System.Windows.Forms.Label();
            lblStock = new System.Windows.Forms.Label();
            panelHeader = new System.Windows.Forms.Panel();
            lblFormTitle = new System.Windows.Forms.Label();
            panelInputs = new System.Windows.Forms.Panel();
            chkIsActive = new System.Windows.Forms.CheckBox();
            txtProductDescription = new System.Windows.Forms.TextBox();
            lblProductDescription = new System.Windows.Forms.Label();
            cmbCategory = new System.Windows.Forms.ComboBox();
            lblCategory = new System.Windows.Forms.Label();
            txtProductPrice = new System.Windows.Forms.TextBox();
            lblProductPrice = new System.Windows.Forms.Label();
            txtProductStock = new System.Windows.Forms.TextBox();
            lblProductStock = new System.Windows.Forms.Label();
            btnUpdate = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();
            txtProductName = new System.Windows.Forms.TextBox();
            lblProductName = new System.Windows.Forms.Label();
            txtProductId = new System.Windows.Forms.TextBox();
            lblProductId = new System.Windows.Forms.Label();
            dataGridViewProducts = new System.Windows.Forms.DataGridView();
            panelSidebar.SuspendLayout();
            panelHeader.SuspendLayout();
            panelInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            SuspendLayout();

            panelSidebar.BackColor = System.Drawing.Color.FromArgb(30, 43, 60);
            panelSidebar.Controls.Add(lblLogo);
            panelSidebar.Controls.Add(lblDashboard);
            panelSidebar.Controls.Add(lblCategories);
            panelSidebar.Controls.Add(lblStock);
            panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            panelSidebar.Location = new System.Drawing.Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new System.Drawing.Size(250, 679);
            panelSidebar.TabIndex = 3;

            lblLogo.AutoSize = true;
            lblLogo.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            lblLogo.ForeColor = System.Drawing.Color.White;
            lblLogo.Location = new System.Drawing.Point(25, 30);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new System.Drawing.Size(151, 38);
            lblLogo.TabIndex = 7;
            lblLogo.Text = "StockFlow";

            lblDashboard.AutoSize = true;
            lblDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            lblDashboard.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblDashboard.ForeColor = System.Drawing.Color.Gainsboro;
            lblDashboard.Location = new System.Drawing.Point(30, 120);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new System.Drawing.Size(108, 28);
            lblDashboard.TabIndex = 4;
            lblDashboard.Text = "Dashboard";

            lblCategories.AutoSize = true;
            lblCategories.Cursor = System.Windows.Forms.Cursors.Hand;
            lblCategories.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblCategories.ForeColor = System.Drawing.Color.Gainsboro;
            lblCategories.Location = new System.Drawing.Point(30, 180);
            lblCategories.Name = "lblCategories";
            lblCategories.Size = new System.Drawing.Size(105, 28);
            lblCategories.TabIndex = 5;
            lblCategories.Text = "Categories";

            lblStock.AutoSize = true;
            lblStock.Cursor = System.Windows.Forms.Cursors.Hand;
            lblStock.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblStock.ForeColor = System.Drawing.Color.Gainsboro;
            lblStock.Location = new System.Drawing.Point(30, 240);
            lblStock.Name = "lblStock";
            lblStock.Size = new System.Drawing.Size(141, 28);
            lblStock.TabIndex = 6;
            lblStock.Text = "Stock Tracking";

            panelHeader.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            panelHeader.Controls.Add(lblFormTitle);
            panelHeader.Location = new System.Drawing.Point(270, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new System.Drawing.Size(1046, 70);
            panelHeader.TabIndex = 0;

            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            lblFormTitle.ForeColor = System.Drawing.Color.White;
            lblFormTitle.Location = new System.Drawing.Point(20, 15);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new System.Drawing.Size(315, 38);
            lblFormTitle.TabIndex = 0;
            lblFormTitle.Text = "Product Management";

            panelInputs.BackColor = System.Drawing.Color.White;
            panelInputs.Controls.Add(chkIsActive);
            panelInputs.Controls.Add(txtProductDescription);
            panelInputs.Controls.Add(lblProductDescription);
            panelInputs.Controls.Add(cmbCategory);
            panelInputs.Controls.Add(lblCategory);
            panelInputs.Controls.Add(txtProductPrice);
            panelInputs.Controls.Add(lblProductPrice);
            panelInputs.Controls.Add(txtProductStock);
            panelInputs.Controls.Add(lblProductStock);
            panelInputs.Controls.Add(btnUpdate);
            panelInputs.Controls.Add(btnDelete);
            panelInputs.Controls.Add(btnAdd);
            panelInputs.Controls.Add(txtProductName);
            panelInputs.Controls.Add(lblProductName);
            panelInputs.Controls.Add(txtProductId);
            panelInputs.Controls.Add(lblProductId);
            panelInputs.Location = new System.Drawing.Point(270, 90);
            panelInputs.Name = "panelInputs";
            panelInputs.Size = new System.Drawing.Size(350, 589);
            panelInputs.TabIndex = 1;

            chkIsActive.AutoSize = true;
            chkIsActive.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            chkIsActive.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            chkIsActive.Location = new System.Drawing.Point(25, 370);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new System.Drawing.Size(166, 27);
            chkIsActive.TabIndex = 12;
            chkIsActive.Text = "Product is Active";
            chkIsActive.UseVisualStyleBackColor = true;

            txtProductDescription.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            txtProductDescription.Location = new System.Drawing.Point(25, 300);
            txtProductDescription.Multiline = true;
            txtProductDescription.Name = "txtProductDescription";
            txtProductDescription.Size = new System.Drawing.Size(300, 60);
            txtProductDescription.TabIndex = 11;

            lblProductDescription.AutoSize = true;
            lblProductDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            lblProductDescription.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            lblProductDescription.Location = new System.Drawing.Point(20, 275);
            lblProductDescription.Name = "lblProductDescription";
            lblProductDescription.Size = new System.Drawing.Size(100, 23);
            lblProductDescription.TabIndex = 10;
            lblProductDescription.Text = "Description:";

            cmbCategory.Font = new System.Drawing.Font("Segoe UI", 12F);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new System.Drawing.Point(25, 235);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new System.Drawing.Size(300, 36);
            cmbCategory.TabIndex = 9;

            lblCategory.AutoSize = true;
            lblCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            lblCategory.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            lblCategory.Location = new System.Drawing.Point(20, 210);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new System.Drawing.Size(85, 23);
            lblCategory.TabIndex = 8;
            lblCategory.Text = "Category:";

            txtProductPrice.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtProductPrice.Location = new System.Drawing.Point(185, 170);
            txtProductPrice.Name = "txtProductPrice";
            txtProductPrice.Size = new System.Drawing.Size(140, 34);
            txtProductPrice.TabIndex = 7;

            lblProductPrice.AutoSize = true;
            lblProductPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            lblProductPrice.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            lblProductPrice.Location = new System.Drawing.Point(180, 145);
            lblProductPrice.Name = "lblProductPrice";
            lblProductPrice.Size = new System.Drawing.Size(51, 23);
            lblProductPrice.TabIndex = 6;
            lblProductPrice.Text = "Price:";

            txtProductStock.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtProductStock.Location = new System.Drawing.Point(25, 170);
            txtProductStock.Name = "txtProductStock";
            txtProductStock.Size = new System.Drawing.Size(140, 34);
            txtProductStock.TabIndex = 5;

            lblProductStock.AutoSize = true;
            lblProductStock.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            lblProductStock.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            lblProductStock.Location = new System.Drawing.Point(20, 145);
            lblProductStock.Name = "lblProductStock";
            lblProductStock.Size = new System.Drawing.Size(129, 23);
            lblProductStock.TabIndex = 4;
            lblProductStock.Text = "Stock Quantity:";

            btnUpdate.BackColor = System.Drawing.Color.FromArgb(243, 156, 18);
            btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            btnUpdate.ForeColor = System.Drawing.Color.White;
            btnUpdate.Location = new System.Drawing.Point(25, 525);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(300, 45);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Update Product";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;

            btnDelete.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            btnDelete.ForeColor = System.Drawing.Color.White;
            btnDelete.Location = new System.Drawing.Point(25, 470);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(300, 45);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete Product";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;

            btnAdd.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            btnAdd.ForeColor = System.Drawing.Color.White;
            btnAdd.Location = new System.Drawing.Point(25, 415);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(300, 45);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Add New Product";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;

            txtProductName.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtProductName.Location = new System.Drawing.Point(25, 105);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new System.Drawing.Size(300, 34);
            txtProductName.TabIndex = 3;

            lblProductName.AutoSize = true;
            lblProductName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            lblProductName.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            lblProductName.Location = new System.Drawing.Point(20, 80);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new System.Drawing.Size(125, 23);
            lblProductName.TabIndex = 2;
            lblProductName.Text = "Product Name:";

            txtProductId.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtProductId.Location = new System.Drawing.Point(25, 40);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new System.Drawing.Size(300, 34);
            txtProductId.TabIndex = 1;

            lblProductId.AutoSize = true;
            lblProductId.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            lblProductId.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            lblProductId.Location = new System.Drawing.Point(20, 15);
            lblProductId.Name = "lblProductId";
            lblProductId.Size = new System.Drawing.Size(97, 23);
            lblProductId.TabIndex = 0;
            lblProductId.Text = "Product ID:";

            dataGridViewProducts.AllowUserToAddRows = false;
            dataGridViewProducts.AllowUserToDeleteRows = false;
            dataGridViewProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProducts.BackgroundColor = System.Drawing.Color.White;
            dataGridViewProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridViewProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.EnableHeadersVisualStyles = false;
            dataGridViewProducts.Location = new System.Drawing.Point(640, 90);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.ReadOnly = true;
            dataGridViewProducts.RowHeadersVisible = false;
            dataGridViewProducts.RowHeadersWidth = 51;
            dataGridViewProducts.RowTemplate.Height = 35;
            dataGridViewProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProducts.Size = new System.Drawing.Size(676, 570);
            dataGridViewProducts.TabIndex = 2;

            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(245, 246, 250);
            ClientSize = new System.Drawing.Size(1328, 679);
            Controls.Add(panelSidebar);
            Controls.Add(dataGridViewProducts);
            Controls.Add(panelInputs);
            Controls.Add(panelHeader);
            Name = "FrmProducts";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Product Management";
            Load += FrmProducts_Load;
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelInputs.ResumeLayout(false);
            panelInputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Panel panelInputs;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductStock;
        private System.Windows.Forms.Label lblProductStock;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtProductDescription;
        private System.Windows.Forms.Label lblProductDescription;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
    }
}