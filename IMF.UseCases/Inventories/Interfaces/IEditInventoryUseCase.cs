using IMF.CoreBusiness;

namespace IMF.UseCases.Inventories
{
    public interface IEditInventoryUseCase
    {
        Task ExecuteAsync(Inventory inventory);
    }
}