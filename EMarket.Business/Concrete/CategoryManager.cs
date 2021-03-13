using System.Collections.Generic;
using EMarket.Business.Abstract;
using EMarket.DataAccess.Abstract;
using EMarket.Entity.Concrete;

namespace EMarket.Business.Concrete
{
    public class CategoryManager:ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }
    }
}
