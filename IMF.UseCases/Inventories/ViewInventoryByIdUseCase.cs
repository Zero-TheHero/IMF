using IMF.CoreBusiness;
using IMF.UseCases.Inventories;
using IMF.UseCases.PluginInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMF.UseCases.Inventories
{
    public class ViewInventoryByIdUseCase : IViewInventoryByIdUseCase
	{
		private readonly IInventoryRepository _inventoryRepository;
		public ViewInventoryByIdUseCase(IInventoryRepository inventoryRepository)
		{
			_inventoryRepository = inventoryRepository;
		}

		public async Task<Inventory> ExecuteAsync(int inventoryId)
		{
			return await _inventoryRepository.GetInventoryByIdAsync(inventoryId);
		}
	}
}
