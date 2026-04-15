namespace StockFlow.UI
{
    partial class FrmStockMovement
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
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.lblCategories = new System.Windows.Forms.Label();
            this.lblProducts = new System.Windows.Forms.Label();
            this.lblStockMovements = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.panelInputs = new System.Windows.Forms.Panel();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.dtpMovementDate = new System.Windows.Forms.DateTimePicker();
            this.lblMovementDate = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.cmbMovementType = new System.Windows.Forms.ComboBox();
            this.lblMovementType = new System.Windows.Forms.Label();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.txtMovementId = new System.Windows.Forms.TextBox();
            this.lblMovementId = new System.Windows.Forms.Label();
            this.dataGridViewStockMovements = new System.Windows.Forms.DataGridView();
            this.panelSidebar.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStockMovements)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.panelSidebar.Controls.Add(this.lblLogo);
            this.panelSidebar.Controls.Add(this.lblDashboard);
            this.panelSidebar.Controls.Add(this.lblCategories);
            this.panelSidebar.Controls.Add(this.lblProducts);
            this.panelSidebar.Controls.Add(this.lblStockMovements);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(250, 750);
            this.panelSidebar.TabIndex = 3;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(25, 30);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(155, 38);
            this.lblLogo.TabIndex = 7;
            this.lblLogo.Text = "StockFlow";
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDashboard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDashboard.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDashboard.Location = new System.Drawing.Point(30, 120);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(109, 28);
            this.lblDashboard.TabIndex = 4;
            this.lblDashboard.Text = "Dashboard";
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCategories.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCategories.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCategories.Location = new System.Drawing.Point(30, 180);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(108, 28);
            this.lblCategories.TabIndex = 5;
            this.lblCategories.Text = "Kategoriler";
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblProducts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProducts.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblProducts.Location = new System.Drawing.Point(30, 240);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(78, 28);
            this.lblProducts.TabIndex = 6;
            this.lblProducts.Text = "Ürünler";
            // 
            // lblStockMovements
            // 
            this.lblStockMovements.AutoSize = true;
            this.lblStockMovements.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblStockMovements.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStockMovements.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblStockMovements.Location = new System.Drawing.Point(30, 300);
            this.lblStockMovements.Name = "lblStockMovements";
            this.lblStockMovements.Size = new System.Drawing.Size(147, 28);
            this.lblStockMovements.TabIndex = 8;
            this.lblStockMovements.Text = "Stok Hareketleri";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panelHeader.Controls.Add(this.lblFormTitle);
            this.panelHeader.Location = new System.Drawing.Point(250, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1100, 70);
            this.panelHeader.TabIndex = 0;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFormTitle.ForeColor = System.Drawing.Color.White;
            this.lblFormTitle.Location = new System.Drawing.Point(20, 15);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(222, 38);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "Stok Hareketleri";
            // 
            // panelInputs
            // 
            this.panelInputs.BackColor = System.Drawing.Color.White;
            this.panelInputs.Controls.Add(this.txtDescription);
            this.panelInputs.Controls.Add(this.lblDescription);
            this.panelInputs.Controls.Add(this.dtpMovementDate);
            this.panelInputs.Controls.Add(this.lblMovementDate);
            this.panelInputs.Controls.Add(this.txtQuantity);
            this.panelInputs.Controls.Add(this.lblQuantity);
            this.panelInputs.Controls.Add(this.cmbMovementType);
            this.panelInputs.Controls.Add(this.lblMovementType);
            this.panelInputs.Controls.Add(this.cmbProduct);
            this.panelInputs.Controls.Add(this.lblProduct);
            this.panelInputs.Controls.Add(this.btnUpdate);
            this.panelInputs.Controls.Add(this.btnDelete);
            this.panelInputs.Controls.Add(this.btnAdd);
            this.panelInputs.Controls.Add(this.btnList);
            this.panelInputs.Controls.Add(this.txtMovementId);
            this.panelInputs.Controls.Add(this.lblMovementId);
            this.panelInputs.Location = new System.Drawing.Point(270, 90);
            this.panelInputs.Name = "panelInputs";
            this.panelInputs.Size = new System.Drawing.Size(350, 630);
            this.panelInputs.TabIndex = 1;
            // 
            // txtMovementId
            // 
            this.txtMovementId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMovementId.Location = new System.Drawing.Point(25, 35);
            this.txtMovementId.Name = "txtMovementId";
            this.txtMovementId.Size = new System.Drawing.Size(300, 34);
            this.txtMovementId.TabIndex = 1;
            // 
            // lblMovementId
            // 
            this.lblMovementId.AutoSize = true;
            this.lblMovementId.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMovementId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMovementId.Location = new System.Drawing.Point(20, 10);
            this.lblMovementId.Name = "lblMovementId";
            this.lblMovementId.Size = new System.Drawing.Size(92, 23);
            this.lblMovementId.TabIndex = 0;
            this.lblMovementId.Text = "Hareket ID:";
            // 
            // cmbProduct
            // 
            this.cmbProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(25, 100);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(300, 36);
            this.cmbProduct.TabIndex = 3;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblProduct.Location = new System.Drawing.Point(20, 75);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(86, 23);
            this.lblProduct.TabIndex = 2;
            this.lblProduct.Text = "Ürün Seç:";
            // 
            // cmbMovementType
            // 
            this.cmbMovementType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbMovementType.FormattingEnabled = true;
            this.cmbMovementType.Items.AddRange(new object[] {
            "Stok Girişi (+)",
            "Stok Çıkışı (-)"});
            this.cmbMovementType.Location = new System.Drawing.Point(25, 165);
            this.cmbMovementType.Name = "cmbMovementType";
            this.cmbMovementType.Size = new System.Drawing.Size(160, 36);
            this.cmbMovementType.TabIndex = 5;
            // 
            // lblMovementType
            // 
            this.lblMovementType.AutoSize = true;
            this.lblMovementType.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMovementType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMovementType.Location = new System.Drawing.Point(20, 140);
            this.lblMovementType.Name = "lblMovementType";
            this.lblMovementType.Size = new System.Drawing.Size(95, 23);
            this.lblMovementType.TabIndex = 4;
            this.lblMovementType.Text = "İşlem Türü:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQuantity.Location = new System.Drawing.Point(195, 165);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(130, 34);
            this.txtQuantity.TabIndex = 7;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblQuantity.Location = new System.Drawing.Point(190, 140);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(66, 23);
            this.lblQuantity.TabIndex = 6;
            this.lblQuantity.Text = "Miktar:";
            // 
            // dtpMovementDate
            // 
            this.dtpMovementDate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpMovementDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMovementDate.Location = new System.Drawing.Point(25, 230);
            this.dtpMovementDate.Name = "dtpMovementDate";
            this.dtpMovementDate.Size = new System.Drawing.Size(300, 31);
            this.dtpMovementDate.TabIndex = 9;
            // 
            // lblMovementDate
            // 
            this.lblMovementDate.AutoSize = true;
            this.lblMovementDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMovementDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMovementDate.Location = new System.Drawing.Point(20, 205);
            this.lblMovementDate.Name = "lblMovementDate";
            this.lblMovementDate.Size = new System.Drawing.Size(100, 23);
            this.lblMovementDate.TabIndex = 8;
            this.lblMovementDate.Text = "İşlem Tarihi:";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescription.Location = new System.Drawing.Point(25, 290);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(300, 60);
            this.txtDescription.TabIndex = 11;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDescription.Location = new System.Drawing.Point(20, 265);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(83, 23);
            this.lblDescription.TabIndex = 10;
            this.lblDescription.Text = "Açıklama:";
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnList.FlatAppearance.BorderSize = 0;
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnList.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnList.ForeColor = System.Drawing.Color.White;
            this.btnList.Location = new System.Drawing.Point(25, 380);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(300, 45);
            this.btnList.TabIndex = 12;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(25, 435);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(300, 45);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "İşlemi Kaydet";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(25, 490);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(300, 45);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "İşlemi İptal Et (Sil)";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(25, 545);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(300, 45);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // dataGridViewStockMovements
            // 
            this.dataGridViewStockMovements.AllowUserToAddRows = false;
            this.dataGridViewStockMovements.AllowUserToDeleteRows = false;
            this.dataGridViewStockMovements.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStockMovements.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewStockMovements.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStockMovements.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewStockMovements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStockMovements.EnableHeadersVisualStyles = false;
            this.dataGridViewStockMovements.Location = new System.Drawing.Point(640, 90);
            this.dataGridViewStockMovements.Name = "dataGridViewStockMovements";
            this.dataGridViewStockMovements.ReadOnly = true;
            this.dataGridViewStockMovements.RowHeadersVisible = false;
            this.dataGridViewStockMovements.RowHeadersWidth = 51;
            this.dataGridViewStockMovements.RowTemplate.Height = 35;
            this.dataGridViewStockMovements.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStockMovements.Size = new System.Drawing.Size(680, 630);
            this.dataGridViewStockMovements.TabIndex = 2;
            // 
            // FrmStockMovement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1350, 750);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.dataGridViewStockMovements);
            this.Controls.Add(this.panelInputs);
            this.Controls.Add(this.panelHeader);
            this.Name = "FrmStockMovement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Hareketleri";
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelInputs.ResumeLayout(false);
            this.panelInputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStockMovements)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Label lblStockMovements;
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
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.DataGridView dataGridViewStockMovements;
    }
}