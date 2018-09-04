using Sanna.Domain.Products;
using System.Collections.Generic;
using System.Data.Entity;

namespace Sanna.Persistence.InMemory
{

    public static class InMemoryHandler
    {
        private static DbSet<Product> data;

        public static DbSet<Product> Products
        {
            get { return data; }
            set { data = value; }
        }
    }
}
