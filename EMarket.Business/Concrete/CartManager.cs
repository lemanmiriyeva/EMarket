using System;
using System.Collections.Generic;
using System.Linq;
using EMarket.Business.Abstract;
using EMarket.Entity.Concrete;
using EMarket.Entity.Domain_Model;

namespace EMarket.Business.Concrete
{
    public class CartManager : ICartService
    {
        private readonly IProductService _productService;

        public CartManager(IProductService productService)
        {
            _productService = productService;
        }

        public void AddToCart(short number,Product product, Cart cart)

        {
            var cartitem = cart.CartItems.FirstOrDefault(c => c.Product.Id == product.Id);

            if (cartitem!=null && product.StockAmount>=cartitem.Quantity+number)
            {
                cartitem.Quantity+=number;
            }
            else if(cartitem==null&&product.StockAmount>=number)
            {
                cart.CartItems.Add(new CartItem() { Product = product, Quantity = number});
            }
            else
            {
                throw new Exception("There is not enough prouct!");
            }
            
        }

        public void DeleteFromCart(Product product, Cart cart)
        {
            var cartItem = cart.CartItems.FirstOrDefault(c => c.Product.Id == product.Id);
            cart.CartItems.Remove(cartItem);
        }

        public void Clear(Cart cart)
        {
            cart.CartItems.Clear();
        }

        public void DeleteOne(Product product,Cart cart)
        {
            var cartItemm = cart.CartItems.FirstOrDefault(c => c.Product.Id == product.Id);
            if (cartItemm != null)
            {
                if (cartItemm.Quantity == 0)
                {
                    cart.CartItems.Remove(cartItemm);
                }
                else
                {
                    cartItemm.Quantity--;
                }
            }
          
            
            
        }

        public List<CartItem> GetAll(Cart cart)
        {
            return cart.CartItems;
        }

        public void Sell(Cart cart)
        {
            foreach (var cartItem in cart.CartItems)
            {
                _productService.Update(new Product()
                {
                    Id = cartItem.Product.Id,
                    CategoryId = cartItem.Product.CategoryId,
                    UnitPrice = cartItem.Product.UnitPrice,
                    ProductName = cartItem.Product.ProductName,
                    StockAmount = Convert.ToInt16(cartItem.Product.StockAmount-cartItem.Quantity)
                });
            }
        }
    }
}
