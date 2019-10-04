using System;
using System.Collections.Generic;
using System.Text;
using Yvz.Northwind.Business.Abstract;
using Yvz.Northwind.DataAccess.Abstract;
using Yvz.Northwind.Entities.Concrete;

namespace Yvz.Northwind.Business.Concrete
{
    public class CategoryManager:ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }
    }
}
