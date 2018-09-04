using Sanna.Application.Services.Contracts;
using Sanna.Domain.Products;
using Sanna.Domain.Repositories;
using System;
using System.Collections.Generic;

namespace Sanna.Application.Services.Impl
{
    class ProductsServices : IProductsServices
    {
        private readonly IProductsRepository repository;

        public ProductsServices(IProductsRepository repository)
        {
            this.repository = repository;
        }

        public bool InMemory
        {
            get { return repository.InMemory; }
            set { repository.InMemory = value; }
        }

        public Product CreateProduct(Product product)
        {
            try
            {
                var result = repository.CreateProduct(product);
                repository.SaveChanges();
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("An error ocurred while inserting new product", ex); ;
            }
            
        }

        public IEnumerable<Product> GetProducts()
        {
            try
            {
                return repository.GetProducts();
            }
            catch (Exception ex)
            {
                throw new Exception("An error ocurred while listing products", ex);
            }
        }
    }
}
