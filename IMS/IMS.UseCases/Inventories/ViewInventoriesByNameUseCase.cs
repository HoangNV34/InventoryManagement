using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;

namespace IMS.UseCases
{
    public class ViewInventoriesByNameUseCase : IViewInventoriesByNameUseCase
    {
        private readonly IInventoryRepository inventoryRepository;
        public ViewInventoriesByNameUseCase(IInventoryRepository inventoryRespository)
        {
            this.inventoryRepository = inventoryRespository;
        }
        public async Task<IEnumerable<Inventory>> ExecuteAsync(string name = "")
        {
            return await this.inventoryRepository.GetInventoriesByName(name);
        }
    }
}