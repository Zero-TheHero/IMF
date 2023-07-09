using IMF.CoreBusiness;

namespace IMF.UseCases.Inventories
{
    public interface IViewInventoryByIdUseCase
    {
        Task<Inventory> ExecuteAsync(int inventoryId);
    }
}