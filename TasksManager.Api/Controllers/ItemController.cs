using Microsoft.AspNetCore.Mvc;
using TasksManager.Api.Requests;
using TasksManager.Api.Responses;
using TasksManager.Api.Service;

namespace TasksManager.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ItemController : ControllerBase
{
    private readonly IItemService _itemService;

    public ItemController(IItemService itemService)
    {
        _itemService = itemService;
    }

    [HttpGet]
    public ListItemResponse GetAll()
    {
        return new ListItemResponse(_itemService.GetAll());
    }

    [HttpPost]
    public ItemResponse Create(NewItemRequest newItem)
    {
        return _itemService.Create(newItem);
    }

    [HttpGet("{id}")]
    public ItemResponse? GetById(int id)
    {
        var item = _itemService.GetById(id);
        return item == null ? null : new ItemResponse(item);
    }
    
    [HttpDelete("{id}")]
    public void DeleteById(int id)
    {
        _itemService.DeleteById(id);
    }
}