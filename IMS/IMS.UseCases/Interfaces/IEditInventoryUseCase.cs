using IMS.CoreBusiness;

namespace IMS.UseCases
{
    public interface IEditInventoryUseCase
    {
        Task ExcuteAsync(Inventory inventory);
    }
}