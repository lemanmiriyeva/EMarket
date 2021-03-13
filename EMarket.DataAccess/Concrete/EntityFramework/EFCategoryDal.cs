using Coree.Entity.Concrete.EntityFramework;
using EMarket.DataAccess.Abstract;
using EMarket.DataAccess.Concrete.EntityFramework.Contexts;
using EMarket.Entity.Concrete;

namespace EMarket.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal:EfEntityRepositoryBase<Category,EMarketContext>,ICategoryDal
    {
       
    }
}
