using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.UseCases
{
    public class ViewInventoryById : IViewInventoryById
    {
        private readonly IInventoryRepository inventoryRepository;

        public ViewInventoryById(IInventoryRepository inventoryRepository)
        {
            this.inventoryRepository = inventoryRepository;
        }
        public async Task<Inventory?> ExecuteAsync(int inventoryId)
        {
            return await this.inventoryRepository.GetInventoryByIdAsync(inventoryId);
        }
    }
}
