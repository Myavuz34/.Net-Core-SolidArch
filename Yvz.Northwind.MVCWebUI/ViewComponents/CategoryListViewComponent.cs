using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Yvz.Northwind.Business.Abstract;
using Yvz.Northwind.MVCWebUI.Models;

namespace Yvz.Northwind.MVCWebUI.ViewComponents
{
    public class CategoryListViewComponent:ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public CategoryListViewComponent(ICategoryService category)
        {
            _categoryService = category;
        }

        public ViewViewComponentResult Invoke()
        {
            var model = new CategoryListViewModel()
            {
                Categories= _categoryService.GetAll(),
                CurrentCategory=Convert.ToInt32(HttpContext.Request.Query["category"])
            };
            return View(model);
        }
    }
}
