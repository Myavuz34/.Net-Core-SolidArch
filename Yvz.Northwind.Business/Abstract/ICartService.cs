using System;
using System.Collections.Generic;
using System.Text;
using Yvz.Northwind.Entities.Concrete;

namespace Yvz.Northwind.Business.Abstract
{
    public interface ICartService
    {
        void AddToCart(Cart cart, Product product);
        void RemoveFromCart(Cart cart, int productId);
        List<CartLine> List(Cart cart);
    }
}
