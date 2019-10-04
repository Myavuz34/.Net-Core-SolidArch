using System;
using System.Collections.Generic;
using System.Text;
using Yvz.Core.DataAccess.EntityFramework;
using Yvz.Northwind.DataAccess.Abstract;
using Yvz.Northwind.Entities.Concrete;

namespace Yvz.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal:EFEntityRepositoryBase<Product,NorthwindContext>,IProductDal
    {
    }
}
