using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using WarehouseManagement.Common.Entities;
using WarehouseManagement.Services;

namespace WarehouseManagement.Pages
{
    public partial class Inventory
    {
        public IEnumerable<InventoryItem> InventoryItems { get; set; }

        [Inject]
        public IInventoryDataService InventoryDataService { get; set; }
        protected override async Task OnInitializedAsync()
        {
            InventoryItems = (await InventoryDataService.GetFullInventory()).ToList();
        }
    }
}
