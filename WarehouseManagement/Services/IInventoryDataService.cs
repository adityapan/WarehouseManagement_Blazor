using System.Collections.Generic;
using System.Threading.Tasks;
using WarehouseManagement.Common.Entities;

namespace WarehouseManagement.Services
{
    public interface IInventoryDataService
    {
        public Task<IEnumerable<InventoryItem>> GetFullInventory();
    }
}
