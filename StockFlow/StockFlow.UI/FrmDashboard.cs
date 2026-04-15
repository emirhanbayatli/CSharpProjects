using StockFlow.Business;

namespace StockFlow.UI
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            FrmCategory frm = new FrmCategory();
            frm.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            FrmProducts frm = new FrmProducts();
            frm.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            FrmStockMovement frm = new FrmStockMovement();
            frm.Show();
            this.Hide();
        }

        ProductService productService = new ProductService();
        CategoryService categoryService = new CategoryService();
        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            var products = productService.GetAllProducts();
            var categories = categoryService.GetAllCategories();

            int productCount = products.Count();
            int categoryCount = categories.Count();
            int totalStock = products.Sum(x => x.ProductStock);

            lblTotalProductCount.Text = productCount.ToString();
            lblTotalCategoryCount.Text = categoryCount.ToString();
            lblTotalStokCount.Text = totalStock.ToString();

            var criticalProducts = products.Where(x => x.ProductStock < 5 && x.ProductStock > 0).ToList();
            var zeroStockProducts = products.Where(x => x.ProductStock == 0).ToList();

            if (criticalProducts.Count == 0)
            {
                dataGridViewCriticalStock.DataSource = null;
            }
            else
            {
                dataGridViewCriticalStock.DataSource = criticalProducts;
            }

            if (zeroStockProducts.Count == 0)
            {
                dataGridViewZeroStockProduct.DataSource = null;
            }
            else
            {
                dataGridViewZeroStockProduct.DataSource = zeroStockProducts;
            }

        }
    }
}
