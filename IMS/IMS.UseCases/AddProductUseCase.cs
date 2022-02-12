using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.UseCases
{
    public class AddProductUseCase : IAddProductUseCase
    {
        private readonly IProductRepository productRespository;

        public AddProductUseCase(IProductRepository productRespository)
        {
            this.productRespository = productRespository;
        }
        public async Task ExcuteAsync(Product product)
        {
            if (product == null) { return; }

            await productRespository.AddProductAsync(product);
        }
    }
}
