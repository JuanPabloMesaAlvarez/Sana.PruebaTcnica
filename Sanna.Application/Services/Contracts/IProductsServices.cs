using Sanna.Domain.Products;
using System.Collections.Generic;

namespace Sanna.Application.Services.Contracts
{
    public interface IProductsServices
    {
        bool InMemory { get; set; }

        IEnumerable<Product> GetProducts();
        Product CreateProduct(Product product);
    }
}
