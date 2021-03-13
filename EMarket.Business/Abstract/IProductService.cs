using EMarket.Entity.Concrete;
using System.Collections.Generic;

namespace EMarket.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetByName(string name);
        List<Product> GetByCategoryId(int id);
        void Update(Product product);
        void Delete(Product product);
        void Add(Product product);
    }
}
