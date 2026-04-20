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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panelSidebar = new Panel();
            lblLogo = new Label();
            lblDashboard = new Label();
            lblCategories = new Label();
            lblStock = new Label();
            panelHeader = new Panel();
            lblFormTitle = new Label();
            panelInputs = new Panel();
            chkIsActive = new CheckBox();
            txtProductDescription = new TextBox();
            lblProductDescription = new Label();
            cmbCategory = new ComboBox();
            lblCategory = new Label();
            txtProductPrice = new TextBox();
            lblProductPrice = new Label();
            txtProductStock = new TextBox();
            lblProductStock = new Label();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            txtProductName = new TextBox();
            lblProductName = new Label();
            txtProductId = new TextBox();
            lblProductId = new Label();
            dataGridViewProducts = new DataGridView();
            panelSidebar.SuspendLayout();
            panelHeader.SuspendLayout();
            panelInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(30, 43, 60);
            panelSidebar.Controls.Add(lblLogo);
            panelSidebar.Controls.Add(lblDashboard);
            panelSidebar.Controls.Add(lblCategories);
            panelSidebar.Controls.Add(lblStock);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(250, 679);
            panelSidebar.TabIndex = 3;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(25, 30);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(151, 38);
            lblLogo.TabIndex = 7;
            lblLogo.Text = "StockFlow";
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Cursor = Cursors.Hand;
            lblDashboard.Font = new Font("Segoe UI", 12F);
            lblDashboard.ForeColor = Color.Gainsboro;
            lblDashboard.Location = new Point(30, 120);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(108, 28);
            lblDashboard.TabIndex = 4;
            lblDashboard.Text = "Dashboard";
            lblDashboard.Click += lblDashboard_Click;
            // 
            // lblCategories
            // 
            lblCategories.AutoSize = true;
            lblCategories.Cursor = Cursors.Hand;
            lblCategories.Font = new Font("Segoe UI", 12F);
            lblCategories.ForeColor = Color.Gainsboro;
            lblCategories.Location = new Point(30, 180);
            lblCategories.Name = "lblCategories";
            lblCategories.Size = new Size(105, 28);
            lblCategories.TabIndex = 5;
            lblCategories.Text = "Categories";
            lblCategories.Click += lblCategories_Click;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Cursor = Cursors.Hand;
            lblStock.Font = new Font("Segoe UI", 12F);
            lblStock.ForeColor = Color.Gainsboro;
            lblStock.Location = new Point(30, 240);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(137, 28);
            lblStock.TabIndex = 6;
            lblStock.Text = "Stock Tracking";
            lblStock.Click += lblStock_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(52, 152, 219);
            panelHeader.Controls.Add(lblFormTitle);
            panelHeader.Location = new Point(270, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1146, 70);
            panelHeader.TabIndex = 0;
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            lblFormTitle.ForeColor = Color.White;
            lblFormTitle.Location = new Point(20, 15);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(303, 38);
            lblFormTitle.TabIndex = 0;
            lblFormTitle.Text = "Product Management";
            // 
            // panelInputs
            // 
            panelInputs.BackColor = Color.White;
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
            panelInputs.Location = new Point(270, 90);
            panelInputs.Name = "panelInputs";
            panelInputs.Size = new Size(350, 589);
            panelInputs.TabIndex = 1;
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            chkIsActive.ForeColor = Color.FromArgb(64, 64, 64);
            chkIsActive.Location = new Point(25, 370);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(160, 27);
            chkIsActive.TabIndex = 12;
            chkIsActive.Text = "Product is Active";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // txtProductDescription
            // 
            txtProductDescription.Font = new Font("Segoe UI", 10.8F);
            txtProductDescription.Location = new Point(25, 300);
            txtProductDescription.Multiline = true;
            txtProductDescription.Name = "txtProductDescription";
            txtProductDescription.Size = new Size(300, 60);
            txtProductDescription.TabIndex = 11;
            // 
            // lblProductDescription
            // 
            lblProductDescription.AutoSize = true;
            lblProductDescription.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblProductDescription.ForeColor = Color.FromArgb(64, 64, 64);
            lblProductDescription.Location = new Point(20, 275);
            lblProductDescription.Name = "lblProductDescription";
            lblProductDescription.Size = new Size(100, 23);
            lblProductDescription.TabIndex = 10;
            lblProductDescription.Text = "Description:";
            // 
            // cmbCategory
            // 
            cmbCategory.Font = new Font("Segoe UI", 12F);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(25, 235);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(300, 36);
            cmbCategory.TabIndex = 9;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblCategory.ForeColor = Color.FromArgb(64, 64, 64);
            lblCategory.Location = new Point(20, 210);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(85, 23);
            lblCategory.TabIndex = 8;
            lblCategory.Text = "Category:";
            // 
            // txtProductPrice
            // 
            txtProductPrice.Font = new Font("Segoe UI", 12F);
            txtProductPrice.Location = new Point(185, 170);
            txtProductPrice.Name = "txtProductPrice";
            txtProductPrice.Size = new Size(140, 34);
            txtProductPrice.TabIndex = 7;
            // 
            // lblProductPrice
            // 
            lblProductPrice.AutoSize = true;
            lblProductPrice.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblProductPrice.ForeColor = Color.FromArgb(64, 64, 64);
            lblProductPrice.Location = new Point(180, 145);
            lblProductPrice.Name = "lblProductPrice";
            lblProductPrice.Size = new Size(51, 23);
            lblProductPrice.TabIndex = 6;
            lblProductPrice.Text = "Price:";
            // 
            // txtProductStock
            // 
            txtProductStock.Font = new Font("Segoe UI", 12F);
            txtProductStock.Location = new Point(25, 170);
            txtProductStock.Name = "txtProductStock";
            txtProductStock.Size = new Size(140, 34);
            txtProductStock.TabIndex = 5;
            // 
            // lblProductStock
            // 
            lblProductStock.AutoSize = true;
            lblProductStock.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblProductStock.ForeColor = Color.FromArgb(64, 64, 64);
            lblProductStock.Location = new Point(20, 145);
            lblProductStock.Name = "lblProductStock";
            lblProductStock.Size = new Size(128, 23);
            lblProductStock.TabIndex = 4;
            lblProductStock.Text = "Stock Quantity:";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(243, 156, 18);
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(25, 525);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(300, 45);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Update Product";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(231, 76, 60);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(25, 470);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(300, 45);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete Product";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(46, 204, 113);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(25, 415);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(300, 45);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Add New Product";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Segoe UI", 12F);
            txtProductName.Location = new Point(25, 105);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(300, 34);
            txtProductName.TabIndex = 3;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblProductName.ForeColor = Color.FromArgb(64, 64, 64);
            lblProductName.Location = new Point(20, 80);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(125, 23);
            lblProductName.TabIndex = 2;
            lblProductName.Text = "Product Name:";
            // 
            // txtProductId
            // 
            txtProductId.Font = new Font("Segoe UI", 12F);
            txtProductId.Location = new Point(25, 40);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(300, 34);
            txtProductId.TabIndex = 1;
            // 
            // lblProductId
            // 
            lblProductId.AutoSize = true;
            lblProductId.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblProductId.ForeColor = Color.FromArgb(64, 64, 64);
            lblProductId.Location = new Point(20, 15);
            lblProductId.Name = "lblProductId";
            lblProductId.Size = new Size(96, 23);
            lblProductId.TabIndex = 0;
            lblProductId.Text = "Product ID:";
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.AllowUserToAddRows = false;
            dataGridViewProducts.AllowUserToDeleteRows = false;
            dataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProducts.BackgroundColor = Color.White;
            dataGridViewProducts.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.EnableHeadersVisualStyles = false;
            dataGridViewProducts.Location = new Point(640, 90);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.ReadOnly = true;
            dataGridViewProducts.RowHeadersVisible = false;
            dataGridViewProducts.RowHeadersWidth = 51;
            dataGridViewProducts.RowTemplate.Height = 35;
            dataGridViewProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProducts.Size = new Size(776, 570);
            dataGridViewProducts.TabIndex = 2;
            // 
            // FrmProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 250);
            ClientSize = new Size(1428, 679);
            Controls.Add(panelSidebar);
            Controls.Add(dataGridViewProducts);
            Controls.Add(panelInputs);
            Controls.Add(panelHeader);
            Name = "FrmProducts";
            StartPosition = FormStartPosition.CenterScreen;
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