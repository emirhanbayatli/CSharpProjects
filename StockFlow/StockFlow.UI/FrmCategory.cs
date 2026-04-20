using Entities;
using StockFlow.Business;

namespace StockFlow.UI
{
    public partial class FrmCategory : Form
    {
        public FrmCategory()
        {
            InitializeComponent();
        }
        CategoryService categoryService = new CategoryService();

        private void FrmCategory_Load(object sender, EventArgs e)
        {
            var values = categoryService.GetAllCategories();
            dataGridViewCategories.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string categoryName = txtCategoryName.Text;
            bool isActive = chkIsActive.Checked;
            Category category = new Category
            {
                CategoryName = categoryName,
                IsActive = isActive,
            };
            var result = categoryService.AddCategory(category);
            MessageBox.Show(result);
            var values = categoryService.GetAllCategories();
            dataGridViewCategories.DataSource = values;

            txtCategoryName.Text = "";
            chkIsActive.Checked = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);
            var result = categoryService.DeleteCategory(id);
            MessageBox.Show(result);
            var values = categoryService.GetAllCategories();
            dataGridViewCategories.DataSource = values;

            txtCategoryId.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);
            string categoryName = txtCategoryName.Text;
            bool isActive = chkIsActive.Checked;
            Category category = new Category
            {
                CategoryId = id,
                CategoryName = categoryName,
                IsActive = isActive,
            };
            var result = categoryService.UpdateCategory(category);
            MessageBox.Show(result);
            var values = categoryService.GetAllCategories();
            dataGridViewCategories.DataSource = values;

            txtCategoryId.Text = "";
            txtCategoryName.Text = "";
            chkIsActive.Checked = false;

        }

        private void lblDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }

        private void lblProducts_Click(object sender, EventArgs e)
        {
            FrmProducts frm = new FrmProducts();
            frm.Show();
            this.Hide();
        }

        private void lblStock_Click(object sender, EventArgs e)
        {
            FrmStockMovement frm = new FrmStockMovement();
            frm.Show();
            this.Hide();
        }
    }
}
