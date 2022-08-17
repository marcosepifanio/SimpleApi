using Microsoft.AspNetCore.Mvc;
using TasksManager.Api.Data;
using TasksManager.Api.Requests;
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

    [HttpGet]
    public IEnumerable<Item> Get()
    {
        return _itemService.GetAll();
    }
    
    [HttpPost]
    public Item Create(NewItemRequest newItem)
    {
        return _itemService.Create(newItem);
    }
}