using Microsoft.AspNetCore.Mvc;
using TasksManager.Api.Data;
using TasksManager.Api.Service;

namespace TasksManager.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ItemController: ControllerBase
{
    private readonly IItemService _itemService;

    public ItemController(IItemService itemService)
    {
        _itemService = itemService;
    }

    [HttpGet(Name = "GetItems")]
    public IEnumerable<Item> Get()
    {
        return _itemService.GetAll();
    }
}