using System.Collections.Generic;
using Coree.Business.Validation.FluentValidation;
using EMarket.Business.Abstract;
using EMarket.Business.Validation.FluentValidation;
using EMarket.DataAccess.Abstract;
using EMarket.Entity.Concrete;

namespace EMarket.Business.Concrete
{ 
    public class ProductManager:IProductService
    {
        private readonly IProductDal _productDal;
        

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<Product> GetByName(string name)
        {
            return _productDal.GetAll(p => p.ProductName.ToLower().Contains(name.ToLower()));
        }

        public List<Product> GetByCategoryId(int id)
        {
            return _productDal.GetAll(p => p.CategoryId == id);
        }

        public void Update(Product product)
        {
            ValidationTool.Validate(new ProductValidator(), product);
            _productDal.Update(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public void Add(Product product)
        {
            ValidationTool.Validate(new ProductValidator(),product);
            _productDal.Add(product);
        }
    }
}
