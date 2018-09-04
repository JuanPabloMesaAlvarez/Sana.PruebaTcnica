using Sanna.Domain.Products;
using Sanna.Persistence.InMemory;
using System.Data.Entity;
using System.Linq;

namespace Sanna.Persistence.DomainContext
{
    class DomainModel : DbContext
    {
        private DbSet<Product> products;
        public DomainModel()
            : base("SannaCnn")
        {
            products = base.Set<Product>();
            if (InMemoryHandler.Products == null)
            {
                InMemoryHandler.Products = base.Set<Product>();
            }
        }

        public bool IsInMemory { get; set; }

        public DbSet<Product> Products
        {
            get
            {
                if (IsInMemory)
                {
                    return InMemoryHandler.Products;
                }
                return products;
            }
            private set
            {
                products = value;
            }
        }
    }
}
