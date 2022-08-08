using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces;

namespace UseCases
{

    public class ViewProductsUseCase : IViewProductsUseCase
    {
        private readonly IProductRepository producRepository;

        public ViewProductsUseCase(IProductRepository producRepository)
        {
            this.producRepository = producRepository;
        }
        public IEnumerable<Product> Execute()
        {
            return producRepository.GetProducts();
        }

       
    }
}
