using Sanna.Domain.Products;
using System.Collections.Generic;

namespace Sanna.Domain.Repositories
{
    public interface IProductsRepository
    {
        bool InMemory { get; set; }

        IEnumerable<Product> GetProducts();
        Product CreateProduct(Product product);
        int SaveChanges();
    }
}
