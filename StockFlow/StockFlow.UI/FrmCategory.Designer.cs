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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            panelSidebar = new System.Windows.Forms.Panel();
            lblLogo = new System.Windows.Forms.Label();
            lblStock = new System.Windows.Forms.Label();
            lblProducts = new System.Windows.Forms.Label();
            lblDashboard = new System.Windows.Forms.Label();
            panelHeader = new System.Windows.Forms.Panel();
            lblFormTitle = new System.Windows.Forms.Label();
            panelInputs = new System.Windows.Forms.Panel();
            chkIsActive = new System.Windows.Forms.CheckBox();
            btnUpdate = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();
            txtCategoryName = new System.Windows.Forms.TextBox();
            lblCategoryName = new System.Windows.Forms.Label();
            txtCategoryId = new System.Windows.Forms.TextBox();
            lblCategoryId = new System.Windows.Forms.Label();
            dataGridViewCategories = new System.Windows.Forms.DataGridView();
            panelSidebar.SuspendLayout();
            panelHeader.SuspendLayout();
            panelInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(dataGridViewCategories)).BeginInit();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = System.Drawing.Color.FromArgb(30, 43, 60);
            panelSidebar.Controls.Add(lblLogo);
            panelSidebar.Controls.Add(lblStock);
            panelSidebar.Controls.Add(lblProducts);
            panelSidebar.Controls.Add(lblDashboard);
            panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            panelSidebar.Location = new System.Drawing.Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new System.Drawing.Size(250, 600);
            panelSidebar.TabIndex = 3;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            lblLogo.ForeColor = System.Drawing.Color.White;
            lblLogo.Location = new System.Drawing.Point(25, 30);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new System.Drawing.Size(151, 38);
            lblLogo.TabIndex = 7;
            lblLogo.Text = "StockFlow";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Cursor = System.Windows.Forms.Cursors.Hand;
            lblStock.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblStock.ForeColor = System.Drawing.Color.Gainsboro;
            lblStock.Location = new System.Drawing.Point(30, 240);
            lblStock.Name = "lblStock";
            lblStock.Size = new System.Drawing.Size(141, 28);
            lblStock.TabIndex = 6;
            lblStock.Text = "Stock Tracking"; 
            // 
            // lblProducts
            // 
            lblProducts.AutoSize = true;
            lblProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            lblProducts.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblProducts.ForeColor = System.Drawing.Color.Gainsboro;
            lblProducts.Location = new System.Drawing.Point(30, 180);
            lblProducts.Name = "lblProducts";
            lblProducts.Size = new System.Drawing.Size(89, 28);
            lblProducts.TabIndex = 5;
            lblProducts.Text = "Products"; 
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            lblDashboard.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblDashboard.ForeColor = System.Drawing.Color.Gainsboro;
            lblDashboard.Location = new System.Drawing.Point(30, 120);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new System.Drawing.Size(108, 28);
            lblDashboard.TabIndex = 4;
            lblDashboard.Text = "Dashboard";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            panelHeader.Controls.Add(lblFormTitle);
            panelHeader.Location = new System.Drawing.Point(250, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new System.Drawing.Size(1000, 70);
            panelHeader.TabIndex = 0;
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            lblFormTitle.ForeColor = System.Drawing.Color.White;
            lblFormTitle.Location = new System.Drawing.Point(20, 15);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new System.Drawing.Size(325, 38);
            lblFormTitle.TabIndex = 0;
            lblFormTitle.Text = "Category Management";
            // 
            // panelInputs
            // 
            panelInputs.BackColor = System.Drawing.Color.White;
            panelInputs.Controls.Add(chkIsActive);
            panelInputs.Controls.Add(btnUpdate);
            panelInputs.Controls.Add(btnDelete);
            panelInputs.Controls.Add(btnAdd);
            panelInputs.Controls.Add(txtCategoryName);
            panelInputs.Controls.Add(lblCategoryName);
            panelInputs.Controls.Add(txtCategoryId);
            panelInputs.Controls.Add(lblCategoryId);
            panelInputs.Location = new System.Drawing.Point(270, 90);
            panelInputs.Name = "panelInputs";
            panelInputs.Size = new System.Drawing.Size(320, 480);
            panelInputs.TabIndex = 1;
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            chkIsActive.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            chkIsActive.Location = new System.Drawing.Point(25, 198);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new System.Drawing.Size(175, 27);
            chkIsActive.TabIndex = 13;
            chkIsActive.Text = "Category is Active"; 
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = System.Drawing.Color.FromArgb(243, 156, 18);
            btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            btnUpdate.ForeColor = System.Drawing.Color.White;
            btnUpdate.Location = new System.Drawing.Point(25, 370);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(270, 45);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update Category"; 
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            btnDelete.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            btnDelete.ForeColor = System.Drawing.Color.White;
            btnDelete.Location = new System.Drawing.Point(25, 310);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(270, 45);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete Category";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            btnAdd.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            btnAdd.ForeColor = System.Drawing.Color.White;
            btnAdd.Location = new System.Drawing.Point(25, 250);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(270, 45);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add New Category"; 
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtCategoryName
            // 
            txtCategoryName.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtCategoryName.Location = new System.Drawing.Point(25, 140);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new System.Drawing.Size(270, 34);
            txtCategoryName.TabIndex = 3;
            // 
            // lblCategoryName
            // 
            lblCategoryName.AutoSize = true;
            lblCategoryName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            lblCategoryName.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            lblCategoryName.Location = new System.Drawing.Point(20, 110);
            lblCategoryName.Name = "lblCategoryName";
            lblCategoryName.Size = new System.Drawing.Size(135, 23);
            lblCategoryName.TabIndex = 2;
            lblCategoryName.Text = "Category Name:"; 
            // 
            // txtCategoryId
            // 
            txtCategoryId.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtCategoryId.Location = new System.Drawing.Point(25, 55);
            txtCategoryId.Name = "txtCategoryId";
            txtCategoryId.Size = new System.Drawing.Size(270, 34);
            txtCategoryId.TabIndex = 1;
            // 
            // lblCategoryId
            // 
            lblCategoryId.AutoSize = true;
            lblCategoryId.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            lblCategoryId.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            lblCategoryId.Location = new System.Drawing.Point(20, 25);
            lblCategoryId.Name = "lblCategoryId";
            lblCategoryId.Size = new System.Drawing.Size(107, 23);
            lblCategoryId.TabIndex = 0;
            lblCategoryId.Text = "Category ID:"; 
            // 
            // dataGridViewCategories
            // 
            dataGridViewCategories.AllowUserToAddRows = false;
            dataGridViewCategories.AllowUserToDeleteRows = false;
            dataGridViewCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCategories.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCategories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridViewCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCategories.EnableHeadersVisualStyles = false;
            dataGridViewCategories.Location = new System.Drawing.Point(610, 90);
            dataGridViewCategories.Name = "dataGridViewCategories";
            dataGridViewCategories.ReadOnly = true;
            dataGridViewCategories.RowHeadersVisible = false;
            dataGridViewCategories.RowHeadersWidth = 51;
            dataGridViewCategories.RowTemplate.Height = 35;
            dataGridViewCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCategories.Size = new System.Drawing.Size(610, 480);
            dataGridViewCategories.TabIndex = 2;
            // 
            // FrmCategory
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(245, 246, 250);
            ClientSize = new System.Drawing.Size(1250, 600);
            Controls.Add(panelSidebar);
            Controls.Add(dataGridViewCategories);
            Controls.Add(panelInputs);
            Controls.Add(panelHeader);
            Name = "FrmCategory";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Category Management"; 
            Load += new System.EventHandler(this.FrmCategory_Load);
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelInputs.ResumeLayout(false);
            panelInputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(dataGridViewCategories)).EndInit();
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