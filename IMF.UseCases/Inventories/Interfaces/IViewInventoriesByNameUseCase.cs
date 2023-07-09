using IMF.CoreBusiness;

namespace IMF.UseCases.Inventories
{
    public interface IViewInventoriesByNameUseCase
    {
        Task<IEnumerable<Inventory>> ExecuteAsync(string name = "");
    }
}