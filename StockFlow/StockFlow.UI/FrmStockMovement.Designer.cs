using Entities;

namespace StockFlow.UI
{
    partial class FrmStockMovement
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panelSidebar = new Panel();
            lblLogo = new Label();
            lblDashboard = new Label();
            lblCategories = new Label();
            lblProducts = new Label();
            panelHeader = new Panel();
            lblFormTitle = new Label();
            panelInputs = new Panel();
            txtDescription = new TextBox();
            lblDescription = new Label();
            dtpMovementDate = new DateTimePicker();
            lblMovementDate = new Label();
            txtQuantity = new TextBox();
            lblQuantity = new Label();
            cmbMovementType = new ComboBox();
            lblMovementType = new Label();
            cmbProduct = new ComboBox();
            lblProduct = new Label();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            txtMovementId = new TextBox();
            lblMovementId = new Label();
            dataGridViewStockMovements = new DataGridView();
            panelSidebar.SuspendLayout();
            panelHeader.SuspendLayout();
            panelInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStockMovements).BeginInit();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(30, 43, 60);
            panelSidebar.Controls.Add(lblLogo);
            panelSidebar.Controls.Add(lblDashboard);
            panelSidebar.Controls.Add(lblCategories);
            panelSidebar.Controls.Add(lblProducts);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(250, 671);
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
            // lblProducts
            // 
            lblProducts.AutoSize = true;
            lblProducts.Cursor = Cursors.Hand;
            lblProducts.Font = new Font("Segoe UI", 12F);
            lblProducts.ForeColor = Color.Gainsboro;
            lblProducts.Location = new Point(30, 240);
            lblProducts.Name = "lblProducts";
            lblProducts.Size = new Size(89, 28);
            lblProducts.TabIndex = 6;
            lblProducts.Text = "Products";
            lblProducts.Click += lblProducts_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(52, 152, 219);
            panelHeader.Controls.Add(lblFormTitle);
            panelHeader.Location = new Point(250, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1100, 70);
            panelHeader.TabIndex = 0;
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            lblFormTitle.ForeColor = Color.White;
            lblFormTitle.Location = new Point(20, 15);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(423, 38);
            lblFormTitle.TabIndex = 0;
            lblFormTitle.Text = "Stock Movement Management";
            // 
            // panelInputs
            // 
            panelInputs.BackColor = Color.White;
            panelInputs.Controls.Add(txtDescription);
            panelInputs.Controls.Add(lblDescription);
            panelInputs.Controls.Add(dtpMovementDate);
            panelInputs.Controls.Add(lblMovementDate);
            panelInputs.Controls.Add(txtQuantity);
            panelInputs.Controls.Add(lblQuantity);
            panelInputs.Controls.Add(cmbMovementType);
            panelInputs.Controls.Add(lblMovementType);
            panelInputs.Controls.Add(cmbProduct);
            panelInputs.Controls.Add(lblProduct);
            panelInputs.Controls.Add(btnUpdate);
            panelInputs.Controls.Add(btnDelete);
            panelInputs.Controls.Add(btnAdd);
            panelInputs.Controls.Add(txtMovementId);
            panelInputs.Controls.Add(lblMovementId);
            panelInputs.Location = new Point(270, 90);
            panelInputs.Name = "panelInputs";
            panelInputs.Size = new Size(350, 567);
            panelInputs.TabIndex = 1;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 10.8F);
            txtDescription.Location = new Point(25, 290);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(300, 60);
            txtDescription.TabIndex = 11;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblDescription.ForeColor = Color.FromArgb(64, 64, 64);
            lblDescription.Location = new Point(20, 265);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(100, 23);
            lblDescription.TabIndex = 10;
            lblDescription.Text = "Description:";
            // 
            // dtpMovementDate
            // 
            dtpMovementDate.Font = new Font("Segoe UI", 10.8F);
            dtpMovementDate.Format = DateTimePickerFormat.Short;
            dtpMovementDate.Location = new Point(25, 230);
            dtpMovementDate.Name = "dtpMovementDate";
            dtpMovementDate.Size = new Size(300, 31);
            dtpMovementDate.TabIndex = 9;
            // 
            // lblMovementDate
            // 
            lblMovementDate.AutoSize = true;
            lblMovementDate.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblMovementDate.ForeColor = Color.FromArgb(64, 64, 64);
            lblMovementDate.Location = new Point(20, 205);
            lblMovementDate.Name = "lblMovementDate";
            lblMovementDate.Size = new Size(142, 23);
            lblMovementDate.TabIndex = 8;
            lblMovementDate.Text = "Transaction Date:";
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Segoe UI", 12F);
            txtQuantity.Location = new Point(195, 165);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(130, 34);
            txtQuantity.TabIndex = 7;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblQuantity.ForeColor = Color.FromArgb(64, 64, 64);
            lblQuantity.Location = new Point(190, 140);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(81, 23);
            lblQuantity.TabIndex = 6;
            lblQuantity.Text = "Quantity:";
            // 
            // cmbMovementType
            // 
            cmbMovementType.Font = new Font("Segoe UI", 12F);
            cmbMovementType.FormattingEnabled = true;
            cmbMovementType.DataSource = Enum.GetValues(typeof(MovementType));
            cmbMovementType.Location = new Point(25, 165);
            cmbMovementType.Name = "cmbMovementType";
            cmbMovementType.Size = new Size(160, 36);
            cmbMovementType.TabIndex = 5;
            // 
            // lblMovementType
            // 
            lblMovementType.AutoSize = true;
            lblMovementType.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblMovementType.ForeColor = Color.FromArgb(64, 64, 64);
            lblMovementType.Location = new Point(20, 140);
            lblMovementType.Name = "lblMovementType";
            lblMovementType.Size = new Size(139, 23);
            lblMovementType.TabIndex = 4;
            lblMovementType.Text = "Movement Type:";
            // 
            // cmbProduct
            // 
            cmbProduct.Font = new Font("Segoe UI", 12F);
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Location = new Point(25, 100);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(300, 36);
            cmbProduct.TabIndex = 3;
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblProduct.ForeColor = Color.FromArgb(64, 64, 64);
            lblProduct.Location = new Point(20, 75);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(124, 23);
            lblProduct.TabIndex = 2;
            lblProduct.Text = "Select Product:";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(243, 156, 18);
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(25, 498);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(300, 45);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Update Movement";
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
            btnDelete.Location = new Point(25, 443);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(300, 45);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete Movement";
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
            btnAdd.Location = new Point(25, 388);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(300, 45);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Save Movement";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtMovementId
            // 
            txtMovementId.Font = new Font("Segoe UI", 12F);
            txtMovementId.Location = new Point(25, 35);
            txtMovementId.Name = "txtMovementId";
            txtMovementId.Size = new Size(300, 34);
            txtMovementId.TabIndex = 1;
            // 
            // lblMovementId
            // 
            lblMovementId.AutoSize = true;
            lblMovementId.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblMovementId.ForeColor = Color.FromArgb(64, 64, 64);
            lblMovementId.Location = new Point(20, 10);
            lblMovementId.Name = "lblMovementId";
            lblMovementId.Size = new Size(120, 23);
            lblMovementId.TabIndex = 0;
            lblMovementId.Text = "Movement ID:";
            // 
            // dataGridViewStockMovements
            // 
            dataGridViewStockMovements.AllowUserToAddRows = false;
            dataGridViewStockMovements.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(249, 249, 249);
            dataGridViewStockMovements.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewStockMovements.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStockMovements.BackgroundColor = Color.White;
            dataGridViewStockMovements.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridViewStockMovements.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewStockMovements.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStockMovements.EnableHeadersVisualStyles = false;
            dataGridViewStockMovements.GridColor = Color.FromArgb(224, 224, 224);
            dataGridViewStockMovements.Location = new Point(640, 90);
            dataGridViewStockMovements.Name = "dataGridViewStockMovements";
            dataGridViewStockMovements.ReadOnly = true;
            dataGridViewStockMovements.RowHeadersVisible = false;
            dataGridViewStockMovements.RowHeadersWidth = 51;
            dataGridViewStockMovements.RowTemplate.Height = 40;
            dataGridViewStockMovements.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewStockMovements.Size = new Size(680, 567);
            dataGridViewStockMovements.TabIndex = 2;
            // 
            // FrmStockMovement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 250);
            ClientSize = new Size(1350, 671);
            Controls.Add(panelSidebar);
            Controls.Add(dataGridViewStockMovements);
            Controls.Add(panelInputs);
            Controls.Add(panelHeader);
            Name = "FrmStockMovement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stock Movement Management";
            Load += FrmStockMovement_Load;
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelInputs.ResumeLayout(false);
            panelInputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStockMovements).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Panel panelInputs;
        private System.Windows.Forms.TextBox txtMovementId;
        private System.Windows.Forms.Label lblMovementId;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.ComboBox cmbMovementType;
        private System.Windows.Forms.Label lblMovementType;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.DateTimePicker dtpMovementDate;
        private System.Windows.Forms.Label lblMovementDate;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridViewStockMovements;
    }
}