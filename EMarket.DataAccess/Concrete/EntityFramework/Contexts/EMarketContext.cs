using System.Data.Entity;
using EMarket.Entity.Concrete;

namespace EMarket.DataAccess.Concrete.EntityFramework.Contexts
{
    public class EMarketContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
