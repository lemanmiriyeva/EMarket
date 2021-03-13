using System.Collections.Generic;
using EMarket.Entity.Concrete;

namespace EMarket.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
