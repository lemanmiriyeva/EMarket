using Coree.Entity.Abstract;
using EMarket.Entity.Concrete;

namespace EMarket.Entity.Domain_Model
{
    public class CartItem:IDomainModel
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
