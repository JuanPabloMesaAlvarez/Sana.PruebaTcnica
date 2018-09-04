using Sanna.Domain.Products;
using Sanna.Domain.Repositories;
using Sanna.Persistence.DomainContext;
using System.Collections.Generic;

namespace Sanna.Persistence.Repositories
{
    public class ProductsRepository : IProductsRepository
    {
        private readonly DomainModel _context;

        public ProductsRepository()
        {
            this._context = new DomainModel();
        }

        public bool InMemory
        {
            get { return _context.IsInMemory; }
            set { _context.IsInMemory = value; }
        }

        public Product CreateProduct(Product product)
        {
            return _context.Products.Add(product);
        }

        public IEnumerable<Product> GetProducts()
        {
            if (InMemory)
            {
                return _context.Products.Local;
            }
            return _context.Products;
        }

        public int SaveChanges()
        {
            if (InMemory)
            {
                return 0;
            }

            return _context.SaveChanges();
        }
    }
}
