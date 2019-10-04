using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yvz.Northwind.Entities.Concrete;

namespace Yvz.Northwind.MVCWebUI.Models
{
    public class CategoryListViewModel
    {
        public List<Category> Categories { get; internal set; }
        public int CurrentCategory { get; set; }
    }
}
