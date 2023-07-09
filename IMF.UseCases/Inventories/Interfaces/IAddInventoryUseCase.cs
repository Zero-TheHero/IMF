using IMF.CoreBusiness;

namespace IMF.UseCases.Inventories
{
    public interface IAddInventoryUseCase
    {
        Task ExecuteAsync(Inventory inventory);
    }
}