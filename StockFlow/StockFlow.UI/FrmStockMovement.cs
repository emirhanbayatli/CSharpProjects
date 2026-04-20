using Entities;
using StockFlow.Business;

namespace StockFlow.UI
{
    public partial class FrmStockMovement : Form
    {
        public FrmStockMovement()
        {
            InitializeComponent();
        }
        ProductService productService = new ProductService();
        StockMovementService stockMovementService = new StockMovementService();

        private void LoadGrid()
        {
            dataGridViewStockMovements.DataSource = stockMovementService
                .GetStockMovements()
                .Select(x => new
                {
                    x.StockMovementId,
                    ProductName = x.Product.ProductName,
                    x.Quantity,
                    x.Type,
                    x.Date,
                    x.Description
                })
                .ToList();
        }

        private void FrmStockMovement_Load(object sender, EventArgs e)
        {
            var products = productService.GetAllProducts();
            cmbProduct.DataSource = products;
            cmbProduct.DisplayMember = "ProductName";
            cmbProduct.ValueMember = "ProductId";
            LoadGrid();

        }

        private void lblDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }

        private void lblCategories_Click(object sender, EventArgs e)
        {
            FrmCategory frm = new FrmCategory();
            frm.Show();
            this.Hide();
        }

        private void lblProducts_Click(object sender, EventArgs e)
        {
            FrmProducts frm = new FrmProducts();
            frm.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string description = txtDescription.Text;
            int quantity = int.Parse(txtQuantity.Text);
            int productId = (int)cmbProduct.SelectedValue;
            MovementType type = (MovementType)cmbMovementType.SelectedItem;
            DateTime date = dtpMovementDate.Value;

            StockMovement stockMovement = new StockMovement
            {
                Description = description,
                Quantity = quantity,
                ProductId = productId,
                Type = type,
                Date = date
            };
            var result = stockMovementService.AddStockMovement(stockMovement);
            MessageBox.Show(result);

            LoadGrid();

            txtDescription.Text = "";
            txtQuantity.Text = "";

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtMovementId.Text);
            var result = stockMovementService.DeleteStockMovement(id);
            MessageBox.Show(result);

            LoadGrid();
            txtMovementId.Text = "";

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtMovementId.Text);
            string description = txtDescription.Text;
            int quantity = int.Parse(txtQuantity.Text);
            int productId = (int)cmbProduct.SelectedValue;
            MovementType type = (MovementType)cmbMovementType.SelectedItem;
            DateTime date = dtpMovementDate.Value;

            StockMovement stockMovement = new StockMovement
            {
                StockMovementId = id,
                Description = description,
                Quantity = quantity,
                ProductId = productId,
                Type = type,
                Date = date
            };
            var result = stockMovementService.UpdateStockMovement(stockMovement);
            MessageBox.Show(result);

            LoadGrid();


            txtDescription.Text = "";
            txtMovementId.Text = "";
            txtQuantity.Text = "";

        }
    }
}
