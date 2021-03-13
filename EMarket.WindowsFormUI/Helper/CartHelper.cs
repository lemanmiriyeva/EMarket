using System.Collections.Generic;
using EMarket.Entity.Domain_Model;
using EMarket.WindowsFormUI.Entity;

namespace EMarket.WindowsFormUI.Helper
{
    public static class CartHelper
    {
        public static List<WindowsFormCart> Converter(Cart cart)
        {
            List<WindowsFormCart> windowsFormCarts = new List<WindowsFormCart>();
            foreach (var cartCartItem in cart.CartItems)
            {
                windowsFormCarts.Add(new WindowsFormCart()
                {
                    Id = cartCartItem.Product.Id,
                    CategoryId = cartCartItem.Product.CategoryId,
                    ProductName = cartCartItem.Product.ProductName,
                    UnitPrice = cartCartItem.Product.UnitPrice,
                    StockAmount = cartCartItem.Product.StockAmount,
                    Quantity = cartCartItem.Quantity
                });
            }

            return windowsFormCarts;

        }
        
    }
}
