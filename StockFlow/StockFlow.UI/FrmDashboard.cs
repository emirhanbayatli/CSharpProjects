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
    }
}
