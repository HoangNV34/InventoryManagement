using IMS.CoreBusiness;

namespace IMS.UseCases
{
    public interface IViewInventoryById
    {
        Task<Inventory?> ExecuteAsync(int inventoryId);
    }
}