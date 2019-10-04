using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yvz.Northwind.Entities.Concrete;

namespace Yvz.Northwind.MVCWebUI.Services
{
    public interface ICartSessionService
    {
        Cart GetCart();
        void SetCart(Cart cart);
    }
}
