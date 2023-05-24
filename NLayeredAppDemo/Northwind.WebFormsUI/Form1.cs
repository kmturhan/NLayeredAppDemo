using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.DataAccess.Concrete.NHibernate;
using Northwind.Entities.Concrete;

namespace Northwind.WebFormsUI
{
	public partial class Form1 : Form
	{
		private IProductService _productService;
		private ICategoryService _categoryService;
		public Form1()
		{
			InitializeComponent();
			_productService = new ProductManager(new EfProductDal());
			_categoryService = new CategoryManager(new EfCategoryDal());
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			LoadProducts();
			LoadCategories();
		}

		private void LoadProducts()
		{
			dgwProduct.DataSource = _productService.GetAll();
		}
		private void LoadCategories()
		{
			cmbCategory.DataSource = _categoryService.GetAll();
			cmbCategory.DisplayMember = "CategoryName";
			cmbCategory.ValueMember = "CategoryId";
			
			cmbCategoryNewProduct.DataSource = _categoryService.GetAll();
			cmbCategoryNewProduct.DisplayMember = "CategoryName";
			cmbCategoryNewProduct.ValueMember = "CategoryId";
		}

		private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				dgwProduct.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cmbCategory.SelectedValue));
			}
			catch (Exception ex)
			{

			}

		}

		private void tbx_TextChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(tbx.Text))
			{
				dgwProduct.DataSource = _productService.GetProductsByProductName(tbx.Text);
			}
			else
			{
				LoadProducts();
			}
		}

		private void btnAddNewProduct_Click(object sender, EventArgs e)
		{

			_productService.Add(new Product
			{
				CategoryId = Convert.ToInt32(cmbCategoryNewProduct.SelectedValue),
				ProductName = txbProductNameNewProduct.Text,
				QuantityPerUnit = txbStockQuantityNewProduct.Text,
				UnitPrice = Convert.ToInt32(txbPriceNewProduct.Text),
				UnitsInStock = Convert.ToInt16(txbStockQuantityNewProduct.Text)
			});
			LoadProducts();
			MessageBox.Show("Success Added!");

		}
	}
}