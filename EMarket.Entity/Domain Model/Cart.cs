using System.Collections.Generic;
using System.Linq;
using Coree.Entity.Abstract;

namespace EMarket.Entity.Domain_Model
{
    public class Cart:IDomainModel
    {
        public Cart()
        {
            CartItems=new List<CartItem>();
        }

        public List<CartItem> CartItems { get; set; }

        public decimal TotalPrice
        {
            get
            {
                return CartItems.Sum(c => c.Product.UnitPrice * c.Quantity);
            }
        }
    }

}
