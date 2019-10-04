using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Yvz.Northwind.Business.Abstract;
using Yvz.Northwind.MVCWebUI.Models;
using Yvz.Northwind.MVCWebUI.Services;

namespace Yvz.Northwind.MVCWebUI.ViewComponents
{
    public class CartSummaryViewComponent: ViewComponent
    {
        private readonly ICartSessionService _cartSessionService;

        public CartSummaryViewComponent(ICartSessionService cartSessionService)
        {
            _cartSessionService = cartSessionService;
        }

        public ViewViewComponentResult Invoke()
        {
            var model = new CartSummaryViewModel
            {
                Cart = _cartSessionService.GetCart()
            };
            return View(model);
        }
    }
}
