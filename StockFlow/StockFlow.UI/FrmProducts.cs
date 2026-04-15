using Entities;
using StockFlow.Business;

namespace StockFlow.UI
{
    public partial class FrmProducts : Form
    {
        public FrmProducts()
        {
            InitializeComponent();
        }
        ProductService productService = new ProductService();
        CategoryService categoryService = new CategoryService();

        private void btnAdd_Click(object sender, EventArgs e)

        {
            string productName = txtProductName.Text;
            string productDescription = txtProductDescription.Text;
            int productStock = int.Parse(txtProductStock.Text);
            decimal productPrice = decimal.Parse(txtProductPrice.Text);
            bool isActive = chkIsActive.Checked;
            Product product = new Product
            {
                ProductName = productName,
                ProductDescription = productDescription,
                ProductStock = productStock,
                ProductPrice = productPrice,
                IsActive = isActive,
                CategoryId = (int)cmbCategory.SelectedValue


            };
            var result = productService.AddProduct(product);
            MessageBox.Show(result);
            var values = productService.GetAllProducts();
            dataGridViewProducts.DataSource = values;

            txtProductName.Text = "";
            txtProductDescription.Text = "";
            txtProductStock.Text = "";
            txtProductPrice.Text = "";
            chkIsActive.Checked = false;

        }

        private void FrmProducts_Load(object sender, EventArgs e)
        {
            var categories = categoryService.GetAllCategories();
            cmbCategory.DataSource = categories;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId";

            var values = productService.GetAllProducts();
            dataGridViewProducts.DataSource = values;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtProductId.Text);
            var result = productService.DeleteProduct(id);
            MessageBox.Show(result);
            var values = productService.GetAllProducts();
            dataGridViewProducts.DataSource = values;

            txtProductId.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int productId = int.Parse(txtProductId.Text);
            string productName = txtProductName.Text;
            string productDescription = txtProductDescription.Text;
            int productStock = int.Parse(txtProductStock.Text);
            decimal productPrice = decimal.Parse(txtProductPrice.Text);
            bool isActive = chkIsActive.Checked;
            Product product = new Product
            {
                ProductId = productId,
                ProductName = productName,
                ProductDescription = productDescription,
                ProductStock = productStock,
                ProductPrice = productPrice,
                IsActive = isActive,
                CategoryId = (int)cmbCategory.SelectedValue


            };
            var result = productService.UpdateProduct(product);
            MessageBox.Show(result);
            var values = productService.GetAllProducts();
            dataGridViewProducts.DataSource = values;

            txtProductId.Text = "";
            txtProductName.Text = "";
            txtProductDescription.Text = "";
            txtProductStock.Text = "";
            txtProductPrice.Text = "";
            chkIsActive.Checked = false;
        }
    }
}
