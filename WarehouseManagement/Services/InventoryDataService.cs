using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using WarehouseManagement.Common.Entities;

namespace WarehouseManagement.Services
{
    public class InventoryDataService : IInventoryDataService
    {
        private readonly HttpClient _httpClient;

        public InventoryDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<InventoryItem>> GetFullInventory()
        {
            var inventory = await _httpClient.GetStreamAsync("api/inventory");

            return await JsonSerializer.DeserializeAsync<IEnumerable<InventoryItem>>(
                inventory, new JsonSerializerOptions() {PropertyNameCaseInsensitive = true});
        }
    }
}
