using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Yvz.Northwind.Business.Abstract;
using Yvz.Northwind.MVCWebUI.Models;

namespace Yvz.Northwind.MVCWebUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public ActionResult Index(int page=1,int category=0)
        {
            int pageSize = 10;
            var products = _productService.GetByCategory(category);
            ProdcutListViewModel model = new ProdcutListViewModel()
            {
                Products=products.Skip((page-1)*pageSize).Take(pageSize).ToList(),
                PageCount = (int)Math.Ceiling(products.Count/(double)pageSize),
                PageSize = pageSize,
                CurrentCategory = category,
                CurrentPage = page
            };
            return View(model);
        }

    }
}