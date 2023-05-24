using Northwind.Business.Abstract;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Concrete
{
    public class ProductManager : IProductService
	{
		private IProductDal _productDal;
		public ProductManager(IProductDal productDal)
		{
			_productDal = productDal;
		}

		public void Add(Product product)
		{
			_productDal.Add(product);
		}

		//EfProductDal productDal = new EfProductDal();
		public List<Product> GetAll()
		{
			//Business code
			return _productDal.GetAll();
		}

		public List<Product> GetProductsByCategory(int categoryId)
		{
			return _productDal.GetAll(p => p.CategoryId == categoryId);
		}

		public List<Product> GetProductsByProductName(string text)
		{
			return _productDal.GetAll(p => p.ProductName.ToLower().Contains(text.ToLower()));
		}
	}
}
