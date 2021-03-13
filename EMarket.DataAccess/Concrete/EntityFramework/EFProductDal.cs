using Coree.Entity.Concrete.EntityFramework;
using EMarket.DataAccess.Abstract;
using EMarket.DataAccess.Concrete.EntityFramework.Contexts;
using EMarket.Entity.Concrete;

namespace EMarket.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal:EfEntityRepositoryBase<Product,EMarketContext>,IProductDal
    {
       
    }
}
