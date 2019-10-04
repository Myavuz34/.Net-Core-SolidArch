using System.Collections.Generic;
using Yvz.Northwind.Entities.Concrete;

namespace Yvz.Northwind.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}