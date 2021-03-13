
namespace EMarket.WindowsFormUI.Entity
{
    public class WindowsFormCart
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public string ProductName { get; set; }

        public decimal UnitPrice { get; set; }

        public short StockAmount { get; set; }

        public int Quantity { get; set; }
    }
}
