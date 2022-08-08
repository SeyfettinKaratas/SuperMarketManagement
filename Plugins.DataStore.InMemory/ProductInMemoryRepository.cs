using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class ProductInMemoryRepository : IProductRepository
    {
        private List<Product> products;
        public ProductInMemoryRepository()
        {
            products = new List<Product>()
            {
                new Product{ProductId=1, CategoryId=1, Name="Iced tea", Quantity=100, Price=1.99},
                new Product{ProductId=2, CategoryId=2, Name="tea", Quantity=200, Price=2.99},
                new Product{ProductId=3, CategoryId=3, Name="Ice", Quantity=500, Price=0.99}
               
            };
        }
        public IEnumerable<Product> GetProducts()
        {
            return products;
        }
    }
}
