using Coree.Entity.Abstract;
namespace EMarket.Entity.Concrete
{
    public class Product:IEntity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public short StockAmount { get; set; }
    }
}
