using System.Collections.Generic;
using EMarket.Entity.Concrete;
using EMarket.Entity.Domain_Model;

namespace EMarket.Business.Abstract
{
    public interface ICartService
    {
        void AddToCart(short number,Product product,Cart cart);
        void DeleteFromCart(Product product, Cart cart);
        void Clear(Cart cart);
        void DeleteOne(Product product, Cart cart);
        List<CartItem> GetAll(Cart cart);
        void Sell(Cart cart);
    }
}
