using Northwind.Business.Concrete;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.DataAccess.Concrete.NHibernate;

namespace Northwind.WebFormsUI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			ProductManager productManager = new ProductManager(new EfProductDal());
			dgwProduct.DataSource = productManager.GetAll();
		}
	}
}