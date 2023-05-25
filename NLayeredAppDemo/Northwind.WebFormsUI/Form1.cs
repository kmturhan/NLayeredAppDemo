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

			cmbCategoryUpdate.DataSource = _categoryService.GetAll();
			cmbCategoryUpdate.DisplayMember = "CategoryName";
			cmbCategoryUpdate.ValueMember = "CategoryId";
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
			try
			{
				_productService.Add(new Product
				{
					CategoryId = Convert.ToInt32(cmbCategoryNewProduct.SelectedValue),
					ProductName = txbProductNameNewProduct.Text,
					QuantityPerUnit = txbQuantityPerUnitNewProduct.Text,
					UnitPrice = Convert.ToInt32(txbUnitPriceNewProduct.Text),
					UnitsInStock = Convert.ToInt16(txbUnitInStockQuantityNewProduct.Text)
				});
				LoadProducts();
				MessageBox.Show("Success Added For Product!");
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message);
			}
			
		}

		private void btnUpdateProduct_Click(object sender, EventArgs e)
		{
			try
			{
				_productService.Update(new Product
				{
					ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
					ProductName = tbxProductNameUpdate.Text,
					CategoryId = Convert.ToInt32(cmbCategoryUpdate.SelectedValue),
					UnitsInStock = Convert.ToInt16(tbxUnitInStockQuantityUpdate.Text),
					QuantityPerUnit = tbxQuantityPerUnitUpdate.Text,
					UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text)
				});
				LoadProducts();
				MessageBox.Show("Success Update For Product!");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			var row = dgwProduct.CurrentRow;
			tbxProductNameUpdate.Text = row.Cells[1].Value.ToString();
			cmbCategoryUpdate.SelectedValue = row.Cells[2].Value;
			tbxUnitPriceUpdate.Text = row.Cells[3].Value.ToString();
			tbxQuantityPerUnitUpdate.Text = row.Cells[4].Value.ToString();
			tbxUnitInStockQuantityUpdate.Text = row.Cells[5].Value.ToString();
		}

		private void btnRemoveProduct_Click(object sender, EventArgs e)
		{
			try
			{
				_productService.Delete(new Product { ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value) });
				LoadProducts();
				MessageBox.Show("Success Delete For Product!");
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message);
			}
			
			
		}
	}
}