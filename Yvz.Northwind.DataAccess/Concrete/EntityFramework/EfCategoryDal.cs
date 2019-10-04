using Yvz.Core.DataAccess.EntityFramework;
using Yvz.Northwind.DataAccess.Abstract;
using Yvz.Northwind.Entities.Concrete;

namespace Yvz.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EFEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {
    }
}
