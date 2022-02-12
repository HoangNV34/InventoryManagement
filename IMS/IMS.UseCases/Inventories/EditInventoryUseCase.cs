using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.UseCases
{
    public class EditInventoryUseCase : IEditInventoryUseCase
    {
        private readonly IInventoryRepository inventoryRespository;

        public EditInventoryUseCase(IInventoryRepository inventoryRespository)
        {
            this.inventoryRespository = inventoryRespository;
        }
        public async Task ExcuteAsync(Inventory inventory)
        {
            await this.inventoryRespository.UpdateInventory(inventory);
        }
    }
}
