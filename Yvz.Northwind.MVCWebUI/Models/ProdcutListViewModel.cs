using System.Collections.Generic;
using Yvz.Northwind.Entities.Concrete;

namespace Yvz.Northwind.MVCWebUI.Models
{
    public class ProdcutListViewModel
    {
        public List<Product> Products { get; internal set; }
        public int PageCount { get; set; }
        public int PageSize { get; set; }
        public int CurrentCategory { get; set; }
        public int CurrentPage { get; set; }
    }
}