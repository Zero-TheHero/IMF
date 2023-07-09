using IMF.CoreBusiness;
using IMF.UseCases.PluginInterfaces;

namespace IMF.UseCases.Inventories
{
	public class AddInventoryUseCase : IAddInventoryUseCase
	{
		private readonly IInventoryRepository _inventoryRepository;
		public AddInventoryUseCase(IInventoryRepository inventoryRepository)
		{
			_inventoryRepository = inventoryRepository;
		}
		public async Task ExecuteAsync(Inventory inventory)
		{
			await _inventoryRepository.AddInventoryAsync(inventory);
		}
	}
}
