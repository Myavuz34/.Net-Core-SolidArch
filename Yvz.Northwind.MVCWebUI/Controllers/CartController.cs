using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Yvz.Northwind.Business.Abstract;
using Yvz.Northwind.Entities.Concrete;
using Yvz.Northwind.MVCWebUI.Models;
using Yvz.Northwind.MVCWebUI.Services;

namespace Yvz.Northwind.MVCWebUI.Controllers
{
    public class CartController:Controller
    {
        private ICartService _cartService;
        private ICartSessionService _cartSessionService;
        private IProductService _productService;

        public CartController(ICartService cartService, ICartSessionService cartSessionService, IProductService productService)
        {
            _cartService = cartService;
            _cartSessionService = cartSessionService;
            _productService = productService;
        }

        public ActionResult AddToCart(int productId)
        {
            var productToBeAdded = _productService.GetById(productId);
            var cart = _cartSessionService.GetCart();
            _cartService.AddToCart(cart, productToBeAdded);
            _cartSessionService.SetCart(cart);
            TempData.Add("message",String.Format("Ürün Eklendi. {0}",productToBeAdded.ProductName));
           return RedirectToAction("Index", "Product");
        }

        public ActionResult List()
        {
            var cart = _cartSessionService.GetCart();
            CartListViewModel cartListViewModel = new CartListViewModel
            {
                Cart = cart
            };
            return View(cartListViewModel);
        }

        public ActionResult Remove(int productId)
        {
            var cart = _cartSessionService.GetCart();
            _cartService.RemoveFromCart(cart,productId);
            _cartSessionService.SetCart(cart);

            TempData.Add("message", String.Format("Ürün Silindi."));
            return RedirectToAction("List");
        }

        public ActionResult Complete()
        {
            var shippingDetailsViewModel = new ShippingDetailsViewModel
            {
                ShippingDetails = new ShippingDetails()
            };
            return View(shippingDetailsViewModel);
        }

        [HttpPost]
        public ActionResult Complete(ShippingDetails shippingDetails)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            TempData.Add("message",String.Format("Siparişiniz için teşekkür ederiz. {0}", shippingDetails.FirstName));
            return View();
        }
    }
}
