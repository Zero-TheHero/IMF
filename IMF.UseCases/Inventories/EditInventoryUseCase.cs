using IMF.CoreBusiness;
using IMF.UseCases.PluginInterfaces;

namespace IMF.UseCases.Inventories
{
	public class EditInventoryUseCase : IEditInventoryUseCase
	{
		private readonly IInventoryRepository _inventoryRepository;

		public EditInventoryUseCase(IInventoryRepository inventoryRepository)
		{
			_inventoryRepository = inventoryRepository;
		}

		public async Task ExecuteAsync(Inventory inventory)
		{
			await _inventoryRepository.UpdateInventoryAsync(inventory);
		}
	}
}
