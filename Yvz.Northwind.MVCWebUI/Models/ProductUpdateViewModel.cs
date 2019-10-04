using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yvz.Northwind.Entities.Concrete;

namespace Yvz.Northwind.MVCWebUI.Models
{
    public class ProductUpdateViewModel
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }
    }
}
