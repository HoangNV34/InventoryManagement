using IMS.CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.UseCases.PluginInterfaces
{
    public interface IInventoryRepository
    {
        Task<Inventory?> GetInventoryByIdAsync(int inventoryId);
        Task UpdateInventory(Inventory inventory);
        Task AddInventory(Inventory inventory);
        Task<IEnumerable<Inventory>> GetInventoriesByName(string name);

    }
}
