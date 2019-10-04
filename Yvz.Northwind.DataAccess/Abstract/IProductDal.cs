using System;
using System.Collections.Generic;
using System.Text;
using Yvz.Core.DataAccess;
using Yvz.Northwind.Entities.Concrete;

namespace Yvz.Northwind.DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {

    }
}
