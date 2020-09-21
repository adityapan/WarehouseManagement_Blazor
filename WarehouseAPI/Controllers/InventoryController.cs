using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WarehouseManagement.Common.Entities;

namespace WarehouseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private static List<InventoryItem> _inventoryItems;

        public InventoryController()
        {
            _inventoryItems = new List<InventoryItem>
            {
                new InventoryItem {ProductId = 1001, Name = "Ice Cream", Quantity = 100, Price = 10.99m},
                new InventoryItem {ProductId = 1002, Name = "Cheesecake", Quantity = 50, Price = 21.50m},
                new InventoryItem { ProductId = 1003, Name = "Pound Cake", Quantity = 130, Price = 6.99m },
                new InventoryItem { ProductId = 1004, Name = "Matcha Chocolate", Quantity = 300, Price = 3.99m }
            };
        }

        [HttpGet]
        public IActionResult GetFullInventory()
        {
            return Ok(_inventoryItems);
        }
    }
}
