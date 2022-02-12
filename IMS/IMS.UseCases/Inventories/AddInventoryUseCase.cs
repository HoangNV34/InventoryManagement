using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.UseCases
{
    public class AddInventoryUseCase : IAddInventoryUseCase
    {
        private readonly IInventoryRepository inventoryRepository;

        public AddInventoryUseCase(IInventoryRepository iventoryRepository)
        {
            this.inventoryRepository = iventoryRepository;
        }
        public async Task ExcuteAsync(Inventory inventory)
        {
            await inventoryRepository.AddInventory(inventory);
        }
    }
}
