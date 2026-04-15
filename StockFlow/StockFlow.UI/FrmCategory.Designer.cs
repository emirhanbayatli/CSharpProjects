namespace StockFlow.UI
{
    partial class FrmCategory
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panelSidebar = new Panel();
            lblLogo = new Label();
            lblStock = new Label();
            lblProducts = new Label();
            lblDashboard = new Label();
            panelHeader = new Panel();
            lblFormTitle = new Label();
            panelInputs = new Panel();
            chkIsActive = new CheckBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            txtCategoryName = new TextBox();
            lblCategoryName = new Label();
            txtCategoryId = new TextBox();
            lblCategoryId = new Label();
            dataGridViewCategories = new DataGridView();
            panelSidebar.SuspendLayout();
            panelHeader.SuspendLayout();
            panelInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategories).BeginInit();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(30, 43, 60);
            panelSidebar.Controls.Add(lblLogo);
            panelSidebar.Controls.Add(lblStock);
            panelSidebar.Controls.Add(lblProducts);
            panelSidebar.Controls.Add(lblDashboard);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(250, 600);
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
            // lblProducts
            // 
            lblProducts.AutoSize = true;
            lblProducts.Cursor = Cursors.Hand;
            lblProducts.Font = new Font("Segoe UI", 12F);
            lblProducts.ForeColor = Color.Gainsboro;
            lblProducts.Location = new Point(30, 180);
            lblProducts.Name = "lblProducts";
            lblProducts.Size = new Size(89, 28);
            lblProducts.TabIndex = 5;
            lblProducts.Text = "Products";
            lblProducts.Click += lblProducts_Click;
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
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(52, 152, 219);
            panelHeader.Controls.Add(lblFormTitle);
            panelHeader.Location = new Point(250, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1000, 70);
            panelHeader.TabIndex = 0;
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            lblFormTitle.ForeColor = Color.White;
            lblFormTitle.Location = new Point(20, 15);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(319, 38);
            lblFormTitle.TabIndex = 0;
            lblFormTitle.Text = "Category Management";
            // 
            // panelInputs
            // 
            panelInputs.BackColor = Color.White;
            panelInputs.Controls.Add(chkIsActive);
            panelInputs.Controls.Add(btnUpdate);
            panelInputs.Controls.Add(btnDelete);
            panelInputs.Controls.Add(btnAdd);
            panelInputs.Controls.Add(txtCategoryName);
            panelInputs.Controls.Add(lblCategoryName);
            panelInputs.Controls.Add(txtCategoryId);
            panelInputs.Controls.Add(lblCategoryId);
            panelInputs.Location = new Point(270, 90);
            panelInputs.Name = "panelInputs";
            panelInputs.Size = new Size(320, 480);
            panelInputs.TabIndex = 1;
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            chkIsActive.ForeColor = Color.FromArgb(64, 64, 64);
            chkIsActive.Location = new Point(25, 198);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(171, 27);
            chkIsActive.TabIndex = 13;
            chkIsActive.Text = "Category is Active";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(243, 156, 18);
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(25, 370);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(270, 45);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update Category";
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
            btnDelete.Location = new Point(25, 310);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(270, 45);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete Category";
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
            btnAdd.Location = new Point(25, 250);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(270, 45);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add New Category";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Font = new Font("Segoe UI", 12F);
            txtCategoryName.Location = new Point(25, 140);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(270, 34);
            txtCategoryName.TabIndex = 3;
            // 
            // lblCategoryName
            // 
            lblCategoryName.AutoSize = true;
            lblCategoryName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblCategoryName.ForeColor = Color.FromArgb(64, 64, 64);
            lblCategoryName.Location = new Point(20, 110);
            lblCategoryName.Name = "lblCategoryName";
            lblCategoryName.Size = new Size(136, 23);
            lblCategoryName.TabIndex = 2;
            lblCategoryName.Text = "Category Name:";
            // 
            // txtCategoryId
            // 
            txtCategoryId.Font = new Font("Segoe UI", 12F);
            txtCategoryId.Location = new Point(25, 55);
            txtCategoryId.Name = "txtCategoryId";
            txtCategoryId.Size = new Size(270, 34);
            txtCategoryId.TabIndex = 1;
            // 
            // lblCategoryId
            // 
            lblCategoryId.AutoSize = true;
            lblCategoryId.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblCategoryId.ForeColor = Color.FromArgb(64, 64, 64);
            lblCategoryId.Location = new Point(20, 25);
            lblCategoryId.Name = "lblCategoryId";
            lblCategoryId.Size = new Size(107, 23);
            lblCategoryId.TabIndex = 0;
            lblCategoryId.Text = "Category ID:";
            // 
            // dataGridViewCategories
            // 
            dataGridViewCategories.AllowUserToAddRows = false;
            dataGridViewCategories.AllowUserToDeleteRows = false;
            dataGridViewCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCategories.BackgroundColor = Color.White;
            dataGridViewCategories.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCategories.EnableHeadersVisualStyles = false;
            dataGridViewCategories.Location = new Point(610, 90);
            dataGridViewCategories.Name = "dataGridViewCategories";
            dataGridViewCategories.ReadOnly = true;
            dataGridViewCategories.RowHeadersVisible = false;
            dataGridViewCategories.RowHeadersWidth = 51;
            dataGridViewCategories.RowTemplate.Height = 35;
            dataGridViewCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCategories.Size = new Size(610, 480);
            dataGridViewCategories.TabIndex = 2;
            // 
            // FrmCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 250);
            ClientSize = new Size(1250, 600);
            Controls.Add(panelSidebar);
            Controls.Add(dataGridViewCategories);
            Controls.Add(panelInputs);
            Controls.Add(panelHeader);
            Name = "FrmCategory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Category Management";
            Load += FrmCategory_Load;
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelInputs.ResumeLayout(false);
            panelInputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategories).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Panel panelInputs;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.TextBox txtCategoryId;
        private System.Windows.Forms.Label lblCategoryId;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridViewCategories;
        private System.Windows.Forms.CheckBox chkIsActive;
    }
}